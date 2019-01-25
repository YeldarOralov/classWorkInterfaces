using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesLesson
{
    public static class ServiceLocator
    {
        public static ISender Sender
        {
            get
            {
                return new EmailService();
            }
        }
    }
}
