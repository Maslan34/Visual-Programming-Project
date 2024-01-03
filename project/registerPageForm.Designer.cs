namespace project
{
    partial class registerPageForm
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
            System.Windows.Forms.Label registerPageLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(registerPageForm));
            this.registerButtonRegister = new System.Windows.Forms.Button();
            this.textBoxPasswordRegister = new System.Windows.Forms.TextBox();
            this.textLabelPassword = new System.Windows.Forms.Label();
            this.textBoxUsernameRegister = new System.Windows.Forms.TextBox();
            this.textLabelUsername = new System.Windows.Forms.Label();
            this.loginPageImage = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            registerPageLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.loginPageImage)).BeginInit();
            this.SuspendLayout();
            // 
            // registerPageLabel
            // 
            registerPageLabel.AutoSize = true;
            registerPageLabel.BackColor = System.Drawing.Color.LightSalmon;
            registerPageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            registerPageLabel.Location = new System.Drawing.Point(248, 15);
            registerPageLabel.Name = "registerPageLabel";
            registerPageLabel.Size = new System.Drawing.Size(316, 20);
            registerPageLabel.TabIndex = 16;
            registerPageLabel.Text = "Market Inventory Management System";
            // 
            // registerButtonRegister
            // 
            this.registerButtonRegister.Location = new System.Drawing.Point(290, 399);
            this.registerButtonRegister.Name = "registerButtonRegister";
            this.registerButtonRegister.Size = new System.Drawing.Size(220, 39);
            this.registerButtonRegister.TabIndex = 17;
            this.registerButtonRegister.Text = "REGISTER";
            this.registerButtonRegister.UseVisualStyleBackColor = true;
            this.registerButtonRegister.Click += new System.EventHandler(this.registerButtonRegister_Click);
            // 
            // textBoxPasswordRegister
            // 
            this.textBoxPasswordRegister.Location = new System.Drawing.Point(290, 344);
            this.textBoxPasswordRegister.Name = "textBoxPasswordRegister";
            this.textBoxPasswordRegister.Size = new System.Drawing.Size(248, 20);
            this.textBoxPasswordRegister.TabIndex = 15;
            // 
            // textLabelPassword
            // 
            this.textLabelPassword.AutoSize = true;
            this.textLabelPassword.Location = new System.Drawing.Point(154, 344);
            this.textLabelPassword.Name = "textLabelPassword";
            this.textLabelPassword.Size = new System.Drawing.Size(70, 13);
            this.textLabelPassword.TabIndex = 14;
            this.textLabelPassword.Text = "PASSWORD";
            // 
            // textBoxUsernameRegister
            // 
            this.textBoxUsernameRegister.Location = new System.Drawing.Point(290, 273);
            this.textBoxUsernameRegister.Name = "textBoxUsernameRegister";
            this.textBoxUsernameRegister.Size = new System.Drawing.Size(248, 20);
            this.textBoxUsernameRegister.TabIndex = 12;
            // 
            // textLabelUsername
            // 
            this.textLabelUsername.AutoSize = true;
            this.textLabelUsername.Location = new System.Drawing.Point(154, 273);
            this.textLabelUsername.Name = "textLabelUsername";
            this.textLabelUsername.Size = new System.Drawing.Size(68, 13);
            this.textLabelUsername.TabIndex = 11;
            this.textLabelUsername.Text = "USERNAME";
            // 
            // loginPageImage
            // 
            this.loginPageImage.Image = ((System.Drawing.Image)(resources.GetObject("loginPageImage.Image")));
            this.loginPageImage.Location = new System.Drawing.Point(178, 48);
            this.loginPageImage.Name = "loginPageImage";
            this.loginPageImage.Size = new System.Drawing.Size(468, 179);
            this.loginPageImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.loginPageImage.TabIndex = 10;
            this.loginPageImage.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(516, 410);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Already Registered ?";
            this.label1.Click += new System.EventHandler(this.alreadyRegistered_Click);
            // 
            // registerPageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.registerButtonRegister);
            this.Controls.Add(registerPageLabel);
            this.Controls.Add(this.textBoxPasswordRegister);
            this.Controls.Add(this.textLabelPassword);
            this.Controls.Add(this.textBoxUsernameRegister);
            this.Controls.Add(this.textLabelUsername);
            this.Controls.Add(this.loginPageImage);
            this.Name = "registerPageForm";
            this.Text = "registerPageForm";
            this.Load += new System.EventHandler(this.registerPageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loginPageImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button registerButtonRegister;
        private System.Windows.Forms.TextBox textBoxPasswordRegister;
        private System.Windows.Forms.Label textLabelPassword;
        private System.Windows.Forms.TextBox textBoxUsernameRegister;
        private System.Windows.Forms.Label textLabelUsername;
        private System.Windows.Forms.PictureBox loginPageImage;
        private System.Windows.Forms.Label label1;
    }
}