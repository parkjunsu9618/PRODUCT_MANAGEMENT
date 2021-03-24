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
    public class Culgo
    {


        OracleConnection con = null;
        string connectString = "Data source = product-management.chkwjetizrxz.ap-northeast-2.rds.amazonaws.com:1521/PRODUCT;User Id=root;Password=bestrong";
        OracleCommand cmd = null;
        OracleCommand cmd2 = null;
        OracleCommand cmd3 = null;
        OracleCommand cmd4 = null;



        OracleDataReader rs;
        OracleDataReader rs2;




        public Culgo()
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





        public Dictionary<String, String> checking_culgoID(string culgo_code)
        {
            Dictionary<String, String> culgo_value = new Dictionary<string, string>();


            try
            {


                String sqlfind = "select * " +
                                "from pjs_culgo " +
                                "where culgo_code = :culgo_code";

                cmd.CommandText = sqlfind;
                cmd.Parameters.Add("culgo_code", OracleDbType.Varchar2).Value = culgo_code;

                rs = cmd.ExecuteReader();

                if (rs.Read())
                {

                    culgo_value.Add("culgo_code", rs["culgo_code"].ToString());
                    culgo_value.Add("culgo_date", rs["culgo_date"].ToString());
                    culgo_value.Add("culgo_cnt", rs["culgo_cnt"].ToString());
                    culgo_value.Add("culgo_sau", rs["culgo_sau"].ToString());
                    culgo_value.Add("culgo_amt", rs["culgo_amt"].ToString());
                    culgo_value.Add("user_sys", rs["user_sys"].ToString());
                    culgo_value.Add("user_sysid", rs["user_sysid"].ToString());
                    return culgo_value;
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


        public Dictionary<String, byte[]> checking_culgo_img(String culgo_code)
        {
            Dictionary<String, byte[]> img_value = new Dictionary<String, byte[]>();


            try
            {



                string sql = "select * from pjs_item_img where img_key = :img_key";

                cmd.CommandText = sql;
                cmd.Parameters.Add("img_key", OracleDbType.Varchar2).Value = culgo_code;


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
        public List<Dictionary<string, string>> serch(string item_name, string culgo_date, string culgo_date2)
        {
            try
            {

                //가공하기
                List<Dictionary<String, String>> culgo_values = new List<Dictionary<String, String>>();

                //date 안들어왔을때 경우 예외처리




                string sql_culgo_find = "select pjs_item.item_code, " +
                       "pjs_item.item_name, " +
                       "pjs_item.item_samt, " +
                       "pjs_culgo.culgo_date, " +
                       "pjs_culgo.culgo_cnt, " +
                       "pjs_culgo.culgo_sau, " +
                       "pjs_culgo.culgo_amt " +
                       "from pjs_item, pjs_culgo " +
                       "where pjs_culgo.culgo_code = pjs_item.item_code(+) " +
                       "and pjs_item.item_yn = 'n' " +
                       "and pjs_item.item_name like :item_name " +
                       "and pjs_culgo.culgo_date >= :culgo_date " +
                       "and pjs_culgo.culgo_date <= :culgo_date2 ";

                cmd.CommandText = sql_culgo_find;
                cmd.Parameters.Add("item_name", OracleDbType.Varchar2).Value = "%" + item_name + "%";                
                cmd.Parameters.Add("culgo_date", OracleDbType.Varchar2).Value = culgo_date;
                cmd.Parameters.Add("culgo_date2", OracleDbType.Varchar2).Value = culgo_date2;
                rs = cmd.ExecuteReader();


                

                while (rs.Read())
                {
                    Dictionary<String, String> culgo_value = new Dictionary<string, string>();




                    culgo_value.Add("item_code", rs["item_code"].ToString());
                    culgo_value.Add("item_name", rs["item_name"].ToString());
                    culgo_value.Add("item_samt", rs["item_samt"].ToString());
                    culgo_value.Add("culgo_date", rs["culgo_date"].ToString());
                    culgo_value.Add("culgo_cnt", rs["culgo_cnt"].ToString());
                    culgo_value.Add("culgo_sau", rs["culgo_sau"].ToString());
                    culgo_value.Add("culgo_amt", rs["culgo_amt"].ToString());

                    culgo_values.Add(culgo_value);
                }
                return culgo_values;

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
        public List<Dictionary<string, string>> serch_stock(string item_code, string culgo_date, string culgo_date2)
        {
            try
            {

                //가공하기
                List<Dictionary<String, String>> culgo_values = new List<Dictionary<String, String>>();

                //date 안들어왔을때 경우 예외처리




                string sql_culgo_find = "select pjs_item.item_code, " +
                       "pjs_item.item_name, " +
                       "pjs_item.item_samt, " +
                       "pjs_culgo.culgo_date, " +
                       "pjs_culgo.culgo_cnt, " +
                       "pjs_culgo.culgo_sau, " +
                       "pjs_culgo.culgo_amt " +
                       "from pjs_item, pjs_culgo " +
                       "where pjs_culgo.culgo_code = pjs_item.item_code(+) " +
                       "and pjs_item.item_yn = 'n' " +
                       "and pjs_item.item_code = :item_code " +
                       "and pjs_culgo.culgo_date >= :culgo_date " +
                       "and pjs_culgo.culgo_date <= :culgo_date2 ";

                cmd.CommandText = sql_culgo_find;
                cmd.Parameters.Add("item_code", OracleDbType.Varchar2).Value = item_code;
                cmd.Parameters.Add("culgo_date", OracleDbType.Varchar2).Value = culgo_date;
                cmd.Parameters.Add("culgo_date2", OracleDbType.Varchar2).Value = culgo_date2;
                rs = cmd.ExecuteReader();




                while (rs.Read())
                {
                    Dictionary<String, String> culgo_value = new Dictionary<string, string>();




                    culgo_value.Add("item_code", rs["item_code"].ToString());
                    culgo_value.Add("item_name", rs["item_name"].ToString());
                    culgo_value.Add("item_samt", rs["item_samt"].ToString());
                    culgo_value.Add("culgo_date", rs["culgo_date"].ToString());
                    culgo_value.Add("culgo_cnt", rs["culgo_cnt"].ToString());
                    culgo_value.Add("culgo_sau", rs["culgo_sau"].ToString());
                    culgo_value.Add("culgo_amt", rs["culgo_amt"].ToString());

                    culgo_values.Add(culgo_value);
                }
                return culgo_values;

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
        public void insert(Dictionary<String, String> culgo_value, string item_samt)
        {
            try
            {



                String sql_find = "select * " +
                                "from pjs_culgo " +
                                "where culgo_code = :culgo_code " +
                                "and culgo_date = :culgo_date";

                cmd.CommandText = sql_find;
                cmd.Parameters.Add("culgo_code", OracleDbType.Varchar2).Value = culgo_value["culgo_code"];
                cmd.Parameters.Add("culgo_date", OracleDbType.Varchar2).Value = culgo_value["culgo_date"];

                rs = cmd.ExecuteReader();

                if (rs.Read())
                {
                    MessageBox.Show("오늘 등록된 출고처리가 있습니다");
                    return;
                }
                else
                {

                    String sql_insert = "insert into pjs_culgo" +
                        "(culgo_code, culgo_date, culgo_cnt, culgo_sau,culgo_amt, user_sysid) " +
                        "values(:culgo_code, :culgo_date, :culgo_cnt, :culgo_sau, :culgo_amt, :user_sysid)";


                    cmd2.CommandText = sql_insert;

                    cmd2.Parameters.Add("culgo_code", OracleDbType.Varchar2).Value = culgo_value["culgo_code"];
                    cmd2.Parameters.Add("culgo_date", OracleDbType.Varchar2).Value = culgo_value["culgo_date"];
                    cmd2.Parameters.Add("culgo_cnt", OracleDbType.Varchar2).Value = culgo_value["culgo_cnt"];
                    cmd2.Parameters.Add("culgo_sau", OracleDbType.Varchar2).Value = culgo_value["culgo_sau"];
                    cmd2.Parameters.Add("culgo_amt", OracleDbType.Varchar2).Value = culgo_value["culgo_amt"];
                    cmd2.Parameters.Add("user_sysid", OracleDbType.Varchar2).Value = culgo_value["user_sysid"];
                    cmd2.ExecuteNonQuery();


                    //재고량값 가져오기 -- 재고량 가져오기


                    //int형 바꾸기
                    item_samt = (Int32.Parse(item_samt) - Int32.Parse(culgo_value["culgo_cnt"])).ToString();




                    //출고처리후 재고량 + 해주기. (업데이트처리)
                    String item_insert = "update pjs_item " +
                        "set item_samt = :item_samt " +
                        "where item_code = :item_code";
                    cmd4.CommandText = item_insert;
                    cmd4.Parameters.Add("item_samt", OracleDbType.Varchar2).Value = item_samt;
                    cmd4.Parameters.Add("item_code", OracleDbType.Varchar2).Value = culgo_value["culgo_code"];
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




        public void update(Dictionary<String, String> culgo_value, string item_samt)
        {

            try
            {

                String pre_culgo_select = "select * from pjs_culgo where culgo_code = :culgo_code and culgo_date = :culgo_date";



                cmd.CommandText = pre_culgo_select;
                cmd.Parameters.Add("culgo_code", OracleDbType.Varchar2).Value = culgo_value["culgo_code"];
                cmd.Parameters.Add("culgo_date", OracleDbType.Varchar2).Value = culgo_value["culgo_date"];

                rs = cmd.ExecuteReader();
                if (rs.Read())
                {


                    // 전 출고량 - 빼기
                    int pre_cnt = Int32.Parse(rs["culgo_cnt"].ToString());
                    // 들어온 출고량 - 더하기
                    int cur_cnt = Int32.Parse(culgo_value["culgo_cnt"]);

                    item_samt = (Int32.Parse(item_samt) + pre_cnt - cur_cnt).ToString();



                    //재고량처리(업데이트 처리)---
                    String item_update = "update pjs_item " +
                                "set item_samt = :item_samt " +
                                "where item_code = :item_code";

                    cmd3.CommandText = item_update;
                    cmd3.Parameters.Add("item_samt", OracleDbType.Varchar2).Value = item_samt;
                    cmd3.Parameters.Add("item_code", OracleDbType.Varchar2).Value = culgo_value["culgo_code"];
                    cmd3.ExecuteNonQuery();


                    //출고테이블 업데이트 처리
                    String culgo_update = "update pjs_culgo set " +
                                        "culgo_cnt = :culgo_cnt , " +
                                        "culgo_sau = :culgo_sau , " +
                                        "culgo_amt = :culgo_amt " +
                                        "where " +
                                        "culgo_code = :culgo_code " +
                                        "and culgo_date = :culgo_date";

                    cmd4.CommandText = culgo_update;
                    cmd4.Parameters.Add("culgo_cnt", OracleDbType.Varchar2).Value = culgo_value["culgo_cnt"];
                    cmd4.Parameters.Add("culgo_sau", OracleDbType.Varchar2).Value = culgo_value["culgo_sau"];
                    cmd4.Parameters.Add("culgo_amt", OracleDbType.Varchar2).Value = culgo_value["culgo_amt"];
                    cmd4.Parameters.Add("culgo_code", OracleDbType.Varchar2).Value = culgo_value["culgo_code"];
                    cmd4.Parameters.Add("culgo_date", OracleDbType.Varchar2).Value = culgo_value["culgo_date"];

                    cmd4.ExecuteNonQuery();


                    MessageBox.Show("수정완료");



                }
                else
                {
                    MessageBox.Show("출고테이블 출고코드가 없습니다.");
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



        public void delete(string culgo_code, string culgo_date, string item_samt)
        {

            try
            {





                String delete_sql = "delete from pjs_culgo where culgo_code = :culgo_code and culgo_date = :culgo_date";


                cmd.CommandText = delete_sql;
                cmd.Parameters.Add("culgo_code", OracleDbType.Varchar2).Value = culgo_code;
                cmd.Parameters.Add("culgo_date", OracleDbType.Varchar2).Value = culgo_date;


                //현재 재고량



                //출고 재고량
                String get_cnt_culgo = "select * from pjs_culgo where culgo_code = :culgo_code and culgo_date = :culgo_date";
                cmd3.CommandText = get_cnt_culgo;
                cmd3.Parameters.Add("culgo_code", OracleDbType.Varchar2).Value = culgo_code;
                cmd3.Parameters.Add("culgo_date", OracleDbType.Varchar2).Value = culgo_date;
                rs2 = cmd3.ExecuteReader();
                if (rs2.Read())
                {
                    //선택된 출고량.
                    int cur_cnt = Int32.Parse(rs2["culgo_cnt"].ToString());

                    item_samt = (Int32.Parse(item_samt) + cur_cnt).ToString();

                    Console.WriteLine(item_samt);

                    String update_samt = "update pjs_item " +
                                            "set item_samt = :item_samt " +
                                            "where item_code = :item_code";
                    cmd4.CommandText = update_samt;
                    cmd4.Parameters.Add("item_samt", OracleDbType.Varchar2).Value = item_samt;
                    cmd4.Parameters.Add("item_code", OracleDbType.Varchar2).Value = culgo_code;
                    cmd4.ExecuteNonQuery();

                    //삭제는 가장 나중에.
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("삭제완료");

                }
                else
                {
                    MessageBox.Show("출고 테이블 값이 없습니다.");
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






        public List<Dictionary<string, string>> get_culgo_info()
        {


            try
            {

                if (con == null)
                {
                    MessageBox.Show("시스템에 문제가 있으니 담당자 연락바람");
                }

                //가공하기
                List<Dictionary<String, String>> culgo_values = new List<Dictionary<String, String>>();




                string sql_culgo_find = "select * from " +
                       "(select pjs_item.item_code, " +
                       "pjs_item.item_name, " +
                       "pjs_item.item_samt, " +
                       "pjs_culgo.culgo_date, " +
                       "pjs_culgo.culgo_cnt, " +
                       "pjs_culgo.culgo_sau, " +
                       "pjs_culgo.culgo_amt " +
                       "from pjs_item, pjs_culgo " +
                       "where pjs_culgo.culgo_code = pjs_item.item_code(+) " +
                       "and pjs_item.item_yn = 'n' " +
                       "order by pjs_culgo.user_sys desc) " +
                       "where rownum <= 10 ";


                cmd.CommandText = sql_culgo_find;
                rs = cmd.ExecuteReader();

                while (rs.Read())
                {
                    Dictionary<String, String> culgo_value = new Dictionary<string, string>();






                    culgo_value.Add("item_code", rs["item_code"].ToString());
                    culgo_value.Add("item_name", rs["item_name"].ToString());
                    culgo_value.Add("item_samt", rs["item_samt"].ToString());
                    culgo_value.Add("culgo_date", rs["culgo_date"].ToString());
                    culgo_value.Add("culgo_cnt", rs["culgo_cnt"].ToString());
                    culgo_value.Add("culgo_sau", rs["culgo_sau"].ToString());
                    culgo_value.Add("culgo_amt", rs["culgo_amt"].ToString());




                    culgo_values.Add(culgo_value);
                }
                return culgo_values;

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

        




        public List<Dictionary<string, string>> get_culgo_best()
        {


            try
            {

                if (con == null)
                {
                    MessageBox.Show("시스템에 문제가 있으니 담당자 연락바람");
                }

                //가공하기
                List<Dictionary<String, String>> culgo_values = new List<Dictionary<String, String>>();


                //1.조인 -> 이름 가지고오기
                //2.출고량 합.
                //3.일주일전 구하기
                //4.5개만 빼오기
                

                //5개만 가져오기.
                string sql_culgo_find = "select * from " +
                                        //조인 이름가지고오기
                                        " (select pjs_item.ITEM_NAME, culgo.sum from pjs_item, " +
                                        // 출고량합
                                        "    (select sum(cast(CULGO_CNT as int)) as sum, CULGO_CODE from " +
                                        //일주일전 날짜 구하기
                                        "        (select user_sys, CULGO_CODE, CULGO_CNT from pjs_culgo where " +
                                        "                user_sys >= (select sysdate - 7 as last_week from dual)) " +
                                        "    group by  CULGO_CODE order by sum desc) culgo " +
                                        " where culgo.CULGO_CODE = pjs_item.item_code(+) " +
                                        " and pjs_item.item_yn = 'n') " +
                                        " where rownum <= 5";


                cmd.CommandText = sql_culgo_find;
                rs = cmd.ExecuteReader();

                while (rs.Read())
                {
                    Dictionary<String, String> culgo_value = new Dictionary<string, string>();


                    
                    culgo_value.Add("item_name", rs["item_name"].ToString());
                    culgo_value.Add("sum", rs["sum"].ToString());
                    
                    culgo_values.Add(culgo_value);
                }
                return culgo_values;

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

