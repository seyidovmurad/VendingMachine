using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VendingMachine
{
    public partial class Form1 : Form
    {
        double money = 0;
        string SelectedSnack;

        List<Snack> snacks;
        public Form1()
        {
            InitializeComponent();
            snacks = new List<Snack>();
            if (File.Exists("snacks.json"))
            {
                var jsonStr = File.ReadAllText("snacks.json");
                if (jsonStr.Length > 0)
                    snacks = JsonConvert.DeserializeObject<List<Snack>>(jsonStr);
            }
            else
                File.WriteAllText("snacks.json", "");
            UpdateProducts();
        }

        private void Btn_10Qep_Click(object sender, EventArgs e)
        {
            if(sender is Button button)
            {
                if (button.Name == "Btn_10Qep") money += 0.1;
                else if (button.Name == "Btn_20Qep") money += 0.2;
                else if (button.Name == "Btn_50Qep") money += 0.5;
                else if (button.Name == "Btn_1Azn") money += 1;
                else if (button.Name == "Btn_5Azn") money += 5;
                else if (button.Name == "Btn_10Azn") money += 10;
                Lbl_MoneyIn.Text = money.ToString();
                if (!string.IsNullOrEmpty(SelectedSnack) && Convert.ToDouble(Lbl_Price.Text) <= money) { 
                    Btn_Pay.Enabled = true;
                    Lbl_MoneyOut.Text = (money - Convert.ToDouble(Lbl_Price.Text)).ToString();
                }
            }
        }


        private void prouduct1_Click(object sender, EventArgs e)
        {
            if(sender is Prouduct product)
            {
                Lbl_Price.Text = product.ProductPrice.ToString();
            }
        }

        private void prouduct1_ProductBtnClick(object sender, EventArgs e)
        {
            if(sender is Button btn)
            {
                SelectedSnack = btn.Text;
                Lbl_Price.Text = snacks.Find(p => p.SnackName == SelectedSnack).SnackPrice.ToString();
                Btn_Pay.Text = SelectedSnack;
            }
        }

        private void Lbl_Price_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(SelectedSnack) && Convert.ToDouble(Lbl_Price.Text) <= money)
            {
                Btn_Pay.Enabled = true;
                Lbl_MoneyOut.Text = (money - Convert.ToDouble(Lbl_Price.Text)).ToString();
            }
        }

        private void Btn_Pay_Click(object sender, EventArgs e)
        {
            AddCustomerToJson();
            Btn_Pay.Enabled = false;
            Btn_Pay.Text = string.Empty;
            Lbl_MoneyOut.Text = "0";
            Lbl_MoneyIn.Text = "0";
            snacks.Find(s => s.SnackName == SelectedSnack).SnackAmount--;
            AddSnacksToJson();
            SelectedSnack = string.Empty;
            Lbl_Price.Text = "0";
            money = 0;
            prouduct1.ChangeProductCount(snacks[0].SnackAmount);
            prouduct2.ChangeProductCount(snacks[1].SnackAmount);
            prouduct3.ChangeProductCount(snacks[2].SnackAmount);
            prouduct4.ChangeProductCount(snacks[3].SnackAmount);
            prouduct5.ChangeProductCount(snacks[4].SnackAmount);
            prouduct6.ChangeProductCount(snacks[5].SnackAmount);
            prouduct7.ChangeProductCount(snacks[6].SnackAmount);
            prouduct8.ChangeProductCount(snacks[7].SnackAmount);
            prouduct9.ChangeProductCount(snacks[8].SnackAmount);
            prouduct10.ChangeProductCount(snacks[9].SnackAmount);
            prouduct11.ChangeProductCount(snacks[10].SnackAmount);
            prouduct12.ChangeProductCount(snacks[11].SnackAmount);
            

        }


        private void AddCustomerToJson()
        {
            List<Customer> customers = new List<Customer>();
            if (File.Exists("customer.json"))
            {
                var jsonStr = File.ReadAllText("customer.json");
                if (jsonStr.Length > 0)
                    customers = JsonConvert.DeserializeObject<List<Customer>>(jsonStr);
            }
            Customer customer = new Customer();
            customer.SnackBought = snacks.Find(s => s.SnackName == SelectedSnack);
            customer.MoneyIn = Lbl_MoneyIn.Text;
            customer.MoneyOut = Lbl_MoneyOut.Text;
            customer.TimeOfBuying = DateTime.Now.ToString();
            customers.Add(customer);
            var jsonFile = JsonConvert.SerializeObject(customers, Formatting.Indented);
            File.WriteAllText("customer.json", jsonFile);
        }

        private void AddSnacksToJson()
        {
            var jsonFile = JsonConvert.SerializeObject(snacks, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText("snacks.json", jsonFile);
        }


        private void UpdateProducts()
        {
            prouduct1.ProducName = snacks[0].SnackName;
            prouduct1.ProductCount = snacks[0].SnackAmount;
            prouduct1.ProductPrice = snacks[0].SnackPrice;
            //
            prouduct2.ProducName = snacks[1].SnackName;
            prouduct2.ProductCount = snacks[1].SnackAmount;
            prouduct2.ProductPrice = snacks[1].SnackPrice;
            //
            prouduct3.ProducName = snacks[2].SnackName;
            prouduct3.ProductCount = snacks[2].SnackAmount;
            prouduct3.ProductPrice = snacks[2].SnackPrice;
            //
            prouduct4.ProducName = snacks[3].SnackName;
            prouduct4.ProductCount = snacks[3].SnackAmount;
            prouduct4.ProductPrice = snacks[3].SnackPrice;
            //
            prouduct5.ProducName = snacks[4].SnackName;
            prouduct5.ProductCount = snacks[4].SnackAmount;
            prouduct5.ProductPrice = snacks[4].SnackPrice;
            //
            prouduct6.ProducName = snacks[5].SnackName;
            prouduct6.ProductCount = snacks[5].SnackAmount;
            prouduct6.ProductPrice = snacks[5].SnackPrice;
            //
            prouduct7.ProducName = snacks[6].SnackName;
            prouduct7.ProductCount = snacks[6].SnackAmount;
            prouduct7.ProductPrice = snacks[6].SnackPrice;
            //
            prouduct8.ProducName = snacks[7].SnackName;
            prouduct8.ProductCount = snacks[7].SnackAmount;
            prouduct8.ProductPrice = snacks[7].SnackPrice;
            //
            prouduct9.ProducName = snacks[8].SnackName;
            prouduct9.ProductCount = snacks[8].SnackAmount;
            prouduct9.ProductPrice = snacks[8].SnackPrice;
            //
            prouduct10.ProducName = snacks[9].SnackName;
            prouduct10.ProductCount = snacks[9].SnackAmount;
            prouduct10.ProductPrice = snacks[9].SnackPrice;
            //
            prouduct11.ProducName = snacks[10].SnackName;
            prouduct11.ProductCount = snacks[10].SnackAmount;
            prouduct11.ProductPrice = snacks[10].SnackPrice;
            //
            prouduct12.ProducName = snacks[11].SnackName;
            prouduct12.ProductCount = snacks[11].SnackAmount;
            prouduct12.ProductPrice = snacks[11].SnackPrice;
            //
        }
    }
}
