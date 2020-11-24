using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GammuMonitoring
{
    public class Log
    {
        public enum Statuses
        {
            Ready,
            Progress,
            Miss,
            Done
        };

        public enum Actions
        {
            Shutdown,
            ClearCache,
            SoftReset,
            PowerUp
        }

        private Statuses status;
        private Actions action;
        private int time;
        private int id;

        public Statuses Status { get => status; set => status = value; }
        public Actions Action { get => action; set => action = value; }
        public int Time { get => time; set => time = value; }
        public int Id { get => id; set => id = value; }

        public Log(Statuses status, Actions action, int time)
        {
            this.Status = status;
            this.Action = action;
            this.Time = time;
        }

        public Log()
        {

        }
    }
}
