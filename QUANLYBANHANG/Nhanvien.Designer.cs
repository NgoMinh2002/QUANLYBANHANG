namespace QUANLYBANHANG
{
    partial class Nhanvien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nhanvien));
            this.text_search = new System.Windows.Forms.TextBox();
            this.btn_them = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_dong = new System.Windows.Forms.Button();
            this.btn_boqua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_luu = new System.Windows.Forms.Button();
            this.btn_capnhap = new System.Windows.Forms.Button();
            this.data_nhanvien = new System.Windows.Forms.DataGridView();
            this.mks_ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.mks_phone = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Ck_gioitinh = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.text_diachi = new System.Windows.Forms.TextBox();
            this.text_ten = new System.Windows.Forms.TextBox();
            this.text_ma = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_nhanvien)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // text_search
            // 
            this.text_search.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.text_search.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_search.Location = new System.Drawing.Point(275, 25);
            this.text_search.Multiline = true;
            this.text_search.Name = "text_search";
            this.text_search.Size = new System.Drawing.Size(431, 31);
            this.text_search.TabIndex = 1;
            this.text_search.TextChanged += new System.EventHandler(this.text_search_TextChanged);
            // 
            // btn_them
            // 
            this.btn_them.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_them.BackColor = System.Drawing.Color.Pink;
            this.btn_them.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.ForeColor = System.Drawing.Color.Black;
            this.btn_them.ImageKey = "pngtree-add-vector-icon-png-image_470700.jpg";
            this.btn_them.ImageList = this.imageList1;
            this.btn_them.Location = new System.Drawing.Point(9, 219);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(119, 40);
            this.btn_them.TabIndex = 30;
            this.btn_them.Text = "Thêm";
            this.btn_them.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "1200px-OOjs_UI_icon_search-ltr.svg.png");
            this.imageList1.Images.SetKeyName(1, "3405244.png");
            this.imageList1.Images.SetKeyName(2, "4856668.png");
            this.imageList1.Images.SetKeyName(3, "icons8-available-updates-350.png");
            this.imageList1.Images.SetKeyName(4, "pngtree-add-vector-icon-png-image_470700.jpg");
            this.imageList1.Images.SetKeyName(5, "shutdown-vector-icon-png_256704.jpg");
            this.imageList1.Images.SetKeyName(6, "transparent-skip-icon-next-icon-essential-compilation-icon-5f6274ef2e0178.5408751" +
        "916002879831885.jpg");
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_them);
            this.panel3.Controls.Add(this.btn_dong);
            this.panel3.Controls.Add(this.btn_boqua);
            this.panel3.Controls.Add(this.btn_xoa);
            this.panel3.Controls.Add(this.btn_luu);
            this.panel3.Controls.Add(this.btn_capnhap);
            this.panel3.Controls.Add(this.data_nhanvien);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 196);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(881, 272);
            this.panel3.TabIndex = 1;
            // 
            // btn_dong
            // 
            this.btn_dong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_dong.BackColor = System.Drawing.Color.Pink;
            this.btn_dong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dong.ImageIndex = 2;
            this.btn_dong.ImageList = this.imageList1;
            this.btn_dong.Location = new System.Drawing.Point(737, 221);
            this.btn_dong.Name = "btn_dong";
            this.btn_dong.Size = new System.Drawing.Size(132, 38);
            this.btn_dong.TabIndex = 22;
            this.btn_dong.Text = "Đóng";
            this.btn_dong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_dong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_dong.UseVisualStyleBackColor = false;
            this.btn_dong.Click += new System.EventHandler(this.btn_dong_Click);
            // 
            // btn_boqua
            // 
            this.btn_boqua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_boqua.BackColor = System.Drawing.Color.Pink;
            this.btn_boqua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_boqua.ImageIndex = 6;
            this.btn_boqua.ImageList = this.imageList1;
            this.btn_boqua.Location = new System.Drawing.Point(585, 219);
            this.btn_boqua.Name = "btn_boqua";
            this.btn_boqua.Size = new System.Drawing.Size(132, 40);
            this.btn_boqua.TabIndex = 21;
            this.btn_boqua.Text = "Bỏ qua";
            this.btn_boqua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_boqua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_boqua.UseVisualStyleBackColor = false;
            this.btn_boqua.Click += new System.EventHandler(this.btn_boqua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_xoa.BackColor = System.Drawing.Color.Pink;
            this.btn_xoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.ImageIndex = 1;
            this.btn_xoa.ImageList = this.imageList1;
            this.btn_xoa.Location = new System.Drawing.Point(436, 219);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(132, 42);
            this.btn_xoa.TabIndex = 20;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_xoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_luu
            // 
            this.btn_luu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_luu.BackColor = System.Drawing.Color.Pink;
            this.btn_luu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_luu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_luu.ImageIndex = 2;
            this.btn_luu.ImageList = this.imageList1;
            this.btn_luu.Location = new System.Drawing.Point(287, 219);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(134, 41);
            this.btn_luu.TabIndex = 19;
            this.btn_luu.Text = "Lưu\r\n";
            this.btn_luu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_luu.UseVisualStyleBackColor = false;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // btn_capnhap
            // 
            this.btn_capnhap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_capnhap.BackColor = System.Drawing.Color.Pink;
            this.btn_capnhap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_capnhap.ForeColor = System.Drawing.Color.Black;
            this.btn_capnhap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_capnhap.ImageKey = "icons8-available-updates-350.png";
            this.btn_capnhap.ImageList = this.imageList1;
            this.btn_capnhap.Location = new System.Drawing.Point(142, 219);
            this.btn_capnhap.Name = "btn_capnhap";
            this.btn_capnhap.Size = new System.Drawing.Size(131, 42);
            this.btn_capnhap.TabIndex = 17;
            this.btn_capnhap.Text = "Cập Nhập";
            this.btn_capnhap.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_capnhap.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_capnhap.UseVisualStyleBackColor = false;
            this.btn_capnhap.Click += new System.EventHandler(this.btn_capnhap_Click);
            // 
            // data_nhanvien
            // 
            this.data_nhanvien.BackgroundColor = System.Drawing.Color.White;
            this.data_nhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_nhanvien.Dock = System.Windows.Forms.DockStyle.Top;
            this.data_nhanvien.Location = new System.Drawing.Point(0, 0);
            this.data_nhanvien.Name = "data_nhanvien";
            this.data_nhanvien.RowHeadersWidth = 51;
            this.data_nhanvien.RowTemplate.Height = 24;
            this.data_nhanvien.Size = new System.Drawing.Size(881, 195);
            this.data_nhanvien.TabIndex = 0;
            this.data_nhanvien.Click += new System.EventHandler(this.data_nhanvien_Click);
            // 
            // mks_ngaysinh
            // 
            this.mks_ngaysinh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mks_ngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.mks_ngaysinh.Location = new System.Drawing.Point(578, 92);
            this.mks_ngaysinh.Name = "mks_ngaysinh";
            this.mks_ngaysinh.Size = new System.Drawing.Size(244, 22);
            this.mks_ngaysinh.TabIndex = 27;
            this.mks_ngaysinh.KeyUp += new System.Windows.Forms.KeyEventHandler(this.mks_ngaysinh_KeyUp);
            // 
            // mks_phone
            // 
            this.mks_phone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mks_phone.Location = new System.Drawing.Point(578, 10);
            this.mks_phone.Margin = new System.Windows.Forms.Padding(4);
            this.mks_phone.Mask = "(999) 000-0000";
            this.mks_phone.Name = "mks_phone";
            this.mks_phone.Size = new System.Drawing.Size(244, 22);
            this.mks_phone.TabIndex = 25;
            this.mks_phone.KeyUp += new System.Windows.Forms.KeyEventHandler(this.mks_ngaysinh_KeyUp);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(465, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 16);
            this.label8.TabIndex = 24;
            this.label8.Text = "Ngày Sinh";
            // 
            // Ck_gioitinh
            // 
            this.Ck_gioitinh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Ck_gioitinh.AutoSize = true;
            this.Ck_gioitinh.Location = new System.Drawing.Point(146, 96);
            this.Ck_gioitinh.Name = "Ck_gioitinh";
            this.Ck_gioitinh.Size = new System.Drawing.Size(58, 20);
            this.Ck_gioitinh.TabIndex = 23;
            this.Ck_gioitinh.Text = "Nam";
            this.Ck_gioitinh.UseVisualStyleBackColor = true;
            this.Ck_gioitinh.KeyUp += new System.Windows.Forms.KeyEventHandler(this.mks_ngaysinh_KeyUp);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 16);
            this.label6.TabIndex = 22;
            this.label6.Text = "Giới Tính";
            // 
            // text_diachi
            // 
            this.text_diachi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.text_diachi.Location = new System.Drawing.Point(578, 52);
            this.text_diachi.Name = "text_diachi";
            this.text_diachi.Size = new System.Drawing.Size(244, 22);
            this.text_diachi.TabIndex = 21;
            this.text_diachi.KeyUp += new System.Windows.Forms.KeyEventHandler(this.mks_ngaysinh_KeyUp);
            // 
            // text_ten
            // 
            this.text_ten.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.text_ten.Location = new System.Drawing.Point(146, 57);
            this.text_ten.Name = "text_ten";
            this.text_ten.Size = new System.Drawing.Size(252, 22);
            this.text_ten.TabIndex = 20;
            this.text_ten.KeyUp += new System.Windows.Forms.KeyEventHandler(this.mks_ngaysinh_KeyUp);
            // 
            // text_ma
            // 
            this.text_ma.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.text_ma.Location = new System.Drawing.Point(146, 12);
            this.text_ma.Name = "text_ma";
            this.text_ma.Size = new System.Drawing.Size(252, 22);
            this.text_ma.TabIndex = 19;
            this.text_ma.KeyUp += new System.Windows.Forms.KeyEventHandler(this.mks_ngaysinh_KeyUp);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(465, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "Điện thoại";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(465, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Địa Chỉ";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.text_search);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(881, 78);
            this.panel5.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(157, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tìm kiếm";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Tên Nhân Viên";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Mã Nhân Viên";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.mks_ngaysinh);
            this.panel6.Controls.Add(this.mks_phone);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Controls.Add(this.Ck_gioitinh);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.text_diachi);
            this.panel6.Controls.Add(this.text_ten);
            this.panel6.Controls.Add(this.text_ma);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 78);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(881, 118);
            this.panel6.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(881, 196);
            this.panel4.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(881, 468);
            this.panel2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Pink;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(881, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH MỤC NHÂN VIÊN\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(881, 44);
            this.panel1.TabIndex = 2;
            // 
            // Nhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.BackgroundImage = global::QUANLYBANHANG.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(881, 512);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Nhanvien";
            this.Text = "Nhanvien";
            this.Load += new System.EventHandler(this.Nhanvien_Load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data_nhanvien)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox text_search;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_dong;
        private System.Windows.Forms.Button btn_boqua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.Button btn_capnhap;
        private System.Windows.Forms.DataGridView data_nhanvien;
        private System.Windows.Forms.DateTimePicker mks_ngaysinh;
        private System.Windows.Forms.MaskedTextBox mks_phone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox Ck_gioitinh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox text_diachi;
        private System.Windows.Forms.TextBox text_ten;
        private System.Windows.Forms.TextBox text_ma;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}