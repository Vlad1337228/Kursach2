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
    public partial class enterForm : Form
    {
        private  mainForm mainf=new mainForm();
        public enterForm(mainForm mf)
        {
            InitializeComponent();
            mainf = mf;
            passwordEnterTextBox.AutoSize = false;
            this.passwordEnterTextBox.Size = new Size(this.passwordEnterTextBox.Size.Width, 28);
            nubmerEnterTextBox.Text = "Номер телефона";
            nubmerEnterTextBox.ForeColor = Color.Gray;
            passwordEnterTextBox.Text = "Пароль";
            passwordEnterTextBox.ForeColor = Color.Gray;

        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            //mainForm main = new mainForm();
            //this.Hide();
            //main.Show();
            
            var telephone_number_string = nubmerEnterTextBox.Text;
            var pass = passwordEnterTextBox.Text;
            
            if(telephone_number_string!="Номер телефона" && pass!="Пароль")
            {
                var telephjne_number_long = long.Parse(nubmerEnterTextBox.Text);
                using (SqlCommand command = new SqlCommand("SELECT * FROM [user] WHERE telephone='" + telephjne_number_long + "' AND password='" + pass + "'" , mainForm.connection))
                {
                    mainForm.connection.Open();
                    command.ExecuteNonQuery();
                    SqlDataReader sqlDataReader = command.ExecuteReader();
                    if( Check_Enter(sqlDataReader))
                    {
                        var user = new User();
                        if(user.InPutUser(sqlDataReader))
                        {
                            mainForm.user = user;
                            mainForm.flag = true;
                            this.mainf.enterBTN.Visible = false;
                            this.mainf.exitBTN.Visible = true;
                            MessageBox.Show("Вы вошли.");
                        }
                        else
                        {
                            return;
                        }
                    }
                    else
                    {
                        sqlDataReader.Close();
                        mainForm.connection.Close();
                        return;
                    }
                    sqlDataReader.Close();
                    mainForm.connection.Close();
                }
                    this.Close();
            }
            else
            {
                MessageBox.Show("Неправильный логин или пароль.");
            }
        }


        private int Count_SqlDataReader(SqlDataReader sql)
        {
            int i = 0;
            while(sql.Read())
            {
                i++;
                if (i > 2)
                    break;
            }
            return i;
        }
        private bool Check_Enter(SqlDataReader sql)
        {
            if (!sql.HasRows)
            {
                MessageBox.Show("Пользователь не найден. Повторите попытку.");
                return false;
            }
            else if (Count_SqlDataReader(sql) > 1)
            {
                MessageBox.Show("Ошибка системы. Кол-во строк: "+ sql.FieldCount);
                return false;
            }

            return true;
            
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            registerForm r1 = new registerForm();
            this.Hide();
            r1.ShowDialog();
        }

        private void nubmerEnterTextBox_Enter(object sender, EventArgs e)
        {
            if (nubmerEnterTextBox.Text == "Номер телефона")
            {
                nubmerEnterTextBox.Text = "";
                nubmerEnterTextBox.ForeColor = Color.Black;
            }    
        }

        private void nubmerEnterTextBox_Leave(object sender, EventArgs e)
        {
            if (nubmerEnterTextBox.Text == "")
            {
                nubmerEnterTextBox.Text = "Номер телефона";
                nubmerEnterTextBox.ForeColor = Color.Gray;
            }
        }

        private void passwordEnterTextBox_Enter(object sender, EventArgs e)
        {
            passwordEnterTextBox.UseSystemPasswordChar = true;
            if (passwordEnterTextBox.Text == "Пароль")
            {
                passwordEnterTextBox.Text = "";
                passwordEnterTextBox.ForeColor = Color.Black;
            }
        }

        private void passwordEnterTextBox_Leave(object sender, EventArgs e)
        {
            if (passwordEnterTextBox.Text == "")
            {
                passwordEnterTextBox.UseSystemPasswordChar = false;
                passwordEnterTextBox.Text = "Пароль";
                passwordEnterTextBox.ForeColor = Color.Gray;
            }
        }

        private void EnterForm_Load(object sender, EventArgs e)
        {

        }

        private void NubmerEnterTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PasswordEnterTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
