﻿
namespace WindowsFormsApp1
{
    partial class Product_edit_delete_admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Product_edit_delete_admin));
            this.btnDelete = new WindowsFormsApp1.DSButton();
            this.lblNoLinkImage2 = new System.Windows.Forms.Label();
            this.txtLinkImage2 = new System.Windows.Forms.TextBox();
            this.lblNoLinkImage1 = new System.Windows.Forms.Label();
            this.cbbColor = new System.Windows.Forms.ComboBox();
            this.lblNoROM = new System.Windows.Forms.Label();
            this.lblNoRAM = new System.Windows.Forms.Label();
            this.txtROM = new System.Windows.Forms.TextBox();
            this.txtRAM = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtLinkImage1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbManufacturer = new System.Windows.Forms.ComboBox();
            this.lblNoQuantity = new System.Windows.Forms.Label();
            this.lblNoPrice = new System.Windows.Forms.Label();
            this.lblNoColor = new System.Windows.Forms.Label();
            this.lblNoManufacturer = new System.Windows.Forms.Label();
            this.lblNoName = new System.Windows.Forms.Label();
            this.btnCancel = new WindowsFormsApp1.DSButton();
            this.btnEdit = new WindowsFormsApp1.DSButton();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblForm = new System.Windows.Forms.Label();
            this.btnClearLinkImage2 = new System.Windows.Forms.Button();
            this.btnAddLinkImage = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Salmon;
            this.btnDelete.BackgroundColor = System.Drawing.Color.Salmon;
            this.btnDelete.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnDelete.BorderRadius = 20;
            this.btnDelete.BorderSize = 0;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(341, 581);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(155, 51);
            this.btnDelete.TabIndex = 139;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.TextColor = System.Drawing.Color.White;
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // lblNoLinkImage2
            // 
            this.lblNoLinkImage2.AutoSize = true;
            this.lblNoLinkImage2.BackColor = System.Drawing.Color.White;
            this.lblNoLinkImage2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoLinkImage2.ForeColor = System.Drawing.Color.Red;
            this.lblNoLinkImage2.Location = new System.Drawing.Point(695, 516);
            this.lblNoLinkImage2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNoLinkImage2.Name = "lblNoLinkImage2";
            this.lblNoLinkImage2.Size = new System.Drawing.Size(203, 17);
            this.lblNoLinkImage2.TabIndex = 137;
            this.lblNoLinkImage2.Text = "* Vui lòng nhập link hình ảnh";
            this.lblNoLinkImage2.Visible = false;
            // 
            // txtLinkImage2
            // 
            this.txtLinkImage2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLinkImage2.ForeColor = System.Drawing.Color.DarkGray;
            this.txtLinkImage2.Location = new System.Drawing.Point(687, 481);
            this.txtLinkImage2.Name = "txtLinkImage2";
            this.txtLinkImage2.Size = new System.Drawing.Size(366, 32);
            this.txtLinkImage2.TabIndex = 136;
            this.txtLinkImage2.Text = "Link URL hình ảnh 2";
            this.txtLinkImage2.Visible = false;
            this.txtLinkImage2.Click += new System.EventHandler(this.txtLinkImage2_Click);
            this.txtLinkImage2.TextChanged += new System.EventHandler(this.txtLinkImage2_TextChanged);
            this.txtLinkImage2.Leave += new System.EventHandler(this.txtLinkImage2_Leave);
            // 
            // lblNoLinkImage1
            // 
            this.lblNoLinkImage1.AutoSize = true;
            this.lblNoLinkImage1.BackColor = System.Drawing.Color.White;
            this.lblNoLinkImage1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoLinkImage1.ForeColor = System.Drawing.Color.Red;
            this.lblNoLinkImage1.Location = new System.Drawing.Point(251, 514);
            this.lblNoLinkImage1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNoLinkImage1.Name = "lblNoLinkImage1";
            this.lblNoLinkImage1.Size = new System.Drawing.Size(203, 17);
            this.lblNoLinkImage1.TabIndex = 134;
            this.lblNoLinkImage1.Text = "* Vui lòng nhập link hình ảnh";
            // 
            // cbbColor
            // 
            this.cbbColor.FormattingEnabled = true;
            this.cbbColor.Items.AddRange(new object[] {
            "Đen",
            "Đỏ",
            "Hồng",
            "Trắng",
            "Xám",
            "Xanh đen",
            "Xanh dương",
            "Xanh lá"});
            this.cbbColor.Location = new System.Drawing.Point(227, 295);
            this.cbbColor.Name = "cbbColor";
            this.cbbColor.Size = new System.Drawing.Size(367, 31);
            this.cbbColor.Sorted = true;
            this.cbbColor.TabIndex = 133;
            this.cbbColor.SelectedIndexChanged += new System.EventHandler(this.cbbColor_SelectedIndexChanged);
            this.cbbColor.TextChanged += new System.EventHandler(this.cbbColor_TextChanged);
            // 
            // lblNoROM
            // 
            this.lblNoROM.AutoSize = true;
            this.lblNoROM.BackColor = System.Drawing.Color.White;
            this.lblNoROM.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoROM.ForeColor = System.Drawing.Color.Red;
            this.lblNoROM.Location = new System.Drawing.Point(822, 267);
            this.lblNoROM.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNoROM.Name = "lblNoROM";
            this.lblNoROM.Size = new System.Drawing.Size(151, 17);
            this.lblNoROM.TabIndex = 132;
            this.lblNoROM.Text = "* Vui lòng nhập ROM";
            // 
            // lblNoRAM
            // 
            this.lblNoRAM.AutoSize = true;
            this.lblNoRAM.BackColor = System.Drawing.Color.White;
            this.lblNoRAM.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoRAM.ForeColor = System.Drawing.Color.Red;
            this.lblNoRAM.Location = new System.Drawing.Point(822, 203);
            this.lblNoRAM.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNoRAM.Name = "lblNoRAM";
            this.lblNoRAM.Size = new System.Drawing.Size(149, 17);
            this.lblNoRAM.TabIndex = 131;
            this.lblNoRAM.Text = "* Vui lòng nhập RAM";
            // 
            // txtROM
            // 
            this.txtROM.Location = new System.Drawing.Point(772, 232);
            this.txtROM.Name = "txtROM";
            this.txtROM.Size = new System.Drawing.Size(366, 32);
            this.txtROM.TabIndex = 130;
            this.txtROM.TextChanged += new System.EventHandler(this.txtROM_TextChanged);
            // 
            // txtRAM
            // 
            this.txtRAM.Location = new System.Drawing.Point(772, 168);
            this.txtRAM.Name = "txtRAM";
            this.txtRAM.Size = new System.Drawing.Size(366, 32);
            this.txtRAM.TabIndex = 129;
            this.txtRAM.TextChanged += new System.EventHandler(this.txtRAM_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(683, 235);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 23);
            this.label10.TabIndex = 128;
            this.label10.Text = "ROM";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(683, 171);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 23);
            this.label9.TabIndex = 127;
            this.label9.Text = "RAM";
            // 
            // txtLinkImage1
            // 
            this.txtLinkImage1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLinkImage1.ForeColor = System.Drawing.Color.DarkGray;
            this.txtLinkImage1.Location = new System.Drawing.Point(228, 479);
            this.txtLinkImage1.Name = "txtLinkImage1";
            this.txtLinkImage1.Size = new System.Drawing.Size(366, 32);
            this.txtLinkImage1.TabIndex = 126;
            this.txtLinkImage1.Text = "Link URL hình ảnh 1";
            this.txtLinkImage1.Click += new System.EventHandler(this.txtLinkImage1_Click);
            this.txtLinkImage1.TextChanged += new System.EventHandler(this.txtLinkImage1_TextChanged);
            this.txtLinkImage1.Leave += new System.EventHandler(this.txtLinkImage1_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(72, 479);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 23);
            this.label2.TabIndex = 125;
            this.label2.Text = "Hình ảnh";
            // 
            // cbbManufacturer
            // 
            this.cbbManufacturer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbManufacturer.FormattingEnabled = true;
            this.cbbManufacturer.Items.AddRange(new object[] {
            "Apple",
            "Oppo",
            "Realme",
            "Samsung",
            "Xiaomi"});
            this.cbbManufacturer.Location = new System.Drawing.Point(228, 235);
            this.cbbManufacturer.Name = "cbbManufacturer";
            this.cbbManufacturer.Size = new System.Drawing.Size(366, 31);
            this.cbbManufacturer.Sorted = true;
            this.cbbManufacturer.TabIndex = 124;
            this.cbbManufacturer.SelectedIndexChanged += new System.EventHandler(this.cbbManufacturer_SelectedIndexChanged);
            this.cbbManufacturer.TextChanged += new System.EventHandler(this.cbbManufacturer_TextChanged);
            // 
            // lblNoQuantity
            // 
            this.lblNoQuantity.AutoSize = true;
            this.lblNoQuantity.BackColor = System.Drawing.Color.White;
            this.lblNoQuantity.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoQuantity.ForeColor = System.Drawing.Color.Red;
            this.lblNoQuantity.Location = new System.Drawing.Point(251, 450);
            this.lblNoQuantity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNoQuantity.Name = "lblNoQuantity";
            this.lblNoQuantity.Size = new System.Drawing.Size(245, 17);
            this.lblNoQuantity.TabIndex = 123;
            this.lblNoQuantity.Text = "* Vui lòng chỉnh số lượng sản phẩm";
            // 
            // lblNoPrice
            // 
            this.lblNoPrice.AutoSize = true;
            this.lblNoPrice.BackColor = System.Drawing.Color.White;
            this.lblNoPrice.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoPrice.ForeColor = System.Drawing.Color.Red;
            this.lblNoPrice.Location = new System.Drawing.Point(251, 393);
            this.lblNoPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNoPrice.Name = "lblNoPrice";
            this.lblNoPrice.Size = new System.Drawing.Size(139, 17);
            this.lblNoPrice.TabIndex = 122;
            this.lblNoPrice.Text = "* Vui lòng nhập giá";
            // 
            // lblNoColor
            // 
            this.lblNoColor.AutoSize = true;
            this.lblNoColor.BackColor = System.Drawing.Color.White;
            this.lblNoColor.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoColor.ForeColor = System.Drawing.Color.Red;
            this.lblNoColor.Location = new System.Drawing.Point(251, 329);
            this.lblNoColor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNoColor.Name = "lblNoColor";
            this.lblNoColor.Size = new System.Drawing.Size(177, 17);
            this.lblNoColor.TabIndex = 121;
            this.lblNoColor.Text = "* Vui lòng nhập mã màu";
            // 
            // lblNoManufacturer
            // 
            this.lblNoManufacturer.AutoSize = true;
            this.lblNoManufacturer.BackColor = System.Drawing.Color.White;
            this.lblNoManufacturer.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoManufacturer.ForeColor = System.Drawing.Color.Red;
            this.lblNoManufacturer.Location = new System.Drawing.Point(251, 267);
            this.lblNoManufacturer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNoManufacturer.Name = "lblNoManufacturer";
            this.lblNoManufacturer.Size = new System.Drawing.Size(203, 17);
            this.lblNoManufacturer.TabIndex = 120;
            this.lblNoManufacturer.Text = "* Vui lòng nhập nhà sản xuất";
            // 
            // lblNoName
            // 
            this.lblNoName.AutoSize = true;
            this.lblNoName.BackColor = System.Drawing.Color.White;
            this.lblNoName.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoName.ForeColor = System.Drawing.Color.Red;
            this.lblNoName.Location = new System.Drawing.Point(251, 203);
            this.lblNoName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNoName.Name = "lblNoName";
            this.lblNoName.Size = new System.Drawing.Size(211, 17);
            this.lblNoName.TabIndex = 119;
            this.lblNoName.Text = "* Vui lòng nhập tên sản phẩm";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnCancel.BackgroundColor = System.Drawing.Color.MidnightBlue;
            this.btnCancel.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCancel.BorderRadius = 20;
            this.btnCancel.BorderSize = 0;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(519, 581);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(155, 51);
            this.btnCancel.TabIndex = 118;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.TextColor = System.Drawing.Color.White;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Salmon;
            this.btnEdit.BackgroundColor = System.Drawing.Color.Salmon;
            this.btnEdit.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnEdit.BorderRadius = 20;
            this.btnEdit.BorderSize = 0;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(165, 581);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(155, 51);
            this.btnEdit.TabIndex = 117;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.TextColor = System.Drawing.Color.White;
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // nudQuantity
            // 
            this.nudQuantity.Location = new System.Drawing.Point(228, 416);
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(120, 32);
            this.nudQuantity.TabIndex = 116;
            this.nudQuantity.ValueChanged += new System.EventHandler(this.nudQuantity_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(72, 416);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 23);
            this.label7.TabIndex = 115;
            this.label7.Text = "Số lượng";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(228, 358);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(366, 32);
            this.txtPrice.TabIndex = 114;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(72, 361);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 23);
            this.label6.TabIndex = 113;
            this.label6.Text = "Giá";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(72, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 23);
            this.label5.TabIndex = 112;
            this.label5.Text = "Màu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(72, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 23);
            this.label4.TabIndex = 111;
            this.label4.Text = "Nhà sản xuất";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(228, 168);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(366, 32);
            this.txtName.TabIndex = 110;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(72, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 23);
            this.label3.TabIndex = 109;
            this.label3.Text = "Tên sản phẩm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(194, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 40);
            this.label1.TabIndex = 106;
            this.label1.Text = "Thông tin sản phẩm";
            // 
            // lblForm
            // 
            this.lblForm.BackColor = System.Drawing.Color.White;
            this.lblForm.Location = new System.Drawing.Point(25, 134);
            this.lblForm.Name = "lblForm";
            this.lblForm.Size = new System.Drawing.Size(1150, 429);
            this.lblForm.TabIndex = 108;
            // 
            // btnClearLinkImage2
            // 
            this.btnClearLinkImage2.BackColor = System.Drawing.Color.White;
            this.btnClearLinkImage2.FlatAppearance.BorderSize = 0;
            this.btnClearLinkImage2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearLinkImage2.Image = ((System.Drawing.Image)(resources.GetObject("btnClearLinkImage2.Image")));
            this.btnClearLinkImage2.Location = new System.Drawing.Point(1080, 481);
            this.btnClearLinkImage2.Name = "btnClearLinkImage2";
            this.btnClearLinkImage2.Size = new System.Drawing.Size(37, 33);
            this.btnClearLinkImage2.TabIndex = 138;
            this.btnClearLinkImage2.UseVisualStyleBackColor = false;
            this.btnClearLinkImage2.Visible = false;
            this.btnClearLinkImage2.Click += new System.EventHandler(this.btnClearLinkImage2_Click);
            // 
            // btnAddLinkImage
            // 
            this.btnAddLinkImage.BackColor = System.Drawing.Color.White;
            this.btnAddLinkImage.FlatAppearance.BorderSize = 0;
            this.btnAddLinkImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddLinkImage.Image = ((System.Drawing.Image)(resources.GetObject("btnAddLinkImage.Image")));
            this.btnAddLinkImage.Location = new System.Drawing.Point(600, 479);
            this.btnAddLinkImage.Name = "btnAddLinkImage";
            this.btnAddLinkImage.Size = new System.Drawing.Size(37, 33);
            this.btnAddLinkImage.TabIndex = 135;
            this.btnAddLinkImage.UseVisualStyleBackColor = false;
            this.btnAddLinkImage.Click += new System.EventHandler(this.btnAddLinkImage_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(65, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(98, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 107;
            this.pictureBox1.TabStop = false;
            // 
            // Product_edit_delete_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1200, 647);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClearLinkImage2);
            this.Controls.Add(this.lblNoLinkImage2);
            this.Controls.Add(this.txtLinkImage2);
            this.Controls.Add(this.btnAddLinkImage);
            this.Controls.Add(this.lblNoLinkImage1);
            this.Controls.Add(this.cbbColor);
            this.Controls.Add(this.lblNoROM);
            this.Controls.Add(this.lblNoRAM);
            this.Controls.Add(this.txtROM);
            this.Controls.Add(this.txtRAM);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtLinkImage1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbbManufacturer);
            this.Controls.Add(this.lblNoQuantity);
            this.Controls.Add(this.lblNoPrice);
            this.Controls.Add(this.lblNoColor);
            this.Controls.Add(this.lblNoManufacturer);
            this.Controls.Add(this.lblNoName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.nudQuantity);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblForm);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Product_edit_delete_admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product_edit_delete_admin";
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DSButton btnDelete;
        private System.Windows.Forms.Button btnClearLinkImage2;
        private System.Windows.Forms.Label lblNoLinkImage2;
        private System.Windows.Forms.TextBox txtLinkImage2;
        private System.Windows.Forms.Button btnAddLinkImage;
        private System.Windows.Forms.Label lblNoLinkImage1;
        private System.Windows.Forms.ComboBox cbbColor;
        private System.Windows.Forms.Label lblNoROM;
        private System.Windows.Forms.Label lblNoRAM;
        private System.Windows.Forms.TextBox txtROM;
        private System.Windows.Forms.TextBox txtRAM;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtLinkImage1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbManufacturer;
        private System.Windows.Forms.Label lblNoQuantity;
        private System.Windows.Forms.Label lblNoPrice;
        private System.Windows.Forms.Label lblNoColor;
        private System.Windows.Forms.Label lblNoManufacturer;
        private System.Windows.Forms.Label lblNoName;
        private DSButton btnCancel;
        private DSButton btnEdit;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblForm;
    }
}