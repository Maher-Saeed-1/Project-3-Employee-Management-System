namespace Myprojeck
{
    partial class ListViewManagmendForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListViewManagmendForm));
            this.label1 = new System.Windows.Forms.Label();
            this.gpBData = new System.Windows.Forms.GroupBox();
            this.gpbggg = new System.Windows.Forms.GroupBox();
            this.rdogiral = new System.Windows.Forms.RadioButton();
            this.rdoMan = new System.Windows.Forms.RadioButton();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.textPhone = new System.Windows.Forms.TextBox();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.lstvData = new System.Windows.Forms.ListView();
            this.cmhID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cohFullName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmhEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmhPhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnAdd = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comBView = new System.Windows.Forms.ComboBox();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblEmailTow = new System.Windows.Forms.Label();
            this.lblPhoneTow = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lalID = new System.Windows.Forms.Label();
            this.lalName = new System.Windows.Forms.Label();
            this.lalEmail = new System.Windows.Forms.Label();
            this.lalPhone = new System.Windows.Forms.Label();
            this.lalAge = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.gpBData.SuspendLayout();
            this.gpbggg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(426, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "بيانات الموظفين";
            // 
            // gpBData
            // 
            this.gpBData.ContextMenuStrip = this.contextMenuStrip1;
            this.gpBData.Controls.Add(this.gpbggg);
            this.gpBData.Controls.Add(this.numericUpDown1);
            this.gpBData.Controls.Add(this.textPhone);
            this.gpBData.Controls.Add(this.textEmail);
            this.gpBData.Controls.Add(this.lblTime);
            this.gpBData.Controls.Add(this.lblPhone);
            this.gpBData.Controls.Add(this.lblEmail);
            this.gpBData.Controls.Add(this.lblName);
            this.gpBData.Controls.Add(this.textName);
            this.gpBData.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpBData.Location = new System.Drawing.Point(692, 63);
            this.gpBData.Margin = new System.Windows.Forms.Padding(4);
            this.gpBData.Name = "gpBData";
            this.gpBData.Padding = new System.Windows.Forms.Padding(4);
            this.gpBData.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gpBData.Size = new System.Drawing.Size(749, 223);
            this.gpBData.TabIndex = 1;
            this.gpBData.TabStop = false;
            this.gpBData.Text = "بيانات الموظف";
            this.gpBData.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // gpbggg
            // 
            this.gpbggg.Controls.Add(this.rdogiral);
            this.gpbggg.Controls.Add(this.rdoMan);
            this.gpbggg.Location = new System.Drawing.Point(0, 35);
            this.gpbggg.Name = "gpbggg";
            this.gpbggg.Size = new System.Drawing.Size(265, 76);
            this.gpbggg.TabIndex = 8;
            this.gpbggg.TabStop = false;
            this.gpbggg.Text = "الجنس";
            // 
            // rdogiral
            // 
            this.rdogiral.AutoSize = true;
            this.rdogiral.Location = new System.Drawing.Point(0, 31);
            this.rdogiral.Name = "rdogiral";
            this.rdogiral.Size = new System.Drawing.Size(69, 28);
            this.rdogiral.TabIndex = 9;
            this.rdogiral.Text = "أنثى";
            this.rdogiral.UseVisualStyleBackColor = true;
            // 
            // rdoMan
            // 
            this.rdoMan.AutoSize = true;
            this.rdoMan.Checked = true;
            this.rdoMan.Location = new System.Drawing.Point(128, 31);
            this.rdoMan.Name = "rdoMan";
            this.rdoMan.Size = new System.Drawing.Size(58, 28);
            this.rdoMan.TabIndex = 8;
            this.rdoMan.TabStop = true;
            this.rdoMan.Text = "ذكر";
            this.rdoMan.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(272, 179);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(286, 32);
            this.numericUpDown1.TabIndex = 20;
            // 
            // textPhone
            // 
            this.textPhone.Location = new System.Drawing.Point(272, 124);
            this.textPhone.Margin = new System.Windows.Forms.Padding(4);
            this.textPhone.Name = "textPhone";
            this.textPhone.Size = new System.Drawing.Size(286, 32);
            this.textPhone.TabIndex = 6;
            this.textPhone.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(272, 84);
            this.textEmail.Margin = new System.Windows.Forms.Padding(4);
            this.textEmail.Name = "textEmail";
            this.textEmail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textEmail.Size = new System.Drawing.Size(286, 32);
            this.textEmail.TabIndex = 5;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(566, 175);
            this.lblTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(103, 24);
            this.lblTime.TabIndex = 4;
            this.lblTime.Text = "كم عمرك:";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(566, 125);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(118, 24);
            this.lblPhone.TabIndex = 3;
            this.lblPhone.Text = "رقم الهاتف:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(566, 84);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(171, 24);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "البريد الالكتروني:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(566, 33);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(140, 24);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "الاسم الكامل:";
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(272, 33);
            this.textName.Margin = new System.Windows.Forms.Padding(4);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(286, 32);
            this.textName.TabIndex = 0;
            // 
            // lstvData
            // 
            this.lstvData.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cmhID,
            this.cohFullName,
            this.cmhEmail,
            this.cmhPhone});
            this.lstvData.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstvData.HideSelection = false;
            this.lstvData.LargeImageList = this.imageList1;
            this.lstvData.Location = new System.Drawing.Point(-2, 347);
            this.lstvData.Name = "lstvData";
            this.lstvData.Size = new System.Drawing.Size(1443, 405);
            this.lstvData.SmallImageList = this.imageList1;
            this.lstvData.TabIndex = 2;
            this.lstvData.UseCompatibleStateImageBehavior = false;
            this.lstvData.View = System.Windows.Forms.View.Details;
            this.lstvData.DoubleClick += new System.EventHandler(this.lstvData_DoubleClick);
            // 
            // cmhID
            // 
            this.cmhID.Text = "ID";
            this.cmhID.Width = 142;
            // 
            // cohFullName
            // 
            this.cohFullName.Text = "FullName";
            this.cohFullName.Width = 250;
            // 
            // cmhEmail
            // 
            this.cmhEmail.Text = "Email";
            this.cmhEmail.Width = 250;
            // 
            // cmhPhone
            // 
            this.cmhPhone.Text = "Phone";
            this.cmhPhone.Width = 250;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Weak.png");
            this.imageList1.Images.SetKeyName(1, "Man.png");
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(1216, 293);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(167, 46);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "اضافة";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1027, 293);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 46);
            this.button1.TabIndex = 3;
            this.button1.Text = "حذف";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(845, 293);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(167, 46);
            this.button2.TabIndex = 4;
            this.button2.Text = "تعديل";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(602, 293);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(223, 46);
            this.button3.TabIndex = 5;
            this.button3.Text = "اضافة بشكل عشواىي";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(310, 307);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(143, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "طريقة العرض:";
            // 
            // comBView
            // 
            this.comBView.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBView.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comBView.FormattingEnabled = true;
            this.comBView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comBView.Items.AddRange(new object[] {
            "LargeIcon",
            "SmallIcon",
            "Tidlt",
            "List",
            "Detalist"});
            this.comBView.Location = new System.Drawing.Point(12, 307);
            this.comBView.Name = "comBView";
            this.comBView.Size = new System.Drawing.Size(280, 36);
            this.comBView.TabIndex = 8;
            this.comBView.UseWaitCursor = true;
            this.comBView.SelectedIndexChanged += new System.EventHandler(this.comBView_SelectedIndexChanged);
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.Location = new System.Drawing.Point(223, 63);
            this.lblFullName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblFullName.Size = new System.Drawing.Size(140, 24);
            this.lblFullName.TabIndex = 9;
            this.lblFullName.Text = "الاسم الكامل:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(223, 20);
            this.lblID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblID.Name = "lblID";
            this.lblID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblID.Size = new System.Drawing.Size(85, 24);
            this.lblID.TabIndex = 10;
            this.lblID.Text = "المعرف:";
            // 
            // lblEmailTow
            // 
            this.lblEmailTow.AutoSize = true;
            this.lblEmailTow.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailTow.Location = new System.Drawing.Point(223, 108);
            this.lblEmailTow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmailTow.Name = "lblEmailTow";
            this.lblEmailTow.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblEmailTow.Size = new System.Drawing.Size(67, 24);
            this.lblEmailTow.TabIndex = 11;
            this.lblEmailTow.Text = "البريد:";
            // 
            // lblPhoneTow
            // 
            this.lblPhoneTow.AutoSize = true;
            this.lblPhoneTow.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneTow.Location = new System.Drawing.Point(223, 150);
            this.lblPhoneTow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhoneTow.Name = "lblPhoneTow";
            this.lblPhoneTow.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPhoneTow.Size = new System.Drawing.Size(77, 24);
            this.lblPhoneTow.TabIndex = 12;
            this.lblPhoneTow.Text = "الهاتف:";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.Location = new System.Drawing.Point(223, 191);
            this.lblAge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAge.Name = "lblAge";
            this.lblAge.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblAge.Size = new System.Drawing.Size(65, 24);
            this.lblAge.TabIndex = 13;
            this.lblAge.Text = "العمر:";
            // 
            // lalID
            // 
            this.lalID.AutoSize = true;
            this.lalID.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lalID.Location = new System.Drawing.Point(13, 14);
            this.lalID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lalID.Name = "lalID";
            this.lalID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lalID.Size = new System.Drawing.Size(0, 24);
            this.lalID.TabIndex = 15;
            // 
            // lalName
            // 
            this.lalName.AutoSize = true;
            this.lalName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lalName.Location = new System.Drawing.Point(13, 57);
            this.lalName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lalName.Name = "lalName";
            this.lalName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lalName.Size = new System.Drawing.Size(0, 24);
            this.lalName.TabIndex = 16;
            // 
            // lalEmail
            // 
            this.lalEmail.AutoSize = true;
            this.lalEmail.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lalEmail.Location = new System.Drawing.Point(13, 102);
            this.lalEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lalEmail.Name = "lalEmail";
            this.lalEmail.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lalEmail.Size = new System.Drawing.Size(0, 24);
            this.lalEmail.TabIndex = 17;
            // 
            // lalPhone
            // 
            this.lalPhone.AutoSize = true;
            this.lalPhone.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lalPhone.Location = new System.Drawing.Point(13, 145);
            this.lalPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lalPhone.Name = "lalPhone";
            this.lalPhone.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lalPhone.Size = new System.Drawing.Size(0, 24);
            this.lalPhone.TabIndex = 18;
            this.lalPhone.Click += new System.EventHandler(this.label6_Click);
            // 
            // lalAge
            // 
            this.lalAge.AutoSize = true;
            this.lalAge.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lalAge.Location = new System.Drawing.Point(13, 185);
            this.lalAge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lalAge.Name = "lalAge";
            this.lalAge.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lalAge.Size = new System.Drawing.Size(0, 24);
            this.lalAge.TabIndex = 19;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(211, 80);
            this.contextMenuStrip1.Text = "ListView";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(210, 24);
            this.toolStripMenuItem1.Text = "FullName:";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(144, 24);
            this.toolStripMenuItem2.Text = "Email:";
            // 
            // ListViewManagmendForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1441, 733);
            this.Controls.Add(this.lalAge);
            this.Controls.Add(this.lalPhone);
            this.Controls.Add(this.lalEmail);
            this.Controls.Add(this.lalName);
            this.Controls.Add(this.lalID);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblPhoneTow);
            this.Controls.Add(this.lblEmailTow);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.comBView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lstvData);
            this.Controls.Add(this.gpBData);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ListViewManagmendForm";
            this.Text = "ListViewManagmendForm";
            this.Load += new System.EventHandler(this.ListViewManagmendForm_Load);
            this.gpBData.ResumeLayout(false);
            this.gpBData.PerformLayout();
            this.gpbggg.ResumeLayout(false);
            this.gpbggg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gpBData;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox textPhone;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.RadioButton rdoMan;
        private System.Windows.Forms.GroupBox gpbggg;
        private System.Windows.Forms.RadioButton rdogiral;
        private System.Windows.Forms.ListView lstvData;
        private System.Windows.Forms.ColumnHeader cohFullName;
        private System.Windows.Forms.ColumnHeader cmhEmail;
        private System.Windows.Forms.ColumnHeader cmhPhone;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ColumnHeader cmhID;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comBView;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblEmailTow;
        private System.Windows.Forms.Label lblPhoneTow;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lalID;
        private System.Windows.Forms.Label lalName;
        private System.Windows.Forms.Label lalEmail;
        private System.Windows.Forms.Label lalPhone;
        private System.Windows.Forms.Label lalAge;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
    }
}