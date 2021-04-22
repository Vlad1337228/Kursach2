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
using System.Data;
using System.Data.SqlClient;

namespace kursach_2
{
    public partial class Form1 : Form
    {
        private SqlConnection connect = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = \"D:\\вуз\\курсач\\Курсовая 4 семестр\\Kursach_2-master\\kursach_2\\Database1.mdf\"; Integrated Security = True");
        public Form1()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connect.Open();
            if (connect.State == ConnectionState.Open)
                MessageBox.Show("1");
        }
    }
}
