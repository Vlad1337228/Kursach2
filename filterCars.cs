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
using System.Reflection;

namespace kursach_2
{
    public partial class filterCars : Form 
    {
        private int page=1;
        private int numerable;
        private int final_advertisement;
        private bool not_switch_next=false;

        public int start_price { get; set; }
        public int end_price { get; set; }
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
            not_switch_next = false;
            page_number.Text = (1).ToString();
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
                var s = " company =N'" + textBox4.Text + "'";
                list.Add(s);
            }
            if (Check_str(textBox5.Text))
            {
                var s = " mark=N'" + textBox5.Text + "'";
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
            page = 1;
            numerable = 0;
            DisplayAuto();
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
            int e=-1;
            int n;
            for(int i=0;i<list.Count;i++)
            {
                if (list[i] != null)
                    e = i;
            }
            if(e!=-1)
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
            if (n == -1)
                return str;
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
                p2 = int.Parse(textBox11.Text);
                return string.Format($" hourse_power <= '"+ p2.ToString() + "' ");
            }
            if (textBox10.Text != "" && textBox11.Text != "")
            {
                p1 = int.Parse(textBox10.Text);
                p2 = int.Parse(textBox11.Text);
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
                return s+"N'new' ";
            }
            else 
            {
                return s+"N'old' ";
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
                return s+"N'мкпп' ";
            }
            else
            {
                return s+"N'акпп' ";
            }
        }
        #region
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

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void CarLabel_1_Click(object sender, EventArgs e)
        {

        }

        private void Label24_Click(object sender, EventArgs e)
        {

        }
        
        private void InfoCar1_Click(object sender, EventArgs e)
        {
        }
        #endregion
        
        private void Delete_infoCar()
        {
            for(int i= final_advertisement+1; i<4;i++)
            {
                if (i == 0)
                    infoCar1.Text = "";
                if (i == 1)
                    infoCar2.Text = "";
                if (i == 2)
                    infoCar3.Text = "";
                if (i == 3)
                    infoCar4.Text = "";
            }
        }
        private void Out_infoCar1(Auto auto)
        {
            string newOrOld;
            if (auto.new_or_old == "new")
                newOrOld = "новое";
            else
                newOrOld = "б/у";

            infoCar1.Text = ("Цена: " + auto.price + "\n\n" +
                "Компания: " + auto.company + "\n\n" +
                "Марка: " + auto.mark + "\n\n" +
                "Год выпуска: " + auto.relise + "\n\n" +
                "Мощность двигателя: " + auto.hourse_power + "\n\n" +
                "Тип КПП: " + auto.transmission + "\n\n" +
                "Состояние: " + newOrOld + "\n\n");
        }
        private void Out_infoCar2(Auto auto)
        {
            string newOrOld;
            if (auto.new_or_old == "new")
                newOrOld = "новое";
            else
                newOrOld = "б/у";

            infoCar2.Text = ("Цена: " + auto.price + "\n\n" +
                "Компания: " + auto.company + "\n\n" +
                "Марка: " + auto.mark + "\n\n" +
                "Год выпуска: " + auto.relise + "\n\n" +
                "Мощность двигателя: " + auto.hourse_power + "\n\n" +
                "Тип КПП: " + auto.transmission + "\n\n" +
                "Состояние: " + newOrOld + "\n\n");
        }
        private void Out_infoCar3(Auto auto)
        {
            string newOrOld;
            if (auto.new_or_old == "new")
                newOrOld = "новое";
            else
                newOrOld = "б/у";

            infoCar3.Text = ("Цена: " + auto.price + "\n\n" +
                "Компания: " + auto.company + "\n\n" +
                "Марка: " + auto.mark + "\n\n" +
                "Год выпуска: " + auto.relise + "\n\n" +
                "Мощность двигателя: " + auto.hourse_power + "\n\n" +
                "Тип КПП: " + auto.transmission + "\n\n" +
                "Состояние: " + newOrOld + "\n\n");
        }
        private void Out_infoCar4(Auto auto)
        {
            string newOrOld;
            if (auto.new_or_old == "new")
                newOrOld = "новое";
            else
                newOrOld = "б/у";

            infoCar4.Text = ("Цена: " + auto.price + "\n\n" +
                "Компания: " + auto.company + "\n\n" +
                "Марка: " + auto.mark + "\n\n" +
                "Год выпуска: " + auto.relise + "\n\n" +
                "Мощность двигателя: " + auto.hourse_power + "\n\n" +
                "Тип КПП: " + auto.transmission + "\n\n" +
                "Состояние: " + newOrOld + "\n\n");
        }

        private void NumOfPageRight_Click(object sender, EventArgs e)
        {
            if(not_switch_next)
            {
                return;
            }
            page += 1;
            page_number.Text = (page).ToString();
            DisplayAuto();
        }

        private void NumOfPageLeft_Click(object sender, EventArgs e)
        {
            if(page==1)
            {
                return;
            }
            page -= 1;
            page_number.Text = (page).ToString();
            DisplayAuto_From_The_End();
        }
        private bool DisplayAuto()
        {
            var list = mainForm.list_auto;
            try
            {
                final_advertisement = -1;

                Out_infoCar1(list[numerable]);
                numerable++;

                final_advertisement = 0;
                Out_infoCar2(list[numerable ]);
                numerable++;

                final_advertisement = 1;
                Out_infoCar3(list[numerable ]);
                numerable++;

                final_advertisement = 2;
                Out_infoCar4(list[numerable ]);
                numerable++;

                final_advertisement = 3;
            }
            catch
            {
                Delete_infoCar();
                not_switch_next = true;
                return false;
            }
            return true;
        }
        private void DisplayAuto_From_The_End()
        {
            var list = mainForm.list_auto;
            try
            {
                numerable = numerable - 4 - (final_advertisement + 1);
                //if (final_advertisement != -1 && final_advertisement!=3)
                //{
                //    numerable = numerable - 8 + (final_advertisement+1 );
                //}
                //else
                //    numerable -= 8;
                //if(final_advertisement==-1)
                //{
                //    numerable += 4;
                //}
                final_advertisement = -1;
                
                Out_infoCar1(list[numerable]);
                final_advertisement = 0;
                numerable +=1 ;
                Out_infoCar2(list[numerable ]);
                final_advertisement = 1;
                numerable += 1;
                Out_infoCar3(list[numerable ]);
                final_advertisement = 2;
                numerable += 1;
                Out_infoCar4(list[numerable ]);
                final_advertisement = 3;
                numerable += 1;

                not_switch_next = false;
            }
            catch
            {
                Delete_infoCar();
                not_switch_next = true;
                return;
            }
        }

        public void Car_price_in_filter(int start,int end)
        {
            string request = string.Format($"SELECT * FROM auto WHERE price>='{start}' AND price <='{end}'");

            using (SqlCommand command = new SqlCommand(request, mainForm.connection))
            {
                mainForm.connection.Open();
                command.ExecuteNonQuery();
                SqlDataReader sqlDataReader = command.ExecuteReader();
                OutAuto(sqlDataReader);
                sqlDataReader.Close();
            }

            mainForm.connection.Close();
            DisplayAuto();
        }
       

        
    }
}
