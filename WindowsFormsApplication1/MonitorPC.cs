using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

namespace WindowsFormsApplication1
{
    class MonitorPC
    {
        static void fddf()
        {

   
            PerformanceCounter perfCpuCount = new PerformanceCounter("Processor Information", "% Processor Time", "_Total");
            perfCpuCount.NextValue();
            PerformanceCounter perfMemCount = new PerformanceCounter("Memory", "Available MBytes");
            perfMemCount.NextValue();


            PerformanceCounter perfUptimeCount = new PerformanceCounter("System", "System Up Time");
            perfUptimeCount.NextValue();

            int currentCpuPercentage = (int)perfCpuCount.NextValue();
            int currentAvailableMemory = (int)perfMemCount.NextValue();
            int CPU = currentCpuPercentage;
            int RAM = currentAvailableMemory;
    

        }

    }
}

  