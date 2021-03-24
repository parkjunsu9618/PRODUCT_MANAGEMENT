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
    public partial class PegiFdd : Form
    {
        public PegiFdd()
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
            item_values = myItem.serch(item_code_serch.Text, item_name_serch.Text, item_date_serch.Text, item_date_serch2.Text);




            ItemGridView.Rows.Clear();

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





                //Console.WriteLine(Item_item["Item_id"]);
            }


        }




        public void btnValue()
        {
            //insertBtn.Enabled = false;
            //deleteBtn.Enabled = false;
            //confirmBtn.Enabled = true;
            //canselBtn.Enabled = true;

        }

        public void btnValue2()
        {
            //insertBtn.Enabled = true;
            //deleteBtn.Enabled = true;
            //confirmBtn.Enabled = false;
            //canselBtn.Enabled = false;

        }




        public void renderImage(String Item_id)
        {

            Item myItem = new Item();
            Dictionary<String, byte[]> img_value = new Dictionary<string, byte[]>();
            img_value = myItem.checking_Item_img(Item_id);
            if (img_value == null)
            {
                pictureBox1.Image = null;
            }
            else
            {
                pictureBox1.Image = new Bitmap(new MemoryStream(img_value["img"]));
            }

        }


        public void clear()
        {

            if (MessageBox.Show("입력하신 내용을 지우시겠습니까?", "YesOrNo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                item_code.Text = "";
                item_name.Text = "";
                item_stand.Text = "";
                item_date.Text = "";
                item_amt.Text = "";
                item_comp.Text = "";
                item_samt.Text = "";
                item_posi.Text = "";
                item_etc.Text = "";
                pictureBox1.Image = null;
            }

        }

        public void serchBtn_Click(object sender, EventArgs e)
        {
            serch_gridView();
        }


        public void insertBtn_Click(object sender, EventArgs e)
        {

            clear();



            Button check_type = (Button)sender;
            if(check_type.Text == "폐기등록")
            {
                code_value = "I";
            }
            else
            {
                code_value = "C";
            }


            
            btnValue();
        }





        public void confirmBtn_Click(string code_value)
        {
            //입력,수정,삭제시 값 물어보기.

            if (item_code.Text == "")
            {
                MessageBox.Show("물품코드를 입력해주세요.");
                return;
            }
            else if (item_name.Text == "")
            {
                MessageBox.Show("물품명을 입력해주세요.");
                return;

            }
            else if (item_stand.Text == "")
            {
                MessageBox.Show("규격을 입력해주세요.");
                return;
            }
            else if (item_date.Text == "")
            {
                MessageBox.Show("구입일자를 입력해주세요.");
                return;
            }
            else if (item_amt.Text == "")
            {
                MessageBox.Show("취득가액을 입력해주세요.");
                return;
            }
            else if (item_comp.Text == "")
            {
                MessageBox.Show("구입처를 입력해주세요.");
                return;
            }
            else if (item_samt.Text == "")
            {
                MessageBox.Show("재고량을 입력해주세요.");
                return;
            }
            else if (item_posi.Text == "")
            {
                MessageBox.Show("물품위치를 입력해주세요.");
                return;
            }
            else if (item_etc.Text == "")
            {
                MessageBox.Show("비고를 입력해주세요.");
                return;
            }





            Item myItem = new Item();
            


            if (code_value == "I")
            {




            }
            else if (code_value == "C")
            {

                myItem.pegi_cansel(item_code.Text);

            }


            clear();
            serch_gridView();
            btnValue2();
        }





        public void canselBtn_Click(object sender, EventArgs e)
        {
            clear();
            btnValue2();

        }









        private void ItemGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ItemGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            item_code.Text = ItemGridView.Rows[e.RowIndex].Cells["Column1"].Value.ToString();
            item_name.Text = ItemGridView.Rows[e.RowIndex].Cells["Column2"].Value.ToString();
            item_stand.Text = ItemGridView.Rows[e.RowIndex].Cells["Column3"].Value.ToString();
            item_date.Text = ItemGridView.Rows[e.RowIndex].Cells["Column4"].Value.ToString();
            item_amt.Text = ItemGridView.Rows[e.RowIndex].Cells["Column5"].Value.ToString();
            item_comp.Text = ItemGridView.Rows[e.RowIndex].Cells["Column6"].Value.ToString();
            item_samt.Text = ItemGridView.Rows[e.RowIndex].Cells["Column7"].Value.ToString();
            item_posi.Text = ItemGridView.Rows[e.RowIndex].Cells["Column8"].Value.ToString();



            String ItemCode = ItemGridView.Rows[e.RowIndex].Cells["Column1"].Value.ToString();

            Item myItem = new Item();
            renderImage(ItemCode);
        }

        private void PegiForm_Load(object sender, EventArgs e)
        {


            item_code.Focus();


            item_date_serch.Value = item_date_serch2.Value.AddDays(-30);


            btnValue2();
        }
    }
}
