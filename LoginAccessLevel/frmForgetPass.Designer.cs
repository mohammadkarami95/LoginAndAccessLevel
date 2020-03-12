namespace LoginAccessLevel
{
    partial class frmForgetPass
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnSecurityQuestion = new System.Windows.Forms.RadioButton();
            this.rbtnEmail = new System.Windows.Forms.RadioButton();
            this.rbtnSMS = new System.Windows.Forms.RadioButton();
            this.btnSend = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.txtAnswerQuestion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.cmbSecurityQuestion = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(278, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "نام کاربری شما :";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(12, 6);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(257, 20);
            this.txtUserName.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnSecurityQuestion);
            this.groupBox1.Controls.Add(this.rbtnEmail);
            this.groupBox1.Controls.Add(this.rbtnSMS);
            this.groupBox1.Location = new System.Drawing.Point(12, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(348, 45);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "نحوه بازیابی";
            // 
            // rbtnSecurityQuestion
            // 
            this.rbtnSecurityQuestion.AutoSize = true;
            this.rbtnSecurityQuestion.Location = new System.Drawing.Point(6, 19);
            this.rbtnSecurityQuestion.Name = "rbtnSecurityQuestion";
            this.rbtnSecurityQuestion.Size = new System.Drawing.Size(83, 17);
            this.rbtnSecurityQuestion.TabIndex = 2;
            this.rbtnSecurityQuestion.Text = "سوال امنیتی";
            this.rbtnSecurityQuestion.UseVisualStyleBackColor = true;
            this.rbtnSecurityQuestion.CheckedChanged += new System.EventHandler(this.rbtnSecurityQuestion_CheckedChanged);
            // 
            // rbtnEmail
            // 
            this.rbtnEmail.AutoSize = true;
            this.rbtnEmail.Location = new System.Drawing.Point(123, 19);
            this.rbtnEmail.Name = "rbtnEmail";
            this.rbtnEmail.Size = new System.Drawing.Size(102, 17);
            this.rbtnEmail.TabIndex = 1;
            this.rbtnEmail.Text = "پست الکترونیکی";
            this.rbtnEmail.UseVisualStyleBackColor = true;
            this.rbtnEmail.CheckedChanged += new System.EventHandler(this.rbtnEmail_CheckedChanged);
            // 
            // rbtnSMS
            // 
            this.rbtnSMS.AutoSize = true;
            this.rbtnSMS.Checked = true;
            this.rbtnSMS.Location = new System.Drawing.Point(257, 19);
            this.rbtnSMS.Name = "rbtnSMS";
            this.rbtnSMS.Size = new System.Drawing.Size(72, 17);
            this.rbtnSMS.TabIndex = 0;
            this.rbtnSMS.TabStop = true;
            this.rbtnSMS.Text = "پیام کوتاه";
            this.rbtnSMS.UseVisualStyleBackColor = true;
            this.rbtnSMS.CheckedChanged += new System.EventHandler(this.rbtnSMS_CheckedChanged);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(12, 83);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(348, 33);
            this.btnSend.TabIndex = 3;
            this.btnSend.Text = "ارسال";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtPassword);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.txtAnswerQuestion);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.cmbSecurityQuestion);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 122);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(348, 165);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "سوال را انتخاب و به ان پاسخ دهید";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(6, 131);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(234, 20);
            this.txtPassword.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(258, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "نمایش کلمه عبور:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 102);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(234, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "نمایش رمز عبور";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtAnswerQuestion
            // 
            this.txtAnswerQuestion.Location = new System.Drawing.Point(6, 76);
            this.txtAnswerQuestion.Name = "txtAnswerQuestion";
            this.txtAnswerQuestion.Size = new System.Drawing.Size(234, 20);
            this.txtAnswerQuestion.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(246, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "پاسخ سوال امنیتی:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(234, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "بررسی";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cmbSecurityQuestion
            // 
            this.cmbSecurityQuestion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSecurityQuestion.Items.AddRange(new object[] {
            "نام غذای مورد علاقه شما چیست؟",
            "نام مکان مورد علاقه شما چیست ؟",
            "اسم مورد علاقه شما چیست؟",
            "کشور مورد علاقه شما چیست ؟",
            "نام معلم اول دبیرستان شما چیست؟",
            "زمینه ورزشی مورد علاقه شما چیست؟"});
            this.cmbSecurityQuestion.Location = new System.Drawing.Point(6, 49);
            this.cmbSecurityQuestion.Name = "cmbSecurityQuestion";
            this.cmbSecurityQuestion.Size = new System.Drawing.Size(234, 21);
            this.cmbSecurityQuestion.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(274, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "سوال امنیتی:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmForgetPass
            // 
            this.AcceptButton = this.btnSend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 297);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label1);
            this.Name = "frmForgetPass";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "بازیابی";
            this.Load += new System.EventHandler(this.frmForgetPass_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnSecurityQuestion;
        private System.Windows.Forms.RadioButton rbtnEmail;
        private System.Windows.Forms.RadioButton rbtnSMS;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtAnswerQuestion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cmbSecurityQuestion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}