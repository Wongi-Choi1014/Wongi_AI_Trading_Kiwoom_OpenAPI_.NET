using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wongi_AI_Trading
{
    //Log출력 Interface
    interface Log_Interface
    {
        void Logger(string format, params Object[] args);
    }
}
