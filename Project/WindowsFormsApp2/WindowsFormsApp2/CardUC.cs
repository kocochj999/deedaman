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
        ItemUC2 UC1;
        ItemUC2 UC2;
        ItemUC2 UC3;
        ItemUC2 UC4;
        ItemUC2 UC5;
        List<ItemUC2> cardList;

        public CardUC()
        {
            InitializeComponent();
            UC1 = new ItemUC2(Properties.Resources.thẻ_viettel, "Viettel",  0);
            UC2 = new ItemUC2(Properties.Resources.thẻ_vina, "Vinaphone",  0);
            UC3 = new ItemUC2(Properties.Resources.thẻ_VNG, "Vinagame",  0);
            UC4 = new ItemUC2(Properties.Resources.thẻ_VTC, "VTCGame",  0);

            cardList = new List<ItemUC2>();

            cardList.Add(UC1);
            cardList.Add(UC2);
            cardList.Add(UC3);
            cardList.Add(UC4);
            
            int k = 0;
            
            for (int i = 0; i < (cardList.Count/2) ; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    cardList[k].Location = new Point(75 + j * 350, i * 350);
                    k++;
                }
            }
            foreach (ItemUC2 uc in cardList)
            {
                this.Controls.Add(uc);
            }

        }

        public List<ItemUC2> CardList { get => cardList; set => cardList = value; }

        public float TotalOfTotal()
        {
            float result = 0;
            foreach (ItemUC2 item in cardList)
            {
                result += item.totalItem();
            }
            return result;
        }
    }
}
