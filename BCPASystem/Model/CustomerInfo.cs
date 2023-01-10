using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCPASystem
{
    public static class CustomerInfo
    {
        public static readonly ObservableCollection<Customer> Customers = new ObservableCollection<Customer>();
    }
}