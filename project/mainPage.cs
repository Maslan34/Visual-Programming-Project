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

namespace project
{
    public partial class mainPage : Form
    {

        OleDbConnection accessConnection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Coppe\\Desktop\\visulProjectSon\\project\\db\\proje.mdb");
        private Panel panelSidebar;
        private Button btnToggleSidebar;
        private String[] categories = { "drinks", "snacks", "patisserie" };

        public mainPage()
        {
            InitializeComponent();
            //string[] categories = { "drinks", "snacks", "patessiere" };
            categoriesComboBox.Items.AddRange(categories);
            categoriesComboBox.SelectedIndex = 0;
            initializeSideBar();
        }

        private void mainPage_Load(object sender, EventArgs e)
        {

         
            string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;


            string parentDirectory = Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetParent(currentDirectory).FullName).FullName).FullName).FullName;

            string imagePath = Path.Combine(parentDirectory, "images", "Project_Logo.jpg");


            categoryPictureBox.Image = Image.FromFile(imagePath);

            categoryPictureBox.SizeMode = PictureBoxSizeMode.Zoom;

            // Access veritabanı bağlantı dizesi
            string accessConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Coppe\\Desktop\\visualTeslim\\visulProjectSon29-12-2023\\project\\db\\proje.mdb";

            // Tabloların listesi
            string[] tables = { "drinks", "snacks", "patisserie" };
     

            List<decimal> totalStockQuantities = new List<decimal>();


            // Bağlantı oluştur
            using (OleDbConnection accessConnection = new OleDbConnection(accessConnectionString))
            {
                // Bağlantıyı aç
                accessConnection.Open();

                foreach (string table in tables)
                {

                 
                   
                    // SQL sorgusu
                    string query = $@"
                    SELECT 
                        SUM(IIf(stockQuantity > 0, stockQuantity, 0)) AS toplamStockQuantity
                    FROM 
                        {table};";

                    // Komut oluştur
                    using (OleDbCommand accessCommand = new OleDbCommand(query, accessConnection))
                    {
                        // Sorguyu çalıştır ve sonucu al
                        object result = accessCommand.ExecuteScalar();
                        if (result != DBNull.Value)
                        {
                            totalStockQuantities.Add(Convert.ToDecimal(result));
                        }



                        // Sonucu ekrana bas
                        Console.WriteLine($"Toplam Stock Quantity for {table}: {result}");

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


        }

       
        private void buttonCategoriesShow_Click(object sender, EventArgs e)
        {
            string selectedCategory = categoriesComboBox.SelectedItem.ToString();

            if (selectedCategory == "drinks")
            {
                manageCategory manageCategory = new manageCategory("drinks");
                this.Hide();
                manageCategory.Show();
            }
            else if (selectedCategory == "snacks")
            {
                manageCategory manageCategory = new manageCategory("snacks");
              
                this.Hide();
                manageCategory.Show();
            }
            else
            {
                manageCategory manageCategory = new manageCategory("pati");
             
                this.Hide();
                manageCategory.Show();
            }
        }

        private void categoriesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            String categoryName=categoriesComboBox.SelectedItem.ToString();


            string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;

            // Dört klasöre çık
            string parentDirectory = Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetParent(currentDirectory).FullName).FullName).FullName).FullName;

          
            string imagePath = Path.Combine(parentDirectory, "images", categoryName+".jpeg");

            

            
            categoryPictureBox.Image = Image.FromFile(imagePath);

            this.Controls.Add(categoryPictureBox);

        }

        private void categoryPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void pieChart1_Load(object sender, EventArgs e)
        {

        }

       

        private void btnToggleSidebar_Click(object sender, EventArgs e)
        {
            panelSidebar.Visible = !panelSidebar.Visible; // Toggle the visibility
        }
        private void initializeSideBar()
        {
            panelSidebar = new Panel();
            panelSidebar.Size = new Size(200, this.ClientSize.Height);
            panelSidebar.BackColor = Color.Aqua;
            panelSidebar.Dock = DockStyle.Left;



            foreach (var category in this.categories)
            {
                Button btnSidebarItem = new Button();
                //btnSidebarItem.MouseHover += (sender, e) => CategoryButton_Hover(sender, e, category);
                btnSidebarItem.Text = category;
                btnSidebarItem.Dock = DockStyle.Top;
                btnSidebarItem.MouseEnter += Button_MouseEnter;
                btnSidebarItem.MouseLeave += Button_MouseLeave;
                btnSidebarItem.Click += (sender, e) => CategoryButton_Click(sender, e, category);
                panelSidebar.Controls.Add(btnSidebarItem);
            }





            this.Controls.Add(panelSidebar); Button btnToggleSidebar = new Button();

            btnToggleSidebar = new Button();
            btnToggleSidebar.Text = "Toggle Sidebar";
            btnToggleSidebar.Location = new Point(0, 10); // Positioned on the left
            btnToggleSidebar.Click += new EventHandler(btnToggleSidebar_Click);
            this.Controls.Add(btnToggleSidebar);


            btnToggleSidebar = new Button();
            btnToggleSidebar.Text = "Toggle Sidebar";
            btnToggleSidebar.Location = new Point(210, 10);
            btnToggleSidebar.Click += new EventHandler(btnShowSidebar_Click);
            btnToggleSidebar.Visible = false; // Start with the toggle button hidden
            this.Controls.Add(btnToggleSidebar);

        }
        private void btnShowSidebar_Click(object sender, EventArgs e)
        {
            panelSidebar.Visible = !panelSidebar.Visible;
            btnToggleSidebar.Visible = panelSidebar.Visible; // Show/hide toggle button with sidebar
        }

      

        private void Form1_Click(object sender, EventArgs e)
        {
            panelSidebar.Visible = false;
        }

        

        private void CategoryButton_Click(object sender, EventArgs e, string category)
        {

            manageCategory manageCategory= new manageCategory(category);
            Console.WriteLine(category);
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
        private void CategoryButton_Hover(object sender, EventArgs e, string category)
        {

            
           


        }

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            
            Button button = (Button)sender;

            String categoryName = categoriesComboBox.SelectedItem.ToString();


            string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;


            string parentDirectory = Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetParent(currentDirectory).FullName).FullName).FullName).FullName;

             
            button.BackColor = System.Drawing.Color.LightGray;

               

               
            
            string imagePath = Path.Combine(parentDirectory, "images", button.Text + ".jpeg");
            categoryPictureBox.Image = Image.FromFile(imagePath);

            this.Controls.Add(categoryPictureBox);

            this.Controls.Add(categoryPictureBox);
            button.BackColor = System.Drawing.Color.DarkGray;
            

        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            // Mouse ayrıldığında butonun arka plan rengini eski haline getirin
            Button button = (Button)sender;
            button.BackColor = System.Drawing.Color.LightGray;

            string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;


            string parentDirectory = Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetParent(currentDirectory).FullName).FullName).FullName).FullName;

            string imagePath = Path.Combine(parentDirectory, "images", "Project_Logo.jpg");


            categoryPictureBox.Image = Image.FromFile(imagePath);
        }



    }
}
