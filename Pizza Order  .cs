using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstWinFormProject
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        float GetSelectedSizePrice()
        {


            if(RBSmall.Checked)
            {
                return Convert.ToSingle(RBSmall.Tag);
            }
           else if(RBMedium.Checked)
            {

                return Convert.ToSingle(RBMedium.Tag);
            }
            else
            {
                return Convert.ToSingle(RBLarge.Tag);
            }
               
            



        }
        float CalculateToppingPrice()
        {

            float ToppingsTotalPrice = 0;

            if(chkExtraCheese.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chkExtraCheese.Tag);

            }
            if(chkMushrooms.Checked)
            {

                ToppingsTotalPrice += Convert.ToSingle(chkMushrooms.Tag);
            }
            if(chkTomatoes.Checked) 
            {
                ToppingsTotalPrice += Convert.ToSingle(chkTomatoes.Tag);

            }
            if(chkOnion .Checked) 
            {
                ToppingsTotalPrice += Convert.ToSingle(chkOnion.Tag);
            }
            if(chkOlivies .Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chkOlivies.Tag);
            }
            if(chkGreenPeppers .Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chkGreenPeppers.Tag);
            }
            return ToppingsTotalPrice;

        }
        float GetSelectedCrustPrice()
        {

            if(RBThikCrust.Checked)
            {
               return  Convert.ToSingle(RBThikCrust.Tag);
            }
            else
            {
                return Convert.ToSingle(RBThinCrust.Tag);
            }

        }

        float CalculateTotalPrice()
        {
            return GetSelectedSizePrice()+CalculateToppingPrice()+GetSelectedCrustPrice();

        }
        void UpdateTotalPrice()
        {


            lblTotalPrice.Text = "$" + CalculateTotalPrice() . ToString();

        }
     
        void UpdateSize()
       {
            UpdateTotalPrice();

            if(RBSmall.Checked)
            {
                lbSize.Text = "Small";
                return;
            }
            if(RBMedium.Checked)
            {
                lbSize.Text = "Medium";
                return;
            }
            if(RBLarge.Checked)
            {
                lbSize.Text = "Large";
                return;
            }

      }
        private void RBSmall_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();


        }
        private void RBMedium_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();



        }
        private void RBLarge_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();




        }

        void UpdateCrust()
        {
            UpdateTotalPrice();

         
            if  (RBThikCrust.Checked)
          
            {
                lblCrust.Text = "Thik Crust";
                return;
         
            }
            if(RBThinCrust.Checked)
            {

                lblCrust.Text = "Thin Crust";
                return;

            }
        }
        private void RBThikCrust_CheckedChanged(object sender, EventArgs e)
        {


           UpdateCrust();
           
        }

        private void RBThinCrust_CheckedChanged(object sender, EventArgs e)
        {

            UpdateCrust();

        }

        void UpdateToppings()
        {
            UpdateTotalPrice();


            string ToppingsChoise = "";


            if(chkExtraCheese.Checked)
            {
                ToppingsChoise = "Extra Cheese";
            }

            if(chkMushrooms.Checked) 
            {
                ToppingsChoise += ", Mushrooms";
            }

            if (chkTomatoes.Checked)
            {
                ToppingsChoise += ", Tomatoes";
            }
            if (chkOnion.Checked)
            {
                ToppingsChoise += ", Onion";
            }
            if (chkOlivies.Checked)
            {
                ToppingsChoise += ", Olivies";
            }
            if (chkGreenPeppers.Checked)
            {
                ToppingsChoise += ", Green Pappers";
            }
            if(ToppingsChoise.StartsWith(","))
            {
                ToppingsChoise=ToppingsChoise.Substring(1,ToppingsChoise.Length-1).Trim();  

            }


            if(ToppingsChoise=="")
            {
                ToppingsChoise = "\t\t\t(No Toppings)";

            }
            
            lblToppings.Text = ToppingsChoise;  


        }



        private void chkExtraCheese_CheckedChanged(object sender, EventArgs e)
        {

            UpdateToppings();

        }

        private void chkMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkOlivies_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkGreenPeppers_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }
        private void chkOnion_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        void UpdateWhereToEat()
        {
            if(RBEatIn.Checked)
            { 
                lbWhereToEat.Text = "Eat In";
                return;
            }
            if(RBTakeOut.Checked)
            {
            
            lbWhereToEat.Text="Take Out";
                return;
            
            }

        }
        private void RBEatIn_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }
        private void RBTakeOut_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }


        private void btnOrderPizza_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm Order", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                MessageBox.Show("Order Placed Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                btnOrderPizza.Enabled = false;
                groupBox1.Enabled = false;
                groupBox2.Enabled = false;
                groupBox3.Enabled = false;
                groupBox4.Enabled = false;

            }

        }
        //reset Form
        private void button2_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;  
            groupBox2.Enabled = true;
            groupBox3.Enabled = true;
            groupBox4.Enabled = true;

            RBMedium.Checked = true;

            chkExtraCheese.Checked = false;
            chkGreenPeppers.Checked= false; 
            chkMushrooms.Checked= false;
            chkTomatoes.Checked= false;
            chkOlivies.Checked= false;
            chkOnion.Checked= false;

            RBThikCrust.Checked= true; 

            RBEatIn.Checked= true;

            btnOrderPizza.Enabled= true;
        }

      void UpdateOrderSummry()
        {

            UpdateSize();
            UpdateToppings();
            UpdateCrust();
            UpdateWhereToEat();
            UpdateTotalPrice();


       }
        private void Form2_Load(object sender, EventArgs e)
        {

            UpdateOrderSummry();

            int Price = 0;
            lblTotalPrice.Text = $"${Price}";
            lblTotalPrice.ForeColor = Color.Green;


        }

      
    }
}
