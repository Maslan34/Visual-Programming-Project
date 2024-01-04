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
            this.labelStatusCategory = new System.Windows.Forms.Label();
            this.categoryPictureBox = new System.Windows.Forms.PictureBox();
            this.pieChart1 = new LiveChartsCore.SkiaSharpView.WinForms.PieChart();
            this.menuIconPictureBox = new System.Windows.Forms.PictureBox();
            this.exitPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.categoryPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuIconPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // labelStatusCategory
            // 
            this.labelStatusCategory.AutoSize = true;
            this.labelStatusCategory.Location = new System.Drawing.Point(255, 49);
            this.labelStatusCategory.Name = "labelStatusCategory";
            this.labelStatusCategory.Size = new System.Drawing.Size(37, 13);
            this.labelStatusCategory.TabIndex = 5;
            this.labelStatusCategory.Text = "Status";
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
            // menuIconPictureBox
            // 
            this.menuIconPictureBox.Location = new System.Drawing.Point(12, 12);
            this.menuIconPictureBox.Name = "menuIconPictureBox";
            this.menuIconPictureBox.Size = new System.Drawing.Size(96, 38);
            this.menuIconPictureBox.TabIndex = 10;
            this.menuIconPictureBox.TabStop = false;
            this.menuIconPictureBox.Click += new System.EventHandler(this.menuIconPictureBox_Click);
            // 
            // exitPictureBox
            // 
            this.exitPictureBox.Location = new System.Drawing.Point(748, 23);
            this.exitPictureBox.Name = "exitPictureBox";
            this.exitPictureBox.Size = new System.Drawing.Size(40, 39);
            this.exitPictureBox.TabIndex = 11;
            this.exitPictureBox.TabStop = false;
            this.exitPictureBox.Click += new System.EventHandler(this.exitPictureBox_Click);
            // 
            // mainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitPictureBox);
            this.Controls.Add(this.menuIconPictureBox);
            this.Controls.Add(this.pieChart1);
            this.Controls.Add(this.categoryPictureBox);
            this.Controls.Add(this.labelStatusCategory);
            this.Name = "mainPage";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.mainPage_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            ((System.ComponentModel.ISupportInitialize)(this.categoryPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuIconPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelStatusCategory;
        private System.Windows.Forms.PictureBox categoryPictureBox;
        private LiveChartsCore.SkiaSharpView.WinForms.PieChart pieChart1;
        private System.Windows.Forms.PictureBox menuIconPictureBox;
        private System.Windows.Forms.PictureBox exitPictureBox;
    }
}