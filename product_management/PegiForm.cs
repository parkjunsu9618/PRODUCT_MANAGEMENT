using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using product_management;
using System.IO;

namespace product_management
{
    public partial class PegiForm : Form
    {
        public PegiForm()
        {
            InitializeComponent();
        }



        DataGridViewRow row;
        int rowIdw = 0;
        String code_value = "";

        Image img;
        byte[] by;
        Bitmap bitmap;




        public string user_sysid;


        public void set_user_sysid(string user_id)
        {
            this.user_sysid = user_id;
        }





        public void serch_gridView()
        {


            Item myItem = new Item();


            List<Dictionary<String, String>> item_values = new List<Dictionary<string, string>>();

            // List 배열값
            item_values = myItem.serch3(item_code_serch.Text, item_name_serch.Text, item_date_serch.Text, item_date_serch2.Text);
            

            ItemGridView.Rows.Clear();

            int index = 1;

            foreach (Dictionary<string, string> Item_item in item_values)
            {

                rowIdw = ItemGridView.Rows.Add();
                row = ItemGridView.Rows[rowIdw];

                row.Cells["column1"].Value = Item_item["item_code"].ToString();
                row.Cells["column2"].Value = Item_item["item_name"].ToString();
                row.Cells["column3"].Value = Item_item["item_stand"].ToString();
                row.Cells["column4"].Value = Item_item["item_date"].ToString();
                row.Cells["column5"].Value = Item_item["item_amt"].ToString();
                row.Cells["column6"].Value = Item_item["item_comp"].ToString();
                row.Cells["column7"].Value = Item_item["item_samt"].ToString();
                row.Cells["column8"].Value = Item_item["item_posi"].ToString();
                row.Cells["column9"].Value = Item_item["item_yn"].ToString() == "y" ? "폐기상품" : "사용상품";
                row.Cells["column10"].Value = Item_item["item_yn"].ToString() == "y" ? true : false;


                

                row.Cells["column11"].Value = index;
                index++;

            }







        }








        public void confirmBtn_Click(string code_value)
        {

            //확인 누를때. 데이터그리드뷰 체크박스 값 가져오기.

            int row_count = ItemGridView.Rows.Count;


            for (int i = 0; i < row_count; i++)
            {

                string pegi_code = ItemGridView.Rows[i].Cells["Column1"].Value.ToString();
                bool pegi_checking = (bool)ItemGridView.Rows[i].Cells["Column10"].Value;


                Item myItem = new Item();

                myItem.pegi(pegi_code, pegi_checking);

            }


            serch_gridView();

        }






      

        private void Pegigi_Load(object sender, EventArgs e)
        {

            item_date_serch.Value = item_date_serch2.Value.AddDays(-30);

        }





        private void button1_Click(object sender, EventArgs e)
        {
            serch_gridView();
        }

        
        public void button2_Click(object sender, EventArgs e)
        {



        }



        Array[] target_container;
        Array[] target;
        
        //폐기등록,취소 UI
        private void ItemGridView_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //칼럼10확인
            string column_index = ItemGridView.Columns[e.ColumnIndex].Index.ToString();

            



            if(column_index == "10")
            {


                //페기여부
                bool checking = (bool)ItemGridView.Rows[e.RowIndex].Cells["Column10"].Value;

                
                //폐기상품.
                if (checking)
                {
                    ItemGridView.Rows[e.RowIndex].Cells["Column10"].Value = false;
                }
                else
                {

                    //재고량
                    int itemCnt = Int32.Parse(ItemGridView.Rows[e.RowIndex].Cells["Column7"].Value.ToString());

                    if (itemCnt == 0)
                    {
                        ItemGridView.Rows[e.RowIndex].Cells["Column10"].Value = true;


                        
                    }
                    else
                    {

                        //mesagebox체킹.
                        if (MessageBox.Show("재고량이 있습니다. 폐기 하시겠습니까?", "YesOrNo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            ItemGridView.Rows[e.RowIndex].Cells["Column10"].Value = true;
                        }
                        
                    }

                    
                }

                //target.Append<>





            }
            
        }


        









        private void ItemGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //칼럼10을 기억하는 로직 필요.

            






        }
    }
}
