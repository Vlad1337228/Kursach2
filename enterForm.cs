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
        private mainForm mainf = mainForm._mainForm;
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
            var telephone_number_string = nubmerEnterTextBox.Text;
            var pass = passwordEnterTextBox.Text;
            long telephjne_number_long=0;
            if (telephone_number_string!="Номер телефона" && pass!="Пароль")
            {
                try
                {
                     telephjne_number_long = long.Parse(nubmerEnterTextBox.Text);
                }
                catch(Exception exce)
                {
                    MessageBox.Show("Заполните поле \"Номер телефона\" корректно.");
                    return;
                }
                using (SqlCommand command = new SqlCommand("SELECT * FROM [user] WHERE telephone='" + telephjne_number_long + "' AND password='" + pass + "'" , mainForm.connection))
                {
                    mainForm.connection.Open();
                    command.ExecuteNonQuery();
                    SqlDataReader sqlDataReader = command.ExecuteReader();
                    if( Check_RowsInDB(sqlDataReader))
                    {
                        var user = new User();
                        if(user.OutPutUser(sqlDataReader))
                        {
                            mainForm.user = user;
                            mainForm.flag = true;
                            this.mainf.enterBTN.Visible = false;
                            this.mainf.exitBTN.Visible = true;
                            sqlDataReader.Close();
                            mainForm.connection.Close();
                            if (Check_Auto(user.id))
                            {
                                Out_Auto(user.id);
                            }
                            MessageBox.Show("Вы вошли.");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Пользователь не найден. Повторите попытку.");
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

        private void Out_Auto(int id)
        {
            using (SqlCommand command = new SqlCommand("SELECT * FROM [auto] WHERE id=" + id, mainForm.connection))
            {
                mainForm.connection.Open();
                command.ExecuteNonQuery();
                SqlDataReader sqlDataReader = command.ExecuteReader();
                Auto auto = new Auto();
                if (auto.OutPutAuto(sqlDataReader))
                {
                    mainForm.user.auto = auto;
                    mainForm._mainForm.deleteAuto.Visible = true;
                }
                sqlDataReader.Close();
            }
            
            mainForm.connection.Close();
        }

        private bool Check_Auto(int id)
        {
            using (SqlCommand command = new SqlCommand("SELECT * FROM [auto] WHERE id="+id, mainForm.connection))
            {
                mainForm.connection.Open();
                command.ExecuteNonQuery();
                SqlDataReader sqlDataReader = command.ExecuteReader();

                if (Check_RowsInDB(sqlDataReader))
                {
                    sqlDataReader.Close();
                    mainForm.connection.Close();
                    return true;
                }
                else
                {
                    sqlDataReader.Close();
                    mainForm.connection.Close();
                    return false;
                }
            }
        }

       
        private bool Check_RowsInDB(SqlDataReader sql)
        {
            if (!sql.HasRows)
            {
                return false;
            }
            return true;
            
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            registerForm r1 = new registerForm();
            mainForm._registerForm = r1;
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
