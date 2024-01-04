using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Windows.Forms.DataVisualization.Charting;
using System.IO;
using System.Configuration;

namespace project
{
    public partial class manageCategory : Form
    {
        private String categoryName;

        private String username;

        private String connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Coppe\\Desktop\\visulProjectFinal\\project\\db\\proje.mdb";


        OleDbConnection accessCon = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Coppe\\Desktop\\visulProjectFinal\\project\\db\\proje.mdb");
        
        public manageCategory(string categoryName,string username)
        {
            InitializeComponent();
            this.categoryName = categoryName;
            this.username = username;
            
            categoryNameLabel.Text = categoryName;
        }

        private void itemsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = itemsList.FocusedItem.Index;

            brandTextBox.Text = itemsList.Items[selectedIndex].SubItems[2].Text;
            priceTextBox.Text = itemsList.Items[selectedIndex].SubItems[5].Text;
            stockQuantityTextBox.Text = itemsList.Items[selectedIndex].SubItems[4].Text;
            expiryDateTextBox.Text = itemsList.Items[selectedIndex].SubItems[3].Text;
        }

        private void manageCategory_Load(object sender, EventArgs e)
        {

            this.BackColor = ColorTranslator.FromHtml("#D4DBA9");
            categoryNameLabel.ForeColor = ColorTranslator.FromHtml("#030D10");

            fetchData();

            manageCategoryInputs.Controls.Add(brandTextBox);
            manageCategoryInputs.Controls.Add(priceTextBox);
            manageCategoryInputs.Controls.Add(expiryDateTextBox);
            manageCategoryInputs.Controls.Add(stockQuantityTextBox);
            this.Controls.Add(manageCategoryInputs);

            string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;

            // Dört klasöre çık
            string parentDirectory =(Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetParent(currentDirectory).FullName).FullName).FullName).FullName);


            string imagePath = Path.Combine(parentDirectory, "images",  "back_button.ico");

            backButtonImage.Image = Image.FromFile(imagePath);


            string imagePathCategory = Path.Combine(parentDirectory, "images", categoryName+".jpeg");

            manageCategoryImage.Image = Image.FromFile(imagePathCategory);

            manageCategoryImage.SizeMode = PictureBoxSizeMode.Zoom;

            backButtonImage.SizeMode =PictureBoxSizeMode.Zoom;


        }

        private void buttonAdd_Click(object sender, EventArgs e)


        {

            bool inputsFilled =true;

            
            foreach (Control control in manageCategoryInputs.Controls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;

                    if (string.IsNullOrWhiteSpace(textBox.Text))
                    {
                        
                        inputsFilled = false;
                        MessageBox.Show("Please fill the form properly.");
                        return;
                    }
                   
                }
            }

             if( this.checkDigit(stockQuantityTextBox.Text) || this.checkDigit(priceTextBox.Text))
            {
              
                inputsFilled = false;
                MessageBox.Show("Lütfen stok veya fiyatın negatif olmadığından veya tamamen sayılardan oluştuğuna emin olun.");
                return;
            }


            if (inputsFilled)
            {
          
                String brand = brandTextBox.Text;
                String price = priceTextBox.Text;
                String stockQuantity = stockQuantityTextBox.Text;
                String expiryDate = expiryDateTextBox.Text;



                string expiryDateText = expiryDateTextBox.Text;

                DateTime expiryDateObject;

                if (DateTime.TryParse(expiryDateText, out expiryDateObject))
                {
                    try
                    {
                        accessCon.Open();

                        // Parametreli SQL sorgusunu oluştur
                        string sqlText = $"INSERT INTO " + this.categoryName + "(brand, expiryDate, stockQuantity, price) VALUES (@Brand, @ExpiryDate, @StockQuantity, @Price)";
                        OleDbCommand AccessCommand = new OleDbCommand(sqlText, accessCon);

                        // Parametre değerlerini ekleyerek SQL enjeksiyonlarına karşı koruma sağla
                        AccessCommand.Parameters.AddWithValue("@Brand", brand);
                        AccessCommand.Parameters.AddWithValue("@ExpiryDate", expiryDateObject);
                        AccessCommand.Parameters.AddWithValue("@StockQuantity", stockQuantity); // Burada dönüşüm yapmaya gerek yok
                        AccessCommand.Parameters.AddWithValue("@Price", price); // Burada dönüşüm yapmaya gerek yok

                        // SQL sorgusunu çalıştır
                        AccessCommand.ExecuteNonQuery();

                        accessCon.Close();

                        MessageBox.Show("Ürün Eklendi.");
                        fetchData();
                        brandTextBox.Clear();
                        priceTextBox.Clear();
                        stockQuantityTextBox.Clear();
                        expiryDateTextBox.Clear();
                        drawChart();   

                    }
                    catch (Exception ex)
                    {
                        // Hata ayrıntılarını göster
                        MessageBox.Show("Hata Oluştu: " + ex.Message);
                    }

                }
                else
                {

                    MessageBox.Show("Geçersiz Tarih Formatı\nTarih Formatı DD/MM/YYYY");
                }

               }

           

        }

        private void stockQuantityTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void fetchData()
        {
            // FETCHING DATA

            itemsList.Items.Clear();

            // Delete ListView before showing Informations;


            accessCon.Open();
            OleDbCommand AccessCommand = new OleDbCommand();
            AccessCommand.Connection = accessCon;
            AccessCommand.CommandText = "SELECT * FROM " + this.categoryName;
            OleDbDataReader read = AccessCommand.ExecuteReader();


            while (read.Read())
            {
                ListViewItem addNew = new ListViewItem();

                //addNew.Text = read["ID"].ToString();
                addNew.SubItems.Add(read["Id"].ToString());
                addNew.SubItems.Add(read["brand"].ToString());
                addNew.SubItems.Add(read["expiryDate"].ToString());
                addNew.SubItems.Add(read["stockQuantity"].ToString());
                addNew.SubItems.Add(read["price"].ToString());

                itemsList.Items.Add(addNew);

            }
            accessCon.Close();

            // FETCHING DATA


            // BAR CHART


            drawChart();
            

            // BAR CHART 
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure ?", "Deletion Confirmation", MessageBoxButtons.YesNo);
            int deletedNumber = itemsList.SelectedItems.Count;
            int checkedNumber = itemsList.CheckedItems.Count;

            if (result == DialogResult.Yes)
            {

                if (checkedNumber > 0)
                {


                    foreach (ListViewItem item in itemsList.CheckedItems)
                    {

                        // Silmeden önce id yi saklama

                        string id = item.SubItems[1].Text;
                        accessCon.Open();
                        string sqlText = "DELETE FROM " + categoryName + " WHERE Id = " + id + " ";

                        OleDbCommand AccessCommand = new OleDbCommand(sqlText, accessCon);

                        AccessCommand.ExecuteNonQuery();
                        accessCon.Close();

                        item.Remove();
                        MessageBox.Show(checkedNumber + " Item(s) Deleted !");
                        drawChart();

                    }
                }
                else if (deletedNumber == 1)
                {
                    foreach (ListViewItem item in itemsList.SelectedItems)
                    {
                        string deletedId = item.SubItems[1].Text;
                        accessCon.Open();
                        string sqlText = "DELETE FROM " + categoryName + " WHERE Id = " + deletedId + " ";
                        OleDbCommand AccessCommand = new OleDbCommand(sqlText, accessCon);
                        AccessCommand.ExecuteNonQuery();
                        accessCon.Close();
                    }
                    fetchData();
                    MessageBox.Show(deletedNumber + " Item(s) Deleted !");
                    drawChart();


                }
                else
                {
                    MessageBox.Show("Silmek için Ürün Seçmediniz !");
                }

               

                    

               
            }
            else
            {
                
    
            }
            
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {


            try
            {
                bool inputsFilled = true;

                foreach (Control control in manageCategoryInputs.Controls)
                {
                    if (control is TextBox)
                    {
                        TextBox textBox = (TextBox)control;

                        if (string.IsNullOrWhiteSpace(textBox.Text))
                        {
                            inputsFilled = false;
                            MessageBox.Show("Please fill the form properly.");
                            return;
                        }
                    }
                }

                if (this.checkDigit(stockQuantityTextBox.Text) || this.checkDigit(priceTextBox.Text))
                {
                    inputsFilled = false;
                    MessageBox.Show("Lütfen stok veya fiyatın negatif olmadığından veya tamamen sayılardan oluştuğuna emin olun.");
                    return;
                }

                if (inputsFilled)
                {
                    if (itemsList.FocusedItem != null)
                    {
                        accessCon.Open();
                        string sqlText = "UPDATE " + categoryName + " SET brand = '" + brandTextBox.Text + "', expiryDate = '" + expiryDateTextBox.Text + "', price = '" + priceTextBox.Text + "' , stockQuantity= '" + stockQuantityTextBox.Text + "' WHERE Id = " + itemsList.Items[itemsList.FocusedItem.Index].SubItems[1].Text + " ";
                        Console.WriteLine(sqlText);
                        OleDbCommand AccessCommand = new OleDbCommand(sqlText, accessCon);

                        AccessCommand.ExecuteNonQuery();
                        accessCon.Close();

                        MessageBox.Show("Ürün Güncellendi.");
                        fetchData();
                        brandTextBox.Clear();
                        priceTextBox.Clear();
                        stockQuantityTextBox.Clear();
                        expiryDateTextBox.Clear();
                        drawChart();
                    }
                    else
                    {
                        MessageBox.Show("You did not select a product!");
                    }
                }
            }
            catch (System.NullReferenceException ex)
            {
                MessageBox.Show("Unexpected null reference exception: ");
            }





        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            itemsList.Items.Clear();
        }

        private void buttonList_Click(object sender, EventArgs e)
        {
            fetchData();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {

            if (!String.IsNullOrEmpty(searchItemTextBox.Text))
            {
                string brand = searchItemTextBox.Text;
                itemsList.Items.Clear();
                try
                {
                    accessCon.Open();
                    string sqlText = "SELECT * FROM " + categoryName + " WHERE brand = '" + brand + "'";
                    Console.WriteLine(sqlText);
                    OleDbCommand AccessCommand = new OleDbCommand(sqlText, accessCon);
                    OleDbDataReader read = AccessCommand.ExecuteReader();
                    if (read.HasRows)
                    {
                        while (read.Read())
                        {
                            ListViewItem addNew = new ListViewItem();
                            addNew.SubItems.Add(read["Id"].ToString());
                            addNew.SubItems.Add(read["brand"].ToString());
                            addNew.SubItems.Add(read["expiryDate"].ToString());
                            addNew.SubItems.Add(read["stockQuantity"].ToString());
                            addNew.SubItems.Add(read["price"].ToString());
                            itemsList.Items.Add(addNew);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ürün Bulunamadı!");
                    }

                    accessCon.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message);
                }
            }
        }

        private void backButtonImage_Click(object sender, EventArgs e)
        {
            mainPage mainPage = new mainPage(this.username);
            this.Hide();
            mainPage.Show();
        }

        private bool checkDigit(string text)
        {
            foreach (char c in text)
            {
                if (!char.IsDigit(c))
                    return true;
            }

            return false;
        }

        private void CreateCategoryChart()
        {
            try
            {
                accessCon.Open();

                // Tablo var mı diye kontrol et
                DataTable schemaTable = accessCon.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, categoryName, "TABLE" });

                if (schemaTable.Rows.Count > 0)
                {
                    // Tablo varsa verileri çek ve grafik oluştur
                    Dictionary<string, int> brandStocks = new Dictionary<string, int>();

                    string query = $"SELECT stockQuantity, brand FROM {categoryName}";

                    using (OleDbCommand command = new OleDbCommand(query, accessCon))
                    {
                        using (OleDbDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string brandName = Convert.ToString(reader["brand"]);
                                int stockQuantity = Convert.ToInt32(reader["stockQuantity"]);
                                brandStocks.Add(brandName, stockQuantity);
                            }
                        }
                    }

                    // Chart oluştur
                    Chart manageCategoryBarChart = new Chart();
                    manageCategoryBarChart.Size = new System.Drawing.Size(300, 200);
                    manageCategoryBarChart.Location = new System.Drawing.Point(607, 23);

                    // ChartArea oluştur
                    ChartArea chartArea = new ChartArea();
                    manageCategoryBarChart.ChartAreas.Add(chartArea);

                    // Series oluştur (veri serisi)
                    Series series = new Series();
                    series.Name = "products";
                    series.ChartType = SeriesChartType.Bar;

                    foreach (var brand in brandStocks.Keys)
                    {
                        series.Points.AddXY(brand, brandStocks[brand]);
                    }

                    // Series'i charta ekleme işlemi
                    manageCategoryBarChart.Series.Add(series);

                    // Forma chartı ekleme işlemi
                    Controls.Add(manageCategoryBarChart);
                }

                accessCon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu: " + ex.Message);
            }
        }


        private void drawChart()
        {
            // Chart oluştur


            Chart manageCategoryBarChart = new Chart();
            manageCategoryBarChart.Size = new System.Drawing.Size(300, 200);


            manageCategoryBarChart.Location = new System.Drawing.Point(607, 23);


            // ChartArea oluştur
            ChartArea chartArea = new ChartArea();
            manageCategoryBarChart.ChartAreas.Add(chartArea);



            // Series oluştur (veri serisi)
            Series series = new Series();
            series.Name = "products";
            series.ChartType = SeriesChartType.Bar;



            Dictionary<string, int> brandStocks = new Dictionary<string, int>();


            try
            {
                string query = "SELECT stockQuantity, brand FROM " + categoryName;

                using (OleDbConnection connection = new OleDbConnection(this.connString))
                {
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        connection.Open();

                        using (OleDbDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string brandName = Convert.ToString(reader["brand"]);
                                int stockQuantity = Convert.ToInt32(reader["stockQuantity"]);

                                // Eğer brandStocks içerisinde bu marka varsa, üzerine eklime yapılcak yoksa dictionaryi ekleme yapılcak.
                                if (brandStocks.ContainsKey(brandName))
                                {
                                    brandStocks[brandName] += stockQuantity;
                                }
                                else
                                {
                                    brandStocks.Add(brandName, stockQuantity);
                                }
                            }
                        }

                        connection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            foreach (var brand in brandStocks.Keys)
            {
                series.Points.AddXY(brand, brandStocks[brand]);
            }




            // Series'i charta ekleme işlemi
            manageCategoryBarChart.Series.Add(series);

            // Forma chartı ekleme işlemi
            Controls.Add(manageCategoryBarChart);
        }

    }
}
