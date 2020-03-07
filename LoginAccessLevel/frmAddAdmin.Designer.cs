namespace LoginAccessLevel
{
    partial class frmAddAdmin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddAdmin));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNameFamily = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtConfirmation = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtMobileNumber = new System.Windows.Forms.TextBox();
            this.txtAnswerQuestion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbSecurityQuestion = new System.Windows.Forms.ComboBox();
            this.pbxCaptcha = new System.Windows.Forms.PictureBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnCaptchaSpeech = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCaptchaCode = new System.Windows.Forms.TextBox();
            this.btnAddToDataBase = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbxCaptcha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(354, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "نام و نام خانوادگی :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(393, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "نام کاربری:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(399, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "کلمه عبور:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(375, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "تایید کلمه عبور:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(396, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "ادرس ایمیل:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(382, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "شماره موبایل:";
            // 
            // txtNameFamily
            // 
            this.txtNameFamily.Location = new System.Drawing.Point(12, 12);
            this.txtNameFamily.Name = "txtNameFamily";
            this.txtNameFamily.Size = new System.Drawing.Size(336, 20);
            this.txtNameFamily.TabIndex = 6;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(12, 38);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(336, 20);
            this.txtUserName.TabIndex = 7;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(12, 64);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(336, 20);
            this.txtPassword.TabIndex = 8;
            // 
            // txtConfirmation
            // 
            this.txtConfirmation.AutoCompleteCustomSource.AddRange(new string[] {
            "نام کتاب مورد علاقه شما چیست ؟",
            "نام غذی مورد علاقه شما چیست ؟",
            "مکان تولد شما کدام شهر هست ؟",
            "مکان مورد علاقه مشا کجاست ؟",
            "کشور مورد علاقه شما چیست ؟",
            "اهنگ مورد علاقه مشا چیست؟"});
            this.txtConfirmation.Location = new System.Drawing.Point(12, 90);
            this.txtConfirmation.Name = "txtConfirmation";
            this.txtConfirmation.Size = new System.Drawing.Size(336, 20);
            this.txtConfirmation.TabIndex = 9;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(12, 116);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(336, 20);
            this.txtEmail.TabIndex = 10;
            // 
            // txtMobileNumber
            // 
            this.txtMobileNumber.Location = new System.Drawing.Point(12, 142);
            this.txtMobileNumber.Name = "txtMobileNumber";
            this.txtMobileNumber.Size = new System.Drawing.Size(336, 20);
            this.txtMobileNumber.TabIndex = 11;
            // 
            // txtAnswerQuestion
            // 
            this.txtAnswerQuestion.Location = new System.Drawing.Point(12, 195);
            this.txtAnswerQuestion.Name = "txtAnswerQuestion";
            this.txtAnswerQuestion.Size = new System.Drawing.Size(336, 20);
            this.txtAnswerQuestion.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(386, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "سوال امنیتی:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(358, 198);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "پاسخ سوال امنیتی:";
            // 
            // cmbSecurityQuestion
            // 
            this.cmbSecurityQuestion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSecurityQuestion.FormattingEnabled = true;
            this.cmbSecurityQuestion.Items.AddRange(new object[] {
            "نام غذای مورد علاقه شما چیست؟",
            "نام مکان مورد علاقه شما چیست ؟",
            "اسم مورد علاقه شما چیست؟",
            "کشور مورد علاقه شما چیست ؟",
            "نام معلم اول دبیرستان شما چیست؟",
            "زمینه ورزشی مورد علاقه شما چیست؟"});
            this.cmbSecurityQuestion.Location = new System.Drawing.Point(12, 168);
            this.cmbSecurityQuestion.Name = "cmbSecurityQuestion";
            this.cmbSecurityQuestion.Size = new System.Drawing.Size(336, 21);
            this.cmbSecurityQuestion.TabIndex = 15;
            // 
            // pbxCaptcha
            // 
            this.pbxCaptcha.Location = new System.Drawing.Point(12, 221);
            this.pbxCaptcha.Name = "pbxCaptcha";
            this.pbxCaptcha.Size = new System.Drawing.Size(150, 70);
            this.pbxCaptcha.TabIndex = 16;
            this.pbxCaptcha.TabStop = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRefresh.BackgroundImage")));
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRefresh.Location = new System.Drawing.Point(187, 221);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(161, 32);
            this.btnRefresh.TabIndex = 17;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnCaptchaSpeech
            // 
            this.btnCaptchaSpeech.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCaptchaSpeech.BackgroundImage")));
            this.btnCaptchaSpeech.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCaptchaSpeech.Location = new System.Drawing.Point(187, 259);
            this.btnCaptchaSpeech.Name = "btnCaptchaSpeech";
            this.btnCaptchaSpeech.Size = new System.Drawing.Size(161, 32);
            this.btnCaptchaSpeech.TabIndex = 17;
            this.btnCaptchaSpeech.UseVisualStyleBackColor = true;
            this.btnCaptchaSpeech.Click += new System.EventHandler(this.btnCaptchaSpeech_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(296, 300);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "کد امنیتی:";
            // 
            // txtCaptchaCode
            // 
            this.txtCaptchaCode.Location = new System.Drawing.Point(12, 297);
            this.txtCaptchaCode.Name = "txtCaptchaCode";
            this.txtCaptchaCode.Size = new System.Drawing.Size(278, 20);
            this.txtCaptchaCode.TabIndex = 19;
            // 
            // btnAddToDataBase
            // 
            this.btnAddToDataBase.Location = new System.Drawing.Point(12, 335);
            this.btnAddToDataBase.Name = "btnAddToDataBase";
            this.btnAddToDataBase.Size = new System.Drawing.Size(336, 23);
            this.btnAddToDataBase.TabIndex = 20;
            this.btnAddToDataBase.Text = "اضافه کردن";
            this.btnAddToDataBase.UseVisualStyleBackColor = true;
            this.btnAddToDataBase.Click += new System.EventHandler(this.button3_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmAddAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 370);
            this.Controls.Add(this.btnAddToDataBase);
            this.Controls.Add(this.txtCaptchaCode);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnCaptchaSpeech);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.pbxCaptcha);
            this.Controls.Add(this.cmbSecurityQuestion);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtAnswerQuestion);
            this.Controls.Add(this.txtMobileNumber);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtConfirmation);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.txtNameFamily);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmAddAdmin";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "ثبت نام مدیر شرکت";
            this.Load += new System.EventHandler(this.frmAddAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxCaptcha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNameFamily;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtConfirmation;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtMobileNumber;
        private System.Windows.Forms.TextBox txtAnswerQuestion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbSecurityQuestion;
        private System.Windows.Forms.PictureBox pbxCaptcha;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnCaptchaSpeech;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCaptchaCode;
        private System.Windows.Forms.Button btnAddToDataBase;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}