using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugSparyWebApp.Emails
{
    //email of the subscriber
    public class Email
    {
        public string E_Mail { get; set; }
        public Email(string e_Mail)
        {
            E_Mail = e_Mail;
        }
    }
}
