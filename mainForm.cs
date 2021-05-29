
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
        public static List<Auto> list_auto;
        public static string connect_user= "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\вуз\\курсач\\Курсовая 4 семестр\\Курсач с интерфейсом\\Database2.mdf;Integrated Security=True";
        public static SqlConnection connection=new SqlConnection(connect_user);
        public static bool flag=false; // false=вышел , true = вошел

        public mainForm()
        {
            
            InitializeComponent();
            _mainForm = this;
            this.exitBTN.Visible = false;
            this.deleteAuto.Visible = false;
            submitBTN.FlatAppearance.BorderSize = 0;
            enterBTN.FlatAppearance.BorderSize = 0;

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
            this.deleteAuto.Visible = false;
            flag = false;
        }

        private void DeleteAuto_Click(object sender, EventArgs e)
        {
            using (SqlCommand command = new SqlCommand("DELETE FROM [auto] WHERE id=" + user.auto.id, mainForm.connection))
            {
                mainForm.connection.Open();
                command.ExecuteNonQuery();
                SqlDataReader sqlDataReader = command.ExecuteReader();
                sqlDataReader.Close();
            }
            deleteAuto.Visible = false;
            mainForm.connection.Close();
        }

        private void FilterBTN_Click(object sender, EventArgs e)
        {
            _filterCars = new filterCars();
            _filterCars.ShowDialog();
        }

        

        private void Car_Class(int start, int end)
        {
            _filterCars = new filterCars();
            _filterCars.Car_price_in_filter(start, end);// посмотреть порядок вызова
            _filterCars.ShowDialog();
        }
        private void PictureBox2_Click(object sender, EventArgs e)
        {
            Car_Class(0, 1000000);
        }
        private void Label5_Click(object sender, EventArgs e)
        {
            PictureBox2_Click(sender,e);
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            Car_Class(1000000,3000000);
        }

        private void Label9_Click_1(object sender, EventArgs e)
        {
            PictureBox3_Click(sender,e);
        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {
            Car_Class(3000000,5000000);
        }

        private void Label10_Click(object sender, EventArgs e)
        {
            PictureBox4_Click(sender,e);
        }

        private void PictureBox5_Click(object sender, EventArgs e)
        {
            Car_Class(5000000,30000000);
        }

        private void Label3_Click(object sender, EventArgs e)
        {
            string request = string.Format($"SELECT * FROM auto ");
            SqlDataReader sql;
            using (SqlCommand command = new SqlCommand(request, mainForm.connection))
            {
                mainForm.connection.Open();
                command.ExecuteNonQuery();
                sql = command.ExecuteReader();
                
            }
           
            List<Auto> l = new List<Auto>();
            while(sql.Read())
            {
                var auto = new Auto();
                auto.id = (Int32)sql.GetValue(0);
                auto.company = (string)sql.GetValue(1);
                auto.mark = (string)sql.GetValue(2);
                auto.relise = (DateTime)sql.GetValue(3);
                auto.hourse_power = (int)sql.GetValue(4);
                auto.transmission = sql.GetValue(5).ToString();
                auto.new_or_old = sql.GetValue(6).ToString();
                auto.price = (int)sql.GetValue(7);
                l.Add(auto);
            }
            Random r = new Random();
            int i = 1;
            while(i!=4)
            {
                int n1 = r.Next(1, l.Count);
                if (i == 1)
                {
                    Out_Suggestion(label6, l[n1]);
                    l[n1] = null;
                    i++;
                }
                if (i == 2)
                {
                    if(l[n1]!=null)
                    {
                        Out_Suggestion(label7, l[n1]);
                        l[n1] = null;
                        i++;
                    }
                }
                if (i == 3)
                {
                    if (l[n1] != null)
                    {
                        Out_Suggestion(label8, l[n1]);
                        l[n1] = null;
                        i++;
                    }
                }
            }

            sql.Close();
            mainForm.connection.Close();
        }

        private void Out_Suggestion(Label l,Auto a)
        {
            string newOrOld;
            if (a.new_or_old == "new")
                newOrOld = "новое";
            else
                newOrOld = "б/у";

            l.Text = ("Цена: " + a.price + "\n\n" +
                "Компания: " + a.company + "\n\n" +
                "Марка: " + a.mark + "\n\n" +
                "Год выпуска: " + a.relise + "\n\n" +
                "Мощность двигателя: " + a.hourse_power + "\n\n" +
                "Тип КПП: " + a.transmission + "\n\n" +
                "Состояние: " + newOrOld + "\n\n");
        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }
    }

   
}
