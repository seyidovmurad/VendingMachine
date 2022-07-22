using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    class Snack
    {
        

        public int SnackAmount
        {
            get;
            set;
        }

        public double SnackPrice { get; set; }

        public string SnackName { get; set; }

        public Snack() { }

        public Snack(int snackAmount, double snackPrice, string snackName)
        {
            SnackAmount = snackAmount;
            SnackPrice = snackPrice;
            SnackName = snackName;
        }
    }
}
