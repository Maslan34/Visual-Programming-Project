using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class registerPageForm : Form
    {
        public registerPageForm()
        {
            InitializeComponent();
        }

        private string connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Coppe\\Desktop\\visulProjectFinal\\project\\db\\proje.mdb";

        private void registerButtonRegister_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxUsernameRegister.Text) || String.IsNullOrEmpty(textBoxPasswordRegister.Text))
            {
                MessageBox.Show("Please fill the Registration Form properly!");
            }
            else
            {
                
                string usernameEntered = textBoxUsernameRegister.Text;

                // Kullanıcın Varlığını Tespit Etme
                string query = "SELECT COUNT(*) FROM users WHERE username = @Username";

                using (OleDbConnection connection = new OleDbConnection(connString))
                {
                    connection.Open();

                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", usernameEntered);

                        int userCount = (int)command.ExecuteScalar();

                        if (userCount > 0)
                        {
                            MessageBox.Show("This username is in use!");
                        }
                        else
                        {
                            string queryAddition = "INSERT INTO users (username, [password]) VALUES (@Username, @Password )";


                            using (OleDbCommand commandForAddition = new OleDbCommand(queryAddition, connection))
                            {

                                commandForAddition.Parameters.AddWithValue("@Username", textBoxUsernameRegister.Text);
                                commandForAddition.Parameters.AddWithValue("@Password", textBoxPasswordRegister.Text);

                                int rowsAffected = commandForAddition.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    Console.WriteLine("User Added.");
                                }
                                else
                                {
                                    Console.WriteLine("User Addition Error!");
                                }

                                MessageBox.Show("You have registered");
                                this.Hide();
                                loginPageForm loginPageForm = new loginPageForm();
                                loginPageForm.Show();
                            }
                        }
                    }
                }
            }
        }

        private void registerPageForm_Load(object sender, EventArgs e)
        {
            textBoxPasswordRegister.PasswordChar = '*';
        }

        private void alreadyRegistered_Click(object sender, EventArgs e)
        {
            loginPageForm loginPageForm = new loginPageForm();
            this.Hide();
            loginPageForm.Show();
        }
    }
}
