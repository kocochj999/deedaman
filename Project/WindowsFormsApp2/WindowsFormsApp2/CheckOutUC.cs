using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class CheckOutUC : UserControl
    {
        
        
        public CheckOutUC()
        {
            InitializeComponent();
        }
        public void GetValueFromForm1(List<ItemUC> foodList, List<ItemUC> drinkList, List<ItemUC> hourList, List<ItemUC2> cardList)
        {
            string resultcheckbox = "";
            float total = 0;
            foreach (ItemUC itemuc in foodList)
            {
                
                if(itemuc.Quantity > 0)
                {
                    resultcheckbox = resultcheckbox +itemuc.FoodName + " - " + itemuc.Quantity.ToString() + " - " + (itemuc.Quantity * itemuc.Price).ToString() +"\n";
                    textBoxList.Text = resultcheckbox;
                    total = total + (itemuc.Quantity * itemuc.Price);
                    totalBox.Text = total.ToString();
                }
            }
            foreach (ItemUC itemuc in drinkList)
            {

                if (itemuc.Quantity > 0)
                {
                    resultcheckbox = resultcheckbox + itemuc.FoodName + " - " + itemuc.Quantity.ToString() + " - " + (itemuc.Quantity * itemuc.Price).ToString() + "\n";
                    textBoxList.Text = resultcheckbox;
                    total = total + (itemuc.Quantity * itemuc.Price);
                    totalBox.Text = total.ToString();
                }
            }
            foreach (ItemUC itemuc in hourList)
            {

                if (itemuc.Quantity > 0)
                {
                    resultcheckbox = resultcheckbox + itemuc.FoodName + " - " + itemuc.Quantity.ToString() + " - " + (itemuc.Quantity * itemuc.Price).ToString() + "\n";
                    textBoxList.Text = resultcheckbox;
                    total = total + (itemuc.Quantity * itemuc.Price);
                    totalBox.Text = total.ToString();
                }
            }
            foreach (ItemUC2 itemuc in cardList)
            {

                if (itemuc.Quantity > 0)
                {
                    resultcheckbox = resultcheckbox + itemuc.FoodName + " - " + itemuc.Quantity.ToString() + " - " + (itemuc.Quantity * itemuc.Price).ToString() + "\n";
                    textBoxList.Text = resultcheckbox;
                    total = total + (itemuc.Quantity * itemuc.Price);
                    totalBox.Text = total.ToString();
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Tổng số tiền cần trả là: " + totalBox.Text);
        }
        
    }
}
