using System;
namespace project
{
    partial class loginPageForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginPageForm));
            System.Windows.Forms.Label label1;
            this.loginPageImage = new System.Windows.Forms.PictureBox();
            this.textLabelUsername = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.loginPageButton = new System.Windows.Forms.Button();
            this.textLabelPassword = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.loginPageImage)).BeginInit();
            this.SuspendLayout();
            // 
            // loginPageImage
            // 
            this.loginPageImage.Image = ((System.Drawing.Image)(resources.GetObject("loginPageImage.Image")));
            this.loginPageImage.Location = new System.Drawing.Point(182, 51);
            this.loginPageImage.Name = "loginPageImage";
            this.loginPageImage.Size = new System.Drawing.Size(468, 179);
            this.loginPageImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.loginPageImage.TabIndex = 0;
            this.loginPageImage.TabStop = false;
            // 
            // textLabelUsername
            // 
            this.textLabelUsername.AutoSize = true;
            this.textLabelUsername.Location = new System.Drawing.Point(158, 276);
            this.textLabelUsername.Name = "textLabelUsername";
            this.textLabelUsername.Size = new System.Drawing.Size(68, 13);
            this.textLabelUsername.TabIndex = 2;
            this.textLabelUsername.Text = "USERNAME";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(294, 276);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(248, 20);
            this.textBoxUsername.TabIndex = 3;
            this.textBoxUsername.TextChanged += new System.EventHandler(this.textBoxUsername_TextChanged);
            // 
            // loginPageButton
            // 
            this.loginPageButton.Location = new System.Drawing.Point(294, 399);
            this.loginPageButton.Name = "loginPageButton";
            this.loginPageButton.Size = new System.Drawing.Size(248, 39);
            this.loginPageButton.TabIndex = 5;
            this.loginPageButton.Text = "LOGIN";
            this.loginPageButton.UseVisualStyleBackColor = true;
            this.loginPageButton.Click += new System.EventHandler(this.loginPageButton_Click);
            // 
            // textLabelPassword
            // 
            this.textLabelPassword.AutoSize = true;
            this.textLabelPassword.Location = new System.Drawing.Point(158, 347);
            this.textLabelPassword.Name = "textLabelPassword";
            this.textLabelPassword.Size = new System.Drawing.Size(70, 13);
            this.textLabelPassword.TabIndex = 6;
            this.textLabelPassword.Text = "PASSWORD";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(294, 347);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(248, 20);
            this.textBoxPassword.TabIndex = 7;
            this.textBoxPassword.TextChanged += new System.EventHandler(this.textBoxPassword_TextChanged);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.PaleGreen;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            label1.Location = new System.Drawing.Point(252, 18);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(316, 20);
            label1.TabIndex = 8;
            label1.Text = "Market Inventory Management System";
            // 
            // loginPageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(label1);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textLabelPassword);
            this.Controls.Add(this.loginPageButton);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.textLabelUsername);
            this.Controls.Add(this.loginPageImage);
            this.ForeColor = System.Drawing.Color.SeaGreen;
            this.Name = "loginPageForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.loginPageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loginPageImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox loginPageImage;
        private System.Windows.Forms.Label textLabelUsername;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Button loginPageButton;
        private System.Windows.Forms.Label textLabelPassword;
        private System.Windows.Forms.TextBox textBoxPassword;
    }
}

