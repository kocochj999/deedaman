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
    public partial class CardUC : UserControl
    {
        ItemUC UC1;
        ItemUC UC2;
        ItemUC UC3;
        ItemUC UC4;
        List<ItemUC> hourList;

        public CardUC()
        {
            InitializeComponent();
            
                ItemUC UC1 = new ItemUC(Properties.Resources.gamehandle, "10000", 10000, 0);
                ItemUC UC2 = new ItemUC(Properties.Resources.gamehandle, "20000", 20000, 0);
                ItemUC UC3 = new ItemUC(Properties.Resources.gamehandle, "50000", 50000, 0);
                ItemUC UC4 = new ItemUC(Properties.Resources.gamehandle, "100000", 100000, 0);

                hourList = new List<ItemUC>();
                hourList.Add(UC1);
                hourList.Add(UC2);
                hourList.Add(UC3);
                hourList.Add(UC4);
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
                    this.Controls.Add(uc);
                }
               

        }
    }
}
