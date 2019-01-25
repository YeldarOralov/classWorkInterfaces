using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesLesson
{
    public class SmsSender: ISender
    {
        public string Message { get; set; }
        public string To { get; set; }

        public void Send(string message, string to)
        {
            //реализация для отправки смс через интернет
        }

        

    }
}
