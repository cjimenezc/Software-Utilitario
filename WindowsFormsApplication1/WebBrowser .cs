using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Diagnostics;
using System.Threading;

namespace WindowsFormsApplication1
{
    public partial class frmWebBrowser : Form
    {
        
        public frmWebBrowser()
        {
            InitializeComponent();
            PerformanceCounter perfCpuCount = new PerformanceCounter("Processor Information", "% Processor Time", "_Total");
            perfCpuCount.NextValue();
            PerformanceCounter perfMemCount = new PerformanceCounter("Memory", "Available MBytes");
            perfMemCount.NextValue();

            PerformanceCounter perfUptimeCount = new PerformanceCounter("System", "System Up Time");
            perfUptimeCount.NextValue();

            int currentCpuPercentage = (int)perfCpuCount.NextValue();
            int currentAvailableMemory = (int)perfMemCount.NextValue();
            lblCPU.Text = Convert.ToString(currentCpuPercentage);
            int RAM = currentAvailableMemory;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(txtDireccion.Text);
        }
    }
}
