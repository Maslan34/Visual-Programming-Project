using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace project
{
    public partial class loginPageForm : Form
    {

        OleDbConnection accessConnection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Coppe\\Desktop\\visulProjectSon\\project\\db\\proje.mdb");
        public loginPageForm()
        {
            InitializeComponent();
            textBoxPassword.PasswordChar = '*';
        }

        private void loginPageButton_Click(object sender, EventArgs e)
        {
            string password = textBoxPassword.Text;
            string username = textBoxUsername.Text;

            accessConnection.Open();

            // Use parameters to prevent SQL injection
            string query = "SELECT COUNT(*) FROM Users WHERE username = @Username AND password = @Password";

            OleDbCommand command = new OleDbCommand(query, accessConnection);
            command.Parameters.AddWithValue("@Username", username);
            command.Parameters.AddWithValue("@Password", password);

            int userCount = (int)command.ExecuteScalar();

            if (userCount > 0)
            {


                mainPage mainPage = new mainPage();
                this.Hide();
                mainPage.Show();


                // Şu anki formu kapatma


            }

            else
            {
                MessageBox.Show("Kullanıcı Mevcut Değil");
                textBoxPassword.Clear();
                textBoxUsername.Clear();

            }

            accessConnection.Close();
        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {


        }
        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxPassword.PasswordChar = '*';
        }

        /*private void loginPageForm_Load(object sender, EventArgs e)
        {

        }*/
    }
}

