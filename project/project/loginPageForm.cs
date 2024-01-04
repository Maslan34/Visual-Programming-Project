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

        OleDbConnection accessConnection = new OleDbConnection("PATH_TO_DB");
        public loginPageForm()
        {
            InitializeComponent();
            
        }

        private void loginPageButton_Click(object sender, EventArgs e)
        {

            if( String.IsNullOrEmpty(textBoxPassword.Text) || String.IsNullOrEmpty(textBoxUsername.Text))
            {
                MessageBox.Show("Please Enter Form Properly!");
            }
            else
            {
               
                string password = textBoxPassword.Text;
                string username = textBoxUsername.Text;



                accessConnection.Open();

                //Query Oluşturma
                string query = "SELECT COUNT(*) FROM Users WHERE username = @Username AND password = @Password";

                OleDbCommand command = new OleDbCommand(query, accessConnection);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", password);

                int userCount = (int)command.ExecuteScalar();

                if (userCount > 0)
                {

                    // Main Page Yönlendirme

                    mainPage mainPage = new mainPage(username);
                    this.Hide();
                    mainPage.Show();


                    


                }

                else
                {
                    MessageBox.Show("User Not Authorized!");
                    textBoxPassword.Clear();
                    textBoxUsername.Clear();

                }

                accessConnection.Close();
            }
                
            }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginPageForm_Load(object sender, EventArgs e)
        {

            textBoxPassword.PasswordChar = '*';
            
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            registerPageForm registerPageForm = new registerPageForm();
            this.Hide();
            registerPageForm.Show();
        }
    }
}
    

    




