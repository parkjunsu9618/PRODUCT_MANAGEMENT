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
    
    public partial class CulgoForm : Form
    {

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

        public CulgoForm()
        {
            InitializeComponent();
        }


        public void serch_gridView()
        {

            Culgo myculgo = new Culgo();


            List<Dictionary<String, String>> culgo_values = new List<Dictionary<string, string>>();

            // List 배열값
            culgo_values = myculgo.serch(item_name_serch.Text, culgo_date_serch.Text, culgo_date_serch2.Text);



            culgoGridView.Rows.Clear();


            int index = 1;

            foreach (Dictionary<string, string> culgo_culgo in culgo_values)
            {

                rowIdw = culgoGridView.Rows.Add();
                row = culgoGridView.Rows[rowIdw];

                Console.WriteLine(rowIdw);

                row.Cells["grid_culgo_code"].Value = culgo_culgo["item_code"].ToString();
                row.Cells["grid_item_name"].Value = culgo_culgo["item_name"].ToString();
                row.Cells["grid_item_samt"].Value = culgo_culgo["item_samt"].ToString();
                row.Cells["grid_culgo_date"].Value = culgo_culgo["culgo_date"].ToString();
                row.Cells["grid_culgo_cnt"].Value = culgo_culgo["culgo_cnt"].ToString();
                row.Cells["grid_culgo_amt"].Value = culgo_culgo["culgo_amt"].ToString();
                row.Cells["grid_index"].Value = index;
                index++;

            }


        }



        public void renderImage(String culgo_id)
        {

            Culgo myculgo = new Culgo();
            Dictionary<String, byte[]> img_value = new Dictionary<string, byte[]>();
            img_value = myculgo.checking_culgo_img(culgo_id);
            if (img_value == null)
            {
                pictureBox1.Image = null;
            }
            else
            {
                pictureBox1.Image = new Bitmap(new MemoryStream(img_value["img"]));
            }

        }




        public Dictionary<String, String> make_culgo_values()
        {

            Dictionary<String, String> culgo_value = new Dictionary<string, string>();
            culgo_value.Add("culgo_code", culgo_code.Text);
            culgo_value.Add("culgo_date", culgo_date.Text);
            culgo_value.Add("culgo_cnt", culgo_cnt.Text);
            culgo_value.Add("culgo_sau", culgo_sau.Text);
            culgo_value.Add("culgo_amt", culgo_amt.Text);
            culgo_value.Add("user_sysid", user_sysid);
            return culgo_value;
        }








        public void clear()
        {

            if (MessageBox.Show("입력하신 내용을 지우시겠습니까?", "YesOrNo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                culgo_code.Text = "";
                item_name.Text = "";
                item_samt.Text = "";
                culgo_date.Text = "";
                culgo_cnt.Text = "";
                culgo_sau.Text = "";
                culgo_amt.Text = "";

                pictureBox1.Image = null;
            }

            culgo_code.Focus();

        }





        public void serchBtn_Click(object sender, EventArgs e)
        {

            serch_gridView();




        }



        string form_code_value = "";
        public void insertBtn_Click()
        {

            clear();



            culgoGridView.Rows.Add();



            //첫입력
            if (rowIdw == 0)
            {
                culgoGridView.CurrentCell = culgoGridView.Rows[rowIdw].Cells[1];
                culgoGridView.Rows[rowIdw].Cells["grid_index"].Value = rowIdw + 2;
            }
            // 데이터 뿌리고 입력
            // 원래 칸보다 하나 더많게 만들기.
            else
            {
                culgoGridView.CurrentCell = culgoGridView.Rows[rowIdw + 1].Cells[1];
                culgoGridView.Rows[rowIdw + 1].Cells["grid_index"].Value = rowIdw + 2;
            }



            culgo_code.Enabled = true;
            culgo_date.Enabled = true;

            form_code_value = "I";

        }


        //이벤트가 비슷하면 묶기

        public bool change_deleteBtn_Click()
        {

            // 아이디 체크후 값 뿌려주기.
            Culgo myculgo = new Culgo();
            Dictionary<String, String> culgo_value = new Dictionary<string, string>();

            culgo_value = myculgo.checking_culgoID(culgo_code.Text);
            if (culgo_value == null)
            {
                MessageBox.Show("아이디가 존재 하지 않습니다.");
                return false;
            }
            else
            {



                //아이디 뿌리기                               
                culgo_date.Text = culgo_value["culgo_date"].ToString();
                culgo_cnt.Text = culgo_value["culgo_cnt"].ToString();
                culgo_sau.Text = culgo_value["culgo_sau"].ToString();
                culgo_amt.Text = culgo_value["culgo_amt"].ToString();



                //이미지 뿌리기      
                renderImage(culgo_code.Text);

            }
            culgo_code.Enabled = false;
            culgo_date.Enabled = false;


            form_code_value = "C";

            return true;
        }






        public void confirmBtn_Click(string code_value)
        {
            //입력,수정,삭제시 값 물어보기.

            if (culgo_code.Text == "")
            {
                MessageBox.Show("물품코드를 입력해주세요.");
                return;
            }
            else if (culgo_date.Text == "")
            {
                MessageBox.Show("출고일자를 입력해주세요.");
                return;

            }
            else if (culgo_cnt.Text == "")
            {
                MessageBox.Show("출고량을 입력해주세요.");
                return;
            }
            else if (culgo_sau.Text == "")
            {
                MessageBox.Show("사유를 입력해주세요.");
                return;
            }
            else if (culgo_amt.Text == "")
            {
                MessageBox.Show("입고가를 입력해주세요.");
                return;
            }




            Culgo myculgo = new Culgo();
            Dictionary<String, String> culgo_value = make_culgo_values();




            if (code_value == "I")
            {

                myculgo.insert(culgo_value, item_samt.Text);



            }
            else if (code_value == "C")
            {
                //현재 재고량 넘겨주기


                myculgo.update(culgo_value, item_samt.Text);



            }
            else if (code_value == "D")
            {


                myculgo.delete(culgo_code.Text, culgo_date.Text, item_samt.Text);


            }

            clear();
            serch_gridView();


            culgo_code.Enabled = true;
            culgo_date.Enabled = true;

            form_code_value = "";



        }

        public void canselBtn_Click()
        {
            clear();
            serch_gridView();

            culgo_code.Enabled = true;
            culgo_date.Enabled = true;

            form_code_value = "";

        }




        private void culgoGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            culgo_code.Text = culgoGridView.Rows[e.RowIndex].Cells["grid_culgo_code"].Value.ToString();
            item_name.Text = culgoGridView.Rows[e.RowIndex].Cells["grid_item_name"].Value.ToString();
            item_samt.Text = culgoGridView.Rows[e.RowIndex].Cells["grid_item_samt"].Value.ToString();
            culgo_date.Text = culgoGridView.Rows[e.RowIndex].Cells["grid_culgo_date"].Value.ToString();
            culgo_cnt.Text = culgoGridView.Rows[e.RowIndex].Cells["grid_culgo_cnt"].Value.ToString();
            culgo_amt.Text = culgoGridView.Rows[e.RowIndex].Cells["grid_culgo_amt"].Value.ToString();



            String culgoCode = culgoGridView.Rows[e.RowIndex].Cells["grid_culgo_code"].Value.ToString();

            Culgo myculgo = new Culgo();
            renderImage(culgoCode);

        }




        /*
         * 입고검색창
         */
        private void culgo_code_serchBtn_Click(object sender, EventArgs e)
        {
            ItemCodeForm itemCodeForm = new ItemCodeForm("culgo");
            itemCodeForm.culgoForm = this;
            itemCodeForm.ShowDialog();

     
        }
        

        private void culgo_cnt_Leave(object sender, EventArgs e)
        {


            TextBox number_box = (TextBox)sender;

            int culgo_cnt = 0;
            if (number_box.Text != "") 
            {
                culgo_cnt = Convert.ToInt32(number_box.Text);
            }

            int item_samtt = Convert.ToInt32(item_samt.Text);


            if (culgo_cnt >= item_samtt)
            {
                MessageBox.Show("출고량이 재고량보다 큽니다.");
            }



        }

        private void CulgoForm_Load(object sender, EventArgs e)
        {

            culgo_code.Focus();


            culgo_date_serch.Value = culgo_date_serch2.Value.AddDays(-30);

            culgoGridView.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            culgoGridView.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            culgoGridView.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            culgoGridView.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            culgoGridView.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;


        }

        private void culgo_code_TextChanged(object sender, EventArgs e)
        {
            renderImage(culgo_code.Text);

            if (form_code_value == "I" || form_code_value == "C")
            {

                TextBox targeted_textbox = (TextBox)sender;
                string target_txt = targeted_textbox.Text;

                string target_name = targeted_textbox.Tag.ToString();

                culgoGridView.CurrentRow.Cells["grid_" + target_name].Value = target_txt;


            }
        }


        private void item_date_serch_ValueChanged(object sender, EventArgs e)
        {
            culgo_date_serch2.MinDate = culgo_date_serch.Value.AddDays(0);
        }





        //event를 입력,수정시 이벤트걸기
        private void TextChanged(object sender, EventArgs e)
        {


            if (form_code_value == "I" || form_code_value == "C")
            {

                TextBox targeted_textbox = (TextBox)sender;
                string target_txt = targeted_textbox.Text;

                string target_name = targeted_textbox.Tag.ToString();

                culgoGridView.CurrentRow.Cells["grid_" + target_name].Value = target_txt;


            }

        }

        private void item_samt_ValueChanged(object sender, EventArgs e)
        {

            if (form_code_value == "I" || form_code_value == "C")
            {


                NumericUpDown targeted_textbox = (NumericUpDown)sender;
                string target_txt = targeted_textbox.Text;
                string target_name = targeted_textbox.Tag.ToString();


                culgoGridView.CurrentRow.Cells["grid_" + target_name].Value = target_txt;

            }
        }

        private void item_date_ValueChanged(object sender, EventArgs e)
        {
            if (form_code_value == "I" || form_code_value == "C")
            {


                DateTimePicker targeted_textbox = (DateTimePicker)sender;
                string target_txt = targeted_textbox.Text;
                string target_name = targeted_textbox.Tag.ToString();


                culgoGridView.CurrentRow.Cells["grid_" + target_name].Value = target_txt;

            }
        }









    }
}



