using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesLesson
{
    public interface ILogger
    {
        void Send(string message, string to);
    }
}
