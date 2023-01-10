using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCPASystem
{
    public class Show
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ShowDate { get; set; }
        public string ShowTime { get; set; }
        public string Venue { get; set; }
        public string Organiser { get; set; }
        public string Promotion { get; set; }
        public int Duration { get; set; }
        public int Capacity { get; set; }
        public override string ToString()
        {
            return String.Format(Name, Description, ShowTime, Venue, Organiser, Promotion, Duration, Capacity);
        }
    }
}
