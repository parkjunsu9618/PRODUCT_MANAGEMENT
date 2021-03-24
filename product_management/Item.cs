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
using System.Data.SqlClient;

namespace product_management
{
    public class Item
    {


        OracleConnection con = null;
        string connectString = "Data source = product-management.chkwjetizrxz.ap-northeast-2.rds.amazonaws.com:1521/PRODUCT;User Id=root;Password=bestrong";
        OracleCommand cmd = null;
        OracleCommand cmd2 = null;
        OracleCommand cmd3 = null;
        OracleCommand cmd4 = null;



        OracleDataReader rs;

        OracleTransaction tran;



        public Item()
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
            catch (Exception er)
            {
                MessageBox.Show(er.ToString());
            }


        }






        public Dictionary<String, String> checking_ItemID(string item_code)
        {
            Dictionary<String, String> item_value = new Dictionary<string, string>();


            try
            {


                String sqlfind = "select * " +
                                "from pjs_item " +
                                "where item_code = :item_code";

                cmd.CommandText = sqlfind;
                cmd.Parameters.Add("item_code", OracleDbType.Varchar2).Value = item_code;

                rs = cmd.ExecuteReader();

                if (rs.Read())
                {

                    item_value.Add("item_code", rs["item_code"].ToString());
                    item_value.Add("item_name", rs["item_name"].ToString());
                    item_value.Add("item_stand", rs["item_stand"].ToString());
                    item_value.Add("item_date", rs["item_date"].ToString());
                    item_value.Add("item_amt", rs["item_amt"].ToString());
                    item_value.Add("item_comp", rs["item_comp"].ToString());
                    item_value.Add("item_samt", rs["item_samt"].ToString());
                    item_value.Add("item_posi", rs["item_posi"].ToString());
                    item_value.Add("item_etc", rs["item_etc"].ToString());                    
                    item_value.Add("user_sysid", rs["user_sysid"].ToString());
                    


                    return item_value;
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


        public Dictionary<String, byte[]> checking_Item_img(String item_code)
        {
            Dictionary<String, byte[]> img_value = new Dictionary<String, byte[]>();


            try
            {

                if (con == null)
                {
                    MessageBox.Show("시스템에 문제가 있으니 담당자 연락바람");

                }

                string sql = "select * from pjs_item_img where img_key = :img_key";

                cmd.CommandText = sql;
                cmd.Parameters.Add("img_key", OracleDbType.Varchar2).Value = item_code;


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
        public List<Dictionary<string, string>> serch(string item_code, string item_name, string item_date, string item_date2)
        {

            try
            {

                if (con == null)
                {
                    MessageBox.Show("시스템에 문제가 있으니 담당자 연락바람");
                }

                //가공하기
                List<Dictionary<String, String>> item_values = new List<Dictionary<String, String>>();





                string sql_item_find = "select * from pjs_item where " +
                    "item_name like :item_code and " +
                    "item_name like :item_name and " +
                    "item_date >= :item_date and " +
                    "item_date <= :item_date2 and " +
                    "item_yn = 'n'";

                cmd.CommandText = sql_item_find;
                cmd.Parameters.Add("item_code", OracleDbType.Varchar2).Value = "%" + item_code + "%";
                cmd.Parameters.Add("item_name", OracleDbType.Varchar2).Value = "%" + item_name + "%";
                cmd.Parameters.Add("item_date", OracleDbType.Varchar2).Value = item_date;
                cmd.Parameters.Add("item_date2", OracleDbType.Varchar2).Value = item_date2;
                rs = cmd.ExecuteReader();


                while (rs.Read())
                {
                    Dictionary<String, String> item_value = new Dictionary<string, string>();

                    item_value.Add("item_code", rs["item_code"].ToString());
                    item_value.Add("item_name", rs["item_name"].ToString());
                    item_value.Add("item_stand", rs["item_stand"].ToString());
                    item_value.Add("item_date", rs["item_date"].ToString());
                    item_value.Add("item_amt", rs["item_amt"].ToString());
                    item_value.Add("item_comp", rs["item_comp"].ToString());
                    item_value.Add("item_samt", rs["item_samt"].ToString());
                    item_value.Add("item_posi", rs["item_posi"].ToString());
                    item_value.Add("item_etc", rs["item_etc"].ToString());
                    item_value.Add("user_sys", rs["user_sys"].ToString());
                    item_value.Add("user_sysid", rs["user_sysid"].ToString());                    


                    item_values.Add(item_value);
                }
                return item_values;

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
        public List<Dictionary<string, string>> serch(string item_name)
        {
            try
            {

                if (con == null)
                {
                    MessageBox.Show("시스템에 문제가 있으니 담당자 연락바람");
                }

                //가공하기
                List<Dictionary<String, String>> item_values = new List<Dictionary<String, String>>();





                string sql_item_find = "select * from pjs_item where " +
                    "item_name like :item_name and " +
                    "item_yn = 'n'"; 

                cmd.CommandText = sql_item_find;
                cmd.Parameters.Add("item_name", OracleDbType.Varchar2).Value = "%" + item_name + "%";
                rs = cmd.ExecuteReader();


                while (rs.Read())
                {
                    Dictionary<String, String> item_value = new Dictionary<string, string>();

                    item_value.Add("item_code", rs["item_code"].ToString());
                    item_value.Add("item_name", rs["item_name"].ToString());
                    item_value.Add("item_stand", rs["item_stand"].ToString());
                    item_value.Add("item_date", rs["item_date"].ToString());
                    item_value.Add("item_amt", rs["item_amt"].ToString());
                    item_value.Add("item_comp", rs["item_comp"].ToString());
                    item_value.Add("item_samt", rs["item_samt"].ToString());
                    item_value.Add("item_posi", rs["item_posi"].ToString());
                    item_value.Add("item_etc", rs["item_etc"].ToString());
                    item_value.Add("user_sys", rs["user_sys"].ToString());
                    item_value.Add("user_sysid", rs["user_sysid"].ToString());


                    item_values.Add(item_value);
                }
                return item_values;

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
        public List<Dictionary<string, string>> serch3(string item_code, string item_name, string item_date, string item_date2)
        {
            try
            {

                if (con == null)
                {
                    MessageBox.Show("시스템에 문제가 있으니 담당자 연락바람");
                }

                //가공하기
                List<Dictionary<String, String>> item_values = new List<Dictionary<String, String>>();





                string sql_item_find = "select * from pjs_item where " +
                    "item_code like :item_code and " +
                    "item_name like :item_name and " +
                    "item_date >= :item_date and " +
                    "item_date <= :item_date2";

                cmd.CommandText = sql_item_find;
                cmd.Parameters.Add("item_code", OracleDbType.Varchar2).Value = "%" + item_code + "%";
                cmd.Parameters.Add("item_name", OracleDbType.Varchar2).Value = "%" + item_name + "%";
                cmd.Parameters.Add("item_date", OracleDbType.Varchar2).Value = item_date;
                cmd.Parameters.Add("item_date2", OracleDbType.Varchar2).Value = item_date2;
                rs = cmd.ExecuteReader();


                while (rs.Read())
                {
                    Dictionary<String, String> item_value = new Dictionary<string, string>();

                    item_value.Add("item_code", rs["item_code"].ToString());
                    item_value.Add("item_name", rs["item_name"].ToString());
                    item_value.Add("item_stand", rs["item_stand"].ToString());
                    item_value.Add("item_date", rs["item_date"].ToString());
                    item_value.Add("item_amt", rs["item_amt"].ToString());
                    item_value.Add("item_comp", rs["item_comp"].ToString());
                    item_value.Add("item_samt", rs["item_samt"].ToString());
                    item_value.Add("item_posi", rs["item_posi"].ToString());
                    item_value.Add("item_etc", rs["item_etc"].ToString());
                    item_value.Add("user_sys", rs["user_sys"].ToString());
                    item_value.Add("user_sysid", rs["user_sysid"].ToString());
                    item_value.Add("item_yn", rs["item_yn"].ToString());


                    item_values.Add(item_value);
                }
                return item_values;

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
        public List<Dictionary<string, string>> serch2(string item_name)
        {
            try
            {

                if (con == null)
                {
                    MessageBox.Show("시스템에 문제가 있으니 담당자 연락바람");
                }

                //가공하기
                List<Dictionary<String, String>> item_values = new List<Dictionary<String, String>>();





                string sql_item_find = "select * from pjs_item where item_name like :item_name";




                cmd.CommandText = sql_item_find;
                cmd.Parameters.Add("item_name", OracleDbType.Varchar2).Value = "%" + item_name + "%";
                rs = cmd.ExecuteReader();


                while (rs.Read())
                {
                    Dictionary<String, String> item_value = new Dictionary<string, string>();

                    item_value.Add("item_code", rs["item_code"].ToString());
                    item_value.Add("item_name", rs["item_name"].ToString());
                    item_value.Add("item_stand", rs["item_stand"].ToString());
                    item_value.Add("item_date", rs["item_date"].ToString());
                    item_value.Add("item_amt", rs["item_amt"].ToString());
                    item_value.Add("item_comp", rs["item_comp"].ToString());
                    item_value.Add("item_samt", rs["item_samt"].ToString());
                    item_value.Add("item_posi", rs["item_posi"].ToString());
                    item_value.Add("item_etc", rs["item_etc"].ToString());
                    item_value.Add("item_yn", rs["item_yn"].ToString());
                    item_value.Add("user_sys", rs["user_sys"].ToString());
                    item_value.Add("user_sysid", rs["user_sysid"].ToString());

                    item_values.Add(item_value);
                }
                return item_values;

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
         * insert 
         */
        public void insert(Dictionary<String, String> item_value, byte[] by)
        {
            try
            {

                if (con == null)
                {
                    MessageBox.Show("시스템에 문제가 있으니 담당자 연락바람");

                }



                String sql_find = "select * " +
                               "from pjs_item " +
                                "where item_code = :item_code";

                cmd.CommandText = sql_find;
                cmd.Parameters.Add("item_code", OracleDbType.Varchar2).Value = item_value["item_code"];

                rs = cmd.ExecuteReader();

                if (rs.Read())
                {
                    MessageBox.Show("등록된 id가 있습니다");
                    con.Close();
                    return;
                }
                else
                {

                    String sql_insert = "insert into pjs_item" +
                        "(item_code, item_name, item_stand, item_date, item_amt, item_comp, item_samt, item_posi, item_etc, user_sysid) " +
                        "values(:item_code, :item_name, :item_stand, :item_date, :item_amt, :item_comp, :item_samt, :item_posi, :item_etc, :user_sysid)";



                    cmd2.CommandText = sql_insert;

                    cmd2.Parameters.Add("item_code", OracleDbType.Varchar2).Value = item_value["item_code"];
                    cmd2.Parameters.Add("item_name", OracleDbType.Varchar2).Value = item_value["item_name"];
                    cmd2.Parameters.Add("item_stand", OracleDbType.Varchar2).Value = item_value["item_stand"];
                    cmd2.Parameters.Add("item_date", OracleDbType.Varchar2).Value = item_value["item_date"];
                    cmd2.Parameters.Add("item_amt", OracleDbType.Varchar2).Value = item_value["item_amt"];
                    cmd2.Parameters.Add("item_comp", OracleDbType.Varchar2).Value = item_value["item_comp"];
                    cmd2.Parameters.Add("item_samt", OracleDbType.Varchar2).Value = item_value["item_samt"];
                    cmd2.Parameters.Add("item_posi", OracleDbType.Varchar2).Value = item_value["item_posi"];
                    cmd2.Parameters.Add("item_etc", OracleDbType.Varchar2).Value = item_value["item_etc"];
                    cmd2.Parameters.Add("user_sysid", OracleDbType.Varchar2).Value = item_value["user_sysid"];

                    cmd2.ExecuteNonQuery();


                    //사진을 안넣었을때 예외 처리.
                    if (by == null)
                    {
                        return;
                    }
                    else
                    {


                        String sql_img = "insert into pjs_item_img values(:img_key, :img)";
                        cmd3.CommandText = sql_img;
                        cmd3.Parameters.Add("img_key", OracleDbType.Varchar2).Value = item_value["item_code"];
                        cmd3.Parameters.Add("img", OracleDbType.Blob, by.Length, by, ParameterDirection.Input);
                        cmd3.ExecuteNonQuery();

                    }


                    MessageBox.Show("등록완료");

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




        public void update(Dictionary<String, String> item_value, byte[] by)
        {

            try
            {






                String sql = "update pjs_item set " +
                                    "item_name = :item_name , " +
                                    "item_stand = :item_stand , " +
                                    "item_date = :item_date , " +
                                    "item_amt = :item_amt , " +
                                    "item_comp = :item_comp , " +
                                    "item_samt = :item_samt , " +
                                    "item_posi = :item_posi , " +
                                    "item_etc = :item_etc , " +
                                    "user_sysid = :user_sysid " +
                                    "where " +
                                    "item_code = :item_code";


                cmd.CommandText = sql;
                cmd.Parameters.Add("item_name", OracleDbType.Varchar2).Value = item_value["item_name"];
                cmd.Parameters.Add("item_stand", OracleDbType.Varchar2).Value = item_value["item_stand"];
                cmd.Parameters.Add("item_date", OracleDbType.Varchar2).Value = item_value["item_date"];
                cmd.Parameters.Add("item_amt", OracleDbType.Varchar2).Value = item_value["item_amt"];
                cmd.Parameters.Add("item_comp", OracleDbType.Varchar2).Value = item_value["item_comp"];
                cmd.Parameters.Add("item_samt", OracleDbType.Varchar2).Value = item_value["item_samt"];
                cmd.Parameters.Add("item_posi", OracleDbType.Varchar2).Value = item_value["item_posi"];
                cmd.Parameters.Add("item_etc", OracleDbType.Varchar2).Value = item_value["item_etc"];
                cmd.Parameters.Add("user_sysid", OracleDbType.Varchar2).Value = item_value["user_sysid"];
                cmd.Parameters.Add("item_code", OracleDbType.Varchar2).Value = item_value["item_code"];
                cmd.ExecuteNonQuery();



                //사용자가 이미지를 넣엏을때 경우
                if (by == null)
                {

                    return;

                }
                else
                {


                    //이미지 데이터 베이스 있는지 확인
                    String sql2 = "select * from pjs_item_img where img_key = :img_key";

                    cmd2.CommandText = sql2;
                    cmd2.Parameters.Add("img_key", OracleDbType.Varchar2).Value = item_value["item_code"];
                    rs = cmd2.ExecuteReader();

                    if (rs.Read())
                    {

                        String sql3 = "update pjs_item_img set " +
                                        "img = :img " +
                                        "where img_key = :img_key";

                        cmd3.CommandText = sql3;
                        cmd3.Parameters.Add("img", OracleDbType.Blob, by.Length, by, ParameterDirection.Input);
                        cmd3.Parameters.Add("img_key", OracleDbType.Varchar2).Value = item_value["item_code"];
                        cmd3.ExecuteNonQuery();
                    }
                    else
                    {


                        String sql4 = "insert into pjs_item_img values(:img_key, :img)";
                        cmd4.CommandText = sql4;
                        cmd4.Parameters.Add("img_key", OracleDbType.Varchar2).Value = item_value["item_code"];
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



        public void delete(string item_code)
        {

            try
            {

                tran = con.BeginTransaction();
                cmd.Transaction = tran;


                String sql = "delete from pjs_item where item_code = :item_code";

                cmd.CommandText = sql;
                cmd.Parameters.Add("item_code", OracleDbType.Varchar2).Value = item_code;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();

                String sql2 = "delete from pjs_item_img where img_key = :img_key";
                
                cmd.CommandText = sql2;
                cmd.Parameters.Add("img_key", OracleDbType.Varchar2).Value = item_code;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();


                String sql3 = "delete from pjs_ipgo where ipgo_code = :item_code";
                cmd.CommandText = sql3;
                cmd.Parameters.Add("item_code", OracleDbType.Varchar2).Value = item_code;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();

                String sql4 = "delete from pjs_culgo where culgo_code = :item_code";
                cmd.CommandText = sql4;
                cmd.Parameters.Add("item_code", OracleDbType.Varchar2).Value = item_code;
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






        public void pegi(string item_code,bool checking_yn)
        {

            try
            {

                if (con == null)
                {
                    MessageBox.Show("시스템에 문제가 있으니 담당자 연락바람");

                }


                //폐기하기.
                if (checking_yn)
                {

                    String sql_update = "update pjs_item set " +
                                            "item_yn = 'y' " +
                                            "where " +
                                            "item_code = :item_code";

                    cmd2.CommandText = sql_update;
                    cmd2.Parameters.Add("item_code", OracleDbType.Varchar2).Value = item_code;
                    cmd2.ExecuteNonQuery();



                }
                //폐기취소
                else
                {

                    String sql_update = "update pjs_item set " +
                                            "item_yn = 'n' " +
                                            "where " +
                                            "item_code = :item_code";

                    cmd2.CommandText = sql_update;
                    cmd2.Parameters.Add("item_code", OracleDbType.Varchar2).Value = item_code;
                    cmd2.ExecuteNonQuery();




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


        public void pegi_cansel(string item_code)
        {


            try
            {

                if (con == null)
                {
                    MessageBox.Show("시스템에 문제가 있으니 담당자 연락바람");

                }



                String sql_find = "select * " +
                               "from pjs_item " +
                                "where item_code = :item_code";

                cmd.CommandText = sql_find;
                cmd.Parameters.Add("item_code", OracleDbType.Varchar2).Value = item_code;

                rs = cmd.ExecuteReader();

                if (rs.Read())
                {


                    if (Int32.Parse(rs["item_samt"].ToString()) == 0)
                    {
                        String sql_update = "update pjs_item set " +
                                                "item_yn = 'n' " +
                                                "where " +
                                                "item_code = :item_code";

                        cmd2.CommandText = sql_update;
                        cmd2.Parameters.Add("item_code", OracleDbType.Varchar2).Value = item_code;
                        cmd2.ExecuteNonQuery();
                        MessageBox.Show("폐기 취소 되었습니다.");
                    }
                    else
                    {
                        MessageBox.Show("재고량이 남아 있습니다.");
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





        public List<Dictionary<string,string>> get_stock()
        {


            try
            {

                if (con == null)
                {
                    MessageBox.Show("시스템에 문제가 있으니 담당자 연락바람");
                }

                //가공하기
                List<Dictionary<String, String>> item_values = new List<Dictionary<String, String>>();





                string sql_item_find = "select * from " +
                                       "(select cast(item_samt as int) as cnt, pjs_item.* from pjs_item where item_yn = 'n') " +
                                       "where rownum <= 5 " +
                                       "order by cnt desc";
                cmd.CommandText = sql_item_find;
                rs = cmd.ExecuteReader();
                
                while (rs.Read())
                {
                    Dictionary<String, String> item_value = new Dictionary<string, string>();


                    
                    item_value.Add("item_code", rs["item_code"].ToString());
                    item_value.Add("item_name", rs["item_name"].ToString());
                    item_value.Add("item_stand", rs["item_stand"].ToString());
                    item_value.Add("item_date", rs["item_date"].ToString());
                    item_value.Add("item_amt", rs["item_amt"].ToString());
                    item_value.Add("item_comp", rs["item_comp"].ToString());
                    item_value.Add("item_samt", rs["cnt"].ToString());
                    item_value.Add("item_posi", rs["item_posi"].ToString());
                    item_value.Add("item_etc", rs["item_etc"].ToString());
                    item_value.Add("user_sys", rs["user_sys"].ToString());
                    item_value.Add("user_sysid", rs["user_sysid"].ToString());


                    item_values.Add(item_value);
                }
                return item_values;

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




        









    }
}

