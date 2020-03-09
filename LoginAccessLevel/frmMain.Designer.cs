namespace LoginAccessLevel
{
    partial class frmMain
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.gbxAddUser = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gbxChangeBackColor = new System.Windows.Forms.GroupBox();
            this.btnDefultColor = new System.Windows.Forms.Button();
            this.btnGreen = new System.Windows.Forms.Button();
            this.btnRed = new System.Windows.Forms.Button();
            this.btnBlue = new System.Windows.Forms.Button();
            this.gbxEdit = new System.Windows.Forms.GroupBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.gbxCalculation = new System.Windows.Forms.GroupBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnJam = new System.Windows.Forms.Button();
            this.btnTafrigh = new System.Windows.Forms.Button();
            this.btnZarb = new System.Windows.Forms.Button();
            this.btnTaghsim = new System.Windows.Forms.Button();
            this.txtNumberTwo = new System.Windows.Forms.TextBox();
            this.txtNumberOne = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.gbxAddUser.SuspendLayout();
            this.gbxChangeBackColor.SuspendLayout();
            this.gbxEdit.SuspendLayout();
            this.gbxCalculation.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblUserName);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(531, 52);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(241, 16);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(35, 13);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "label1";
            // 
            // gbxAddUser
            // 
            this.gbxAddUser.Controls.Add(this.btnAdd);
            this.gbxAddUser.Location = new System.Drawing.Point(332, 70);
            this.gbxAddUser.Name = "gbxAddUser";
            this.gbxAddUser.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gbxAddUser.Size = new System.Drawing.Size(211, 70);
            this.gbxAddUser.TabIndex = 1;
            this.gbxAddUser.TabStop = false;
            this.gbxAddUser.Text = "اضافه کردن کاربر جدید";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(18, 19);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(176, 32);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "برای اضافه کردن کلیک کنید";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // gbxChangeBackColor
            // 
            this.gbxChangeBackColor.Controls.Add(this.btnDefultColor);
            this.gbxChangeBackColor.Controls.Add(this.btnGreen);
            this.gbxChangeBackColor.Controls.Add(this.btnRed);
            this.gbxChangeBackColor.Controls.Add(this.btnBlue);
            this.gbxChangeBackColor.Location = new System.Drawing.Point(332, 146);
            this.gbxChangeBackColor.Name = "gbxChangeBackColor";
            this.gbxChangeBackColor.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gbxChangeBackColor.Size = new System.Drawing.Size(211, 180);
            this.gbxChangeBackColor.TabIndex = 2;
            this.gbxChangeBackColor.TabStop = false;
            this.gbxChangeBackColor.Text = "تغییر رنگ پس زمینه برنامه";
            // 
            // btnDefultColor
            // 
            this.btnDefultColor.Location = new System.Drawing.Point(18, 116);
            this.btnDefultColor.Name = "btnDefultColor";
            this.btnDefultColor.Size = new System.Drawing.Size(176, 23);
            this.btnDefultColor.TabIndex = 1;
            this.btnDefultColor.Text = "رنگ تست";
            this.btnDefultColor.UseVisualStyleBackColor = true;
            this.btnDefultColor.Click += new System.EventHandler(this.btnDefultColor_Click);
            // 
            // btnGreen
            // 
            this.btnGreen.Location = new System.Drawing.Point(18, 58);
            this.btnGreen.Name = "btnGreen";
            this.btnGreen.Size = new System.Drawing.Size(176, 23);
            this.btnGreen.TabIndex = 0;
            this.btnGreen.Text = "سبر";
            this.btnGreen.UseVisualStyleBackColor = true;
            this.btnGreen.Click += new System.EventHandler(this.btnGreen_Click);
            // 
            // btnRed
            // 
            this.btnRed.Location = new System.Drawing.Point(18, 87);
            this.btnRed.Name = "btnRed";
            this.btnRed.Size = new System.Drawing.Size(176, 23);
            this.btnRed.TabIndex = 0;
            this.btnRed.Text = "قرمز";
            this.btnRed.UseVisualStyleBackColor = true;
            this.btnRed.Click += new System.EventHandler(this.btnRed_Click);
            // 
            // btnBlue
            // 
            this.btnBlue.Location = new System.Drawing.Point(18, 29);
            this.btnBlue.Name = "btnBlue";
            this.btnBlue.Size = new System.Drawing.Size(176, 23);
            this.btnBlue.TabIndex = 0;
            this.btnBlue.Text = "ابی";
            this.btnBlue.UseVisualStyleBackColor = true;
            this.btnBlue.Click += new System.EventHandler(this.btnBlue_Click);
            // 
            // gbxEdit
            // 
            this.gbxEdit.Controls.Add(this.btnEdit);
            this.gbxEdit.Location = new System.Drawing.Point(12, 70);
            this.gbxEdit.Name = "gbxEdit";
            this.gbxEdit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gbxEdit.Size = new System.Drawing.Size(200, 70);
            this.gbxEdit.TabIndex = 3;
            this.gbxEdit.TabStop = false;
            this.gbxEdit.Text = "ویرایش مشخصات";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(6, 24);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(188, 23);
            this.btnEdit.TabIndex = 0;
            this.btnEdit.Text = "بارای ویرایش کلیک کنید";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // gbxCalculation
            // 
            this.gbxCalculation.Controls.Add(this.txtResult);
            this.gbxCalculation.Controls.Add(this.label4);
            this.gbxCalculation.Controls.Add(this.btnJam);
            this.gbxCalculation.Controls.Add(this.btnTafrigh);
            this.gbxCalculation.Controls.Add(this.btnZarb);
            this.gbxCalculation.Controls.Add(this.btnTaghsim);
            this.gbxCalculation.Controls.Add(this.txtNumberTwo);
            this.gbxCalculation.Controls.Add(this.txtNumberOne);
            this.gbxCalculation.Controls.Add(this.label3);
            this.gbxCalculation.Controls.Add(this.label2);
            this.gbxCalculation.Location = new System.Drawing.Point(12, 146);
            this.gbxCalculation.Name = "gbxCalculation";
            this.gbxCalculation.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gbxCalculation.Size = new System.Drawing.Size(200, 180);
            this.gbxCalculation.TabIndex = 1;
            this.gbxCalculation.TabStop = false;
            this.gbxCalculation.Text = "مجاسبات عددی";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(6, 144);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(136, 20);
            this.txtResult.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(157, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "نتیجه :";
            // 
            // btnJam
            // 
            this.btnJam.Location = new System.Drawing.Point(6, 115);
            this.btnJam.Name = "btnJam";
            this.btnJam.Size = new System.Drawing.Size(75, 23);
            this.btnJam.TabIndex = 7;
            this.btnJam.Text = "جمع";
            this.btnJam.UseVisualStyleBackColor = true;
            this.btnJam.Click += new System.EventHandler(this.btnJam_Click);
            // 
            // btnTafrigh
            // 
            this.btnTafrigh.Location = new System.Drawing.Point(6, 86);
            this.btnTafrigh.Name = "btnTafrigh";
            this.btnTafrigh.Size = new System.Drawing.Size(75, 23);
            this.btnTafrigh.TabIndex = 6;
            this.btnTafrigh.Text = "تفریق";
            this.btnTafrigh.UseVisualStyleBackColor = true;
            this.btnTafrigh.Click += new System.EventHandler(this.btnTafrigh_Click);
            // 
            // btnZarb
            // 
            this.btnZarb.Location = new System.Drawing.Point(87, 86);
            this.btnZarb.Name = "btnZarb";
            this.btnZarb.Size = new System.Drawing.Size(75, 23);
            this.btnZarb.TabIndex = 5;
            this.btnZarb.Text = "ضرب";
            this.btnZarb.UseVisualStyleBackColor = true;
            this.btnZarb.Click += new System.EventHandler(this.btnZarb_Click);
            // 
            // btnTaghsim
            // 
            this.btnTaghsim.Location = new System.Drawing.Point(87, 115);
            this.btnTaghsim.Name = "btnTaghsim";
            this.btnTaghsim.Size = new System.Drawing.Size(75, 23);
            this.btnTaghsim.TabIndex = 4;
            this.btnTaghsim.Text = "تقسیم";
            this.btnTaghsim.UseVisualStyleBackColor = true;
            this.btnTaghsim.Click += new System.EventHandler(this.btnTaghsim_Click);
            // 
            // txtNumberTwo
            // 
            this.txtNumberTwo.Location = new System.Drawing.Point(6, 60);
            this.txtNumberTwo.Name = "txtNumberTwo";
            this.txtNumberTwo.Size = new System.Drawing.Size(136, 20);
            this.txtNumberTwo.TabIndex = 3;
            // 
            // txtNumberOne
            // 
            this.txtNumberOne.Location = new System.Drawing.Point(6, 25);
            this.txtNumberOne.Name = "txtNumberOne";
            this.txtNumberOne.Size = new System.Drawing.Size(136, 20);
            this.txtNumberOne.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(148, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "عدد دوم :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "عدد اول :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 333);
            this.Controls.Add(this.gbxCalculation);
            this.Controls.Add(this.gbxEdit);
            this.Controls.Add(this.gbxChangeBackColor);
            this.Controls.Add(this.gbxAddUser);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMain";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "فرم اصلی";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbxAddUser.ResumeLayout(false);
            this.gbxChangeBackColor.ResumeLayout(false);
            this.gbxEdit.ResumeLayout(false);
            this.gbxCalculation.ResumeLayout(false);
            this.gbxCalculation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.GroupBox gbxAddUser;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox gbxChangeBackColor;
        private System.Windows.Forms.Button btnGreen;
        private System.Windows.Forms.Button btnRed;
        private System.Windows.Forms.Button btnBlue;
        private System.Windows.Forms.GroupBox gbxEdit;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.GroupBox gbxCalculation;
        private System.Windows.Forms.TextBox txtNumberTwo;
        private System.Windows.Forms.TextBox txtNumberOne;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnJam;
        private System.Windows.Forms.Button btnTafrigh;
        private System.Windows.Forms.Button btnZarb;
        private System.Windows.Forms.Button btnTaghsim;
        private System.Windows.Forms.Button btnDefultColor;

    }
}

