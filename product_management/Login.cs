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

namespace product_management
{
    public partial class Login : MaterialForm
    {
        public Login()
        {
            InitializeComponent();

            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);

            //여기에서 라이트모드, 블랙모드 지정.
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);





        }

        private void loginBtn_Click(object sender, EventArgs e)
        {

            if (admin_id.Text == "")
            {
                MessageBox.Show("아이디를 제대로 입력하세요.");
                return;
            }
            if (admin_pass.Text == "")
            {
                MessageBox.Show("비밀번호를 제대로 입력하세요.");
                return;
            }



            Admin myadmin = new Admin();

            int result;

            result = myadmin.login(admin_id.Text, admin_pass.Text);

            //login 의 메소드 결과 값에 따라 hide 여부 
            if(result >= 1)
            {
                this.Hide();
            }
            else if(result == -1)
            {
                pass_label.Show();
                id_label.Hide();
            }
            else if(result == -2)
            {
                id_label.Show();
                pass_label.Hide();
            }

        }



        private void Form2_Load(object sender, EventArgs e)
        {

            admin_id.ForeColor = Color.Aqua;
            id_label.Hide();
            pass_label.Hide();
        }
    }
}
