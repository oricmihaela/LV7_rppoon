using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV7_rppoon.Promatrac
{
    class SystemDataProvider : SimpleSystemDataProvider
    {
        private float previousCPULoad;
        private float previousRAMAvailable;
        public SystemDataProvider() : base()
        {
            this.previousCPULoad = this.CPULoad;
            this.previousRAMAvailable = this.AvailableRAM;
        }
        //public float GetCPULoad()
        //{
        //    float currentLoad = this.CPULoad;
        //    if (currentLoad != this.previousCPULoad)
        //    {
        //        this.Notify();
        //    }
        //    this.previousCPULoad = currentLoad;
        //    return currentLoad;
        //}
        //public float GetAvailableRAM()
        //{
        //    float currentRAM = this.AvailableRAM;
        //    if(currentRAM != this.previousRAMAvailable)
        //    {
        //        this.Notify();
        //    }
        //    this.previousRAMAvailable = currentRAM;
        //    return currentRAM;
        //}

        //4. zadatak
        public float GetCPULoad()
        {
            float currentLoad = this.CPULoad;
            if (Math.Abs((currentLoad-this.previousCPULoad)/this.previousCPULoad) >= 0.1)
            {
                this.Notify();
            }
            this.previousCPULoad = currentLoad;
            return currentLoad;
        }
        public float GetAvailableRAM()
        {
            float currentRAM = this.AvailableRAM;
            if (Math.Abs((currentRAM - this.previousRAMAvailable) / this.previousRAMAvailable) >= 0.1)
            {
                this.Notify();
            }
            this.previousRAMAvailable = currentRAM;
            return currentRAM;
        }
    }
}
