using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV7_rppoon.Posjetitelj
{
    interface IItem
    {
        double Accept(IVisitor visitor);
    }
}
