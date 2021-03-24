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


    public partial class ItemForm : Form
    {

        DataGridViewRow row;
        int rowIdw = 0;
        //String code_value = "";

        Image img;
        byte[] by;
        Bitmap bitmap;


        public string user_sysid;


        public void set_user_sysid(string user_id)
        {
            this.user_sysid = user_id;           
        }



        public ItemForm()
        {
            InitializeComponent();
            AutoSize = true;

            //var flp = tableLayoutPanel1();
            //Controls.Add(flp);
        }


        public void serch_gridView()
        {
            Item myItem = new Item();


            List<Dictionary<String, String>> item_values = new List<Dictionary<string, string>>();

            // List 배열값
            item_values = myItem.serch(item_code_serch.Text,item_name_serch.Text,item_date_serch.Text,item_date_serch2.Text);


            ItemGridView.Rows.Clear();


            int index = 1;
            foreach (Dictionary<string, string> Item_item in item_values)
            {

                rowIdw = ItemGridView.Rows.Add();
                row = ItemGridView.Rows[rowIdw];

                row.Cells["grid_item_code"].Value = Item_item["item_code"].ToString();
                row.Cells["grid_item_name"].Value = Item_item["item_name"].ToString();
                row.Cells["grid_item_stand"].Value = Item_item["item_stand"].ToString();
                row.Cells["grid_item_date"].Value = Item_item["item_date"].ToString();

                row.Cells["grid_item_amt"].Value = Item_item["item_amt"].ToString();
                row.Cells["grid_item_comp"].Value = Item_item["item_comp"].ToString();
                row.Cells["grid_item_samt"].Value = Item_item["item_samt"].ToString();                
                row.Cells["grid_item_posi"].Value = Item_item["item_posi"].ToString();
                row.Cells["grid_item_etc"].Value = Item_item["item_etc"].ToString();
                row.Cells["grid_index"].Value = index;
                index++;

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
                pictureBox1.Image = null;
            }
            else
            {
                pictureBox1.Image = new Bitmap(new MemoryStream(img_value["img"]));
            }

        }




        public Dictionary<String, String> make_item_values()
        {

            Dictionary<String, String> Item_value = new Dictionary<string, string>();
            Item_value.Add("item_code", item_code.Text);
            Item_value.Add("item_name", item_name.Text);
            Item_value.Add("item_stand", item_stand.Text);
            Item_value.Add("item_date", item_date.Text);
            Item_value.Add("item_amt", item_amt.Text);
            Item_value.Add("item_comp", item_comp.Text);
            Item_value.Add("item_samt", item_samt.Text);
            Item_value.Add("item_posi", item_posi.Text);
            Item_value.Add("item_etc", item_etc.Text);
            Item_value.Add("user_sysid", user_sysid);

          
            return Item_value;
        }








        public void clear()
        {

            if(MessageBox.Show("입력하신 내용을 지우시겠습니까?", "YesOrNo", MessageBoxButtons.YesNo) == DialogResult.Yes)
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
            item_code.Focus();


        }





        private void Form4_Load(object sender, EventArgs e)
        {


            item_code.Focus();
            

            item_date_serch.Value = item_date_serch2.Value.AddDays(-30);

            ItemGridView.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            ItemGridView.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            ItemGridView.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            ItemGridView.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            

        }



        private void serchBtn_Click(object sender, EventArgs e)
        {

            serch_gridView();




        }


        string form_code_value = "";



        public void insertBtn_Click()
        {

            clear();


            ItemGridView.Rows.Add();



            //첫입력
            if (rowIdw == 0)
            {
                ItemGridView.CurrentCell = ItemGridView.Rows[rowIdw].Cells[1];
                ItemGridView.Rows[rowIdw].Cells["grid_index"].Value = rowIdw + 1;
            }
            // 데이터 뿌리고 입력
            // 원래 칸보다 하나 더많게 만들기.
            else
            {
                ItemGridView.CurrentCell = ItemGridView.Rows[rowIdw + 1].Cells[1];
                ItemGridView.Rows[rowIdw + 1].Cells["grid_index"].Value = rowIdw + 2;
            }



            item_code.Enabled = true;

            form_code_value = "I";

        }


        //이벤트가 비슷하면 묶기

        public bool change_deleteBtn_Click()
        {

            // 아이디 체크후 값 뿌려주기.
            Item myItem = new Item();
            Dictionary<String, String> Item_value = new Dictionary<string, string>();

            Item_value = myItem.checking_ItemID(item_code.Text);
            if (Item_value == null)
            {
                MessageBox.Show("아이디가 존재 하지 않습니다.");
                return false;
            }
            else
            {
                //아이디 뿌리기
                item_code.Text = Item_value["item_code"].ToString();
                item_name.Text = Item_value["item_name"].ToString();
                item_stand.Text = Item_value["item_stand"].ToString();
                item_date.Text = Item_value["item_date"].ToString();
                item_amt.Text = Item_value["item_amt"].ToString();
                item_comp.Text = Item_value["item_comp"].ToString();
                item_samt.Text = Item_value["item_samt"].ToString();
                item_posi.Text = Item_value["item_posi"].ToString();
                item_etc.Text = Item_value["item_etc"].ToString();

                //이미지 뿌리기      
                renderImage(item_code.Text);

            }


            item_code.Enabled = false;
            form_code_value = "C";
            return true;



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


            Item myItem = new Item();
            Dictionary<String, String> Item_value = make_item_values();


            if (code_value == "I")
            {

                myItem.insert(Item_value, by);


            }
            else if (code_value == "C")
            {

                myItem.update(Item_value, by);

            }
            else if (code_value == "D")
            {

                if (MessageBox.Show("물품정보를 지우면 입고,출고 정보도 삭제됩니다. 삭제하시겠습니까?", "YesOrNo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {                    
                    myItem.delete(item_code.Text);
                }

            }


            item_code.Enabled = true;
            clear();
            serch_gridView();
            form_code_value = "";

        }

        private void canselBtn_Click(object sender, EventArgs e)
        {
            clear();
            serch_gridView();
            form_code_value = "";
            item_code.Enabled = true;

        }




        private void ItemGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            item_code.Text = ItemGridView.Rows[e.RowIndex].Cells["grid_item_code"].Value.ToString();
            item_name.Text = ItemGridView.Rows[e.RowIndex].Cells["grid_item_name"].Value.ToString();
            item_stand.Text = ItemGridView.Rows[e.RowIndex].Cells["grid_item_stand"].Value.ToString();
            item_date.Text = ItemGridView.Rows[e.RowIndex].Cells["grid_item_date"].Value.ToString();
            item_amt.Text = ItemGridView.Rows[e.RowIndex].Cells["grid_item_amt"].Value.ToString();
            item_comp.Text = ItemGridView.Rows[e.RowIndex].Cells["grid_item_comp"].Value.ToString();
            item_samt.Text = ItemGridView.Rows[e.RowIndex].Cells["grid_item_samt"].Value.ToString();
            item_posi.Text = ItemGridView.Rows[e.RowIndex].Cells["grid_item_posi"].Value.ToString();
            item_etc.Text = ItemGridView.Rows[e.RowIndex].Cells["grid_item_etc"].Value.ToString();


            //비고값을 받기.




            String ItemCode = ItemGridView.Rows[e.RowIndex].Cells["grid_item_code"].Value.ToString();

            Item myItem = new Item();
            renderImage(ItemCode);

        }





        private void pictureBtn_Click(object sender, EventArgs e)
        {

            string image_file = "";

            OpenFileDialog dialog = new OpenFileDialog();


            //c드라이브 디렉토리
            //dialog.InitialDirectory = @"C:\";

            if (dialog.ShowDialog() == DialogResult.OK)
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


        private void item_date_serch_ValueChanged(object sender, EventArgs e)
        {
            item_date_serch2.MinDate = item_date_serch.Value.AddDays(0);
        }





        private void item_code_serchBtn_Click(object sender, EventArgs e)
        {
            ItemCodeForm itemCodeForm = new ItemCodeForm("item");
            itemCodeForm.itemForm = this;
            itemCodeForm.ShowDialog();

        }


        //event를 입력,수정시 이벤트걸기
        private void TextChanged(object sender, EventArgs e)
        {


            if (form_code_value == "I" || form_code_value == "C")
            {


                TextBox targeted_textbox = (TextBox)sender;
                string target_txt = targeted_textbox.Text;

                string target_name = targeted_textbox.Tag.ToString();
                
                ItemGridView.CurrentRow.Cells["grid_" + target_name].Value = target_txt;


            }

        }

        private void item_samt_ValueChanged(object sender, EventArgs e)
        {

            if (form_code_value == "I" || form_code_value == "C")
            {


                NumericUpDown targeted_textbox = (NumericUpDown)sender;
                string target_txt = targeted_textbox.Text;
                string target_name = targeted_textbox.Tag.ToString();
                

                ItemGridView.CurrentRow.Cells["grid_" + target_name].Value = target_txt;

            }
        }

        private void item_date_ValueChanged(object sender, EventArgs e)
        {
            if (form_code_value == "I" || form_code_value == "C")
            {


                DateTimePicker targeted_textbox = (DateTimePicker)sender;
                string target_txt = targeted_textbox.Text;
                string target_name = targeted_textbox.Tag.ToString();


                ItemGridView.CurrentRow.Cells["grid_" + target_name].Value = target_txt;

            }
        }
    }
}

