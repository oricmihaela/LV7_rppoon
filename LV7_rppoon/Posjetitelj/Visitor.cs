using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV7_rppoon.Posjetitelj
{
    class Visitor : IVisitor
    {
        public double Visit(DVD DVDItem)
        {
            if(DVDItem.Type == DVDType.SOFTWARE)
            {
                return (double.NaN);
            }
            return DVDItem.Price * 0.9;
        }
        public double Visit(VHS VHSItem)
        {
            return VHSItem.Price * 0.9;
        }
        public double Visit(Book BookItem)
        {
            return BookItem.Price * 0.9;
        }
    }
}
