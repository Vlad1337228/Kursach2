using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursach_2
{
    public partial class filterCars : Form
    {
        public filterCars()
        {
            InitializeComponent();
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            mainForm m1 = new mainForm();
            this.Hide();
            m1.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string request;
            List<string> list = new List<string>();

            try
            {
                list.Add(Check_NewOrOld());
            }
            catch
            {
                MessageBox.Show("Пожалуйста выбирите корректные данные в поле \"Состояние авто\".");
                return;
            }

            try
            {
                list.Add(Check_trans());
            }
            catch
            {
                MessageBox.Show("Пожалуйста выбирите корректные данные в поле \"Тип КПП\".");
                return;
            }

            try
            {
                list.Add(Check_Price());
            }
            catch
            {
                MessageBox.Show("Введите корректные данные в поля \"Цена\"");
                return;
            }

            try
            {
                list.Add(Check_Year());
            }
            catch
            {
                MessageBox.Show("Введите корректные данные в поля \"Год выпуска\"");
                return;
            }
            if(Check_str(textBox4.Text))
            {
                var s = " company ='" + textBox4.Text + "'";
                list.Add(s);
            }
            if (Check_str(textBox5.Text))
            {
                var s = " mark='" + textBox5.Text + "'";
                list.Add(s);
            }

            try
            {
                list.Add(Check_HP());
            }
            catch
            {
                MessageBox.Show("Введите корректные данные в поле \"Мощность двигателя\".");
                return;
            }

            request=FormatStringForDB(list);

            using (SqlCommand command = new SqlCommand(request, mainForm.connection))
            {
                mainForm.connection.Open();
                command.ExecuteNonQuery();
                SqlDataReader sqlDataReader = command.ExecuteReader();
                OutAuto(sqlDataReader);
                sqlDataReader.Close();
            }

            mainForm.connection.Close();
        }

        private void OutAuto(SqlDataReader sql)
        {
            List<Auto> auto = new List<Auto>();
            while (sql.Read())
            {
                Auto car = new Auto();
                car.id = (Int32)sql.GetValue(0);
                car.company = (string)sql.GetValue(1);
                car.mark = (string)sql.GetValue(2);
                car.relise = (DateTime)sql.GetValue(3);
                car.hourse_power = (int)sql.GetValue(4);
                car.transmission = sql.GetValue(5).ToString();
                car.new_or_old = sql.GetValue(6).ToString();
                car.price = (int)sql.GetValue(7);
                auto.Add(car);
            }
            mainForm.list_auto = auto;
        }

        private string FormatStringForDB(List<string> list)
        {
            string str = "SELECT * FROM auto ";
            int e=0;
            int n;
            for(int i=0;i<list.Count;i++)
            {
                if (list[i] != null)
                    e = i;
            }
            if(e!=0)
            {
                str += " WHERE ";
            }
            if (e == 0 && e==list.Count)
                n = list.Count;
            else
                n = e ;
            for(int i=0;i<n;i++)
            {
                if(list[i]!=null)
                {
                    
                    str += list[i];
                    str += " AND ";
                }
            }
            str += list[n];
            return str;
        }

        private string Check_HP()
        {
            int p1 = 0;
            int p2 = 0;
            if (textBox10.Text == "" && textBox11.Text == "")
            {
                return null;
            }
            if (textBox10.Text != "" && textBox11.Text == "")
            {
                p1 = int.Parse(textBox10.Text);
                return string.Format($" hourse_power >= '" + p1.ToString() + "' ");
            }
            if (textBox10.Text == "" && textBox11.Text != "")
            {
                p2 = int.Parse(textBox2.Text);
                return string.Format($" hourse_power <= '"+ p2.ToString() + "' ");
            }
            if (textBox10.Text != "" && textBox11.Text != "")
            {
                p1 = int.Parse(textBox10.Text);
                p2 = int.Parse(textBox2.Text);
                return string.Format($" hourse_power BETWEEN '"+ p1.ToString()+"' AND '"+ p2.ToString() + "' ");
            }
            else
            {
                throw new Exception();
            }
        }
        private bool Check_str(string s)
        {
            if (s != "")
                return true;
            return false;
        }

        private string Check_Year()
        {
            if (textBox9.Text == "" && textBox8.Text == "")
            {
                return null;
            }
            if (textBox9.Text != "" && textBox8.Text == "")
            {
                return string.Format($" relise >= ' " + textBox9.Text +"-01-01' ");
            }
            if (textBox9.Text == "" && textBox8.Text != "")
            {
                return string.Format($" relise <= + '" + textBox8.Text + "-12-31' ");
            }
            if (textBox9.Text != "" && textBox8.Text != "")
            {
                return string.Format($" relise BETWEEN '"+ textBox9.Text + "-01-01' AND  '"  +textBox8.Text + "-12-31' " );
            }
            else
            {
                throw new Exception();
            }
        }
        private string Check_Price()
        {
            int p1= 0;
            int p2 =0;
            if (textBox1.Text=="" && textBox2.Text=="")
            {
                return null;
            }
            if(textBox1.Text != "" && textBox2.Text == "")
            {
                p1 = int.Parse(textBox1.Text);
                return string.Format($" price >=  '"+ p1.ToString()+"' ");
            }
            if (textBox1.Text == "" && textBox2.Text != "")
            {
                p2 = int.Parse(textBox2.Text);
                return string.Format($" price <= '" + p2.ToString() + "' ");
            }
            if(textBox1.Text != "" && textBox2.Text != "")
            {
                p1 = int.Parse(textBox1.Text);
                p2 = int.Parse(textBox2.Text);
                return string.Format($" price BETWEEN  '"+ p1.ToString()+"' AND '"+ p2.ToString() + "'"); 
            }
            else
            {
                throw new Exception();
            }
        }

        private string Check_NewOrOld()
        {
            var s = " new_or_old=";
            if (checkBox1.Checked && checkBox2.Checked )
            {
                throw new Exception();
            }
            if(!checkBox1.Checked && !checkBox2.Checked )
            {
                return null;
            }
            if(checkBox1.Checked)
            {
                return s+"'new' ";
            }
            else 
            {
                return s+"'old' ";
            }
        }
        private string Check_trans()
        {
            var s = " transmission=";
            if (checkBox3.Checked && checkBox4.Checked)
            {
                throw new Exception();
            }
            if (!checkBox3.Checked && !checkBox4.Checked)
            {
                return null;
            }
            if (checkBox3.Checked)
            {
                return s+"'акпп' ";
            }
            else
            {
                return s+"'мкпп' ";
            }
        }
        
        private void FilterCars_Load(object sender, EventArgs e)
        {

        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CheckBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }
    }
}
