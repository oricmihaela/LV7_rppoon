using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV7_rppoon.Strategija
{
    class SequentialSearch : ISearchStrategy
    {
        private double element;
        public SequentialSearch(double wantedElement)
        {
            this.element = wantedElement;
        }
        public bool Search(double[] array)
        {
            for(int i = 0; i < array.Length; i++)
            {
                if(array[i] == element)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
