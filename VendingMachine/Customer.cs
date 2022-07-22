using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    class Customer
    {
        public string MoneyIn { get; set; }

        public string MoneyOut { get; set; }

        public string TimeOfBuying { get; set; }

        public Snack SnackBought { get; set; }

        public Customer()
        {
            SnackBought = new Snack();
        }
    }
}
