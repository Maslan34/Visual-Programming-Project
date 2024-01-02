namespace project
{
    partial class mainPage
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
            this.labelCategories = new System.Windows.Forms.Label();
            this.buttonCategoriesShow = new System.Windows.Forms.Button();
            this.categoriesComboBox = new System.Windows.Forms.ComboBox();
            this.categoryPictureBox = new System.Windows.Forms.PictureBox();
            this.pieChart1 = new LiveChartsCore.SkiaSharpView.WinForms.PieChart();
            ((System.ComponentModel.ISupportInitialize)(this.categoryPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCategories
            // 
            this.labelCategories.AutoSize = true;
            this.labelCategories.Location = new System.Drawing.Point(364, 43);
            this.labelCategories.Name = "labelCategories";
            this.labelCategories.Size = new System.Drawing.Size(57, 13);
            this.labelCategories.TabIndex = 5;
            this.labelCategories.Text = "Categories";
            // 
            // buttonCategoriesShow
            // 
            this.buttonCategoriesShow.Location = new System.Drawing.Point(367, 337);
            this.buttonCategoriesShow.Name = "buttonCategoriesShow";
            this.buttonCategoriesShow.Size = new System.Drawing.Size(75, 23);
            this.buttonCategoriesShow.TabIndex = 6;
            this.buttonCategoriesShow.Text = "SHOW";
            this.buttonCategoriesShow.UseVisualStyleBackColor = true;
            this.buttonCategoriesShow.Click += new System.EventHandler(this.buttonCategoriesShow_Click);
            // 
            // categoriesComboBox
            // 
            this.categoriesComboBox.FormattingEnabled = true;
            this.categoriesComboBox.Location = new System.Drawing.Point(335, 78);
            this.categoriesComboBox.Name = "categoriesComboBox";
            this.categoriesComboBox.Size = new System.Drawing.Size(121, 21);
            this.categoriesComboBox.TabIndex = 7;
            this.categoriesComboBox.SelectedIndexChanged += new System.EventHandler(this.categoriesComboBox_SelectedIndexChanged);
            // 
            // categoryPictureBox
            // 
            this.categoryPictureBox.Location = new System.Drawing.Point(606, 120);
            this.categoryPictureBox.Name = "categoryPictureBox";
            this.categoryPictureBox.Size = new System.Drawing.Size(182, 213);
            this.categoryPictureBox.TabIndex = 8;
            this.categoryPictureBox.TabStop = false;
            this.categoryPictureBox.Click += new System.EventHandler(this.categoryPictureBox_Click);
            // 
            // pieChart1
            // 
            this.pieChart1.InitialRotation = 0D;
            this.pieChart1.IsClockwise = true;
            this.pieChart1.Location = new System.Drawing.Point(241, 105);
            this.pieChart1.MaxAngle = 360D;
            this.pieChart1.MaxValue = null;
            this.pieChart1.MinValue = 0D;
            this.pieChart1.Name = "pieChart1";
            this.pieChart1.Size = new System.Drawing.Size(329, 228);
            this.pieChart1.TabIndex = 9;
            this.pieChart1.Total = null;
            this.pieChart1.Load += new System.EventHandler(this.pieChart1_Load);
            // 
            // mainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pieChart1);
            this.Controls.Add(this.categoryPictureBox);
            this.Controls.Add(this.categoriesComboBox);
            this.Controls.Add(this.buttonCategoriesShow);
            this.Controls.Add(this.labelCategories);
            this.Name = "mainPage";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.mainPage_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            ((System.ComponentModel.ISupportInitialize)(this.categoryPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelCategories;
        private System.Windows.Forms.Button buttonCategoriesShow;
        private System.Windows.Forms.ComboBox categoriesComboBox;
        private System.Windows.Forms.PictureBox categoryPictureBox;
        private LiveChartsCore.SkiaSharpView.WinForms.PieChart pieChart1;
    }
}