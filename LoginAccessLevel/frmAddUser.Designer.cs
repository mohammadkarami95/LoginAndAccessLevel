namespace LoginAccessLevel
{
    partial class frmAddUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddUser));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCaptchaCode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAddAdd = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSpeech = new System.Windows.Forms.Button();
            this.pbxCaptcha = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ckbCalculationAdd = new System.Windows.Forms.CheckBox();
            this.ckbChangeColorAdd = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txtConfimationAdd = new System.Windows.Forms.TextBox();
            this.txtPasswordAdd = new System.Windows.Forms.TextBox();
            this.txtUserNameAdd = new System.Windows.Forms.TextBox();
            this.txtNameFamilyAdd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbSecurityQuestionEdit = new System.Windows.Forms.ComboBox();
            this.btEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.gbxAccessLevel = new System.Windows.Forms.GroupBox();
            this.ckbChangeColorEdit = new System.Windows.Forms.CheckBox();
            this.ckbCalculationEdit = new System.Windows.Forms.CheckBox();
            this.ckbAddUserEdit = new System.Windows.Forms.CheckBox();
            this.txtConfirmationEdit = new System.Windows.Forms.TextBox();
            this.txtPasswordEdit = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtAnswerQuestionEdit = new System.Windows.Forms.TextBox();
            this.txtEmailEdit = new System.Windows.Forms.TextBox();
            this.txtNameFamilyEdit = new System.Windows.Forms.TextBox();
            this.txtMobileNumberEdit = new System.Windows.Forms.TextBox();
            this.txtUserNameEdit = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCaptcha)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gbxAccessLevel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCaptchaCode);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnAddAdd);
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.Controls.Add(this.btnSpeech);
            this.groupBox1.Controls.Add(this.pbxCaptcha);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txtConfimationAdd);
            this.groupBox1.Controls.Add(this.txtPasswordAdd);
            this.groupBox1.Controls.Add(this.txtUserNameAdd);
            this.groupBox1.Controls.Add(this.txtNameFamilyAdd);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(668, 185);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "اضافه کردن کاربر جدید";
            // 
            // txtCaptchaCode
            // 
            this.txtCaptchaCode.Location = new System.Drawing.Point(6, 130);
            this.txtCaptchaCode.Name = "txtCaptchaCode";
            this.txtCaptchaCode.Size = new System.Drawing.Size(100, 20);
            this.txtCaptchaCode.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(112, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "کدامنیتی:";
            // 
            // btnAddAdd
            // 
            this.btnAddAdd.Location = new System.Drawing.Point(170, 133);
            this.btnAddAdd.Name = "btnAddAdd";
            this.btnAddAdd.Size = new System.Drawing.Size(492, 38);
            this.btnAddAdd.TabIndex = 11;
            this.btnAddAdd.Text = "اضافه کردن";
            this.btnAddAdd.UseVisualStyleBackColor = true;
            this.btnAddAdd.Click += new System.EventHandler(this.btnAddAdd_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRefresh.BackgroundImage")));
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRefresh.Location = new System.Drawing.Point(6, 102);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(121, 22);
            this.btnRefresh.TabIndex = 10;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSpeech
            // 
            this.btnSpeech.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSpeech.BackgroundImage")));
            this.btnSpeech.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSpeech.Location = new System.Drawing.Point(6, 73);
            this.btnSpeech.Name = "btnSpeech";
            this.btnSpeech.Size = new System.Drawing.Size(121, 23);
            this.btnSpeech.TabIndex = 9;
            this.btnSpeech.UseVisualStyleBackColor = true;
            this.btnSpeech.Click += new System.EventHandler(this.btnSpeech_Click);
            // 
            // pbxCaptcha
            // 
            this.pbxCaptcha.Location = new System.Drawing.Point(6, 19);
            this.pbxCaptcha.Name = "pbxCaptcha";
            this.pbxCaptcha.Size = new System.Drawing.Size(121, 48);
            this.pbxCaptcha.TabIndex = 1;
            this.pbxCaptcha.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ckbCalculationAdd);
            this.groupBox2.Controls.Add(this.ckbChangeColorAdd);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Location = new System.Drawing.Point(133, 73);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(529, 52);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // ckbCalculationAdd
            // 
            this.ckbCalculationAdd.AutoSize = true;
            this.ckbCalculationAdd.Location = new System.Drawing.Point(6, 19);
            this.ckbCalculationAdd.Name = "ckbCalculationAdd";
            this.ckbCalculationAdd.Size = new System.Drawing.Size(93, 17);
            this.ckbCalculationAdd.TabIndex = 2;
            this.ckbCalculationAdd.Text = "انجام محاسبات";
            this.ckbCalculationAdd.UseVisualStyleBackColor = true;
            // 
            // ckbChangeColorAdd
            // 
            this.ckbChangeColorAdd.AutoSize = true;
            this.ckbChangeColorAdd.Location = new System.Drawing.Point(204, 19);
            this.ckbChangeColorAdd.Name = "ckbChangeColorAdd";
            this.ckbChangeColorAdd.Size = new System.Drawing.Size(110, 17);
            this.ckbChangeColorAdd.TabIndex = 1;
            this.ckbChangeColorAdd.Text = "تغییر رنگ نرم افزار";
            this.ckbChangeColorAdd.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Enabled = false;
            this.checkBox1.Location = new System.Drawing.Point(419, 19);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(108, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "اضافه کردن کاربر";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // txtConfimationAdd
            // 
            this.txtConfimationAdd.Location = new System.Drawing.Point(133, 47);
            this.txtConfimationAdd.Name = "txtConfimationAdd";
            this.txtConfimationAdd.Size = new System.Drawing.Size(156, 20);
            this.txtConfimationAdd.TabIndex = 7;
            // 
            // txtPasswordAdd
            // 
            this.txtPasswordAdd.Location = new System.Drawing.Point(401, 47);
            this.txtPasswordAdd.Name = "txtPasswordAdd";
            this.txtPasswordAdd.Size = new System.Drawing.Size(158, 20);
            this.txtPasswordAdd.TabIndex = 6;
            // 
            // txtUserNameAdd
            // 
            this.txtUserNameAdd.Location = new System.Drawing.Point(133, 19);
            this.txtUserNameAdd.Name = "txtUserNameAdd";
            this.txtUserNameAdd.Size = new System.Drawing.Size(156, 20);
            this.txtUserNameAdd.TabIndex = 5;
            // 
            // txtNameFamilyAdd
            // 
            this.txtNameFamilyAdd.Location = new System.Drawing.Point(401, 19);
            this.txtNameFamilyAdd.Name = "txtNameFamilyAdd";
            this.txtNameFamilyAdd.Size = new System.Drawing.Size(158, 20);
            this.txtNameFamilyAdd.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(295, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "تایید کلمه عبور:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(607, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "کلمه عبور:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(310, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "نام کاربری :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(565, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "نام و نام خانوادگی:";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.cmbSecurityQuestionEdit);
            this.groupBox3.Controls.Add(this.btEdit);
            this.groupBox3.Controls.Add(this.btnDelete);
            this.groupBox3.Controls.Add(this.gbxAccessLevel);
            this.groupBox3.Controls.Add(this.txtConfirmationEdit);
            this.groupBox3.Controls.Add(this.txtPasswordEdit);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txtAnswerQuestionEdit);
            this.groupBox3.Controls.Add(this.txtEmailEdit);
            this.groupBox3.Controls.Add(this.txtNameFamilyEdit);
            this.groupBox3.Controls.Add(this.txtMobileNumberEdit);
            this.groupBox3.Controls.Add(this.txtUserNameEdit);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(12, 203);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(668, 383);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ویرایش مشخصات کلیه کاربران";
            // 
            // cmbSecurityQuestionEdit
            // 
            this.cmbSecurityQuestionEdit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSecurityQuestionEdit.FormattingEnabled = true;
            this.cmbSecurityQuestionEdit.Items.AddRange(new object[] {
            "نام غذای مورد علاقه شما چیست؟",
            "نام مکان مورد علاقه شما چیست ؟",
            "اسم مورد علاقه شما چیست؟",
            "کشور مورد علاقه شما چیست ؟",
            "نام معلم اول دبیرستان شما چیست؟",
            "زمینه ورزشی مورد علاقه شما چیست؟"});
            this.cmbSecurityQuestionEdit.Location = new System.Drawing.Point(339, 238);
            this.cmbSecurityQuestionEdit.Name = "cmbSecurityQuestionEdit";
            this.cmbSecurityQuestionEdit.Size = new System.Drawing.Size(217, 21);
            this.cmbSecurityQuestionEdit.TabIndex = 16;
            // 
            // btEdit
            // 
            this.btEdit.Location = new System.Drawing.Point(188, 335);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(116, 42);
            this.btEdit.TabIndex = 3;
            this.btEdit.Text = "ویرایش";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(12, 335);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(116, 42);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "حذف";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // gbxAccessLevel
            // 
            this.gbxAccessLevel.Controls.Add(this.ckbChangeColorEdit);
            this.gbxAccessLevel.Controls.Add(this.ckbCalculationEdit);
            this.gbxAccessLevel.Controls.Add(this.ckbAddUserEdit);
            this.gbxAccessLevel.Location = new System.Drawing.Point(6, 264);
            this.gbxAccessLevel.Name = "gbxAccessLevel";
            this.gbxAccessLevel.Size = new System.Drawing.Size(298, 65);
            this.gbxAccessLevel.TabIndex = 15;
            this.gbxAccessLevel.TabStop = false;
            // 
            // ckbChangeColorEdit
            // 
            this.ckbChangeColorEdit.AutoSize = true;
            this.ckbChangeColorEdit.Location = new System.Drawing.Point(182, 42);
            this.ckbChangeColorEdit.Name = "ckbChangeColorEdit";
            this.ckbChangeColorEdit.Size = new System.Drawing.Size(110, 17);
            this.ckbChangeColorEdit.TabIndex = 2;
            this.ckbChangeColorEdit.Text = "تغییر رنگ نرم افزار";
            this.ckbChangeColorEdit.UseVisualStyleBackColor = true;
            // 
            // ckbCalculationEdit
            // 
            this.ckbCalculationEdit.AutoSize = true;
            this.ckbCalculationEdit.Location = new System.Drawing.Point(75, 19);
            this.ckbCalculationEdit.Name = "ckbCalculationEdit";
            this.ckbCalculationEdit.Size = new System.Drawing.Size(93, 17);
            this.ckbCalculationEdit.TabIndex = 1;
            this.ckbCalculationEdit.Text = "انجام محاسبات";
            this.ckbCalculationEdit.UseVisualStyleBackColor = true;
            // 
            // ckbAddUserEdit
            // 
            this.ckbAddUserEdit.AutoSize = true;
            this.ckbAddUserEdit.Enabled = false;
            this.ckbAddUserEdit.Location = new System.Drawing.Point(184, 19);
            this.ckbAddUserEdit.Name = "ckbAddUserEdit";
            this.ckbAddUserEdit.Size = new System.Drawing.Size(108, 17);
            this.ckbAddUserEdit.TabIndex = 0;
            this.ckbAddUserEdit.Text = "اضافه کردن کاربر";
            this.ckbAddUserEdit.UseVisualStyleBackColor = true;
            // 
            // txtConfirmationEdit
            // 
            this.txtConfirmationEdit.Location = new System.Drawing.Point(339, 290);
            this.txtConfirmationEdit.Name = "txtConfirmationEdit";
            this.txtConfirmationEdit.Size = new System.Drawing.Size(217, 20);
            this.txtConfirmationEdit.TabIndex = 14;
            // 
            // txtPasswordEdit
            // 
            this.txtPasswordEdit.Location = new System.Drawing.Point(339, 264);
            this.txtPasswordEdit.Name = "txtPasswordEdit";
            this.txtPasswordEdit.Size = new System.Drawing.Size(217, 20);
            this.txtPasswordEdit.TabIndex = 13;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(586, 293);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "تایید کلمه عبور:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(607, 267);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "کلمه عبور:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(597, 241);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "سوال امنیتی";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(211, 241);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "پاسخ سوال امنیتی:";
            // 
            // txtAnswerQuestionEdit
            // 
            this.txtAnswerQuestionEdit.Location = new System.Drawing.Point(6, 238);
            this.txtAnswerQuestionEdit.Name = "txtAnswerQuestionEdit";
            this.txtAnswerQuestionEdit.Size = new System.Drawing.Size(199, 20);
            this.txtAnswerQuestionEdit.TabIndex = 9;
            // 
            // txtEmailEdit
            // 
            this.txtEmailEdit.Location = new System.Drawing.Point(6, 212);
            this.txtEmailEdit.Name = "txtEmailEdit";
            this.txtEmailEdit.Size = new System.Drawing.Size(199, 20);
            this.txtEmailEdit.TabIndex = 8;
            // 
            // txtNameFamilyEdit
            // 
            this.txtNameFamilyEdit.Location = new System.Drawing.Point(339, 212);
            this.txtNameFamilyEdit.Name = "txtNameFamilyEdit";
            this.txtNameFamilyEdit.Size = new System.Drawing.Size(217, 20);
            this.txtNameFamilyEdit.TabIndex = 7;
            // 
            // txtMobileNumberEdit
            // 
            this.txtMobileNumberEdit.Location = new System.Drawing.Point(6, 186);
            this.txtMobileNumberEdit.Name = "txtMobileNumberEdit";
            this.txtMobileNumberEdit.Size = new System.Drawing.Size(199, 20);
            this.txtMobileNumberEdit.TabIndex = 6;
            // 
            // txtUserNameEdit
            // 
            this.txtUserNameEdit.Enabled = false;
            this.txtUserNameEdit.Location = new System.Drawing.Point(339, 186);
            this.txtUserNameEdit.Name = "txtUserNameEdit";
            this.txtUserNameEdit.Size = new System.Drawing.Size(217, 20);
            this.txtUserNameEdit.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(249, 215);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "ادرس ایمیل:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(562, 215);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "نام و نام خانوادگی :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(235, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "شماره موبایل:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(601, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "نام کاربری:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(653, 161);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmAddUser
            // 
            this.AcceptButton = this.btnAddAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 598);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmAddUser";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "اضافه کردن کاربر جدید و ویرایش";
            this.Load += new System.EventHandler(this.frmAddUser_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCaptcha)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.gbxAccessLevel.ResumeLayout(false);
            this.gbxAccessLevel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCaptchaCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAddAdd;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSpeech;
        private System.Windows.Forms.PictureBox pbxCaptcha;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox ckbCalculationAdd;
        private System.Windows.Forms.CheckBox ckbChangeColorAdd;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox txtConfimationAdd;
        private System.Windows.Forms.TextBox txtPasswordAdd;
        private System.Windows.Forms.TextBox txtUserNameAdd;
        private System.Windows.Forms.TextBox txtNameFamilyAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox gbxAccessLevel;
        private System.Windows.Forms.CheckBox ckbChangeColorEdit;
        private System.Windows.Forms.CheckBox ckbCalculationEdit;
        private System.Windows.Forms.CheckBox ckbAddUserEdit;
        private System.Windows.Forms.TextBox txtConfirmationEdit;
        private System.Windows.Forms.TextBox txtPasswordEdit;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtAnswerQuestionEdit;
        private System.Windows.Forms.TextBox txtEmailEdit;
        private System.Windows.Forms.TextBox txtNameFamilyEdit;
        private System.Windows.Forms.TextBox txtMobileNumberEdit;
        private System.Windows.Forms.TextBox txtUserNameEdit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox cmbSecurityQuestionEdit;
    }
}