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
using Microsoft.Win32;

namespace tablet
{
    public partial class check : Form
    {
        public check()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            try
            {
                foreach (var process in Process.GetProcessesByName("WTClient"))
                {
                    process.Kill();
                }

                System.Diagnostics.Process.Start(@"C:\Windows\SysWOW64\WTClient.exe");
            }
            catch(Exception)
            {

            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            timer.Stop();
            timer.Start();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }
    }
}
