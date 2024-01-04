using LiveChartsCore.SkiaSharpView;
using LiveChartsCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Collections.ObjectModel;
using System.Collections;
using System.Data.SqlClient;
using System.Windows.Media;

namespace project
{
    public partial class mainPage : Form
    {
        private string connString = "PROVIDER_STRING";

        OleDbConnection accessConnection = new OleDbConnection("PATH_TO_DB");
        
        private Panel panelSidebar;

        private String[] categories = { "drinks", "snacks", "patisserie" };
        private String username;
        
        
        
        public mainPage(String username)
        {
            this.username = username;
            InitializeComponent();
            //string[] categories = { "drinks", "snacks", "patessiere" };
         
            initializeSideBar();

        }

        private void mainPage_Load(object sender, EventArgs e)
        {


           
 
            // BACKGROUND COLOR

            this.BackColor = ColorTranslator.FromHtml("#D4DBA9");

            // BACKGROUND COLOR



            //LOADING CATEGORY IMAGE 
            string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;

            //üSt Klasöre Çıkma
            string parentDirectory = Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetParent(currentDirectory).FullName).FullName).FullName).FullName;

            string imagePath = Path.Combine(parentDirectory, "images", "Project_Logo.jpg");


            categoryPictureBox.Image = Image.FromFile(imagePath);

            categoryPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            
            //LOADING CATEGORY IMAGE 




            //LOADING MENU IMAGE 


            string imagePathMenu = Path.Combine(parentDirectory, "images", "menu_icon.ico");


            menuIconPictureBox.Image = Image.FromFile(imagePathMenu);

            menuIconPictureBox.SizeMode = PictureBoxSizeMode.Zoom;

            //LOADING MENU IMAGE 





            // DISABLING MENU ON LOAD
            menuIconPictureBox.Visible = false;
            // DISABLING MENU ON LOAD



            //LOADING EXIT IMAGE 
            string imagePathExit = Path.Combine(parentDirectory, "images", "exit_icon.ico");


            exitPictureBox.Image = Image.FromFile(imagePathExit);

            exitPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            //LOADING EXIT IMAGE 
            



            
     
            //SQLDE ÇALIŞMAK İÇİN

            List <decimal> totalStockQuantities = new List<decimal>();
            
            // KATEGORİ ADLARI İLE STOCK MİKTARINI TUTMA
            Dictionary<string, int> stockWarning = new Dictionary<string, int>();

            


            // Bağlantı oluşturma
            using (OleDbConnection accessConnection = new OleDbConnection(this.connString))
            {
               
                accessConnection.Open();

                foreach (string table in this.categories)
                {

                 
                   
                    
                    string query = $@"
                    SELECT 
                        SUM(IIf(stockQuantity > 0, stockQuantity, 0)) AS toplamStockQuantity
                    FROM 
                        {table};";

                    
                    using (OleDbCommand accessCommand = new OleDbCommand(query, accessConnection))
                    {
                     
                        object result = accessCommand.ExecuteScalar();

                        if (result != DBNull.Value)
                        {
                            totalStockQuantities.Add(Convert.ToDecimal(result));
                        }


                       
                        
                        if (Convert.ToInt32(result) <= 10)
                        {
                            Console.WriteLine("Warning:"+Convert.ToInt32(result));
                            stockWarning.Add(table, Convert.ToInt32(result));
                           
                        }

                        Console.WriteLine($"All Stock Quantity for {table}: {result}");

                    }
                    
                }
            }

            

            decimal[] decimalDizisi = totalStockQuantities.ToArray();

            int[] sayiDizisi = new int[decimalDizisi.Length];

            for (int i = 0; i < decimalDizisi.Length; i++)
            {
                sayiDizisi[i] = Decimal.ToInt32(decimalDizisi[i]);
            }

            


            pieChart1.Series = new ISeries[]

            {
                new PieSeries<double>
                {
                    Name = "Drinks",
                    Values = new ObservableCollection<double> { sayiDizisi[0] },
                    
                    TooltipLabelFormatter =
                        (chartPoint) => $"{chartPoint.Context.Series.Name}: {chartPoint.PrimaryValue}"
                },
                new PieSeries<double>
                {
                    Name = "Snacks",
                    Values = new ObservableCollection<double> { sayiDizisi[1] },

                    TooltipLabelFormatter =
                        (chartPoint) => $"{chartPoint.Context.Series.Name}: {chartPoint.PrimaryValue}"
                },new PieSeries<double>
                {
                    Name = "Patisserie",
                    Values = new ObservableCollection<double> { sayiDizisi[2] },

                    TooltipLabelFormatter =
                        (chartPoint) => $"{chartPoint.Context.Series.Name}: {chartPoint.PrimaryValue}"
                },
            };





            //LOADING STATUS LABEL

           
            

            
            labelStatusCategory.AutoSize = false;
            labelStatusCategory.Font = new Font(labelStatusCategory.Font.FontFamily, 15, labelStatusCategory.Font.Style);
            labelStatusCategory.Height = 50;
            labelStatusCategory.Width = 350;
            labelStatusCategory.BackColor = ColorTranslator.FromHtml("#D4DBA9");
            labelStatusCategory.ForeColor = System.Drawing.Color.Red;

            string warningMessage = "";

            if (stockWarning.Count == 0)
            {
                labelStatusCategory.Text = "There is no problem with stock on any product";
            }
            else
            {
                foreach (var keyValuePair in stockWarning)
                {
                    warningMessage = warningMessage + keyValuePair.Key + " ";

                }

                labelStatusCategory.Text = "Warning: " + warningMessage + "is at critical level!";
              

            }
             
        }

        //LOADING STATUS LABEL




        private void categoryPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void pieChart1_Load(object sender, EventArgs e)
        {

        }


        private void initializeSideBar()
        {
            panelSidebar = new Panel();
            panelSidebar.Size = new Size(200, this.ClientSize.Height);
            panelSidebar.BackColor = ColorTranslator.FromHtml("#0B2C37");
            panelSidebar.Dock = DockStyle.Left;

            PictureBox userPictureBox = new PictureBox();

            string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;

            string parentDirectory = Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetParent(currentDirectory).FullName).FullName).FullName).FullName;

            string imagePath = Path.Combine(parentDirectory, "images", "user_icon.ico");
            userPictureBox.Image = Image.FromFile(imagePath);
            userPictureBox.Dock = DockStyle.Top;
            userPictureBox.Size = new Size(50, 50);
            userPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            

            Label userNameLabel = new Label();
            userNameLabel.Dock = DockStyle.Top;
     
            Font bolded = new Font(userNameLabel.Font, FontStyle.Bold);

            userNameLabel.Font = bolded;
            userNameLabel.AutoSize = false;
            userNameLabel.Font = new Font(labelStatusCategory.Font.FontFamily, 15, labelStatusCategory.Font.Style);
            userNameLabel.Height = 50;
            userNameLabel.Width = 350;
           
            //this.Controls.Add(userNameLabel);


            userNameLabel.Text = "Welcome Back!\n"+this.username;
            userNameLabel.ForeColor = System.Drawing.Color.White;
            userNameLabel.Dock = DockStyle.Top;

            panelSidebar.Controls.Add(userNameLabel);
            panelSidebar.Controls.Add(userPictureBox);

            foreach (var category in this.categories)
            {
                Button btnSidebarItem = new Button();
                btnSidebarItem.Text = category;
                btnSidebarItem.Dock = DockStyle.Bottom;
                btnSidebarItem.BackColor = ColorTranslator.FromHtml("#D4DBA9");

                btnSidebarItem.MouseEnter += Button_MouseEnter;
                btnSidebarItem.MouseLeave += Button_MouseLeave;

                btnSidebarItem.Click += (sender, e) => CategoryButton_Click(sender, e, category);
                panelSidebar.Controls.Add(btnSidebarItem);
            }

            this.Controls.Add(panelSidebar);

        }
      

        private void Form1_Click(object sender, EventArgs e)
        {
            panelSidebar.Visible = false;
            menuIconPictureBox.Visible = true;
        }

       
        private void CategoryButton_Click(object sender, EventArgs e, string category)
        {

            manageCategory manageCategory= new manageCategory(category,this.username);

            //Console.WriteLine(category);


            // Bu kısma gerek olmayabilir tek show yeterli olabilir.
            if (category == "drinks")
            { 
                this.Hide();
                manageCategory.Show();
            }
               
            else if (category == "snacks")
            {
             
                this.Hide();
                manageCategory.Show();
            }

            else
            {
          
                this.Hide();
                manageCategory.Show();
            }
               

        }

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            
            Button button = (Button)sender;


            string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;


            string parentDirectory = Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetParent(currentDirectory).FullName).FullName).FullName).FullName;

             
            button.BackColor = System.Drawing.Color.LightGray;

               

               
            
            string imagePath = Path.Combine(parentDirectory, "images", button.Text + ".jpeg");

            categoryPictureBox.Image = Image.FromFile(imagePath);

            //this.Controls.Add(categoryPictureBox);

            button.BackColor = System.Drawing.Color.DarkGray;
            

        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            // Mouse ayrıldığında butonun arka plan rengini eski haline getirin
            Button button = (Button)sender;
            button.BackColor =  ColorTranslator.FromHtml("#D4DBA9");

            string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;


            string parentDirectory = Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetParent(currentDirectory).FullName).FullName).FullName).FullName;

            string imagePath = Path.Combine(parentDirectory, "images", "Project_Logo.jpg");


            categoryPictureBox.Image = Image.FromFile(imagePath);
        }

        private void menuIconPictureBox_Click(object sender, EventArgs e)
        {
            panelSidebar.Visible = true;
            menuIconPictureBox.Visible = false;
        }

        private void exitPictureBox_Click(object sender, EventArgs e)
        {
            
            DialogResult result = MessageBox.Show("Are you sure to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            
            if (result == DialogResult.Yes)
            {
                loginPageForm loginPageForm = new loginPageForm();
                this.Hide();
                loginPageForm.Show();
            }
        }
    }
}
