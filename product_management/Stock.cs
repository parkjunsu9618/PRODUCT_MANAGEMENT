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
    public partial class Stock : Form
    {



        DataGridViewRow row;
        int rowIdw = 0;




        String code_value = "";

        Image img;
        byte[] by;
        Bitmap bitmap;



        public Stock()
        {
            InitializeComponent();
        }

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


        public void renderImage(String Item_id)
        {

            Item myItem = new Item();
            Dictionary<String, byte[]> img_value = new Dictionary<string, byte[]>();
            img_value = myItem.checking_Item_img(Item_id);
            if (img_value == null)
            {
                //pictureBox1.Image = null;
            }
            else
            {
                //pictureBox1.Image = new Bitmap(new MemoryStream(img_value["img"]));
            }

        }





        private void serchBtn_Click(object sender, EventArgs e)
        {
            serch_gridView();
        }

        private void ItemGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            //입고든 출고든 item_code로 받기
            string item_code = ItemGridView.Rows[e.RowIndex].Cells["Column1"].Value.ToString();

            



            Ipgo myipgo = new Ipgo();


            List<Dictionary<String, String>> ipgo_values = new List<Dictionary<string, string>>();
            // List 배열값

            ipgo_values = myipgo.serch_stock(item_code, ipgo_date_serch.Text, ipgo_date_serch2.Text);


            ipgoGridView.Rows.Clear();

            foreach (Dictionary<string, string> ipgo_ipgo in ipgo_values)
            {



                rowIdw = ipgoGridView.Rows.Add();
                row = ipgoGridView.Rows[rowIdw];
                

                row.Cells["item_cnt"].Value = ipgo_ipgo["item_samt"].ToString();
                row.Cells["ipgo_date"].Value = ipgo_ipgo["ipgo_date"].ToString();
                row.Cells["ipgo_cnt"].Value = ipgo_ipgo["ipgo_cnt"].ToString();
                row.Cells["ipgo_comp"].Value = ipgo_ipgo["ipgo_comp"].ToString();
                row.Cells["ipgo_amt"].Value = ipgo_ipgo["ipgo_amt"].ToString();

            }


            Culgo myculgo = new Culgo();


            List<Dictionary<String, String>> culgo_values = new List<Dictionary<string, string>>();

            // List 배열값
            culgo_values = myculgo.serch_stock(item_code, culgo_date_serch.Text, culgo_date_serch2.Text);

            

            culgoGridView.Rows.Clear();

            foreach (Dictionary<string, string> culgo_culgo in culgo_values)
            {

                rowIdw = culgoGridView.Rows.Add();
                row = culgoGridView.Rows[rowIdw];

                row.Cells["item_cnt2"].Value = culgo_culgo["item_samt"].ToString();
                row.Cells["culgo_date"].Value = culgo_culgo["culgo_date"].ToString();
                row.Cells["culgo_cnt"].Value = culgo_culgo["culgo_cnt"].ToString();
                row.Cells["culgo_amt"].Value = culgo_culgo["culgo_amt"].ToString();

            }




        }

        private void ItemGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            //입고든 출고든 item_code로 받기
            string item_code = ItemGridView.Rows[e.RowIndex].Cells["Column1"].Value.ToString();





            Ipgo myipgo = new Ipgo();


            List<Dictionary<String, String>> ipgo_values = new List<Dictionary<string, string>>();
            // List 배열값

            ipgo_values = myipgo.serch_stock(item_code, ipgo_date_serch.Text, ipgo_date_serch2.Text);


            ipgoGridView.Rows.Clear();

            foreach (Dictionary<string, string> ipgo_ipgo in ipgo_values)
            {



                rowIdw = ipgoGridView.Rows.Add();
                row = ipgoGridView.Rows[rowIdw];


                row.Cells["item_cnt"].Value = ipgo_ipgo["item_samt"].ToString();
                row.Cells["ipgo_date"].Value = ipgo_ipgo["ipgo_date"].ToString();
                row.Cells["ipgo_cnt"].Value = ipgo_ipgo["ipgo_cnt"].ToString();
                row.Cells["ipgo_comp"].Value = ipgo_ipgo["ipgo_comp"].ToString();
                row.Cells["ipgo_amt"].Value = ipgo_ipgo["ipgo_amt"].ToString();

            }







            Culgo myculgo = new Culgo();


            List<Dictionary<String, String>> culgo_values = new List<Dictionary<string, string>>();

            // List 배열값
            culgo_values = myculgo.serch_stock(item_code, culgo_date_serch.Text, culgo_date_serch2.Text);



            culgoGridView.Rows.Clear();

            foreach (Dictionary<string, string> culgo_culgo in culgo_values)
            {

                rowIdw = culgoGridView.Rows.Add();
                row = culgoGridView.Rows[rowIdw];

                row.Cells["item_cnt2"].Value = culgo_culgo["item_samt"].ToString();
                row.Cells["culgo_date"].Value = culgo_culgo["culgo_date"].ToString();
                row.Cells["culgo_cnt"].Value = culgo_culgo["culgo_cnt"].ToString();
                row.Cells["culgo_amt"].Value = culgo_culgo["culgo_amt"].ToString();

            }




        }

        private void Stock_Load(object sender, EventArgs e)
        {

            item_code_serch.Focus();
            
            item_date_serch.Value = item_date_serch2.Value.AddDays(-30);
            ipgo_date_serch.Value = item_date_serch2.Value.AddDays(-30);
            culgo_date_serch.Value = item_date_serch2.Value.AddDays(-30);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
