using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace kursach_2
{
    public class Auto
    {
        public int id;
        public string company;
        public string mark;
        public DateTime relise;
        public int hourse_power;
        public string transmission;
        public string new_or_old;
        public int price;

        public bool OutPutAuto(SqlDataReader sql)
        {
            try
            {
                sql.Read();
                this.id = (Int32)sql.GetValue(0);
                this.company = (string)sql.GetValue(1);
                this.mark= (string)sql.GetValue(2);
                this.relise = (DateTime)sql.GetValue(3);
                this.hourse_power = (int)sql.GetValue(4);
                this.transmission = sql.GetValue(6).ToString();
                this.new_or_old = sql.GetValue(7).ToString();
                this.price = (int)sql.GetValue(8);

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Ошибка "+e);
                return false;
            }

        }
    }

   
}