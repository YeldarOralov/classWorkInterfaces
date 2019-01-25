using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesLesson
{
    public class EmailService: ISender, ILogger
    {
        public string Message { get; set; }
        public string To { get; set; }
        

        public void ToDo()
        {
            //какие то другие методы
        }

        void ISender.Send(string message, string to)
        {
            throw new NotImplementedException();
        }

        void ILogger.Send(string message, string to)
        {
            throw new NotImplementedException();
        }

        public void Send(string message, string to)
        {
            (this as ILogger).Send(message, to);
            (this as ISender).Send(message, to);
        }
    }
}
