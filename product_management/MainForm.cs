using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Windows.Input;

namespace product_management
{

    public partial class MainForm : MaterialForm
    {

        string code_value = null;


        //키바인딩. -낼작업





        public string user_sysid;
        public string admin_name;



        private void InitializeComponet()
        {

        }


        public MainForm(string adminId, string adminName)
        {
            InitializeComponent();
            user_sysid = adminId;
            admin_name = adminName;


            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);

            //여기에서 라이트모드, 블랙모드 지정.
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            KeyPreview = true;
            KeyUp += MainForm_KeyUp;


        }




        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }



        public void btnValue()
        {
            serchBtn.Enabled = true;
            insertBtn.Enabled = false;
            changeBtn.Enabled = false;
            deleteBtn.Enabled = false;
            confirmBtn.Enabled = true;
            canselBtn.Enabled = true;

        }

        public void btnValue2()
        {
            serchBtn.Enabled = true;
            insertBtn.Enabled = true;
            changeBtn.Enabled = true;
            deleteBtn.Enabled = true;
            confirmBtn.Enabled = false;
            canselBtn.Enabled = false;

        }
        public void btnValue3()
        {
            serchBtn.Enabled = false;
            insertBtn.Enabled = false;
            changeBtn.Enabled = false;
            deleteBtn.Enabled = false;
            confirmBtn.Enabled = false;
            canselBtn.Enabled = false;

        }



        public void showChart()
        {
            //재고량 top5를 가져오는 로직
            Item myItem = new Item();






        }




        //탭컨트롤의 탭페이지가 있는지 없는지 검사로직
        //폼이 열려있는지 없는지 검사하는 로직 -- 폼검사 로직 ( 열린폼 검사 로직)
        private Form formIsExist(Form target_form)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form == target_form)
                {
                    return form;
                }
            }
            return null;
        }


        




        //폼만드는 로직
        public void make_tap(Form target_form, string title, string tag_value)
        {
            //컨텐츠 넣을 페이지 추가
            TabPage mypage = new TabPage(title);

            //패널안에 폼을 넣기                        

            target_form.TopLevel = false;
            target_form.Size = tapControl.Size;

            
            mypage.Controls.Add(target_form);

            //태그밸류
            mypage.Tag = tag_value;

            //만들어진 탭 페이지를 탭컨트롤에 넣기.
            tapControl.TabPages.Add(mypage);

            

            tapControl.SelectedTab = mypage;


            target_form.Show();

        }




        //폼열려 있을경우 이동 로직
        public void move_tap(string title)
        {
            foreach (TabPage target in tapControl.TabPages)
            {
                if (target.Text == title)
                {
                    tapControl.SelectedTab = target;
                }
            }
     
        }


        public int formExit(string title)
        {
            foreach (TabPage target in tapControl.TabPages)
            {
                
                if (target.Text == title)
                {
                    return -1;
                }
            }
            return 1;
        }


        

        //노드에맞게 인스턴스 생성
        public Form GetInstance(string strFullyQualifiedName)
        {
            t = Type.GetType(strFullyQualifiedName);
            frm = Activator.CreateInstance(t, null) as Form;
            return frm;
        }


        Type t;
        Form frm;




        /*
         * 노드 클릭시 인스턴스 생성
         */
        private void MainTree_AfterSelect(object sender, TreeViewEventArgs e)
        {



            string tree = e.Node.Name;
            string tag_value = MainTree.SelectedNode.Tag.ToString();


            //태그값 없을때 불러오기. tag값 비우기
            if (tag_value != "")
            {

                //폼이 열렸는지 안열렸는지 검사하는로직
                int form_check = formExit(tree);
                //폼없음
                if (form_check == 1)
                {
                    Form target_frm = GetInstance("product_management." + tag_value);
                    make_tap(target_frm, tree, tag_value);
                }
                else
                {
                    move_tap(tree);
                }
               
            }

            if (tapControl.SelectedTab.Tag.ToString() == "PegiForm")
            {
                btnValue();
            }
            else if(tapControl.SelectedTab.Tag.ToString() == "Statement")
            {
                btnValue3();
            }
            else
            {
                btnValue2();
            }

            
        }





        private void tapControl_Resize(object sender, EventArgs e)
        {

            //탭컨트롤 페이지안 컨트롤은 폼 하나뿐.
            foreach (TabPage pages in tapControl.TabPages)
            {


                //폼열려있는지 체크.


                foreach (Form target in pages.Controls)
                {


                    target.Size = tapControl.Size;
                }
                

                

            }

        }

       

        private void tapControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tapControl.SelectedTab.Tag == null)
            {
                return;
            }
            if (tapControl.SelectedTab.Tag.ToString() == "PegiForm")
            {
                btnValue();
            }
            else if(tapControl.SelectedTab.Tag.ToString() == "Statement")
            {

                stateForm.Statement_Load(sender,e);

                btnValue3();
            }
            else
            {
                btnValue2();
            }

            string tag_value = tapControl.SelectedTab.Tag.ToString();

            t = Type.GetType("product_management." + tag_value);

            frm = (Form)tapControl.SelectedTab.Controls.Find(tag_value, true).FirstOrDefault();
        }






       




        public void serchBtn_Click(object sender, EventArgs e)
        {
            

            t.GetMethod("serch_gridView").Invoke(frm, null);

        }

        private void insertBtn_Click_1(object sender, EventArgs e)
        {

            t.GetMethod("insertBtn_Click").Invoke(frm, null);
            //t.GetMethod("clear").Invoke(frm, null);
            code_value = "I";
            btnValue();
            
        }

        
        private void changeBtn_Click(object sender, EventArgs e)
        {


            

            bool checking = (bool)t.GetMethod("change_deleteBtn_Click").Invoke(frm, null);

            
            Button check_type = (Button)sender;
            if (check_type.Tag == "수정")
            {
                code_value = "C";
            }
            else
            {
                code_value = "D";
            }


            if (checking)
            {
                btnValue();
            }
            
        }
        

        private void confirmBtn_Click(object sender, EventArgs e)
        {

            string[] param = { user_sysid };

            string[] param2 = { code_value };





            t.GetMethod("set_user_sysid").Invoke(frm, param);

            //t.GetField[]
            t.GetMethod("confirmBtn_Click").Invoke(frm, param2);


            //확인 누를시


            if (tapControl.SelectedTab.Tag.ToString() == "PegiForm")
            {                
                btnValue();
            }
            else
            {
                btnValue2();
            }


        }


        private void canselBtn_Click(object sender, EventArgs e)
        {

            t.GetMethod("canselBtn_Click").Invoke(frm, null);
            if (tapControl.SelectedTab.Tag.ToString() == "PegiForm")
            {

                btnValue();
            }
            else
            {
                btnValue2();
            }


        }


        Statement stateForm = new Statement();




        private void MainForm_Load(object sender, EventArgs e)
        {
            //Login loginForm = new Login();
            //loginForm.ShowDialog();


            label_hint.Visible = false;

            adminName.Text = admin_name;



            btnValue3();







            stateForm.TopLevel = false;
            stateForm.Size = tapControl.Size;



            Statement.Controls.Add(stateForm);

            stateForm.Show();





        }



        


        private void serchBtn_MouseEnter(object sender, EventArgs e)
        {
            Button target_btn = sender as Button;


            label_hint.Text = "";
            label_hint.Visible = true;
            label_hint.Location = new Point(FunctionPanel.Location.X + target_btn.Location.X, target_btn.Location.Y + 35);


            switch (target_btn.Name)
            {
                case "serchBtn":
                    label_hint.Text = "검색버튼(Control + w)";
                    break;
                case "insertBtn":
                    label_hint.Text = "입력버튼(Control + i)";
                    break;
                case "changeBtn":
                    label_hint.Text = "수정버튼(Control + c)";
                    break;
                case "deleteBtn":
                    label_hint.Text = "삭제버튼(Control + d)";
                    break;
                case "confirmBtn":
                    label_hint.Text = "확인버튼(Control + s)";
                    break;
                case "canselBtn":
                    label_hint.Text = "취소버튼(Control + r)";
                    break;
            }


            
        }






        private void serchBtn_MouseLeave(object sender, EventArgs e)
        {

            Button tartget_btn = sender as Button;
            label_hint.Text = "";
            label_hint.Visible = true;



        }



        private void MainForm_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {

            //serchbtn
            if (e.Control && e.KeyCode == Keys.W)
            {
                serchBtn.PerformClick();
                
            }
            //insertbtn
            else if(e.Control && e.KeyCode == Keys.I)
            {
                insertBtn.PerformClick();
            }
            else if (e.Control && e.KeyCode == Keys.U)
            {
                changeBtn.PerformClick();
            }
            else if (e.Control && e.KeyCode == Keys.D)
            {
                deleteBtn.PerformClick();
            }
            //confirmbtn
            else if (e.Control && e.KeyCode == Keys.S)
            {
                confirmBtn.PerformClick();
            }
            else if (e.Control && e.KeyCode == Keys.R)
            {
                canselBtn.PerformClick();
            }




        }


        
        
    }

}
