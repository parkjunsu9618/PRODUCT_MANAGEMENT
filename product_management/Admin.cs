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
    public class Admin
    {
        private string admin_id;
        private string admin_pass;
        private string admin_name;

        OracleConnection con = null;
        string connectString = "Data source = product-management.chkwjetizrxz.ap-northeast-2.rds.amazonaws.com:1521/PRODUCT;User Id=root;Password=bestrong";
        OracleCommand cmd = null;
        OracleCommand cmd2 = null;
        OracleCommand cmd3 = null;
        OracleCommand cmd4 = null;

        OracleTransaction tran;



        OracleDataReader rs;
        


        public Admin()
        {
            try
            {
                con = new OracleConnection(connectString);
                con.Open();
                cmd = con.CreateCommand();
                cmd2 = con.CreateCommand();
                cmd3 = con.CreateCommand();
                cmd4 = con.CreateCommand();

                cmd.BindByName = true;
                cmd2.BindByName = true;
                cmd3.BindByName = true;
                cmd4.BindByName = true;


                if (con == null)
                {
                    MessageBox.Show("시스템에 문제가 있으니 담당자 연락바람");
                   
                }
                if (cmd == null)
                {
                    MessageBox.Show("시스템에 문제가 있으니 담당자 연락바람");
                }

            }
            catch(Exception er)
            {
                MessageBox.Show(er.ToString());
            }


        }





        public int login(string admin_id, string admin_pass)
        {



            try
            {
                if (con == null)
                {
                    MessageBox.Show("시스템에 문제가 있으니 담당자 연락바람");
                    return -3;
                }
                else if (cmd == null)
                {
                    MessageBox.Show("시스템에 문제가 있으니 담당자 연락바람");
                    return -3;
                }



                String sql = "select * " +
                               "from pjs_admin " +
                                "where admin_id = :admin_id";

                
                
                cmd.CommandText = sql;
                cmd.Parameters.Add("admin_id", OracleDbType.Varchar2).Value = admin_id;
                rs = cmd.ExecuteReader();

                if (rs.Read())
                {
                    string db_pass = rs["admin_pass"].ToString();

                    
                    if (admin_pass.Equals(db_pass))
                    {
                        string admin_name = rs["admin_name"].ToString();

                        //네임값 넘겨주기.
                        MainForm productForm = new MainForm(rs["admin_id"].ToString(),rs["admin_name"].ToString());
                        productForm.Show();
                        return 1;

                    }
                    //비밀번호 다른경우
                    else
                    {

                        return -1;
                    }

                }
                //아이디 없는 경우
                else
                {

                    return -2;

                }
            }
            catch(Exception er)
            {
                MessageBox.Show(er.ToString());
            }
            //db connection 해제 해주는 작업을 해줘야함.
            finally
            {
                
                con.Close();

            }
            return 5;
        }





        public Dictionary<String, String> checking_adminID(string admin_id)
        {
            Dictionary<String, String> admin_value = new Dictionary<string, string>();


            try
            {
                if (con == null)
                {
                    MessageBox.Show("시스템에 문제가 있으니 담당자 연락바람");

                }

                String sqlfind = "select * " +
                                "from pjs_admin " +
                                "where admin_id = :admin_id";

                cmd.CommandText = sqlfind;
                cmd.Parameters.Add("admin_id", OracleDbType.Varchar2).Value = admin_id;

                rs = cmd.ExecuteReader();

                if (rs.Read())
                {

                    admin_value.Add("admin_id", rs["admin_id"].ToString());
                    admin_value.Add("admin_pass", rs["admin_pass"].ToString());
                    admin_value.Add("admin_name", rs["admin_name"].ToString());

                    return admin_value;
                }
                else
                {
                    return null;
                }

            }
            catch (Exception er)
            {
                MessageBox.Show(er.ToString());
            }
            finally
            {
                con.Close();
            }
            return null;
        }


        public Dictionary<String, byte[]> checking_admin_img(String admin_id)
        {
            Dictionary<String, byte[]> img_value = new Dictionary<String, byte[]>();


            try
            {

                if (con == null)
                {
                    MessageBox.Show("시스템에 문제가 있으니 담당자 연락바람");

                }

                string sql = "select * from pjs_admin_img where img_key = :img_key";

                cmd.CommandText = sql;
                cmd.Parameters.Add("img_key", OracleDbType.Varchar2).Value = admin_id;


                rs = cmd.ExecuteReader();

                if (rs.Read())
                {


                    img_value.Add("img", (byte[])rs["img"]);


                    return img_value;
                }
                else
                {
                    return null;
                }

            }
            catch (Exception er)
            {
                MessageBox.Show(er.ToString());
            }
            finally
            {
                con.Close();
            }

            return null;
        }









        /**
         * serch
         */
        public List<Dictionary<string,string>> serch(string admin_name)
        {
            try
            {

                if (con == null)
                {
                    MessageBox.Show("시스템에 문제가 있으니 담당자 연락바람");
                }

                //가공하기
                List<Dictionary<String, String>> admin_values = new List<Dictionary<String, String>>();



                string sql_admin_find = "select * from pjs_admin where admin_name like :admin_name";
                cmd.CommandText = sql_admin_find;
                cmd.Parameters.Add("admin_name", OracleDbType.Varchar2).Value = "%" + admin_name + "%";
                rs = cmd.ExecuteReader();
                

                while (rs.Read())
                {
                    Dictionary<String, String> admin_value = new Dictionary<string, string>();
                    admin_value.Add("admin_id", rs["admin_id"].ToString());
                    admin_value.Add("admin_pass", rs["admin_pass"].ToString());
                    admin_value.Add("admin_name", rs["admin_name"].ToString());
                    admin_values.Add(admin_value);
                }
                return admin_values;

            }
            catch(Exception er){
                MessageBox.Show(er.ToString());
            }
            finally
            {
                con.Close();
            }


            return null;
        }



        /**
         * insert 
         */
        public void insert(Dictionary<String,String> admin_value, byte[] by)
        {
            try{



                String sql_find = "select * " +
                               "from pjs_admin " +
                                "where admin_id = :admin_id";

                cmd.CommandText = sql_find;
                cmd.Parameters.Add("admin_id", OracleDbType.Varchar2).Value = admin_value["아이디"];

                rs = cmd.ExecuteReader();

                if (rs.Read())
                {
                    MessageBox.Show("등록된 id가 있습니다");
                    con.Close();
                    return;
                }
                else
                {

                    String sql_insert = "insert into pjs_admin values(:admin_id,:admin_pass,:admin_name)";


                    
                    cmd2.CommandText = sql_insert;
                    
                    cmd2.Parameters.Add("admin_id", OracleDbType.Varchar2).Value = admin_value["아이디"];
                    cmd2.Parameters.Add("admin_pass", OracleDbType.Varchar2).Value = admin_value["비번"];
                    cmd2.Parameters.Add("admin_name", OracleDbType.Varchar2).Value = admin_value["이름"];


                    cmd2.ExecuteNonQuery();


                    //사진을 안넣었을때 예외 처리.
                    if (by == null)
                    {
                        return;
                    }
                    else
                    {


                        String sql_img = "insert into pjs_admin_img values(:img_key, :img)";                        
                        cmd3.CommandText = sql_img;                       
                        cmd3.Parameters.Add("img_key", OracleDbType.Varchar2).Value = admin_value["아이디"];
                        cmd3.Parameters.Add("img", OracleDbType.Blob, by.Length, by, ParameterDirection.Input);
                        cmd3.ExecuteNonQuery();

                    }

                }

            }
            catch (Exception er)
            {
                MessageBox.Show(er.ToString());
            }
            //db connection 해제 해주는 작업을 해줘야함.
            finally
            {
                con.Close();
            }

        }




        public void update(Dictionary<String, String> admin_value,byte[] by)
        {

            try
            {


                String sql = "update pjs_admin set " +
                                    "admin_pass = :admin_pass , " +
                                    "admin_name = :admin_name " +
                                    "where " +
                                    "admin_id = :admin_id";



                
                cmd.CommandText = sql;
                cmd.Parameters.Add("admin_pass", OracleDbType.Varchar2).Value = admin_value["비번"];
                cmd.Parameters.Add("admin_name", OracleDbType.Varchar2).Value = admin_value["이름"];
                cmd.Parameters.Add("admin_id", OracleDbType.Varchar2).Value = admin_value["아이디"];
                cmd.ExecuteNonQuery();



                //사용자가 이미지를 넣엏을때 경우
                if (by == null)
                {                    


                }
                else
                {


                    //이미지 데이터 베이스 있는지 확인
                    String sql2 = "select * from pjs_admin_img where img_key = :admin_id";

                    cmd2.CommandText = sql2;
                    cmd2.Parameters.Add("admin_id", OracleDbType.Varchar2).Value = admin_value["아이디"];
                    rs = cmd2.ExecuteReader();

                    if (rs.Read())
                    {

                        String sql3 = "update pjs_admin_img set " +
                                        "img = :img " +
                                        "where img_key = :admin_id";

                        cmd3.CommandText = sql3;
                        cmd3.Parameters.Add("img", OracleDbType.Blob, by.Length, by, ParameterDirection.Input);
                        cmd3.Parameters.Add("admin_id", OracleDbType.Varchar2).Value = admin_value["아이디"];            
                        cmd3.ExecuteNonQuery();
                    }
                    else
                    {


                        String sql4 = "insert into pjs_admin_img values(:img_key, :img)";
                        cmd4.CommandText = sql4;
                        cmd4.Parameters.Add("img_key", OracleDbType.Varchar2).Value = admin_value["아이디"];
                        cmd4.Parameters.Add("img", OracleDbType.Blob, by.Length, by, ParameterDirection.Input);
                        cmd4.ExecuteNonQuery();


                    }


                }

                MessageBox.Show("수정완료");
                
            }
            catch (Exception er)
            {
                MessageBox.Show(er.ToString());
            }
            //db connection 해제 해주는 작업을 해줘야함.
            finally
            {
                con.Close();
            }

        }



        public void delete(string admin_id)
        {

            try
            {

                tran = con.BeginTransaction();

                cmd.Transaction = tran;




                String sql = "delete from pjs_admin where admin_id = :admin_id";


                cmd.CommandText = sql;
                cmd.Parameters.Add("admin_id", OracleDbType.Varchar2).Value = admin_id;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();


                String sql2 = "delete from pjs_admin_img where img_key = :img_key";


                cmd.CommandText = sql2;
                cmd.Parameters.Add("img_key", OracleDbType.Varchar2).Value = admin_id;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();

                tran.Commit();


                MessageBox.Show("삭제완료");


            }
            catch (Exception er)
            {
                tran.Rollback();
                MessageBox.Show(er.ToString());
            }
            //db connection 해제 해주는 작업을 해줘야함.
            finally
            {
                con.Close();
            }

        }




    }
}

