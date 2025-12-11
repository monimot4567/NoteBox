using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace test
{
    public partial class SplashForm : Form
    {
        public bool SkipRequested = false;

        public SplashForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;   // Daha modern görünüm
            this.StartPosition = FormStartPosition.CenterScreen;

            // Timer → otomatik kapanma için
            System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();
            t.Interval = 3500; // 3.5 saniye
            t.Tick += (s, e) =>
            {
                t.Stop();
                this.Close();
            };
            t.Start();
        }

        private void btnSkip_Click(object sender, EventArgs e)
        {
            SkipRequested = true;
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }

}
