using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaProject
{
    public partial class frmPizzaOrder : Form
    { 
        public frmPizzaOrder()
        {
            InitializeComponent();
        }

        void UpdateTotalPrice()
        {
            double TotalPrice = 0;
            if(rdSmallSize.Checked)
            {
                TotalPrice += Convert.ToSByte(rdSmallSize.Tag);
            }
            if (rdMeduimSize.Checked)
            {
                TotalPrice += Convert.ToSByte(rdMeduimSize.Tag);
            }
            if (rdLargeSize.Checked)
            {
                TotalPrice += Convert.ToSByte(rdLargeSize.Tag);
            }

            if (rdThickCrust.Checked)
            {
                TotalPrice += Convert.ToSByte(rdThickCrust.Tag);
            }

            if (chkExtraCheese.Checked)
            {
                TotalPrice += Convert.ToSByte(chkExtraCheese.Tag);
            }
            if (chkMushrooms.Checked)
            {
                TotalPrice += Convert.ToSByte(chkMushrooms.Tag);
            }
            if (chkOlives.Checked)
            {
                TotalPrice += Convert.ToSByte(chkOlives.Tag);
            }
            if (chkTomatoes.Checked)
            {
                TotalPrice += Convert.ToSByte(chkTomatoes.Tag);
            }
            if (chkGreenPappers.Checked)
            {
                TotalPrice += Convert.ToSByte(chkGreenPappers.Tag);
            }
            if (chkOnion.Checked)
            {
                TotalPrice += Convert.ToSByte(chkOnion.Tag);
            }

            lbTotalPrice.Text = "$" + Convert.ToString(TotalPrice);
        }
        void UpdateToppings()
        {
            string Topping = "";
            if(chkExtraCheese.Checked)
            {
                Topping += chkExtraCheese.Text+",";
            }
            if (chkMushrooms.Checked)
            {
                Topping += chkMushrooms.Text+",";
            }
            if (chkOlives.Checked)
            {
                Topping += chkOlives.Text+",";
            }
            if (chkOnion.Checked)
            {
                Topping += chkOnion.Text+",";
            }
            if (chkTomatoes.Checked)
            {
                Topping += chkTomatoes.Text+",";
            }
            if (chkGreenPappers.Checked)
            {
                Topping += chkGreenPappers.Text+",";
            }

            if (Topping == "")
                lbTopping.Text = "No Toppings";
            else
                lbTopping.Text = Topping;
        }

        void ResetOrder()
        {
            rdSmallSize.Checked = false;
            rdMeduimSize.Checked = true;
            rdLargeSize.Checked = false;

            rdThickCrust.Checked = false;
            rdThinCrust.Checked = true;

            rdTakeOut.Checked = false;
            rdEatIn.Checked = true;

            chkExtraCheese.Checked = false;
            chkGreenPappers.Checked = false;
            chkMushrooms.Checked = false;
            chkOlives.Checked = false;
            chkOnion.Checked = false;
            chkTomatoes.Checked = false;

           // lbTotalPrice.Text = "$0";
        }
        private void rdSmallSize_CheckedChanged(object sender, EventArgs e)
        {
            lbSize.Text = rdSmallSize.Text;
            //  lbTotalPrice.Tag = Convert.ToSByte(lbTotalPrice.Tag) + Convert.ToSByte(rdSmallSize.Tag);
            // lbTotalPrice.Text = "$" +Convert.ToString(lbTotalPrice.Tag);
            UpdateTotalPrice();

        }

        private void rdMeduimSize_CheckedChanged(object sender, EventArgs e)
        {
            lbSize.Text = rdMeduimSize.Text;
            UpdateTotalPrice();
        }

        private void rdLargeSize_CheckedChanged(object sender, EventArgs e)
        {
            lbSize.Text = rdLargeSize.Text;
            UpdateTotalPrice();
        }

        private void rdThinCrust_CheckedChanged(object sender, EventArgs e)
        {
            lbCrustType.Text = rdThinCrust.Text;
        }

        private void rdThickCrust_CheckedChanged(object sender, EventArgs e)
        {
            lbCrustType.Text = rdThickCrust.Text;
            UpdateTotalPrice();
        }

        private void rdEatIn_CheckedChanged(object sender, EventArgs e)
        {
            lbWhereToEat.Text = rdEatIn.Text;
        }

        private void rdTakeOut_CheckedChanged(object sender, EventArgs e)
        {
            lbWhereToEat.Text = rdTakeOut.Text;
        }

        private void chkExtraCheese_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
            UpdateTotalPrice();
        }

        private void chkMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
            UpdateTotalPrice();
        }

        private void chkTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
            UpdateTotalPrice();
        }

        private void chkOnion_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
            UpdateTotalPrice();
        }

        private void chkOlives_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
            UpdateTotalPrice();
        }

        private void chkGreenPappers_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
            UpdateTotalPrice();
        }

        private void btnOrderPizza_Click(object sender, EventArgs e)
        {
            gbSize.Enabled = false;
            gbToppings.Enabled = false;
            gbWhereToEat.Enabled = false;
            gbCrustType.Enabled = false;
            btnOrderPizza.Enabled = false;
        }

        private void btnResetForm_Click(object sender, EventArgs e)
        {
            gbSize.Enabled = true;
            gbToppings.Enabled = true;
            gbWhereToEat.Enabled = true;
            gbCrustType.Enabled = true;
            btnOrderPizza.Enabled = true;
            ResetOrder();
        }
    }
}
