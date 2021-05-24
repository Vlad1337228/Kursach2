using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursach_2
{
    public partial class submitForm : Form
    {
        public submitForm()
        {
            InitializeComponent();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void SubmitForm_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

            if (checkBox1.Checked && checkBox2.Checked || !checkBox1.Checked && !checkBox2.Checked)
            {
                MessageBox.Show("Пожалуйста выбирите корректное состояние авто.");
                return;
            }

            string newOrOld = "";
            if (checkBox1.Checked)
                newOrOld = "new";
            else
                newOrOld = "old";
            if (checkBox3.Checked && checkBox4.Checked || !checkBox3.Checked && !checkBox4.Checked)
            {
                MessageBox.Show("Пожалуйста выбирите корректное поле коробки авто.");
                return;
            }
            bool flag;
            string trans = "";
            if (checkBox3.Checked)
                trans = "акпп";
            else
                trans = "мкпп";

            mainForm.user.auto = new Auto();
            var auto = mainForm.user.auto;
            auto.id = mainForm.user.id;

            try
            {
                Check(textBox3.Text);
                Check(textBox4.Text);
            }
            catch(ArgumentException exp)
            {
                MessageBox.Show("Введите корректные данные в поля фирма и марка.");
                return ;
            }

            auto.company = textBox3.Text;
            auto.mark = textBox4.Text;
            auto.transmission = trans;
            auto.new_or_old = newOrOld;
            (auto.relise, flag) = ConvertToDateTime(textBox5.Text);
            if (!flag)
                return;
            try
            {

                auto.hourse_power = int.Parse(textBox1.Text);
                auto.price = int.Parse(textBox2.Text);
            }
            catch (Exception exp)
            {
                MessageBox.Show("Введите корректные данные в поля \"Цена\" или \"Мощность двигателя\".");
                return;
            }
            InPutAytoInDB();
            mainForm._mainForm.deleteAuto.Visible = true;
            return;
        }


        private void InPutAytoInDB()
        {
           var a= mainForm.user.auto;
           using (SqlCommand command1 = new SqlCommand($"INSERT INTO [auto] (id,company,mark,relise,hourse_power,transmission,new_or_old,price) Values(@id,@company,@mark,@relise,@hourse_power,@transmission,@new_or_old,@price)", mainForm.connection))
           {
              mainForm.connection.Open();
              command1.Parameters.AddWithValue("@id",a.id);
              command1.Parameters.AddWithValue("@company", a.company);
              command1.Parameters.AddWithValue("@mark", a.mark);
              command1.Parameters.AddWithValue("@relise", a.relise);
              command1.Parameters.AddWithValue("@hourse_power",a.hourse_power );
              command1.Parameters.AddWithValue("@transmission", a.transmission);
              command1.Parameters.AddWithValue("@new_or_old",a.new_or_old );
              command1.Parameters.AddWithValue("@price",a.price );
                try
                {
                    command1.ExecuteNonQuery();
                }
              catch(Exception e)
                {
                    MessageBox.Show("У вас уже есть одно выставленное объявление. Пожалуйста удалите старое,чтобы выставить новое.");
                    return;
                }
           }
            mainForm.connection.Close();
            MessageBox.Show("Объявление добавлено.");
            this.Close();
        }
        private void Check(string s)
        {
            if (s == null)
                throw new ArgumentException();
        }
        private (DateTime,bool) ConvertToDateTime(string s)
        {
            var str = s.Split('.');
            Array.Reverse(str);
            for(int i=0;i<3;i++)
            {
                try
                {
                    int.Parse(str[i]);
                }
                catch(Exception e)
                {
                    MessageBox.Show("Введите корректные данные в поле даты.");
                    return (default(DateTime),false);
                }
            }
            int n1 =0;
            int n2 =0;
            int n3 =0;
            try
            {
                
                 n1=int.Parse(str[0]);
                 n2 = int.Parse(str[1]);
                 n3 = int.Parse(str[2]);
            }
            catch(Exception exp)
            {
                MessageBox.Show("Введите корректные данные в поле \"Год выпуска\"");
                return (default(DateTime), false);
            }
            DateTime dt =new DateTime();
            try
            {
                 dt = new DateTime(n1, n2, n3);
            }
            catch(Exception e)
            {
                MessageBox.Show("Введите корректные данные в поле \"Год выпуска\"");
                return (dt, false);
            }
            return (dt,true);
        }
        
    }
}
