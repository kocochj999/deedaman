using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {

        FoodUC ucFood = new FoodUC();
        DrinkUC ucDrink = new DrinkUC();
        CardUC ucCard = new CardUC();
        HourUC ucHour = new HourUC();
        CheckOutUC ucCheckOut = new CheckOutUC();
        
        


        

        public Form1()
        {
            InitializeComponent();
            SidePanel.Height = FoodButton.Height;
            SidePanel.Top = FoodButton.Top;
            MainPanel.Controls.Add(ucFood);
            ucFood.Dock = DockStyle.Fill;
            ucFood.BringToFront();
        }

        private void FoodButton_Click(object sender, EventArgs e)
        {
            SidePanel.Height = FoodButton.Height;
            SidePanel.Top = FoodButton.Top;
            MainPanel.Controls.Add(ucFood);
            ucFood.Dock = DockStyle.Fill;
            ucFood.BringToFront();



        }

        private void DrinkButton_Click(object sender, EventArgs e)
        {

            SidePanel.Height = DrinkButton.Height;
            SidePanel.Top = DrinkButton.Top;
            MainPanel.Controls.Add(ucDrink);
            ucDrink.Dock = DockStyle.Fill;
            ucDrink.BringToFront();

        }

        private void CardsButton_Click(object sender, EventArgs e)
        {
            SidePanel.Height = CardsButton.Height;
            SidePanel.Top = CardsButton.Top;
            MainPanel.Controls.Add(ucCard);
            ucCard.Dock = DockStyle.Fill;
            ucCard.BringToFront();
        }

        private void GameHourButton_Click(object sender, EventArgs e)
        {
            SidePanel.Height = GameHourButton.Height;
            SidePanel.Top = GameHourButton.Top;
            MainPanel.Controls.Add(ucHour);
            ucHour.Dock = DockStyle.Fill;
            ucHour.BringToFront();
        }

        private void CheckOutButton_Click(object sender, EventArgs e)
        {
            SidePanel.Height = CheckOutButton.Height;
            SidePanel.Top = CheckOutButton.Top;
            MainPanel.Controls.Add(ucCheckOut);
            ucCheckOut.Dock = DockStyle.Fill;
            ucCheckOut.BringToFront();
            ucCheckOut.GetValueFromForm1(ucFood.FoodList, ucDrink.DrinkList, ucHour.HourList, ucCard.CardList);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        public float TotalOfAll()
        {
            return ucFood.TotalOfTotal() + ucDrink.TotalOfTotal() + ucHour.TotalOfTotal() +ucCard.TotalOfTotal();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            this.TotalTextBox.Text = TotalOfAll().ToString();
            
        }
        
    }
}
