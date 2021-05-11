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
        private int id;
        private long telephone;
        private string password;
        private string name;
        private string second_name;

        public bool InPutUser(SqlDataReader sql)
        {
            try
            {
                while (sql.Read())
                {
                    this.id = int.Parse(sql.GetString(0));
                    this.telephone = long.Parse(sql.GetString(1));
                    this.password = sql.GetString(2);
                    this.name = sql.GetString(3);
                    this.second_name = sql.GetString(4);
                   
                }
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
