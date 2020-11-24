using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Configuration;
using System.Threading;

namespace GammuMonitoring
{
    class GMonit : GMonitData
    {
        String location;
        String appname;

        public const String PULL1INDEX = "pull1";
        public const String PULL2INDEX = "pull2";

        public Process process;

        public GMonit(String location, String pullIndex) : base (pullIndex)
        {
            this.location = location;
            this.appname = System.IO.Path.GetFileNameWithoutExtension(location);
            this.pullIndex = pullIndex;
        }

        public void setProcess(Process process)
        {
            this.process = process;
        }

        public void startProcess()
        {
            String smsdrc = Helper.Setingan.getDefaultSmsdRc(location,
                ConfigurationManager.AppSettings.Get(pullIndex + "ConfigLocation"));
            Console.WriteLine(this.location + smsdrc);

            var psi = new ProcessStartInfo(location)
            {
                Arguments = @"-c " + smsdrc,
                UseShellExecute = false,
                CreateNoWindow = true
            };
            Process p = Process.Start(psi);
            this.process = p;
        }

        public void stopProcess()
        {
            this.process.Kill();
        }

        public void clearCache()
        {
            String phpPath = ConfigurationManager.AppSettings.Get("phplocation");
            String artisanPath = ConfigurationManager.AppSettings.Get(pullIndex + "ArtisanLocation");
            if (!String.IsNullOrEmpty(phpPath) && !String.IsNullOrEmpty(artisanPath))
            {
                String command = phpPath;
                var sb = new StringBuilder();
                
                var psi = new ProcessStartInfo(phpPath) {
                    Arguments = @" " + artisanPath + " cache:clear",
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                Process p = new Process();
                p.StartInfo = psi;
                p.StartInfo.RedirectStandardOutput = true;
                p.StartInfo.RedirectStandardError = true;
                p.OutputDataReceived += (sender, args) => sb.AppendLine(args.Data);
                p.ErrorDataReceived += (sender, args) => sb.AppendLine(args.Data);
                p.Start();

                p.BeginOutputReadLine();
                p.BeginErrorReadLine();
                p.WaitForExit();
            }
        }

        public void softReset()
        {
            String gammuloc = System.IO.Path.GetDirectoryName(location) + "\\gammu.exe";
            var sb = new StringBuilder();
            var psi = new ProcessStartInfo(gammuloc)
            {
                Arguments = @"--reset SOFT",
                UseShellExecute = false,
                CreateNoWindow = true
            };
            Process p = new Process();
            p.StartInfo = psi;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.RedirectStandardError = true;
            p.OutputDataReceived += (sender, args) => sb.AppendLine(args.Data);
            p.ErrorDataReceived += (sender, args) => sb.AppendLine(args.Data);
            p.Start();

            p.BeginOutputReadLine();
            p.BeginErrorReadLine();

            // until we are done
            //
            p.WaitForExit();
            Console.WriteLine(sb.ToString());
            
        }


        public void detectProcess()
        {
            if (this.appname != null)
            {
                Process[] localByName = Process.GetProcessesByName(this.appname);
                foreach (Process pro in localByName)
                {
                    if (pro.MainModule.FileName.Equals(this.location))
                    {
                        this.process = pro;
                    }
                }
            }
        }

        public bool checkRunning()
        {
            if (this.process == null) return false;
            this.process.Refresh();
            if (this.process.HasExited)
            {
                return false;
            }
            else return true;
        }

        public void nextSchedule()
        {
            if (this.pullIndex != null)
            {
                bool status = this.checkTableExists();
                Console.WriteLine(status);
                if (!status)
                {
                    this.createTableLog();
                }
                String x = this.setNextShutdown();
            }
        }   

        public int  runSchedule()
        {
            Log currentSchedule = this.getCurrentSchedule();
            if (currentSchedule.Id > 0)
            {
                Console.WriteLine(Helper.MyDateTIme.EpochToDateTime(currentSchedule.Time).ToString("HH:mm:ss"));
                this.updateStatusLog(currentSchedule, Log.Statuses.Progress);
                return doActionSchedule(currentSchedule);
            }
            return 0;
        }

        private int doActionSchedule(Log log)
        {
            int result = 0;
            switch (log.Action)
            {
                case Log.Actions.Shutdown:
                    doShutdown();
                    updateStatusLog(log,Log.Statuses.Done);
                    result =  1;
                    break;
                case Log.Actions.PowerUp:
                    doPowerUp();
                    updateStatusLog(log, Log.Statuses.Done);
                    if (checkRunning())
                    {
                        this.setNextShutdown();
                    }
                    result = 1;
                    break;
                case Log.Actions.SoftReset:
                    softReset();
                    updateStatusLog(log, Log.Statuses.Done);
                    result = 1;
                    break;
                case Log.Actions.ClearCache:
                    clearCache();
                    updateStatusLog(log, Log.Statuses.Done);
                    result = 1;
                    break;
                default:
                    result = 1;
                    break;
            }

            return result;

        }

        private void doPowerUp()
        {
            if (checkRunning() == false)
            {
                startProcess();
            }
        }

        private void doShutdown()
        {
            if (checkRunning())
            {
                stopProcess();
            }
        }


    }
}
