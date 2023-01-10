using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BCPASystem
{
    public class Promotion
    {
        public string Identifier { get; set; }
        public double AdultPrice { get; set; }
        public double StudentPrice { get; set; }
        public double SeniorPrice { get; set; }
        public double ChildPrice { get; set; }
        public override string ToString()
        {
            return String.Format(Identifier, AdultPrice, StudentPrice, SeniorPrice, ChildPrice);
        }
    }
}
