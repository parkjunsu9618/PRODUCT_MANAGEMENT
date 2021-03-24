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
    public class Ipgo
    {


        OracleConnection con = null;
        string connectString = "Data source = product-management.chkwjetizrxz.ap-northeast-2.rds.amazonaws.com:1521/PRODUCT;User Id=root;Password=bestrong";
        OracleCommand cmd = null;
        OracleCommand cmd2 = null;
        OracleCommand cmd3 = null;
        OracleCommand cmd4 = null;



        OracleDataReader rs;
        OracleDataReader rs2;




        public Ipgo()
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





        public Dictionary<String, String> checking_ipgoID(string ipgo_code)
        {
            Dictionary<String, String> ipgo_value = new Dictionary<string, string>();


            try
            {


                String sqlfind = "select * " +
                                "from pjs_ipgo " +
                                "where ipgo_code = :ipgo_code";

                cmd.CommandText = sqlfind;
                cmd.Parameters.Add("ipgo_code", OracleDbType.Varchar2).Value = ipgo_code;

                rs = cmd.ExecuteReader();

                if (rs.Read())
                {

                    ipgo_value.Add("ipgo_code", rs["ipgo_code"].ToString());
                    ipgo_value.Add("ipgo_date", rs["ipgo_date"].ToString());
                    ipgo_value.Add("ipgo_cnt", rs["ipgo_cnt"].ToString());
                    ipgo_value.Add("ipgo_comp", rs["ipgo_comp"].ToString());
                    ipgo_value.Add("ipgo_amt", rs["ipgo_amt"].ToString());
                    ipgo_value.Add("user_sys", rs["user_sys"].ToString());
                    ipgo_value.Add("user_sysid", rs["user_sysid"].ToString());                   
                    return ipgo_value;
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


        public Dictionary<String, byte[]> checking_ipgo_img(String ipgo_code)
        {
            Dictionary<String, byte[]> img_value = new Dictionary<String, byte[]>();


            try
            {



                string sql = "select * from pjs_item_img where img_key = :img_key";

                cmd.CommandText = sql;
                cmd.Parameters.Add("img_key", OracleDbType.Varchar2).Value = ipgo_code;


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
        public List<Dictionary<string, string>> serch(string item_name,string ipgo_comp, string ipgo_date, string ipgo_date2)
        {
            try
            {

                //가공하기
                List<Dictionary<String, String>> ipgo_values = new List<Dictionary<String, String>>();

                //date 안들어왔을때 경우 예외처리

                


                string sql_ipgo_find = "select pjs_item.item_code, " +
                       "pjs_item.item_name, " +
                       "pjs_item.item_samt, " +
                       "pjs_ipgo.ipgo_date, " +
                       "pjs_ipgo.ipgo_cnt, " +
                       "pjs_ipgo.ipgo_comp, " +
                       "pjs_ipgo.ipgo_amt " +
                       "from pjs_item, pjs_ipgo " +
                       "where pjs_ipgo.ipgo_code = pjs_item.item_code(+) " +
                       "and pjs_item.item_yn = 'n'" +
                       "and pjs_item.item_name like :item_name " +
                       "and pjs_ipgo.ipgo_comp like :ipgo_comp " +
                       "and pjs_ipgo.ipgo_date >= :ipgo_date " +
                       "and pjs_ipgo.ipgo_date <= :ipgo_date2 ";
                
                cmd.CommandText = sql_ipgo_find;
                cmd.Parameters.Add("item_name", OracleDbType.Varchar2).Value = "%" + item_name + "%";
                cmd.Parameters.Add("ipgo_comp", OracleDbType.Varchar2).Value = "%" + ipgo_comp + "%";
                cmd.Parameters.Add("ipgo_date", OracleDbType.Varchar2).Value = ipgo_date;
                cmd.Parameters.Add("ipgo_date2", OracleDbType.Varchar2).Value = ipgo_date2;
                rs = cmd.ExecuteReader();
                
                while (rs.Read())
                {
                    Dictionary<String, String> ipgo_value = new Dictionary<string, string>();




                    ipgo_value.Add("item_code", rs["item_code"].ToString());
                    ipgo_value.Add("item_name", rs["item_name"].ToString());
                    ipgo_value.Add("item_samt", rs["item_samt"].ToString());                    
                    ipgo_value.Add("ipgo_date", rs["ipgo_date"].ToString());
                    ipgo_value.Add("ipgo_cnt", rs["ipgo_cnt"].ToString());                          
                    ipgo_value.Add("ipgo_comp", rs["ipgo_comp"].ToString());
                    ipgo_value.Add("ipgo_amt", rs["ipgo_amt"].ToString());

                    ipgo_values.Add(ipgo_value);
                }
                return ipgo_values;

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
        public List<Dictionary<string, string>> serch_stock(string item_code, string ipgo_date, string ipgo_date2)
        {
            try
            {

                //가공하기
                List<Dictionary<String, String>> ipgo_values = new List<Dictionary<String, String>>();

                //date 안들어왔을때 경우 예외처리




                string sql_ipgo_find = "select pjs_item.item_code, " +
                       "pjs_item.item_name, " +
                       "pjs_item.item_samt, " +
                       "pjs_ipgo.ipgo_date, " +
                       "pjs_ipgo.ipgo_cnt, " +
                       "pjs_ipgo.ipgo_comp, " +
                       "pjs_ipgo.ipgo_amt " +
                       "from pjs_item, pjs_ipgo " +
                       "where pjs_ipgo.ipgo_code = pjs_item.item_code(+) " +
                       "and pjs_item.item_yn = 'n'" +
                       "and pjs_item.item_code = :item_code " +
                       "and pjs_ipgo.ipgo_date >= :ipgo_date " +
                       "and pjs_ipgo.ipgo_date <= :ipgo_date2 ";

                cmd.CommandText = sql_ipgo_find;
                cmd.Parameters.Add("item_code", OracleDbType.Varchar2).Value = item_code;                
                cmd.Parameters.Add("ipgo_date", OracleDbType.Varchar2).Value = ipgo_date;
                cmd.Parameters.Add("ipgo_date2", OracleDbType.Varchar2).Value = ipgo_date2;
                rs = cmd.ExecuteReader();

                while (rs.Read())
                {
                    Dictionary<String, String> ipgo_value = new Dictionary<string, string>();




                    ipgo_value.Add("item_code", rs["item_code"].ToString());
                    ipgo_value.Add("item_name", rs["item_name"].ToString());
                    ipgo_value.Add("item_samt", rs["item_samt"].ToString());
                    ipgo_value.Add("ipgo_date", rs["ipgo_date"].ToString());
                    ipgo_value.Add("ipgo_cnt", rs["ipgo_cnt"].ToString());
                    ipgo_value.Add("ipgo_comp", rs["ipgo_comp"].ToString());
                    ipgo_value.Add("ipgo_amt", rs["ipgo_amt"].ToString());

                    ipgo_values.Add(ipgo_value);
                }
                return ipgo_values;

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
        public void insert(Dictionary<String, String> ipgo_value, string item_samt)
        {
            try
            {



                String sql_find = "select * " +
                                "from pjs_ipgo " +
                                "where ipgo_code = :ipgo_code " +
                                "and ipgo_date = :ipgo_date";

                cmd.CommandText = sql_find;
                cmd.Parameters.Add("ipgo_code", OracleDbType.Varchar2).Value = ipgo_value["ipgo_code"];
                cmd.Parameters.Add("ipgo_date", OracleDbType.Varchar2).Value = ipgo_value["ipgo_date"];

                rs = cmd.ExecuteReader();

                if (rs.Read())
                {
                    MessageBox.Show("오늘 등록된 입고처리가 있습니다");
                    return;
                }
                else
                {

                    String sql_insert = "insert into pjs_ipgo" +
                        "(ipgo_code, ipgo_date, ipgo_cnt, ipgo_comp,ipgo_amt, user_sysid) " +
                        "values(:ipgo_code, :ipgo_date, :ipgo_cnt, :ipgo_comp, :ipgo_amt, :user_sysid)";


                    cmd2.CommandText = sql_insert;

                    cmd2.Parameters.Add("ipgo_code", OracleDbType.Varchar2).Value = ipgo_value["ipgo_code"];
                    cmd2.Parameters.Add("ipgo_date", OracleDbType.Varchar2).Value = ipgo_value["ipgo_date"];
                    cmd2.Parameters.Add("ipgo_cnt", OracleDbType.Varchar2).Value = ipgo_value["ipgo_cnt"];
                    cmd2.Parameters.Add("ipgo_comp", OracleDbType.Varchar2).Value = ipgo_value["ipgo_comp"];
                    cmd2.Parameters.Add("ipgo_amt", OracleDbType.Varchar2).Value = ipgo_value["ipgo_amt"];
                    cmd2.Parameters.Add("user_sysid", OracleDbType.Varchar2).Value = ipgo_value["user_sysid"];                          
                    cmd2.ExecuteNonQuery();
                    

                    //재고량값 가져오기 -- 재고량 가져오기


                    //int형 바꾸기
                    string item_samt_value = (Int32.Parse(item_samt) + Int32.Parse(ipgo_value["ipgo_cnt"])).ToString();

                        


                    //입고처리후 재고량 + 해주기. (업데이트처리)
                    String item_insert = "update pjs_item " +
                        "set item_samt = :item_samt " +
                        "where item_code = :item_code";
                    cmd4.CommandText = item_insert;
                    cmd4.Parameters.Add("item_samt", OracleDbType.Varchar2).Value = item_samt_value;
                    cmd4.Parameters.Add("item_code", OracleDbType.Varchar2).Value = ipgo_value["ipgo_code"];
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




        public void update(Dictionary<String, String> ipgo_value,string item_samt)
        {

            try
            {

                String pre_ipgo_select = "select * from pjs_ipgo where ipgo_code = :ipgo_code and ipgo_date = :ipgo_date";



                cmd.CommandText = pre_ipgo_select;
                cmd.Parameters.Add("ipgo_code", OracleDbType.Varchar2).Value = ipgo_value["ipgo_code"];
                cmd.Parameters.Add("ipgo_date", OracleDbType.Varchar2).Value = ipgo_value["ipgo_date"];

                rs = cmd.ExecuteReader();
                if (rs.Read())
                {


                    // 전 입고량 - 빼기
                    int pre_cnt = Int32.Parse(rs["ipgo_cnt"].ToString());
                    // 들어온 입고량 - 더하기
                    int cur_cnt = Int32.Parse(ipgo_value["ipgo_cnt"]);

                    item_samt = (Int32.Parse(item_samt) - pre_cnt + cur_cnt).ToString();



                    //재고량처리(업데이트 처리)---
                    String item_update = "update pjs_item " +
                                "set item_samt = :item_samt " +
                                "where item_code = :item_code";

                    cmd3.CommandText = item_update;
                    cmd3.Parameters.Add("item_samt", OracleDbType.Varchar2).Value = item_samt;
                    cmd3.Parameters.Add("item_code", OracleDbType.Varchar2).Value = ipgo_value["ipgo_code"];
                    cmd3.ExecuteNonQuery();


                    //입고테이블 업데이트 처리
                    String ipgo_update = "update pjs_ipgo set " +
                                        "ipgo_cnt = :ipgo_cnt , " +
                                        "ipgo_comp = :ipgo_comp , " +
                                        "ipgo_amt = :ipgo_amt " +
                                        "where " +
                                        "ipgo_code = :ipgo_code " +
                                        "and ipgo_date = :ipgo_date";
                        
                    cmd4.CommandText = ipgo_update;
                    cmd4.Parameters.Add("ipgo_cnt", OracleDbType.Varchar2).Value = ipgo_value["ipgo_cnt"];
                    cmd4.Parameters.Add("ipgo_comp", OracleDbType.Varchar2).Value = ipgo_value["ipgo_comp"];
                    cmd4.Parameters.Add("ipgo_amt", OracleDbType.Varchar2).Value = ipgo_value["ipgo_amt"];
                    cmd4.Parameters.Add("ipgo_code", OracleDbType.Varchar2).Value = ipgo_value["ipgo_code"];
                    cmd4.Parameters.Add("ipgo_date", OracleDbType.Varchar2).Value = ipgo_value["ipgo_date"];                        

                    cmd4.ExecuteNonQuery();

                        
                    MessageBox.Show("수정완료");
                       
                    

                }
                else
                {
                    MessageBox.Show("입고테이블 입고코드가 없습니다.");
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



        public void delete(string ipgo_code,string ipgo_date, string item_samt)
        {

            try
            {





                String delete_sql = "delete from pjs_ipgo where ipgo_code = :ipgo_code and ipgo_date = :ipgo_date";


                cmd.CommandText = delete_sql;
                cmd.Parameters.Add("ipgo_code", OracleDbType.Varchar2).Value = ipgo_code;
                cmd.Parameters.Add("ipgo_date", OracleDbType.Varchar2).Value = ipgo_date;
                

                //현재 재고량



                //입고 재고량
                String get_cnt_ipgo = "select * from pjs_ipgo where ipgo_code = :ipgo_code and ipgo_date = :ipgo_date";
                cmd3.CommandText = get_cnt_ipgo;
                cmd3.Parameters.Add("ipgo_code", OracleDbType.Varchar2).Value = ipgo_code;
                cmd3.Parameters.Add("ipgo_date", OracleDbType.Varchar2).Value = ipgo_date;
                rs2 = cmd3.ExecuteReader();
                if (rs2.Read())
                {
                    //선택된 입고량.
                    int cur_cnt = Int32.Parse(rs2["ipgo_cnt"].ToString());

                    item_samt = (Int32.Parse(item_samt) - cur_cnt).ToString();

                    Console.WriteLine(item_samt);

                    String update_samt = "update pjs_item " +
                                            "set item_samt = :item_samt " +
                                            "where item_code = :item_code";
                    cmd4.CommandText = update_samt;
                    cmd4.Parameters.Add("item_samt", OracleDbType.Varchar2).Value = item_samt;
                    cmd4.Parameters.Add("item_code", OracleDbType.Varchar2).Value = ipgo_code;
                    cmd4.ExecuteNonQuery();

                    //삭제는 가장 나중에.
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("삭제완료");

                }
                else
                {
                    MessageBox.Show("입고 테이블 값이 없습니다.");
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



        public List<Dictionary<string, string>> get_ipgo_info()
        {


            try
            {

                if (con == null)
                {
                    MessageBox.Show("시스템에 문제가 있으니 담당자 연락바람");
                }

                //가공하기
                List<Dictionary<String, String>> ipgo_values = new List<Dictionary<String, String>>();





                string sql_item_find = "select * from " +
                                       "(select pjs_item.item_code, " +
                                       "pjs_item.item_name, " +
                                       "pjs_item.item_samt, " +
                                       "pjs_ipgo.ipgo_date, " +
                                       "pjs_ipgo.ipgo_cnt, " +
                                       "pjs_ipgo.ipgo_comp, " +
                                       "pjs_ipgo.ipgo_amt " +
                                       "from pjs_item, pjs_ipgo " +
                                       "where pjs_ipgo.ipgo_code = pjs_item.item_code(+) " +
                                       "and pjs_item.item_yn = 'n' " +
                                       "order by pjs_ipgo.user_sys desc) " +
                                       "where rownum <= 10";


               
                cmd.CommandText = sql_item_find;
                rs = cmd.ExecuteReader();

                while (rs.Read())
                {
                    Dictionary<String, String> ipgo_value = new Dictionary<string, string>();

                    



                    ipgo_value.Add("item_code", rs["item_code"].ToString());
                    ipgo_value.Add("item_name", rs["item_name"].ToString());
                    ipgo_value.Add("item_samt", rs["item_samt"].ToString());
                    ipgo_value.Add("ipgo_date", rs["ipgo_date"].ToString());
                    ipgo_value.Add("ipgo_cnt", rs["ipgo_cnt"].ToString());
                    ipgo_value.Add("ipgo_comp", rs["ipgo_comp"].ToString());
                    ipgo_value.Add("ipgo_amt", rs["ipgo_amt"].ToString());




                    ipgo_values.Add(ipgo_value);
                }
                return ipgo_values;

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

