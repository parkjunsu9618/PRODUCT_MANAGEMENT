using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;







namespace product_management
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void checkBox1_Paint(object sender, PaintEventArgs e)
        {
            CheckBox myCheckbox = (CheckBox)sender;
            Rectangle borderRectangle = myCheckbox.ClientRectangle;
            if (myCheckbox.Checked)
            {
                ControlPaint.DrawBorder3D(e.Graphics, borderRectangle,
                    Border3DStyle.Sunken);
            }
            else
            {
                ControlPaint.DrawBorder3D(e.Graphics, borderRectangle,
                    Border3DStyle.Raised);
            }
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            InitializeComponent();

           

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {




        }

        private void Form2_KeyUp(object sender, KeyEventArgs e)
        {
            MessageBox.Show("asdfasd");
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show("2222");
        }
    }
}
