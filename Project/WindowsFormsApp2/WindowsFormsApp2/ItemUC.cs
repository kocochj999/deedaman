﻿using System;
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
    public partial class ItemUC : UserControl
    {
        public ItemUC()
        {
            InitializeComponent();
        }

        private void UserControlFood_Load(object sender, EventArgs e)
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
        
        

        public float Price { get => price; set => price = value; }
        public string FoodName { get => foodName; set => foodName = value; }
        public int Quantity { get => quantity; set => quantity = value; }

        public ItemUC(Bitmap img,  string n, float p, int q)
        {
            InitializeComponent();
            this.pictureBox2.Image = img;
            
            this.foodName = n;
            this.labelName.Text = this.foodName;

            this.price = p;
            this.labelPrice.Text = this.price.ToString();

            this.quantity = q;
            this.numericQuantity.Value = this.quantity;
        }

        private void numericQuantity_ValueChanged(object sender, EventArgs e)
        {
            this.quantity = (int) this.numericQuantity.Value;
        }
        public float totalItem()
        {
            return this.quantity * this.price;
        }
        
    }
}
