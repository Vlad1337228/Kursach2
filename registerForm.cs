using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace kursach_2
{
    public partial class registerForm : Form
    {
        public registerForm()
        {
            InitializeComponent();
            secondNameBoxRegister.Text = "Фамилия";
            secondNameBoxRegister.ForeColor = Color.Gray;
            nameBoxRegister.Text = "Имя";
            nameBoxRegister.ForeColor = Color.Gray;
            numberBoxRegister.Text = "Номер телефона";
            numberBoxRegister.ForeColor = Color.Gray;
            passwordBoxRegister.Text = "Пароль";
            passwordBoxRegister.ForeColor = Color.Gray;
            this.passwordBoxRegister.Size = new Size(this.passwordBoxRegister.Size.Width, 28);

        }
        private bool Check(string s1,string s2, string s3 , string s4)
        {
            try
            {
                long.Parse(s1);
            }
            catch (Exception e)
            {
                MessageBox.Show("Пожалуйста введите корректные данные в поле \"Номер телефона\"");
                return false;
            }
            if (s2.Length >= 30 || s3.Length >= 30 || s4.Length >= 20)
            {
                MessageBox.Show("Поля \"Имя\" \"Фамилия\" должны иметь не более 30 символов. Поле \"Пароль\" должно содержать не более 20 символов.");
                return false;
            }
            return true;
        }
        private void registerBTN_Click(object sender, EventArgs e)
        {
            var second_name = secondNameBoxRegister.Text;
            var name = nameBoxRegister.Text;
            var telephone_number = numberBoxRegister.Text;
            var pass = passwordBoxRegister.Text;
            
            if (Check(telephone_number,second_name,name,pass))
            {
                if (second_name != "Фамилия" && name != "Имя" && telephone_number != "Номер телефона" && pass != "Пароль")
                {
                    string s = "SELECT * FROM [user] WHERE telephone='" + long.Parse(telephone_number) + "' AND password='" + pass + "'";
                    using (SqlCommand command = new SqlCommand(s, mainForm.connection))
                    {
                        mainForm.connection.Open();
                        command.ExecuteNonQuery();
                        SqlDataReader sqlDataReader = command.ExecuteReader();


                        if (!sqlDataReader.HasRows)
                        {
                            sqlDataReader.Close();
                            using (SqlCommand command1 = new SqlCommand($"INSERT INTO [user] (telephone, password, name, second_name) Values(@telephone_number, @pass, @name, @second_name)", mainForm.connection))
                            {
                                command1.Parameters.AddWithValue("@second_name", second_name);
                                command1.Parameters.AddWithValue("@name", name);
                                command1.Parameters.AddWithValue("@telephone_number", long.Parse(telephone_number));
                                command1.Parameters.AddWithValue("@pass", pass);
                                command1.ExecuteNonQuery();
                            }
                            MessageBox.Show("Пользователь зарегестрирован.");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Пользователь с этими данными уже есть.");
                        }
                        sqlDataReader.Close();
                        mainForm.connection.Close();
                    }

                }
                else
                {
                    MessageBox.Show("Не все поля заполнены.");
                }
            }
        }

        private void secondNameBoxRegister_Enter(object sender, EventArgs e)
        {
            if (secondNameBoxRegister.Text == "Фамилия")
            {
                secondNameBoxRegister.Text = "";
                secondNameBoxRegister.ForeColor = Color.Black;
            }
        }

        private void secondNameBoxRegister_Leave(object sender, EventArgs e)
        {
            if (secondNameBoxRegister.Text == "")
            {
                secondNameBoxRegister.Text = "Фамилия";
                secondNameBoxRegister.ForeColor = Color.Gray;
            }

        }

        private void nameBoxRegister_Enter(object sender, EventArgs e)
        {
            if (nameBoxRegister.Text == "Имя")
            {
                nameBoxRegister.Text = "";
                nameBoxRegister.ForeColor = Color.Black;
            }
        }

        private void nameBoxRegister_Leave(object sender, EventArgs e)
        {
            if (nameBoxRegister.Text == "")
            {
                nameBoxRegister.Text = "Имя";
                nameBoxRegister.ForeColor = Color.Gray;
            }
        }

        private void numberBoxRegister_Enter(object sender, EventArgs e)
        {
            if (numberBoxRegister.Text == "Номер телефона")
            {
                numberBoxRegister.Text = "";
                numberBoxRegister.ForeColor = Color.Black;
            }
        }

        private void numberBoxRegister_Leave(object sender, EventArgs e)
        {
            if (numberBoxRegister.Text == "")
            {
                numberBoxRegister.Text = "Номер телефона";
                numberBoxRegister.ForeColor = Color.Gray;
            }
        }

        private void passwordBoxRegister_Enter(object sender, EventArgs e)
        {
            passwordBoxRegister.UseSystemPasswordChar = true;
            if (passwordBoxRegister.Text == "Пароль")
            {
                passwordBoxRegister.Text = "";
                passwordBoxRegister.ForeColor = Color.Black;
            }    
        }

        private void passwordBoxRegister_Leave(object sender, EventArgs e)
        {
            if (passwordBoxRegister.Text == "")
            {
                passwordBoxRegister.UseSystemPasswordChar = false;
                passwordBoxRegister.Text = "Пароль";
                passwordBoxRegister.ForeColor = Color.Gray;
            }
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }
    }
}
