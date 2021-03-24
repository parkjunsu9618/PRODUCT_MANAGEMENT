using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using System.ComponentModel;
using System.Data;
using System.Drawing;





namespace product_management
{
    class Colors
    {


        bool check_dark = true;


        public void ChangeTheme(Color_scheme scheme, Control.ControlCollection container,Form setting_form,List<DataGridView> dg)
        {

            

            Color_scheme colors = new Color_scheme();

            
            

            if (check_dark)
            {

                //폼
                setting_form.BackColor = colors.FormBC;
                setting_form.ForeColor = colors.FormFC;


                //데이터그리드뷰
                foreach (DataGridView ddd in dg)
                {
                    ddd.BackgroundColor = colors.GridBC;                    
                }



                //컨트롤들
                foreach (Control component in container)
                {
                    Console.WriteLine(component);
                    if (component is Panel)
                    {
                        component.BackColor = colors.PanelBC;
                        component.ForeColor = colors.PanelFC;

                        foreach (Control pannel_control_el in component.Controls)
                        {
                            if (pannel_control_el is Button)
                            {
                                pannel_control_el.BackColor = colors.ButtonBC;
                                pannel_control_el.ForeColor = colors.ButtonFC;
                            }
                            else if (pannel_control_el is TextBox)
                            {
                                pannel_control_el.BackColor = colors.TextBC;
                                pannel_control_el.ForeColor = colors.TextFC;
                            }
                            else if (pannel_control_el is Label)
                            {
                                pannel_control_el.BackColor = colors.LabelBC;
                                pannel_control_el.ForeColor = colors.LabelFC;
                            }

                        }

                    }
                    else if (component is Button)
                    {
                        component.BackColor = colors.ButtonBC;
                        component.ForeColor = colors.ButtonFC;
                    }
                    else if (component is TextBox)
                    {
                        component.BackColor = colors.TextBC;
                        component.ForeColor = colors.TextFC;

                    }
                    else if (component is Label)
                    {
                        component.BackColor = colors.LabelBC;
                        component.ForeColor = colors.LabelFC;

                    }
                    else if (component is DataGridView)
                    {




                    }


                }
            }

            //다크모드해제 
            else
            {
                setting_form.BackColor = colors.white_FormBC;
                setting_form.ForeColor = colors.white_FormFC;

                foreach (Control component in container)
                {
                    if (component is Panel)
                    {
                        component.BackColor = colors.white_PanelBC;
                        component.ForeColor = colors.white_PanelFC;
                        foreach (Control pannel_control_el in component.Controls)
                        {
                            if (pannel_control_el is Button)
                            {
                                pannel_control_el.BackColor = colors.white_ButtonBC;
                                pannel_control_el.ForeColor = colors.white_ButtonFC;
                            }
                            else if (pannel_control_el is TextBox)
                            {
                                pannel_control_el.BackColor = colors.white_TextBC;
                                pannel_control_el.ForeColor = colors.white_TextFC;
                            }
                            else if (pannel_control_el is Label)
                            {
                                pannel_control_el.BackColor = colors.white_LabelBC;
                                pannel_control_el.ForeColor = colors.white_LabelFC;
                            }

                           
                        }
                    }
                    else if (component is Button)
                    {
                        component.BackColor = colors.white_ButtonBC;
                        component.ForeColor = colors.white_ButtonFC;



                    }
                    else if (component is TextBox)
                    {
                        component.BackColor = colors.white_TextBC;
                        component.ForeColor = colors.white_TextFC;
                    }
                    else if (component is Label)
                    {
                        component.BackColor = colors.white_LabelBC;
                        component.ForeColor = colors.white_LabelFC;                        
                    }
                    else if (component is DataGridView)
                    {
                        component.BackColor = colors.white_GridBC;
                        component.ForeColor = colors.white_GridFC;
                    }


                }
                
            }
            check_dark = !check_dark;


            //다크 모드를 눌렀을때 다른폼 다 바뀌게끔.







        }


    }
}
