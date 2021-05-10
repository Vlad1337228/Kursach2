
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
        public static string connect_user= "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\вуз\\курсач\\Курсовая 4 семестр\\Курсач с интерфейсом\\Database2.mdf;Integrated Security=True";
    //    public static string connect_auto = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\вуз\\курсач\\Курсовая 4 семестр\\Курсач с интерфейсом\\Database2.mdf;Integrated Security=True";
        public static SqlConnection connection=new SqlConnection(connect_user);
        public mainForm()
        {
            InitializeComponent();
            //this.MaximizeBox = false;
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
            enterForm ent = new enterForm();
            ent.ShowDialog();

        }

        private void label9_Click(object sender, EventArgs e)
        {
            filterCars c1 = new filterCars();
            this.Hide();
            c1.Show();
        }

        private void SubmitBTN_Click(object sender, EventArgs e)
        {

        }
    }
}
