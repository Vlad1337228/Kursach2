using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursach_2
{
    public class User
    {
        public int id;
        public long telephone;
        public string password;
        public string name;
        public string second_name;
        public Auto auto;

        public bool OutPutUser(SqlDataReader sql)
        {
            try
            {
                //SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
                //sqlDataAdapter.SelectCommand = sql;
                //DataTable dt = new DataTable();
                //sqlDataAdapter.
                //sqlDataAdapter.Fill(dt);
                //this.id = int.Parse(sql.GetString(0));
                //this.telephone = long.Parse(sql.GetString(1));
                //this.password = sql.GetString(2);
                //this.name = sql.GetString(3);
                //this.second_name = sql.GetString(4);
                sql.Read();
                this.id = (Int32)sql.GetValue(0);
                this.telephone = (long)sql.GetValue(1);
                this.password = sql.GetValue(2).ToString();
                this.name = sql.GetValue(3).ToString();
                this.second_name = sql.GetValue(4).ToString();


                return true;
            }
            catch(Exception e)
            {
                MessageBox.Show("Ошибка системы. Название ошибки: "+e);
                return false;
            }
            
        }
    }
}
