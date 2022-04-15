using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailSender
{
    public class EmailSenderModel
    {
        public string From { get; set; }
        public string To { get; set; }
        public string Password { get; set; }
        public string Body { get; set; }
    }
}
