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
using System.Threading;

namespace product_management
{


    public partial class AdminForm : Form
    {

        DataGridViewRow row;
        int rowIdw = 0;
        //String code_value = "";

        Image img;
        byte[] by;
        Bitmap bitmap;



        public AdminForm()
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
            Admin myAdmin = new Admin();


            List<Dictionary<String, String>> admin_values = new List<Dictionary<string, string>>();

            // List 배열값
            admin_values = myAdmin.serch(admin_name_serch.Text);



            adminGridView.Rows.Clear();

            int index = 1;
            foreach (Dictionary<string, string> admin_item in admin_values)
            {

                rowIdw = adminGridView.Rows.Add();
                row = adminGridView.Rows[rowIdw];

                row.Cells["grid_admin_id"].Value = admin_item["admin_id"].ToString();
                row.Cells["grid_admin_pass"].Value = admin_item["admin_pass"].ToString();
                row.Cells["grid_admin_name"].Value = admin_item["admin_name"].ToString();
                row.Cells["grid_index"].Value = index;
                index++;

                //Console.WriteLine(admin_item["admin_id"]);
            }


        }



        public void renderImage(String admin_id)
        {

            Admin myAdmin = new Admin();
            Dictionary<String, byte[]> img_value = new Dictionary<string, byte[]>();
            img_value = myAdmin.checking_admin_img(admin_id);
            if (img_value == null)
            {
                pictureBox1.Image = null;
            }
            else
            {
                pictureBox1.Image = new Bitmap(new MemoryStream(img_value["img"]));
            }

        }




        public Dictionary<String, String> make_admin_values()
        {
           
            Dictionary<String, String> admin_value = new Dictionary<string, string>();
            admin_value.Add("아이디", admin_id.Text);
            admin_value.Add("비번", admin_pass.Text);
            admin_value.Add("이름", admin_name.Text);
            return admin_value;
        }




        public void clear()
        {

            if (MessageBox.Show("입력하신 내용을 지우시겠습니까?", "YesOrNo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                admin_id.Text = "";
                admin_pass.Text = "";
                admin_name.Text = "";
                pictureBox1.Image = null;

            }



        }





        public void serchBtn_Click(object sender, EventArgs e)
        {            

            serch_gridView();




        }




        string form_code_value = "";

        
        public void insertBtn_Click()
        {

            clear();
            

            adminGridView.Rows.Add();
            
             //첫입력
            if(rowIdw == 0)
            {
                adminGridView.CurrentCell = adminGridView.Rows[rowIdw].Cells[1];
                adminGridView.Rows[rowIdw].Cells["grid_index"].Value = rowIdw + 2;
            }
            // 데이터 뿌리고 입력
            // 원래 칸보다 하나 더많게 만들기.
            else
            {
                adminGridView.CurrentCell = adminGridView.Rows[rowIdw + 1].Cells[1];
                adminGridView.Rows[rowIdw + 1].Cells["grid_index"].Value = rowIdw + 2;
            }
            

            admin_id.Enabled = true;
            form_code_value = "I";
            
        }


        //이벤트가 비슷하면 묶기
        
        public bool change_deleteBtn_Click()
        {

            


            // 아이디 체크후 값 뿌려주기.
            Admin myAdmin = new Admin();
            Dictionary<String, String> admin_value = new Dictionary<string, string>();
            
            admin_value = myAdmin.checking_adminID(admin_id.Text);
            if(admin_value == null)
            {
                MessageBox.Show("아이디가 존재 하지 않습니다.");
                return false;
            }
            else
            {
                //아이디 뿌리기
                admin_id.Text = admin_value["admin_id"].ToString();
                admin_pass.Text = admin_value["admin_pass"].ToString();
                admin_name.Text = admin_value["admin_name"].ToString();

                //이미지 뿌리기      
                renderImage(admin_id.Text);

            }



            admin_id.Enabled = false;

            form_code_value = "C";



            return true;


        }










        public void confirmBtn_Click(String code_value)
        {
            //입력,수정,삭제시 값 물어보기.

            if(admin_id.Text == "")
            {
                MessageBox.Show("아이디를 입력해주세요.");
                return;
            }
            else if(admin_pass.Text == "")
            {
                MessageBox.Show("비밀번호를 입력해주세요.");
                return;

            }
            else if (admin_name.Text == "")
            {
                MessageBox.Show("이름을 입력해주세요.");
                return;
            }



            Admin myadmin = new Admin();
            Dictionary<String, String> admin_value = make_admin_values();


            if (code_value == "I")
            {
               
                myadmin.insert(admin_value, by);                


            }
            else if(code_value == "C")
            {


                myadmin.update(admin_value, by);
                


            }
            else if (code_value == "D")
            {

                
                myadmin.delete(admin_id.Text);
                

            }



            admin_id.Enabled = true;
            admin_name.Enabled = true;
            admin_pass.Enabled = true;
            clear();
            serch_gridView();

            form_code_value = "";
        }

        public void canselBtn_Click()
        {
            clear();
            serch_gridView();
            form_code_value = "";

            admin_id.Enabled = true;
            admin_name.Enabled = true;
            admin_pass.Enabled = true;
        }




        private void adminGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            admin_id.Text = adminGridView.Rows[e.RowIndex].Cells["grid_admin_id"].Value.ToString();
            admin_pass.Text = adminGridView.Rows[e.RowIndex].Cells["grid_admin_pass"].Value.ToString();
            admin_name.Text = adminGridView.Rows[e.RowIndex].Cells["grid_admin_name"].Value.ToString();

            String adminId = adminGridView.Rows[e.RowIndex].Cells["grid_admin_id"].Value.ToString();

            Admin myAdmin = new Admin();
            renderImage(adminId);

        }




        private void pictureBtn_Click(object sender, EventArgs e)
        {



            string image_file = "";

            OpenFileDialog dialog = new OpenFileDialog();


            //c드라이브 디렉토리
            //dialog.InitialDirectory = @"C:\";

            if(dialog.ShowDialog() == DialogResult.OK)
            {               
                image_file = dialog.FileName;

                //선택파일을 image로 변환
                img = Bitmap.FromFile(image_file);

                ImageConverter converter = new ImageConverter();
                by = (byte[])converter.ConvertTo(img, typeof(byte[]));

                if (by.Length >= Math.Pow(2, 10) * 30)
                {
                    MessageBox.Show("30kb 이하의 사진을 등록해주세요.");
                    return;
                }
                pictureBox1.Image = Bitmap.FromFile(image_file);

            }
            else
            {
                MessageBox.Show("취소하였습니다.");
            }


        }

        //현재 폼객체 생성
        public AdminForm admin;

        Colors colors = new Colors();

        Color_scheme myColor = new Color_scheme();


        private void button1_Click(object sender, EventArgs e)
        {
            // color label, background color 바꾸기. -- (CLASS 로 관리)

            // 폼값 넘기기, 데이터그리드뷰 넘기기.

            admin = this;

            List<DataGridView> datagridviews = new List<DataGridView>();
            datagridviews.Add(this.adminGridView);



            colors.ChangeTheme(myColor, this.Controls,admin,datagridviews);
            


        }





        //event를 입력,수정시 이벤트걸기
        private void admin_id_TextChanged(object sender, EventArgs e)
        {

            if(form_code_value == "I" || form_code_value == "C")
            {

                TextBox targeted_textbox = (TextBox)sender;

                string target_txt = targeted_textbox.Text;

                string target_name = targeted_textbox.Tag.ToString();
                row = adminGridView.CurrentRow;

                row.Cells["grid_" + target_name].Value = target_txt;

            }

        }











        //이벤트바꾸기
        private void adminGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {


            //현재 선택된 rowindex 를 가져오기.
            //MessageBox.Show(e.RowIndex.ToString());


            //if(e.RowIndex != 0)
            //{

            //    foreach (Control myControl in groupBox1.Controls)
            //    {


            //        //typeof로 컨트롤들 비교할것.
            //        if(typeof(TextBox) == myControl.GetType())
            //        {

            //            foreach (TextBox target_textbox in myControl.Controls)
            //            {                            
            //                //선택되었을때 text박스들 값들을 읽은거
            //                //=> 선택되고나서 값들을 읽어야해.
            //                //조건
            //                if (target_textbox.Name == "admin_id")
            //                {
            //                    adminGridView.Rows[e.RowIndex].Cells["grid_admin_id"].Value = target_textbox.Text;
            //                }
            //                else if (target_textbox.Name == "admin_pass")
            //                {
            //                    adminGridView.Rows[e.RowIndex].Cells["grid_admin_pass"].Value = target_textbox.Text;
            //                }
            //                else if (target_textbox.Name == "admin_name")
            //                {
            //                    adminGridView.Rows[e.RowIndex].Cells["grid_admin_name"].Value = target_textbox.Text;
            //                }

                             
                            


            //            }

            //        }
                    

            //    }



            //}




        }
    }

}

