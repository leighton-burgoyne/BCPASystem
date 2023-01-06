using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCPA
{
    public class Show
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public DateTime ShowDate { get; set; }
        public DateTime ShowTime { get; set; }
        public string Venue { get; set; }
        public string Organiser { get; set; }
        public int Duration { get; set; }
        public int Capacity { get; set; }


    }
}
