using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            ISender sender = ServiceLocator.Sender;
            sender.Send("text", "куда то");
        }
    }
}
