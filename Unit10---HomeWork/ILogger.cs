using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit10___HomeWork
{
    interface ILogger
    {
        void Event(string message);
        void Error(string message);
    }
}
