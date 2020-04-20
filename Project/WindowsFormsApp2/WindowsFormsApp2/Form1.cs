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
        

        public Form1()
        {
            InitializeComponent();
            SidePanel.Height = FoodButton.Height;
            SidePanel.Top = FoodButton.Top;
            DisplayFood();
            foodContainer.BringToFront();



        }
        public void DisplayDrink()
        {
            ItemUC UC1 = new ItemUC(Properties.Resources._7up, "7up", 12000, 0);
            ItemUC UC2 = new ItemUC(Properties.Resources.aquafina, "Aquafina", 8000, 0);
            ItemUC UC3 = new ItemUC(Properties.Resources.coca, "Cocacola", 12000, 0);
            ItemUC UC4 = new ItemUC(Properties.Resources.monster, "Monster", 30000, 0);
            ItemUC UC5 = new ItemUC(Properties.Resources.sting, "Sting", 10000, 0);
            ItemUC UC6 = new ItemUC(Properties.Resources.trà_đá, "Trà đá", 10000, 0);

            List<ItemUC> drinkList = new List<ItemUC>();
            drinkList.Add(UC1);
            drinkList.Add(UC2);
            drinkList.Add(UC3);
            drinkList.Add(UC4);
            drinkList.Add(UC5);
            drinkList.Add(UC6);

            int k = 0;
            for (int i = 0; i < (drinkList.Count / 2); i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    drinkList[k].Location = new Point(75 + j * 350, i * 350);
                    k++;
                }
            }
            foreach (ItemUC uc in drinkList)
            {
                drinkContainer.Controls.Add(uc);
            }
            drinkContainer.BringToFront();
        }
        public void DisplayFood()
        {
            ItemUC UC7 = new ItemUC(Properties.Resources.com_rang_thap_cam, "Cơm rang thập cẩm", 30000, 0);
            ItemUC UC8 = new ItemUC(Properties.Resources.cach_lam_com_rang_dua_bo_1, "Cơm rang dưa bò", 35000, 0);
            ItemUC UC9 = new ItemUC(Properties.Resources.bánh_mì_trứng, "Bánh mì trứng", 10000, 0);
            ItemUC UC10 = new ItemUC(Properties.Resources.bánh_mì_xúc_xích, "Bánh mì xúc xích", 15000, 0);
            ItemUC UC11 = new ItemUC(Properties.Resources.mì_tôm_trứng, "Mì tôm trứng", 10000, 0);
            ItemUC UC12 = new ItemUC(Properties.Resources.thêm_trứng, "Thêm trứng", 5000, 0);
            List<ItemUC> foodList = new List<ItemUC>();
            foodList.Add(UC7);
            foodList.Add(UC8);
            foodList.Add(UC9);
            foodList.Add(UC10);
            foodList.Add(UC11);
            foodList.Add(UC12);
            int k = 0;
            for (int i = 0; i < (foodList.Count / 2); i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    foodList[k].Location = new Point(75 + j * 350, i * 350);
                    k++;
                }
            }
            foreach (ItemUC uc in foodList)
            {
                foodContainer.Controls.Add(uc);
            }
            foodContainer.BringToFront();
        }
        public void DisplayGameHour()
        {
            ItemUC UC13 = new ItemUC(Properties.Resources.gamehandle, "10000", 10000, 0);
            ItemUC UC14 = new ItemUC(Properties.Resources.gamehandle, "20000", 20000, 0);
            ItemUC UC15 = new ItemUC(Properties.Resources.gamehandle, "50000", 50000, 0);
            ItemUC UC16 = new ItemUC(Properties.Resources.gamehandle, "100000", 100000, 0);
            List <ItemUC > hourList = new List<ItemUC>();
            hourList.Add(UC13);
            hourList.Add(UC14);
            hourList.Add(UC15);
            hourList.Add(UC16);
            int k = 0;
            for (int i = 0; i < (hourList.Count / 2); i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    hourList[k].Location = new Point(75 + j * 350, i * 350);
                    k++;
                }
            }
            foreach (ItemUC uc in hourList)
            {
                gameHourContainer.Controls.Add(uc);
            }
            gameHourContainer.BringToFront();
            
        }

        private void FoodButton_Click(object sender, EventArgs e)
        {

            SidePanel.Height = FoodButton.Height;
            SidePanel.Top = FoodButton.Top;
            DisplayFood();
            
            
        }

        private void DrinkButton_Click(object sender, EventArgs e)
        {

            SidePanel.Height = DrinkButton.Height;
            SidePanel.Top = DrinkButton.Top;
            DisplayDrink();
            

            

        }

        private void CardsButton_Click(object sender, EventArgs e)
        {
            SidePanel.Height = CardsButton.Height;
            SidePanel.Top = CardsButton.Top;
           


        }

        private void GameHourButton_Click(object sender, EventArgs e)
        {
            SidePanel.Height = GameHourButton.Height;
            SidePanel.Top = GameHourButton.Top;
            DisplayGameHour();
            

        }

        private void CheckOutButton_Click(object sender, EventArgs e)
        {
            SidePanel.Height = CheckOutButton.Height;
            SidePanel.Top = CheckOutButton.Top;
        }

        
        






}
}
