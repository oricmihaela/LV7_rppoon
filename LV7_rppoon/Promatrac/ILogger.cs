using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV7_rppoon.Promatrac
{
    interface ILogger //promijenjen naziv u ILogger zbog toga sto interface u nazivu mora imati 'I'
    {
        void Log(SimpleSystemDataProvider provider);
    }
}
