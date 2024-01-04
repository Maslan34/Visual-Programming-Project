namespace project
{
    partial class manageCategory
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.categoryNameLabel = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.itemsList = new System.Windows.Forms.ListView();
            this.emptyColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.brand = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.expiryDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.stockQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonList = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.searchItemTextBox = new System.Windows.Forms.TextBox();
            this.labelSearchItem = new System.Windows.Forms.Label();
            this.backButtonImage = new System.Windows.Forms.PictureBox();
            this.manageCategoryImage = new System.Windows.Forms.PictureBox();
            this.manageCategoryInputs = new System.Windows.Forms.GroupBox();
            this.brandTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.stockQuantityTextBox = new System.Windows.Forms.TextBox();
            this.expiryDateTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.backButtonImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manageCategoryImage)).BeginInit();
            this.manageCategoryInputs.SuspendLayout();
            this.SuspendLayout();
            // 
            // categoryNameLabel
            // 
            this.categoryNameLabel.AutoSize = true;
            this.categoryNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.categoryNameLabel.Location = new System.Drawing.Point(370, 23);
            this.categoryNameLabel.Name = "categoryNameLabel";
            this.categoryNameLabel.Size = new System.Drawing.Size(126, 46);
            this.categoryNameLabel.TabIndex = 0;
            this.categoryNameLabel.Text = "label1";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(626, 502);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 9;
            this.buttonAdd.Text = "ADD";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(719, 502);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 10;
            this.buttonUpdate.Text = "UPDATE";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(814, 502);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 11;
            this.buttonDelete.Text = "DELETE";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // itemsList
            // 
            this.itemsList.CheckBoxes = true;
            this.itemsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.emptyColumn,
            this.Id,
            this.brand,
            this.expiryDate,
            this.stockQuantity,
            this.price});
            this.itemsList.FullRowSelect = true;
            this.itemsList.HideSelection = false;
            this.itemsList.Location = new System.Drawing.Point(10, 271);
            this.itemsList.Name = "itemsList";
            this.itemsList.Size = new System.Drawing.Size(412, 225);
            this.itemsList.TabIndex = 12;
            this.itemsList.UseCompatibleStateImageBehavior = false;
            this.itemsList.View = System.Windows.Forms.View.Details;
            this.itemsList.SelectedIndexChanged += new System.EventHandler(this.itemsList_SelectedIndexChanged);
            // 
            // emptyColumn
            // 
            this.emptyColumn.Text = "";
            // 
            // Id
            // 
            this.Id.Text = "ID";
            // 
            // brand
            // 
            this.brand.Text = "BRAND";
            // 
            // expiryDate
            // 
            this.expiryDate.Text = "EXPIRYDATE";
            // 
            // stockQuantity
            // 
            this.stockQuantity.Text = "STOCK";
            // 
            // price
            // 
            this.price.Text = "PRICE";
            // 
            // buttonList
            // 
            this.buttonList.Location = new System.Drawing.Point(93, 502);
            this.buttonList.Name = "buttonList";
            this.buttonList.Size = new System.Drawing.Size(75, 23);
            this.buttonList.TabIndex = 13;
            this.buttonList.Text = "LIST";
            this.buttonList.UseVisualStyleBackColor = true;
            this.buttonList.Click += new System.EventHandler(this.buttonList_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(221, 502);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 14;
            this.buttonClear.Text = "CLEAR";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(221, 220);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 15;
            this.buttonSearch.Text = "SEARCH";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // searchItemTextBox
            // 
            this.searchItemTextBox.Location = new System.Drawing.Point(93, 220);
            this.searchItemTextBox.Name = "searchItemTextBox";
            this.searchItemTextBox.Size = new System.Drawing.Size(100, 20);
            this.searchItemTextBox.TabIndex = 16;
            // 
            // labelSearchItem
            // 
            this.labelSearchItem.AutoSize = true;
            this.labelSearchItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSearchItem.Location = new System.Drawing.Point(143, 167);
            this.labelSearchItem.Name = "labelSearchItem";
            this.labelSearchItem.Size = new System.Drawing.Size(121, 24);
            this.labelSearchItem.TabIndex = 17;
            this.labelSearchItem.Text = "Search Item";
            // 
            // backButtonImage
            // 
            this.backButtonImage.Location = new System.Drawing.Point(23, 23);
            this.backButtonImage.Name = "backButtonImage";
            this.backButtonImage.Size = new System.Drawing.Size(97, 43);
            this.backButtonImage.TabIndex = 19;
            this.backButtonImage.TabStop = false;
            this.backButtonImage.Click += new System.EventHandler(this.backButtonImage_Click);
            // 
            // manageCategoryImage
            // 
            this.manageCategoryImage.Location = new System.Drawing.Point(378, 82);
            this.manageCategoryImage.Name = "manageCategoryImage";
            this.manageCategoryImage.Size = new System.Drawing.Size(145, 133);
            this.manageCategoryImage.TabIndex = 20;
            this.manageCategoryImage.TabStop = false;
            // 
            // manageCategoryInputs
            // 
            this.manageCategoryInputs.Controls.Add(this.label1);
            this.manageCategoryInputs.Controls.Add(this.brandTextBox);
            this.manageCategoryInputs.Controls.Add(this.label2);
            this.manageCategoryInputs.Controls.Add(this.label3);
            this.manageCategoryInputs.Controls.Add(this.label4);
            this.manageCategoryInputs.Controls.Add(this.priceTextBox);
            this.manageCategoryInputs.Controls.Add(this.stockQuantityTextBox);
            this.manageCategoryInputs.Controls.Add(this.expiryDateTextBox);
            this.manageCategoryInputs.Location = new System.Drawing.Point(610, 271);
            this.manageCategoryInputs.Name = "manageCategoryInputs";
            this.manageCategoryInputs.Size = new System.Drawing.Size(306, 225);
            this.manageCategoryInputs.TabIndex = 21;
            this.manageCategoryInputs.TabStop = false;
            this.manageCategoryInputs.Text = "Ürün Bilgileri";
            // 
            // brandTextBox
            // 
            this.brandTextBox.Location = new System.Drawing.Point(99, 31);
            this.brandTextBox.Name = "brandTextBox";
            this.brandTextBox.Size = new System.Drawing.Size(100, 20);
            this.brandTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Brand:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Price:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "stockQuantity:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "expiryDate:";
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(99, 80);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(100, 20);
            this.priceTextBox.TabIndex = 6;
            // 
            // stockQuantityTextBox
            // 
            this.stockQuantityTextBox.Location = new System.Drawing.Point(99, 119);
            this.stockQuantityTextBox.Name = "stockQuantityTextBox";
            this.stockQuantityTextBox.Size = new System.Drawing.Size(100, 20);
            this.stockQuantityTextBox.TabIndex = 7;
            this.stockQuantityTextBox.TextChanged += new System.EventHandler(this.stockQuantityTextBox_TextChanged);
            // 
            // expiryDateTextBox
            // 
            this.expiryDateTextBox.Location = new System.Drawing.Point(99, 160);
            this.expiryDateTextBox.Name = "expiryDateTextBox";
            this.expiryDateTextBox.Size = new System.Drawing.Size(100, 20);
            this.expiryDateTextBox.TabIndex = 8;
            // 
            // manageCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 603);
            this.Controls.Add(this.manageCategoryInputs);
            this.Controls.Add(this.manageCategoryImage);
            this.Controls.Add(this.backButtonImage);
            this.Controls.Add(this.labelSearchItem);
            this.Controls.Add(this.searchItemTextBox);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonList);
            this.Controls.Add(this.itemsList);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.categoryNameLabel);
            this.Name = "manageCategory";
            this.Text = "manageCategory";
            this.Load += new System.EventHandler(this.manageCategory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.backButtonImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manageCategoryImage)).EndInit();
            this.manageCategoryInputs.ResumeLayout(false);
            this.manageCategoryInputs.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label categoryNameLabel;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.ListView itemsList;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader brand;
        private System.Windows.Forms.ColumnHeader expiryDate;
        private System.Windows.Forms.ColumnHeader stockQuantity;
        private System.Windows.Forms.ColumnHeader price;
        private System.Windows.Forms.ColumnHeader emptyColumn;
        private System.Windows.Forms.Button buttonList;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox searchItemTextBox;
        private System.Windows.Forms.Label labelSearchItem;
        private System.Windows.Forms.PictureBox backButtonImage;
        private System.Windows.Forms.PictureBox manageCategoryImage;
        private System.Windows.Forms.GroupBox manageCategoryInputs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox brandTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox stockQuantityTextBox;
        private System.Windows.Forms.TextBox expiryDateTextBox;
    }
}