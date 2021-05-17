
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace kursach_2
{
    public partial class mainForm : Form
    {
        public static User user;

        public static enterForm _enterForm;
        public static filterCars _filterCars;
        public static mainForm _mainForm;
        public static submitForm _submitForm;
        public static registerForm _registerForm;

        public static string connect_user= "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\вуз\\курсач\\Курсовая 4 семестр\\Курсач с интерфейсом\\Database2.mdf;Integrated Security=True";
        public static SqlConnection connection=new SqlConnection(connect_user);
        public static bool flag=false; // false=вышел , true = вошел

        public mainForm()
        {
            
            InitializeComponent();
            _mainForm = this;
            this.exitBTN.Visible = false;
            clearBTN.FlatAppearance.BorderSize = 0;
            clearBTN.FlatStyle = FlatStyle.Flat;
            searchBTN.FlatAppearance.BorderSize = 0;
            submitBTN.FlatAppearance.BorderSize = 0;
            enterBTN.FlatAppearance.BorderSize = 0;

        }

        private void clearBTN_Click(object sender, EventArgs e)
        {
            searchLine.Text = "";
        }

        private void enterBTN_Click(object sender, EventArgs e)
        {
            enterForm ent = new enterForm(this);
            _enterForm = ent;
            ent.ShowDialog();
            
        }

        private void label9_Click(object sender, EventArgs e)
        {
            filterCars c1 = new filterCars();
            _filterCars = c1;
            this.Hide();
            c1.Show();
        }

        private void SubmitBTN_Click(object sender, EventArgs e)
        {
            if (mainForm.user == null)
            {
                MessageBox.Show("Войдите в аккаунт.");
                return;
            }
            
            submitForm sf = new submitForm();
            _submitForm = sf;
            sf.ShowDialog();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void ExitBTN_Click(object sender, EventArgs e)
        {
            user = null;
            this.enterBTN.Visible = true;
            this.exitBTN.Visible = false;
            flag = false;
        }
    }

   
}
