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


    public partial class _PegiForm : Form
    {

        DataGridViewRow row;
        int rowIdw = 0;
        String code_value = "";

        Image img;
        byte[] by;
        Bitmap bitmap;



        public _PegiForm()
        {
            InitializeComponent();
        }


        public void serch_gridView()
        {
            Pegi mypegi = new Pegi();


            List<Dictionary<String, String>> pegi_values = new List<Dictionary<string, string>>();

            // List 배열값
            pegi_values = mypegi.serch(item_name_serch.Text, pegi_date_serch.Text, pegi_date_serch2.Text);



            pegiGridView.Rows.Clear();

            foreach (Dictionary<string, string> pegi_pegi in pegi_values)
            {

                rowIdw = pegiGridView.Rows.Add();
                row = pegiGridView.Rows[rowIdw];

                row.Cells["column1"].Value = pegi_pegi["item_code"].ToString();
                row.Cells["column2"].Value = pegi_pegi["item_name"].ToString();
                row.Cells["column3"].Value = pegi_pegi["item_samt"].ToString();
                row.Cells["column4"].Value = pegi_pegi["pegi_date"].ToString();
                row.Cells["column5"].Value = pegi_pegi["pegi_cnt"].ToString();
                

            }


        }



        public void renderImage(String pegi_id)
        {

            Pegi mypegi = new Pegi();
            Dictionary<String, byte[]> img_value = new Dictionary<string, byte[]>();
            img_value = mypegi.checking_pegi_img(pegi_id);
            if (img_value == null)
            {
                pictureBox1.Image = null;
            }
            else
            {
                pictureBox1.Image = new Bitmap(new MemoryStream(img_value["img"]));
            }

        }




        public Dictionary<String, String> make_pegi_values()
        {

            Dictionary<String, String> pegi_value = new Dictionary<string, string>();
            pegi_value.Add("pegi_code", pegi_code.Text);
            pegi_value.Add("pegi_date", pegi_date.Text);
            pegi_value.Add("pegi_cnt", pegi_cnt.Text);
            pegi_value.Add("pegi_sau", pegi_sau.Text);            
            pegi_value.Add("user_sysid", user_sysid.Text);
            return pegi_value;
        }






        public void btnValue()
        {
            insertBtn.Enabled = false;
            changeBtn.Enabled = false;
            deleteBtn.Enabled = false;
            confirmBtn.Enabled = true;
            canselBtn.Enabled = true;

        }

        public void btnValue2()
        {
            insertBtn.Enabled = true;
            changeBtn.Enabled = true;
            deleteBtn.Enabled = true;
            confirmBtn.Enabled = false;
            canselBtn.Enabled = false;

        }




        public void clear()
        {
            pegi_code.Text = "";
            item_name.Text = "";
            item_samt.Text = "";
            pegi_date.Text = "";
            pegi_cnt.Text = "";
            pegi_sau.Text = "";


            pictureBox1.Image = null;

        }





        private void Form4_Load(object sender, EventArgs e)
        {


            btnValue2();
        }



        private void serchBtn_Click(object sender, EventArgs e)
        {

            serch_gridView();




        }



        private void insertBtn_Click(object sender, EventArgs e)
        {

            clear();


            code_value = "I";
            btnValue();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }





        //이벤트가 비슷하면 묶기

        private void change_deleteBtn_Click(object sender, EventArgs e)
        {

            // 아이디 체크후 값 뿌려주기.
            Pegi mypegi = new Pegi();
            Dictionary<String, String> pegi_value = new Dictionary<string, string>();

            pegi_value = mypegi.checking_pegiID(pegi_code.Text);
            if (pegi_value == null)
            {
                MessageBox.Show("아이디가 존재 하지 않습니다.");
                return;
            }
            else
            {



                //아이디 뿌리기                               
                pegi_date.Text = pegi_value["pegi_date"].ToString();
                pegi_cnt.Text = pegi_value["pegi_cnt"].ToString();
                pegi_sau.Text = pegi_value["pegi_sau"].ToString();




                //이미지 뿌리기      
                renderImage(pegi_code.Text);

            }




            Button check_type = (Button)sender;
            if (check_type.Text == "수정")
            {
                code_value = "C";
            }
            else
            {
                code_value = "D";
            }


            btnValue();


        }






        private void confirmBtn_Click(object sender, EventArgs e)
        {
            //입력,수정,삭제시 값 물어보기.

            if (pegi_code.Text == "")
            {
                MessageBox.Show("물품코드를 입력해주세요.");
                return;
            }
            else if (pegi_date.Text == "")
            {
                MessageBox.Show("출고일자를 입력해주세요.");
                return;

            }
            else if (pegi_cnt.Text == "")
            {
                MessageBox.Show("출고량을 입력해주세요.");
                return;
            }
            else if (pegi_sau.Text == "")
            {
                MessageBox.Show("사유를 입력해주세요.");
                return;
            }




            Pegi mypegi = new Pegi();
            Dictionary<String, String> pegi_value = make_pegi_values();




            if (code_value == "I")
            {

                mypegi.insert(pegi_value, item_samt.Text);



            }
            else if (code_value == "C")
            {
                //현재 재고량 넘겨주기


                mypegi.update(pegi_value, item_samt.Text);



            }
            else if (code_value == "D")
            {


                mypegi.delete(pegi_code.Text, pegi_date.Text, item_samt.Text);


            }

            clear();
            serch_gridView();
            btnValue2();
        }

        private void canselBtn_Click(object sender, EventArgs e)
        {
            clear();
            btnValue2();

        }




        private void pegiGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            pegi_code.Text = pegiGridView.Rows[e.RowIndex].Cells["Column1"].Value.ToString();
            item_name.Text = pegiGridView.Rows[e.RowIndex].Cells["Column2"].Value.ToString();
            item_samt.Text = pegiGridView.Rows[e.RowIndex].Cells["Column3"].Value.ToString();
            pegi_date.Text = pegiGridView.Rows[e.RowIndex].Cells["Column4"].Value.ToString();
            pegi_cnt.Text = pegiGridView.Rows[e.RowIndex].Cells["Column5"].Value.ToString();



            String pegiCode = pegiGridView.Rows[e.RowIndex].Cells["Column1"].Value.ToString();

            Pegi mypegi = new Pegi();
            renderImage(pegiCode);

        }




        /*
         * 입고검색창
         */
        private void pegi_code_serchBtn_Click(object sender, EventArgs e)
        {
            ItemCodeForm itemCodeForm = new ItemCodeForm("pegi");
            itemCodeForm.pegiForm = this;
            itemCodeForm.ShowDialog();


        }




        private void pegi_cnt_Leave(object sender, EventArgs e)
        {


            NumericUpDown number_box = (NumericUpDown)sender;

            int pegi_cnt = 0;
            if (number_box.Text != "")
            {
                pegi_cnt = Convert.ToInt32(number_box.Text);
            }

            int item_samtt = Convert.ToInt32(item_samt.Text);


            if (pegi_cnt >= item_samtt)
            {
                MessageBox.Show("폐기량이 재고량보다 큽니다.");
            }



        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {





        }
    }
}


