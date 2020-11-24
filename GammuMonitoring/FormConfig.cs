using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace GammuMonitoring
{
    public partial class FormConfig : Form
    {
        String pullIndex;
        public FormConfig(String pullIndex)
        {
            this.pullIndex = pullIndex;
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal interval =  inpInterval.Value;
            decimal bootup = inpBootup.Value;
            Boolean clearcache = chkClearCache.Checked;
            Boolean softReset = chkSoftReset.Checked;
            Helper.Setingan.set(this.pullIndex + "Interval",interval.ToString());
            Helper.Setingan.set(this.pullIndex + "BootUp", bootup.ToString());
            Helper.Setingan.set(this.pullIndex + "ClearCache", clearcache.ToString());
            Helper.Setingan.set(this.pullIndex + "SoftReset", softReset.ToString());
            Helper.Setingan.set(this.pullIndex + "ConfigLocation", txtSmsdrc.Text);
            Helper.Setingan.set(this.pullIndex + "ArtisanLocation", txtArtisanPath.Text);
            Helper.Setingan.set("phplocation", txtPhpPath.Text);
            System.Windows.Forms.MessageBox.Show("Configuration Saved");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormConfig_Load(object sender, EventArgs e)
        {
            this.Text = this.pullIndex + " Configuration";
            inpInterval.Value = Decimal.Parse(ConfigurationManager.AppSettings.Get(this.pullIndex + "Interval"));
            inpBootup.Value = Decimal.Parse(ConfigurationManager.AppSettings.Get(this.pullIndex + "Bootup"));
            txtPhpPath.Text = ConfigurationManager.AppSettings.Get("phplocation");
            txtArtisanPath.Text = ConfigurationManager.AppSettings.Get(this.pullIndex + "ArtisanLocation");
            Boolean clearCache = Boolean.Parse(ConfigurationManager.AppSettings.Get(this.pullIndex + "ClearCache"));
            Boolean softReset = Boolean.Parse(ConfigurationManager.AppSettings.Get(this.pullIndex + "SoftReset"));
            chkClearCache.Checked = clearCache;
            chkSoftReset.Checked = softReset;
            txtSmsdrc.Text = ConfigurationManager.AppSettings.Get(this.pullIndex + "ConfigLocation");
        }
           

        private void button3_Click(object sender, EventArgs e)
        {
            var filepath = String.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                //openFileDialog.Filter = ".exe";
                openFileDialog.RestoreDirectory = true;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filepath = openFileDialog.FileName;
                    txtSmsdrc.Text = filepath;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var filepath = String.Empty;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                //openFileDialog.Filter = ".exe";
                openFileDialog.RestoreDirectory = true;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filepath = openFileDialog.FileName;
                    txtPhpPath.Text = filepath;
                }
            };
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var filepath = String.Empty;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                //openFileDialog.Filter = ".exe";
                openFileDialog.RestoreDirectory = true;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filepath = openFileDialog.FileName;
                    txtArtisanPath.Text = filepath;
                }
            };
        }
    }
}
