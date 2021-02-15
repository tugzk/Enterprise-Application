using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw2Enterprise
{
    public class ContactModel
    {
        private string name;
        private string cEmail;
        private string cNo;
       
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string ContactEmail
        {
            get { return cEmail; }
            set { cEmail = value; }
        }
        public string ContactNumber
        {
            get { return cNo; }
            set { cNo = value; }
        }
    }
}

