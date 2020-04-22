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
    public partial class ItemUC2 : UserControl
    {
        public ItemUC2()
        {
            InitializeComponent();
        }

        private void ItemUC2_Load(object sender, EventArgs e)
        {
            foreach (Control ctl in Controls)
            {
                if (ctl.GetType() == typeof(NumericUpDown))
                {
                    ctl.MouseWheel += Ctl_MouseWheel;
                }
            }
        }
        private void Ctl_MouseWheel(object sender, MouseEventArgs e)
            {
                ((HandledMouseEventArgs)e).Handled = true;
            }


        private string foodName;
        private float price;
        private int quantity;

        public string FoodName { get => foodName; set => foodName = value; }
        public float Price { get => price; set => price = value; }
        public int Quantity { get => quantity; set => quantity = value; }

        public ItemUC2(Bitmap img, string n, int q)
        {
            InitializeComponent();
            this.pictureBox2.Image = img;

            this.foodName = n;
            this.labelName.Text = this.foodName;

            

            this.quantity = q;
            this.numericQuantity.Value = this.quantity;
        }

        private void numericQuantity_ValueChanged(object sender, EventArgs e)
        {
            
        }
        private void listBoxPrice_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.price = float.Parse(this.listBoxPrice.Text);
        }
        private void numericQuantity_ValueChanged_1(object sender, EventArgs e)
        {
            this.quantity = (int)this.numericQuantity.Value;
        }
        public float totalItem()
        {
            return this.quantity * this.price;
        }

        private void change(object sender, EventArgs e)
        {
            
        }
    }
}
