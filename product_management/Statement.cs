using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace product_management
{
    public partial class Statement : Form
    {
        public Statement()
        {
            InitializeComponent();
        }

        public void Statement_Load(object sender, EventArgs e)
        {


            Item myItem = new Item();

            List<Dictionary<String, String>> stock_values = new List<Dictionary<string, string>>();




            stock_values = myItem.get_stock();



            stockChart.Series.Clear();

            Series s1 = new Series("물품명");

            stockChart.Series.Add(s1);


            List<string> xValues = new List<string>();
            List<int> yValues = new List<int>();




            foreach (Dictionary<string, string> stock_stock in stock_values)
            {

                xValues.Add(stock_stock["item_name"].ToString());
                yValues.Add(Int32.Parse(stock_stock["item_samt"]));

             

            }

            s1.Points.DataBindXY(xValues, yValues);

            s1.ChartType = SeriesChartType.Column;

            s1.BorderWidth = 12;


            s1.Color = Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));

            s1.IsValueShownAsLabel = true;
            s1.BackGradientStyle = GradientStyle.DiagonalRight;

            stockChart.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            stockChart.ChartAreas[0].AxisX.MajorGrid.LineDashStyle = ChartDashStyle.NotSet;
            stockChart.ChartAreas[0].AxisY.MajorGrid.LineDashStyle = ChartDashStyle.NotSet;




            
            Culgo myculgo2 = new Culgo();

            List<Dictionary<String, String>> bestCulgos = new List<Dictionary<string, string>>();

            bestCulgos = myculgo2.get_culgo_best();



            bestChart.Series.Clear();

            Series s2 = new Series("물품명");

            bestChart.Series.Add(s2);


            List<string> xValues2 = new List<string>();
            List<int> yValues2 = new List<int>();

            foreach (Dictionary<string, string> best_item in bestCulgos)
            {

                xValues2.Add(best_item["item_name"].ToString());
                yValues2.Add(Int32.Parse(best_item["sum"]));

                //Console.WriteLine(best_item["item_name"].ToString());
                //Console.WriteLine(best_item["sum"].ToString());

            }

            s2.Points.DataBindXY(xValues2, yValues2);
            s2.ChartType = SeriesChartType.Column;

            s2.BorderWidth = 12;
            
            s2.Color = Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));

            s2.IsValueShownAsLabel = true;
            s2.BackGradientStyle = GradientStyle.DiagonalRight;

            bestChart.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            bestChart.ChartAreas[0].AxisX.MajorGrid.LineDashStyle = ChartDashStyle.NotSet;
            bestChart.ChartAreas[0].AxisY.MajorGrid.LineDashStyle = ChartDashStyle.NotSet;











            /**
             * 입고정보
             */

            Ipgo myipgo = new Ipgo();


            List<Dictionary<String, String>> ipgo_values = new List<Dictionary<string, string>>();

            // List 배열값
            ipgo_values = myipgo.get_ipgo_info();



            ipgo_list.Items.Clear();


            int index = 1;

            foreach (Dictionary<string, string> ipgo_ipgo in ipgo_values)
            {

                string ipgo_name = ipgo_ipgo["item_name"].ToString();
                string ipgo_date = ipgo_ipgo["ipgo_date"].ToString();
                string ipgo_cnt = ipgo_ipgo["ipgo_cnt"].ToString();

                ipgo_list.Items.Add(index +".  ( " +ipgo_date+" ) "+ipgo_name+"(이)가 "+ipgo_cnt+"개 입고 되었습니다.");

                index = index + 1;
                

            }




            /**
             * 출고정보
             */

            Culgo myculgo = new Culgo();


            List<Dictionary<String, String>> culgo_values = new List<Dictionary<string, string>>();

            // List 배열값
            culgo_values = myculgo.get_culgo_info();

            
            culgo_list.Items.Clear();


            int culgo_index = 1;

            foreach (Dictionary<string, string> ipgo_ipgo in culgo_values)
            {

                string culgo_name = ipgo_ipgo["item_name"].ToString();
                string culgo_date = ipgo_ipgo["culgo_date"].ToString();
                string culgo_cnt = ipgo_ipgo["culgo_cnt"].ToString();

                culgo_list.Items.Add(culgo_index + ".  ( " + culgo_date + " ) " + culgo_name + "(이)가 " + culgo_cnt + "개 출고 되었습니다.");

                culgo_index = culgo_index + 1;


            }




            



        }
    }
}
