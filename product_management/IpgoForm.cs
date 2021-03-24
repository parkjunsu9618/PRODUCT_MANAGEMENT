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


    public partial class IpgoForm : Form
    {

        DataGridViewRow row;
        int rowIdw = 0;


        Image img;
        byte[] by;
        Bitmap bitmap;



        public IpgoForm()
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


            Ipgo myipgo = new Ipgo();


            List<Dictionary<String, String>> ipgo_values = new List<Dictionary<string, string>>();

            // List 배열값
            ipgo_values = myipgo.serch(item_name_serch.Text,ipgo_comp_serch.Text,ipgo_date_serch.Text,ipgo_date_serch2.Text);



            ipgoGridView.Rows.Clear();



            int index = 1;
            foreach (Dictionary<string, string> ipgo_ipgo in ipgo_values)
            {

                rowIdw = ipgoGridView.Rows.Add();
                row = ipgoGridView.Rows[rowIdw];


                Console.WriteLine(rowIdw);

                row.Cells["grid_ipgo_code"].Value = ipgo_ipgo["item_code"].ToString();
                row.Cells["grid_item_name"].Value = ipgo_ipgo["item_name"].ToString();
                row.Cells["grid_item_samt"].Value = ipgo_ipgo["item_samt"].ToString();
                row.Cells["grid_ipgo_date"].Value = ipgo_ipgo["ipgo_date"].ToString();
                row.Cells["grid_ipgo_cnt"].Value = ipgo_ipgo["ipgo_cnt"].ToString();
                row.Cells["grid_ipgo_comp"].Value = ipgo_ipgo["ipgo_comp"].ToString();
                row.Cells["grid_ipgo_amt"].Value = ipgo_ipgo["ipgo_amt"].ToString();
                row.Cells["grid_index"].Value = index;
                index++;
            }


        }



        public void renderImage(String ipgo_id)
        {

            Ipgo myipgo = new Ipgo();
            Dictionary<String, byte[]> img_value = new Dictionary<string, byte[]>();
            img_value = myipgo.checking_ipgo_img(ipgo_id);
            if (img_value == null)
            {
                pictureBox1.Image = null;
            }
            else
            {
                pictureBox1.Image = new Bitmap(new MemoryStream(img_value["img"]));
            }

        }




        public Dictionary<String, String> make_ipgo_values()
        {

            Dictionary<String, String> ipgo_value = new Dictionary<string, string>();
            ipgo_value.Add("ipgo_code", ipgo_code.Text);
            ipgo_value.Add("ipgo_date", ipgo_date.Text);
            ipgo_value.Add("ipgo_cnt", ipgo_cnt.Text);
            ipgo_value.Add("ipgo_comp", ipgo_comp.Text);
            ipgo_value.Add("ipgo_amt", ipgo_amt.Text);            
            ipgo_value.Add("user_sysid", user_sysid);
            return ipgo_value;
        }






        public void clear()
        {

            if (MessageBox.Show("입력하신 내용을 지우시겠습니까?", "YesOrNo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ipgo_code.Text = "";
                item_name.Text = "";
                item_samt.Text = "";
                ipgo_date.Text = "";
                ipgo_cnt.Text = "";
                ipgo_comp.Text = "";
                ipgo_amt.Text = "";

                pictureBox1.Image = null;
            }

            ipgo_code.Focus();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            ipgo_code.Focus();

            ipgo_date_serch.Value = ipgo_date_serch2.Value.AddDays(-30);

            ipgoGridView.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            ipgoGridView.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            ipgoGridView.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            ipgoGridView.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            ipgoGridView.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;


        }





        private void serchBtn_Click(object sender, EventArgs e)
        {

            serch_gridView();




        }


        string form_code_value = "";

        public void insertBtn_Click()
        {

            clear();



            int rowint = ipgoGridView.Rows.Add();


            ipgoGridView.CurrentCell = ipgoGridView.Rows[rowint].Cells[1];
            ipgoGridView.Rows[rowint].Cells["grid_index"].Value = rowint + 1;

            Console.WriteLine(rowIdw);

            //첫입력
            //if (ipgoGridView.RowCount == 0)
            //{
            //    if(rowIdw == 0)
            //    {

            //    }
            //    else
            //    {
            //        ipgoGridView.CurrentCell = ipgoGridView.Rows[rowIdw + 1].Cells[1];
            //        ipgoGridView.Rows[rowIdw + 1].Cells["grid_index"].Value = rowIdw + 2;
            //    }

            //}
            // 데이터 뿌리고 입력
            // 원래 칸보다 하나 더많게 만들기.











            ipgo_code.Enabled = true;
            ipgo_date.Enabled = true;

            form_code_value = "I";
        }







        //이벤트가 비슷하면 묶기
        
        public bool change_deleteBtn_Click()
        {

            // 아이디 체크후 값 뿌려주기.
            Ipgo myipgo = new Ipgo();
            Dictionary<String, String> ipgo_value = new Dictionary<string, string>();

            ipgo_value = myipgo.checking_ipgoID(ipgo_code.Text);
            if (ipgo_value == null)
            {
                MessageBox.Show("아이디가 존재 하지 않습니다.");
                return false;
            }
            else
            {



                //아이디 뿌리기                               
                ipgo_date.Text = ipgo_value["ipgo_date"].ToString();
                ipgo_cnt.Text = ipgo_value["ipgo_cnt"].ToString();
                ipgo_comp.Text = ipgo_value["ipgo_comp"].ToString();
                ipgo_amt.Text = ipgo_value["ipgo_amt"].ToString();
                
                
                
                //이미지 뿌리기      
                renderImage(ipgo_code.Text);

            }

            ipgo_code.Enabled = false;
            ipgo_date.Enabled = false;
            

            form_code_value = "C";

            return true;

        }
        





        public void confirmBtn_Click(string code_value)
        {

            //입력,수정,삭제시 값 물어보기.
            if (ipgo_code.Text == "")
            {
                MessageBox.Show("물품코드를 입력해주세요.");
                return;
            }
            else if (ipgo_date.Text == "")
            {
                MessageBox.Show("입고일자를 입력해주세요.");
                return;

            }
            else if (ipgo_cnt.Text == "")
            {
                MessageBox.Show("입고량을 입력해주세요.");
                return;
            }
            else if (ipgo_comp.Text == "")
            {
                MessageBox.Show("입고처를 입력해주세요.");
                return;
            }
            else if (ipgo_amt.Text == "")
            {
                MessageBox.Show("입고가를 입력해주세요.");
                return;
            }




            Ipgo myipgo = new Ipgo();
            Dictionary<String, String> ipgo_value = make_ipgo_values();


            Console.WriteLine(ipgo_value);

            if (code_value == "I")
            {

                myipgo.insert(ipgo_value,item_samt.Text);



            }
            else if (code_value == "C")
            {
                //현재 재고량 넘겨주기
                

                myipgo.update(ipgo_value,item_samt.Text);



            }
            else if (code_value == "D")
            {


                myipgo.delete(ipgo_code.Text, ipgo_date.Text, item_samt.Text);


            }

            ipgo_code.Enabled = true;
            ipgo_date.Enabled = true;

            clear();
            serch_gridView();
            form_code_value = "";
        }

        public void canselBtn_Click()
        {
            clear();
            serch_gridView();
            form_code_value = "";
            ipgo_code.Enabled = true;
            ipgo_date.Enabled = true;

        }




        private void ipgoGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ipgo_code.Text = ipgoGridView.Rows[e.RowIndex].Cells["grid_ipgo_code"].Value.ToString();
            item_name.Text = ipgoGridView.Rows[e.RowIndex].Cells["grid_item_name"].Value.ToString();
            item_samt.Text = ipgoGridView.Rows[e.RowIndex].Cells["grid_item_samt"].Value.ToString();
            ipgo_date.Text = ipgoGridView.Rows[e.RowIndex].Cells["grid_ipgo_date"].Value.ToString();
            ipgo_cnt.Text = ipgoGridView.Rows[e.RowIndex].Cells["grid_ipgo_cnt"].Value.ToString();
            ipgo_comp.Text = ipgoGridView.Rows[e.RowIndex].Cells["grid_ipgo_comp"].Value.ToString();
            ipgo_amt.Text = ipgoGridView.Rows[e.RowIndex].Cells["grid_ipgo_amt"].Value.ToString();


            String ipgoCode = ipgoGridView.Rows[e.RowIndex].Cells["grid_ipgo_code"].Value.ToString();

            Ipgo myipgo = new Ipgo();
            renderImage(ipgoCode);

        }




        /*
         * 입고검색창
         */
        private void ipgo_code_serchBtn_Click(object sender, EventArgs e)
        {
            ItemCodeForm itemCodeForm = new ItemCodeForm("ipgo");
            itemCodeForm.ipgoForm = this;
            itemCodeForm.ShowDialog();





        }
        
        private void ipgo_code_TextChanged(object sender, EventArgs e)
        {

            renderImage(ipgo_code.Text);


            if (form_code_value == "I" || form_code_value == "C")
            {

                TextBox targeted_textbox = (TextBox)sender;
                string target_txt = targeted_textbox.Text;

                string target_name = targeted_textbox.Tag.ToString();

                ipgoGridView.CurrentRow.Cells["grid_" + target_name].Value = target_txt;


            }





        }

        
        private void item_date_serch_ValueChanged(object sender, EventArgs e)
        {
            ipgo_date_serch2.MinDate = ipgo_date_serch.Value.AddDays(0);
        }


        //event를 입력,수정시 이벤트걸기
        private void TextChanged(object sender, EventArgs e)
        {


            if (form_code_value == "I" || form_code_value == "C")
            {
                
                TextBox targeted_textbox = (TextBox)sender;
                string target_txt = targeted_textbox.Text;

                string target_name = targeted_textbox.Tag.ToString();

                ipgoGridView.CurrentRow.Cells["grid_" + target_name].Value = target_txt;


            }

        }

        private void item_samt_ValueChanged(object sender, EventArgs e)
        {

            if (form_code_value == "I" || form_code_value == "C")
            {


                NumericUpDown targeted_textbox = (NumericUpDown)sender;
                string target_txt = targeted_textbox.Text;
                string target_name = targeted_textbox.Tag.ToString();


                ipgoGridView.CurrentRow.Cells["grid_" + target_name].Value = target_txt;

            }
        }

        private void item_date_ValueChanged(object sender, EventArgs e)
        {
            if (form_code_value == "I" || form_code_value == "C")
            {


                DateTimePicker targeted_textbox = (DateTimePicker)sender;
                string target_txt = targeted_textbox.Text;
                string target_name = targeted_textbox.Tag.ToString();


                ipgoGridView.CurrentRow.Cells["grid_" + target_name].Value = target_txt;

            }
        }




    }
}


