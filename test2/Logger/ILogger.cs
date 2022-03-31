using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2.Logger
{
    public interface ILogger
    {
        void Log(params String[] messages);
    }
}
