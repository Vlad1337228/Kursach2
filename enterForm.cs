using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursach_2
{
    public partial class enterForm : Form
    {
        public enterForm()
        {
            InitializeComponent();
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
            
            var telephone_number = nubmerEnterTextBox.Text;
            var pass = passwordEnterTextBox.Text;
            if(telephone_number!="Номер телефона" && pass!="Пароль")
            {

                this.Close();
            }
            else
            {
                MessageBox.Show("Неправильный логин или пароль.");
            }
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
