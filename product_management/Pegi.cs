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
    public class Pegi
    {


        OracleConnection con = null;
        string connectString = "Data source = product-management.chkwjetizrxz.ap-northeast-2.rds.amazonaws.com:1521/PRODUCT;User Id=root;Password=bestrong";
        OracleCommand cmd = null;
        OracleCommand cmd2 = null;
        OracleCommand cmd3 = null;
        OracleCommand cmd4 = null;



        OracleDataReader rs;
        OracleDataReader rs2;




        public Pegi()
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





        public Dictionary<String, String> checking_pegiID(string pegi_code)
        {
            Dictionary<String, String> pegi_value = new Dictionary<string, string>();


            try
            {


                String sqlfind = "select * " +
                                "from pjs_pegi " +
                                "where pegi_code = :pegi_code";

                cmd.CommandText = sqlfind;
                cmd.Parameters.Add("pegi_code", OracleDbType.Varchar2).Value = pegi_code;

                rs = cmd.ExecuteReader();

                if (rs.Read())
                {

                    pegi_value.Add("pegi_code", rs["pegi_code"].ToString());
                    pegi_value.Add("pegi_date", rs["pegi_date"].ToString());
                    pegi_value.Add("pegi_cnt", rs["pegi_cnt"].ToString());
                    pegi_value.Add("pegi_sau", rs["pegi_sau"].ToString());                    
                    pegi_value.Add("user_sys", rs["user_sys"].ToString());
                    pegi_value.Add("user_sysid", rs["user_sysid"].ToString());
                    return pegi_value;
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


        public Dictionary<String, byte[]> checking_pegi_img(String pegi_code)
        {
            Dictionary<String, byte[]> img_value = new Dictionary<String, byte[]>();


            try
            {



                string sql = "select * from pjs_item_img where img_key = :img_key";

                cmd.CommandText = sql;
                cmd.Parameters.Add("img_key", OracleDbType.Varchar2).Value = pegi_code;


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
        public List<Dictionary<string, string>> serch(string item_name, string pegi_date, string pegi_date2)
        {
            try
            {

                //가공하기
                List<Dictionary<String, String>> pegi_values = new List<Dictionary<String, String>>();

                //date 안들어왔을때 경우 예외처리




                string sql_pegi_find = "select pjs_item.item_code, " +
                       "pjs_item.item_name, " +
                       "pjs_item.item_samt, " +
                       "pjs_pegi.pegi_date, " +
                       "pjs_pegi.pegi_cnt, " +
                       "pjs_pegi.pegi_sau " +
                       "from pjs_item, pjs_pegi " +
                       "where pjs_pegi.pegi_code = pjs_item.item_code(+) " +
                       "and pjs_item.item_yn = 'y' "+
                       "and pjs_item.item_name like :item_name " +
                       "and pjs_pegi.pegi_date >= :pegi_date " +
                       "and pjs_pegi.pegi_date <= :pegi_date2 ";

                cmd.CommandText = sql_pegi_find;
                cmd.Parameters.Add("item_name", OracleDbType.Varchar2).Value = "%" + item_name + "%";
                cmd.Parameters.Add("pegi_date", OracleDbType.Varchar2).Value = pegi_date;
                cmd.Parameters.Add("pegi_date2", OracleDbType.Varchar2).Value = pegi_date2;
                rs = cmd.ExecuteReader();




                while (rs.Read())
                {
                    Dictionary<String, String> pegi_value = new Dictionary<string, string>();




                    pegi_value.Add("item_code", rs["item_code"].ToString());
                    pegi_value.Add("item_name", rs["item_name"].ToString());
                    pegi_value.Add("item_samt", rs["item_samt"].ToString());
                    pegi_value.Add("pegi_date", rs["pegi_date"].ToString());
                    pegi_value.Add("pegi_cnt", rs["pegi_cnt"].ToString());
                    pegi_value.Add("pegi_sau", rs["pegi_sau"].ToString());


                    pegi_values.Add(pegi_value);
                }
                return pegi_values;

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
        public void insert(Dictionary<String, String> pegi_value, string item_samt)
        {
            try
            {



                String sql_find = "select * " +
                                "from pjs_pegi " +
                                "where pegi_code = :pegi_code " +
                                "and pegi_date = :pegi_date";

                cmd.CommandText = sql_find;
                cmd.Parameters.Add("pegi_code", OracleDbType.Varchar2).Value = pegi_value["pegi_code"];
                cmd.Parameters.Add("pegi_date", OracleDbType.Varchar2).Value = pegi_value["pegi_date"];

                rs = cmd.ExecuteReader();

                if (rs.Read())
                {
                    MessageBox.Show("오늘 등록된 폐기처리가 있습니다");
                    return;
                }
                else
                {


                    //insert 가 아닌 업데이트로 폐기 
                    String sql_insert = "insert into pjs_pegi" +
                        "(pegi_code, pegi_date, pegi_cnt, pegi_sau, user_sysid) " +
                        "values(:pegi_code, :pegi_date, :pegi_cnt, :pegi_sau, :user_sysid)";


                    cmd2.CommandText = sql_insert;

                    cmd2.Parameters.Add("pegi_code", OracleDbType.Varchar2).Value = pegi_value["pegi_code"];
                    cmd2.Parameters.Add("pegi_date", OracleDbType.Varchar2).Value = pegi_value["pegi_date"];
                    cmd2.Parameters.Add("pegi_cnt", OracleDbType.Varchar2).Value = pegi_value["pegi_cnt"];
                    cmd2.Parameters.Add("pegi_sau", OracleDbType.Varchar2).Value = pegi_value["pegi_sau"];
                    cmd2.Parameters.Add("user_sysid", OracleDbType.Varchar2).Value = pegi_value["user_sysid"];
                    cmd2.ExecuteNonQuery();


                    //재고량값 가져오기 -- 재고량 가져오기


                    //int형 바꾸기
                    item_samt = (Int32.Parse(item_samt) - Int32.Parse(pegi_value["pegi_cnt"])).ToString();




                    //폐기처리후 재고량 + 해주기. (업데이트처리)
                    String item_insert = "update pjs_item " +
                        "set item_samt = :item_samt " +
                        "where item_code = :item_code";
                    cmd4.CommandText = item_insert;
                    cmd4.Parameters.Add("item_samt", OracleDbType.Varchar2).Value = item_samt;
                    cmd4.Parameters.Add("item_code", OracleDbType.Varchar2).Value = pegi_value["pegi_code"];
                    cmd4.ExecuteNonQuery();


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




        public void update(Dictionary<String, String> pegi_value, string item_samt)
        {

            try
            {

                String pre_pegi_select = "select * from pjs_pegi where pegi_code = :pegi_code and pegi_date = :pegi_date";



                cmd.CommandText = pre_pegi_select;
                cmd.Parameters.Add("pegi_code", OracleDbType.Varchar2).Value = pegi_value["pegi_code"];
                cmd.Parameters.Add("pegi_date", OracleDbType.Varchar2).Value = pegi_value["pegi_date"];

                rs = cmd.ExecuteReader();
                if (rs.Read())
                {


                    // 전 폐기량 - 빼기
                    int pre_cnt = Int32.Parse(rs["pegi_cnt"].ToString());
                    // 들어온 폐기량 - 더하기
                    int cur_cnt = Int32.Parse(pegi_value["pegi_cnt"]);

                    item_samt = (Int32.Parse(item_samt) + pre_cnt - cur_cnt).ToString();



                    //재고량처리(업데이트 처리)---
                    String item_update = "update pjs_item " +
                                "set item_samt = :item_samt " +
                                "where item_code = :item_code";

                    cmd3.CommandText = item_update;
                    cmd3.Parameters.Add("item_samt", OracleDbType.Varchar2).Value = item_samt;
                    cmd3.Parameters.Add("item_code", OracleDbType.Varchar2).Value = pegi_value["pegi_code"];
                    cmd3.ExecuteNonQuery();


                    //폐기테이블 업데이트 처리
                    String pegi_update = "update pjs_pegi set " +
                                        "pegi_cnt = :pegi_cnt , " +
                                        "pegi_sau = :pegi_sau  " +                                        
                                        "where " +
                                        "pegi_code = :pegi_code " +
                                        "and pegi_date = :pegi_date";

                    cmd4.CommandText = pegi_update;
                    cmd4.Parameters.Add("pegi_cnt", OracleDbType.Varchar2).Value = pegi_value["pegi_cnt"];
                    cmd4.Parameters.Add("pegi_sau", OracleDbType.Varchar2).Value = pegi_value["pegi_sau"];                 
                    cmd4.Parameters.Add("pegi_code", OracleDbType.Varchar2).Value = pegi_value["pegi_code"];
                    cmd4.Parameters.Add("pegi_date", OracleDbType.Varchar2).Value = pegi_value["pegi_date"];

                    cmd4.ExecuteNonQuery();


                    MessageBox.Show("수정완료");



                }
                else
                {
                    MessageBox.Show("폐기테이블 폐기코드가 없습니다.");
                    return;
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



        public void delete(string pegi_code, string pegi_date, string item_samt)
        {

            try
            {





                String delete_sql = "delete from pjs_pegi where pegi_code = :pegi_code and pegi_date = :pegi_date";


                cmd.CommandText = delete_sql;
                cmd.Parameters.Add("pegi_code", OracleDbType.Varchar2).Value = pegi_code;
                cmd.Parameters.Add("pegi_date", OracleDbType.Varchar2).Value = pegi_date;


                //현재 재고량



                //폐기 재고량
                String get_cnt_pegi = "select * from pjs_pegi where pegi_code = :pegi_code and pegi_date = :pegi_date";
                cmd3.CommandText = get_cnt_pegi;
                cmd3.Parameters.Add("pegi_code", OracleDbType.Varchar2).Value = pegi_code;
                cmd3.Parameters.Add("pegi_date", OracleDbType.Varchar2).Value = pegi_date;
                rs2 = cmd3.ExecuteReader();
                if (rs2.Read())
                {
                    //선택된 폐기량.
                    int cur_cnt = Int32.Parse(rs2["pegi_cnt"].ToString());

                    item_samt = (Int32.Parse(item_samt) + cur_cnt).ToString();

                    Console.WriteLine(item_samt);

                    String update_samt = "update pjs_item " +
                                            "set item_samt = :item_samt " +
                                            "where item_code = :item_code";
                    cmd4.CommandText = update_samt;
                    cmd4.Parameters.Add("item_samt", OracleDbType.Varchar2).Value = item_samt;
                    cmd4.Parameters.Add("item_code", OracleDbType.Varchar2).Value = pegi_code;
                    cmd4.ExecuteNonQuery();

                    //삭제는 가장 나중에.
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("삭제완료");

                }
                else
                {
                    MessageBox.Show("폐기 테이블 값이 없습니다.");
                    return;
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




    }
}

