using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw2Enterprise
{
    public class EventModel
    {
        private string Name;
        private string location;
        private string notes;
        private static DateTime _DateTime;
        private string _contact;

        public static IFormatProvider EventDetails { get; internal set; }

        public string name
        {
            get { return Name; }
            set { Name = value; }
        }

        public string Location
        {
            get { return location; }
            set { location = value; }
        }

        public static DateTime EDateTime
        {
            get { return _DateTime; }
            set { _DateTime = value; }
        }

        public static string _Event { get; set; }

        public string _Contact
        {
            get { return _contact; }
            set { _contact = value; }
        }

        public string Notes
        {
            get { return notes; }
            set { notes = value; }
        }

        public string _eventType
        {
            get { return _eventType; }
            set { _eventType = value; }
        }
    }
}
