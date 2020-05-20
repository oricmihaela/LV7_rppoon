using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV7_rppoon.Promatrac
{
    abstract class SimpleSystemDataProvider
    {
        private System.Diagnostics.PerformanceCounter cpuCounter;
        private System.Diagnostics.PerformanceCounter ramCounter;
        private List<ILogger> loggers;
        public SimpleSystemDataProvider()
        {
            this.cpuCounter =
           new System.Diagnostics.PerformanceCounter("Processor", "% processor time", "_Total");
            this.ramCounter =
           new System.Diagnostics.PerformanceCounter("Memory", "Available MBytes");
            this.loggers = new List<ILogger>();
        }
        public float CPULoad { get { return this.cpuCounter.NextValue(); } }
        public float AvailableRAM { get { return this.ramCounter.NextValue(); } }
        public void Attach(ILogger logger)
        {
            if (!this.loggers.Contains(logger))
                this.loggers.Add(logger);
        }
        public void Detach(ILogger logger)
        {
            this.loggers.Remove(logger);
        }
        public void Notify()
        {
            foreach (ILogger logger in this.loggers)
            {
                logger.Log(this);
            }
        }
    }
}
