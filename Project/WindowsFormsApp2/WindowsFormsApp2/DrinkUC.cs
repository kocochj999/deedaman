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
    public partial class DrinkUC : UserControl
    {
        ItemUC UC1;
        ItemUC UC2;
        ItemUC UC3;
        ItemUC UC4;
        ItemUC UC5;
        ItemUC UC6;
        List<ItemUC> drinkList;
        public DrinkUC()
        {
            InitializeComponent();
            
                UC1 = new ItemUC(Properties.Resources._7up, "7up", 12000, 0);
                UC2 = new ItemUC(Properties.Resources.aquafina, "Aquafina", 8000, 0);
                UC3 = new ItemUC(Properties.Resources.coca, "Cocacola", 12000, 0);
                UC4 = new ItemUC(Properties.Resources.monster, "Monster", 30000, 0);
                UC5 = new ItemUC(Properties.Resources.sting, "Sting", 10000, 0);
                UC6 = new ItemUC(Properties.Resources.trà_đá, "Trà đá", 10000, 0);

                drinkList = new List<ItemUC>();

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
                    this.Controls.Add(uc);
                }
                
            

        }
    }
}
