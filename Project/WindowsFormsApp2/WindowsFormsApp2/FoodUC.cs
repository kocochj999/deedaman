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
    public partial class FoodUC : UserControl
    {
        ItemUC UC1;
        ItemUC UC2;
        ItemUC UC3;
        ItemUC UC4;
        ItemUC UC5;
        ItemUC UC6;
        List<ItemUC> foodList;


        public FoodUC()
        {
            InitializeComponent();

            UC1 = new ItemUC(Properties.Resources.com_rang_thap_cam, "Cơm rang thập cẩm", 30000, 0);
            UC2 = new ItemUC(Properties.Resources.cach_lam_com_rang_dua_bo_1, "Cơm rang dưa bò", 35000, 0);
            UC3 = new ItemUC(Properties.Resources.bánh_mì_trứng, "Bánh mì trứng", 10000, 0);
            UC4 = new ItemUC(Properties.Resources.bánh_mì_xúc_xích, "Bánh mì xúc xích", 15000, 0);
            UC5 = new ItemUC(Properties.Resources.mì_tôm_trứng, "Mì tôm trứng", 10000, 0);
            UC6 = new ItemUC(Properties.Resources.thêm_trứng, "Thêm trứng", 5000, 0);

            foodList = new List<ItemUC>();

            foodList.Add(UC1);
            foodList.Add(UC2);
            foodList.Add(UC3);
            foodList.Add(UC4);
            foodList.Add(UC5);
            foodList.Add(UC6);
            
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
                this.Controls.Add(uc);
            }

        }
        
            
            
        
    }
}
