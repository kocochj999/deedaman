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
    public partial class HourUC : UserControl
    {
        ItemUC UC1;
        ItemUC UC2;
        ItemUC UC3;
        ItemUC UC4;
        List<ItemUC> hourList;

        public HourUC()
        {
            InitializeComponent();
            UC1 = new ItemUC(Properties.Resources.gamehandle, "10000đ Giờ chơi", 10000, 0);
            UC2 = new ItemUC(Properties.Resources.gamehandle, "20000đ Giờ chơi", 20000, 0);
            UC3 = new ItemUC(Properties.Resources.gamehandle, "50000đ Giờ chơi", 50000, 0);
            UC4 = new ItemUC(Properties.Resources.gamehandle, "100000đ Giờ chơi", 100000, 0);

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

        public List<ItemUC> HourList { get => hourList; set => hourList = value; }

        public float TotalOfTotal()
        {
            float result = 0;
            foreach (ItemUC item in hourList)
            {
                result += item.totalItem();
            }
            return result;
        }
    }
}
