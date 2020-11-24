using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Configuration;

namespace GammuMonitoring
{
    public class GMonitData
    {
        public SQLiteConnection con;
        protected String pullIndex;

        

        public GMonitData(String pullIndex)
        {
            this.pullIndex = pullIndex;
            this.setConnection();
        }

        public void setConnection()
        {
            SQLiteConnection con = new SQLiteConnection("Data Source = database.db; Version = 3; New = True; Compress = True;");
            try
            {
                con.Open();
            }catch (Exception e)
            {

            }

            this.con = con;
        }

        public void calculateSchedule()
        {

        }

        public String setNextShutdown()
        {
            int lastShutdown = this.getLastShutdown();
            int shutdownInterval = Int32.Parse(ConfigurationManager.AppSettings.Get(pullIndex + "Interval"));
            Console.WriteLine("last shutdown " + lastShutdown);
            if (lastShutdown == 0)
            {
                DateTime now = DateTime.Now;
                DateTime time = now.AddMinutes(shutdownInterval);
                Console.WriteLine(time);
                Log log = new Log(Log.Statuses.Ready, Log.Actions.Shutdown, Helper.MyDateTIme.DateTimeToEpoch(time));
                insertRow(log);
                nextAttribute(log);
            }
            else
            {
                DateTime lastTime = Helper.MyDateTIme.EpochToDateTime(lastShutdown);
                int defaultTaskTime = Int32.Parse(ConfigurationManager.AppSettings.Get("defaultTaskTime"));
                bool clearCacheConfig = Boolean.Parse(ConfigurationManager.AppSettings.Get(pullIndex + "ClearCache"));
                bool softResetConfig = Boolean.Parse(ConfigurationManager.AppSettings.Get(pullIndex + "SoftReset"));
                int powerupInterval = Int32.Parse(ConfigurationManager.AppSettings.Get(pullIndex + "BootUp"));
                
                List<bool> checkparam = new List<bool> { clearCacheConfig, softResetConfig };
                List<bool> d = checkparam.FindAll(p => true);
                if ((d.Count * defaultTaskTime) > powerupInterval)
                {
                    powerupInterval = defaultTaskTime;
                }
                int minutesToAdd = shutdownInterval + powerupInterval;
                Console.WriteLine(minutesToAdd);
                DateTime nextShutdownTime = lastTime.AddMinutes(minutesToAdd);
                Log log = new Log(Log.Statuses.Ready, Log.Actions.Shutdown, Helper.MyDateTIme.DateTimeToEpoch(nextShutdownTime));
                insertRow(log);
                nextAttribute(log);
            }
            return "";
        }

        private void nextAttribute(Log shutdownLog)
        {
            DateTime lasttime;
            //clear cache
            DateTime shutdownTime = Helper.MyDateTIme.EpochToDateTime(shutdownLog.Time);
            lasttime = shutdownTime;
            int defaultTaskTime = Int32.Parse(ConfigurationManager.AppSettings.Get("defaultTaskTime"));
            bool clearCacheConfig = Boolean.Parse(ConfigurationManager.AppSettings.Get(pullIndex + "ClearCache"));
            if (clearCacheConfig)
            {
                DateTime clearCacheTime = lasttime.AddMinutes(defaultTaskTime);
                lasttime = clearCacheTime;
                Log logClearCache = new Log(Log.Statuses.Ready,Log.Actions.ClearCache,
                    Helper.MyDateTIme.DateTimeToEpoch(clearCacheTime));
                insertRow(logClearCache);
            }
            // soft reset
            bool softResetConfig = Boolean.Parse(ConfigurationManager.AppSettings.Get(pullIndex + "SoftReset"));
            if (softResetConfig)
            {
                DateTime softResetTime = lasttime.AddMinutes(defaultTaskTime);
                lasttime = softResetTime;
                Log logSeftReset = new Log(Log.Statuses.Ready, Log.Actions.SoftReset,
                    Helper.MyDateTIme.DateTimeToEpoch(softResetTime));
                insertRow(logSeftReset);
            }
            //power up
            int powerupInterval = Int32.Parse(ConfigurationManager.AppSettings.Get(pullIndex + "BootUp"));
            List<bool> checkparam = new List<bool> {clearCacheConfig,softResetConfig};
            List<bool> d = checkparam.FindAll(p => true);
            if ((d.Count * defaultTaskTime) > powerupInterval)
            {
                powerupInterval = (d.Count() * defaultTaskTime) + defaultTaskTime;
            }
            DateTime powerUpTime = shutdownTime.AddMinutes(powerupInterval);
            lasttime = powerUpTime;

            Log logPowerUp = new Log(Log.Statuses.Ready, Log.Actions.PowerUp,
                Helper.MyDateTIme.DateTimeToEpoch(powerUpTime));
            insertRow(logPowerUp);
        }

        private void insertRow(Log log)
        {
            SQLiteCommand cmd = con.CreateCommand();
            cmd.CommandText = "Insert into " + this.getTableName() + " (time,action,status) values "
                +"('"
                + log.Time.ToString() + "','"
                + log.Action + "','"
                + log.Status
                + "')";

            cmd.ExecuteNonQuery();
        }

        public int getLastShutdown()
        {
            String query = "select time from " + this.getTableName() + " where action = 'Shutdown' order by id  DESC limit 1";
            Console.WriteLine(query);
            SQLiteCommand cmd = con.CreateCommand();
            cmd.CommandText = query;
            SQLiteDataReader reader = cmd.ExecuteReader();
            int waktu = 0;
            while (reader.Read())
            {
                waktu = reader.GetInt32(0);
            }
            DateTime now = DateTime.Now;
            int nowEpoch = Helper.MyDateTIme.DateTimeToEpoch(now);
            if ( nowEpoch > waktu)
            {
                return nowEpoch;
            }
            return waktu;
        }

        public Log getCurrentSchedule()
        {
            Log l = new Log();

            DateTime beginTime = DateTime.Now.AddSeconds(-5);
            DateTime endTime = DateTime.Now.AddSeconds(5);
            String query = "select id,time,action,status from " + this.getTableName() + " where status = 'Ready' and time >= "
                + Helper.MyDateTIme.DateTimeToEpoch(beginTime) + " and time <="
                + Helper.MyDateTIme.DateTimeToEpoch(endTime) + " limit 1";

            SQLiteCommand cmd = con.CreateCommand();
            cmd.CommandText = query;
            SQLiteDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                l.Id = reader.GetInt32(0);
                l.Time = reader.GetInt32(1);
                l.Action = (Log.Actions)Enum.Parse(typeof(Log.Actions), reader.GetString(2));
                l.Status = (Log.Statuses)Enum.Parse(typeof(Log.Statuses), reader.GetString(3));
            }
            return l;
        }

        public void updateStatusLog(Log log,Log.Statuses status)
        {
            String query = "update " + this.getTableName() + " set status='" + status + "' where id = " + log.Id;
            SQLiteCommand cmd = con.CreateCommand();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
        }

        public List<Log> getListLogs()
        {
            List<Log> logs = new List<Log>();

            SQLiteCommand cmd = con.CreateCommand();
            DateTime from = DateTime.Now.AddMinutes(-15);
            cmd.CommandText = "select id,time,action,status from " + this.getTableName() + " "
                + "where time > " + Helper.MyDateTIme.DateTimeToEpoch(from) + " "
                + "order by time asc";
            SQLiteDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Log log = new Log();
                log.Action = (Log.Actions)Enum.Parse(typeof(Log.Actions), reader.GetString(2));
                log.Time = reader.GetInt32(1);
                log.Id = reader.GetInt32(0);
                log.Status = (Log.Statuses)Enum.Parse(typeof(Log.Statuses), reader.GetString(3));
                logs.Add(log);
            }
            return logs;
        }

        public void removeIncomingSchedule()
        {
            String query = "delete from " + getTableName() + " where time > " 
                + Helper.MyDateTIme.DateTimeToEpoch(DateTime.Now) + " and status='"+Log.Statuses.Ready+"'";
            SQLiteCommand cmd = con.CreateCommand();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
        }

        public void createTableLog()
        {
            String tableName = this.getTableName();
            String createQuery = "Create Table if not exists " + tableName
                + "("
                + "id INTEGER PRIMARY KEY AUTOINCREMENT,"
                + "time INTEGER,"
                + "action TEXT,"
                + "status TEXT,"
                + "response TEXT"
                + ")";
            SQLiteCommand cmd = this.con.CreateCommand();
            cmd.CommandText = createQuery;
            cmd.ExecuteNonQuery();
        }

        public bool checkTableExists()
        {
            bool exists;

            
            try
            {
                exists = true;
                var cmdOthers = new SQLiteCommand("select 1 from " + this.getTableName() + " where 1 = 0", con);
                cmdOthers.ExecuteNonQuery();
            }
            catch
            {
                exists = false;
            }
            
            return exists;
        }

        private String getTableName()
        {
            return this.pullIndex + "_log";
        }
    }
}
