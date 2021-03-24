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
    public partial class ItemCodeForm : Form
    {

        private string check_form;

        public ItemCodeForm(String check_form)
        {
            InitializeComponent();

            this.check_form = check_form;
        }





        DataGridViewRow row;
        int rowIdw = 0;

        private void serchBtn_Click(object sender, EventArgs e)
        {
            Item myItem = new Item();


            List<Dictionary<String, String>> item_values = new List<Dictionary<string, string>>();

            // List 배열값
            item_values = myItem.serch(item_name.Text);



            itemGridView.Rows.Clear();

            foreach (Dictionary<string, string> Item_item in item_values)
            {

                rowIdw = itemGridView.Rows.Add();
                row = itemGridView.Rows[rowIdw];

                row.Cells["column1"].Value = Item_item["item_code"].ToString();
                row.Cells["column2"].Value = Item_item["item_name"].ToString();
                row.Cells["column3"].Value = Item_item["item_samt"].ToString();
                //Console.WriteLine(Item_item["Item_id"]);
            }









        }

        public ItemForm itemForm;
        public IpgoForm ipgoForm;
        public CulgoForm culgoForm;
        public _PegiForm pegiForm;

        private void itemGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {




            string item_code = itemGridView.Rows[e.RowIndex].Cells["Column1"].Value.ToString();
            string item_name = itemGridView.Rows[e.RowIndex].Cells["Column2"].Value.ToString();
            string item_samt = itemGridView.Rows[e.RowIndex].Cells["Column3"].Value.ToString();
            
            if(check_form == "ipgo")
            {
                ipgoForm.ipgo_code.Text = item_code;
                ipgoForm.item_name.Text = item_name;
                ipgoForm.item_samt.Text = item_samt;
            }
            else if(check_form == "culgo")
            {

                culgoForm.culgo_code.Text = item_code;
                culgoForm.item_name.Text = item_name;
                culgoForm.item_samt.Text = item_samt;
            }
            else if(check_form == "item")
            {

                itemForm.item_code.Text = item_code;
                itemForm.item_name.Text = item_name;
                itemForm.item_samt.Text = item_samt;
            }
            else
            {
                pegiForm.pegi_code.Text = item_code;
                pegiForm.item_name.Text = item_name;
                pegiForm.item_samt.Text = item_samt;
            }

            this.Close();









        }
    }
}

