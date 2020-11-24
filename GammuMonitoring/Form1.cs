using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Configuration;
using System.Collections.Specialized;


namespace GammuMonitoring
{
    public partial class Form1 : Form
    {
        String pull1Location;
        String pull2Location;
        bool pull1Enabled;
        bool pull2Enabled;
        GMonit gammuPull1;
        GMonit gammuPull2;
        public Form1()
        {
            pull1Location = ConfigurationManager.AppSettings.Get("pull1Location");
            pull2Location = ConfigurationManager.AppSettings.Get("pull2Location");
            pull1Enabled = Boolean.Parse(ConfigurationManager.AppSettings.Get("pull1Enabled"));
            pull2Enabled = Boolean.Parse(ConfigurationManager.AppSettings.Get("pull2Enabled"));
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (gammuPull1 != null)
            {
                if (gammuPull1.checkTableExists()) gammuPull1.removeIncomingSchedule();
                gammuPull1.nextSchedule();
                fillPull1DataList();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var filepath = String.Empty;
            
            using (OpenFileDialog openFileDialog =  new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Exe Files (.exe)|*.exe|All Files (*.*)|*.*";
                openFileDialog.RestoreDirectory = true;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filepath = openFileDialog.FileName;
                    textBox1.Text = filepath;
                    Helper.Setingan.set("pull1Location", filepath);
                    this.gammuPull1 = new GMonit(filepath,GMonit.PULL1INDEX);
                    if (timerMonitPull1.Enabled == false)
                    {
                        timerMonitPull1.Start();
                    }
                }
            }
        }

        private void timerJam_Tick(object sender, EventArgs e)
        {
            labelJam.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timerJam.Start();
            picStatusPull1.Image = GammuMonitoring.Properties.Resources.power;
            picStatusPull2.Image = GammuMonitoring.Properties.Resources.power;
            bool firstStart = Boolean.Parse(ConfigurationManager.AppSettings.Get("firstload"));
            if (firstStart)
            {
                gammuPull1 = new GMonit("", GMonit.PULL1INDEX);
                gammuPull1.createTableLog();
                gammuPull2 = new GMonit("", GMonit.PULL2INDEX);
                gammuPull2.createTableLog();
                Helper.Setingan.set("firstload","true");
            }
            else
            {
                checkPull1();
                checkPull2();
            }
        }


        private void checkPull2()
        {
            txtLocationPull2.Text = this.pull2Location;
            chkEnablePull2.Checked = this.pull2Enabled;
            if (String.IsNullOrEmpty(this.pull2Location) == false && this.pull2Enabled)
            {
                gammuPull2 = new GMonit(pull2Location, GMonit.PULL2INDEX);
                if (!gammuPull2.checkTableExists())
                {
                    chkEnablePull2.Checked = false;
                    this.pull2Enabled = false;
                    DialogResult dr = MessageBox.Show("System Cannot detected table, want to create new?",
                      "Table not found", MessageBoxButtons.YesNo);
                    switch (dr)
                    {
                        case DialogResult.Yes:
                            gammuPull2.createTableLog();
                            break;
                    }
                }
                else
                {
                    gammuPull2.detectProcess();
                    timerMonitPull2.Start();
                    fillPull2DataList();
                }
            }
        }

        private void checkPull1()
        {  
            textBox1.Text = this.pull1Location;
            chkEnablePull1.Checked = this.pull1Enabled;
            if (String.IsNullOrEmpty(this.pull1Location) == false && this.pull1Enabled)
            {
                gammuPull1 = new GMonit(pull1Location, GMonit.PULL1INDEX);
                if (!gammuPull1.checkTableExists())
                {
                    chkEnablePull1.Checked = false;
                    this.pull1Enabled = false;
                    DialogResult dr = MessageBox.Show("System Cannot detected table, want to create new?",
                      "Table not found", MessageBoxButtons.YesNo);
                    switch (dr)
                    {
                        case DialogResult.Yes:
                            gammuPull1.createTableLog();
                            break;
                    }
                }
                else
                {
                    gammuPull1.detectProcess();
                    timerMonitPull1.Start();
                    fillPull1DataList();
                }
            }   
        }

        private void offPull1()
        {
            timerMonitPull1.Stop();
        }

        private void offPull2()
        {
            timerMonitPull2.Stop();
        }

        private void fillPull1DataList()
        {
            if (gammuPull1 != null)
            {
                dgPull1.Rows.Clear();
                List<Log> logs = gammuPull1.getListLogs();
                logs.ForEach(delegate (Log log)
                {
                    dgPull1.Rows.Add(new object[] {
                        Helper.MyDateTIme.EpochToDateTime(log.Time).ToString("dd/MM/yyyy HH:mm:ss"),
                        log.Action,
                        log.Status
                    });
                });
            }
        }

        private void fillPull2DataList()
        {
            if (gammuPull2 != null)
            {
                dgPull2.Rows.Clear();
                List<Log> logs = gammuPull2.getListLogs();
                logs.ForEach(delegate (Log log)
                {
                    dgPull2.Rows.Add(new object[] {
                        Helper.MyDateTIme.EpochToDateTime(log.Time).ToString("dd/MM/yyyy HH:mm:ss"),
                        log.Action,
                        log.Status
                    });
                });
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormConfig frmCfg = new FormConfig(GMonit.PULL1INDEX);
            frmCfg.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //validate
            String location = textBox1.Text;
            if (String.IsNullOrEmpty(location))
            {
                MessageBox.Show("gammu location cant be empty");
            }
            else
            {
                this.gammuPull1.startProcess();
                btnPull1Start.Enabled = false;
                btnPull1Stop.Enabled = true;
            }
        }

        public enum CommonErrorCode
        {
              Success = 0,
              INternalError = 256
        }

        private void timerMonitPull1_Tick(object sender, EventArgs e)
        {
            gammuPull1.detectProcess();
            if (gammuPull1.checkRunning())
            {
                picStatusPull1.Image = GammuMonitoring.Properties.Resources.power_on;
                btnPull1Start.Enabled = false;
                btnPull1Stop.Enabled = true;
                lblProcessId.Text = gammuPull1.process.Id.ToString();
            } else {
                picStatusPull1.Image = GammuMonitoring.Properties.Resources.power;
                btnPull1Start.Enabled = true;
                btnPull1Stop.Enabled = false;
                lblProcessId.Text = "";
            }
            int d = gammuPull1.runSchedule();
            if (d > 0) fillPull1DataList();
        }

        private void btnPull1Stop_Click(object sender, EventArgs e)
        {
            if (gammuPull1 != null)
            {
                gammuPull1.stopProcess();
            }
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gammuPull1.clearCache();
        }

        private void chkEnablePull1_CheckedChanged(object sender, EventArgs e)
        {
            
            Helper.Setingan.set("pull1Enabled",chkEnablePull1.Checked.ToString());
            pull1Enabled = chkEnablePull1.Checked;
            if (chkEnablePull1.Checked)
            {
                checkPull1();
            }
            else
            {
                offPull1();
            }
            
        }

        private void btnLocationPull2_Click(object sender, EventArgs e)
        {
            var filepath = String.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Exe Files (.exe)|*.exe|All Files (*.*)|*.*";
                openFileDialog.RestoreDirectory = true;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filepath = openFileDialog.FileName;
                    txtLocationPull2.Text = filepath;
                    Helper.Setingan.set("pull2Location", filepath);
                    this.gammuPull2 = new GMonit(filepath, GMonit.PULL2INDEX);
                }
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormConfig frmCfg = new FormConfig(GMonit.PULL2INDEX);
            frmCfg.ShowDialog();
        }

        private void lblPull2Start_Click(object sender, EventArgs e)
        {
            //validate
            String location = txtLocationPull2.Text;
            if (String.IsNullOrEmpty(location))
            {
                MessageBox.Show("gammu location cant be empty");
            }
            else
            {
                this.gammuPull2.startProcess();
                btnPull2Start.Enabled = false;
                btnPull2Stop.Enabled = true;
            }
        }

        private void btnPull2Stop_Click(object sender, EventArgs e)
        {
            if (gammuPull2 != null)
            {
                gammuPull2.stopProcess();
            }
        }

        private void chkEnablePull2_CheckedChanged(object sender, EventArgs e)
        {
            Helper.Setingan.set("pull2Enabled", chkEnablePull2.Checked.ToString());
            pull2Enabled = chkEnablePull2.Checked;
            if (chkEnablePull2.Checked)
            {
                checkPull2();
            }
            else
            {
                offPull2();
            }
        }

        private void timerMonitPull2_Tick(object sender, EventArgs e)
        {
            gammuPull2.detectProcess();
            if (gammuPull2.checkRunning())
            {
                picStatusPull2.Image = GammuMonitoring.Properties.Resources.power_on;
                btnPull2Start.Enabled = false;
                btnPull2Stop.Enabled = true;
                lblProcessId2.Text = gammuPull2.process.Id.ToString();
            }
            else
            {
                picStatusPull2.Image = GammuMonitoring.Properties.Resources.power;
                btnPull2Start.Enabled = true;
                btnPull2Stop.Enabled = false;
                lblProcessId2.Text = "";
            }
            int d = gammuPull2.runSchedule();
            if (d > 0) fillPull2DataList();
        }

        private void btnSchedulePull2_Click(object sender, EventArgs e)
        {
            if (gammuPull2 != null)
            {
                if (gammuPull2.checkTableExists()) gammuPull2.removeIncomingSchedule();
                gammuPull2.nextSchedule();
                fillPull2DataList();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
