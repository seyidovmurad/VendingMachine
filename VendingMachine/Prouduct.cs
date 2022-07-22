using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VendingMachine
{



    public partial class Prouduct : UserControl
    {


        public string ProducName { get; set; }

        private int productCount;

        public int ProductCount 
        { 
            get => productCount;
            set
            {
                if (value > 50 || value < 0)
                {
                    productCount = 0;
                    throw new Exception("Product Count 0 - 50");
                }
                else
                    productCount = value;
            }
        }

        

        public double ProductPrice { get; set; }

        public Prouduct()
        {
            InitializeComponent();
            Btn_Product.Click += new EventHandler(BtnClick);
        }


        private void Prouduct_Paint(object sender, PaintEventArgs e)
        {
            Lbl_Price.Text = ProductPrice.ToString();
            NUD_CountProduct.Value = productCount;
            NUD_CountProduct.Enabled = false;
            Btn_Product.Text = ProducName;
        }

        private void NUD_CountProduct_ValueChanged(object sender, EventArgs e)
        {
            if (NUD_CountProduct.Value == 0)
                Btn_Product.Enabled = false;
            else
                Btn_Product.Enabled = true;
        }

        public event EventHandler ProductBtnClick;

        private void BtnClick(object sender, EventArgs e)
        {
            if (ProductBtnClick != null)
            {
                ProductBtnClick.Invoke(sender, e);
            }
        }

        public void ChangeProductCount(int count)
        {
            NUD_CountProduct.Value = count;
        }
    }
}
