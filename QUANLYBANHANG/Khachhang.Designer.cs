namespace QUANLYBANHANG
{
    partial class Khachhang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Khachhang));
            this.mks_phone = new System.Windows.Forms.MaskedTextBox();
            this.text_diachi = new System.Windows.Forms.TextBox();
            this.text_ten = new System.Windows.Forms.TextBox();
            this.text_ma = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.text_search = new System.Windows.Forms.TextBox();
            this.data_Khachhang = new System.Windows.Forms.DataGridView();
            this.btn_dong = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_boqua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_luu = new System.Windows.Forms.Button();
            this.btn_capnhap = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_them = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_Khachhang)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mks_phone
            // 
            this.mks_phone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mks_phone.Location = new System.Drawing.Point(589, 98);
            this.mks_phone.Mask = "(999) 000-0000";
            this.mks_phone.Name = "mks_phone";
            this.mks_phone.Size = new System.Drawing.Size(266, 22);
            this.mks_phone.TabIndex = 30;
            this.mks_phone.KeyUp += new System.Windows.Forms.KeyEventHandler(this.text_diachi_KeyUp);
            // 
            // text_diachi
            // 
            this.text_diachi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.text_diachi.Location = new System.Drawing.Point(589, 141);
            this.text_diachi.Name = "text_diachi";
            this.text_diachi.Size = new System.Drawing.Size(266, 22);
            this.text_diachi.TabIndex = 28;
            this.text_diachi.KeyUp += new System.Windows.Forms.KeyEventHandler(this.text_diachi_KeyUp);
            // 
            // text_ten
            // 
            this.text_ten.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.text_ten.Location = new System.Drawing.Point(160, 138);
            this.text_ten.Name = "text_ten";
            this.text_ten.Size = new System.Drawing.Size(268, 22);
            this.text_ten.TabIndex = 27;
            this.text_ten.KeyUp += new System.Windows.Forms.KeyEventHandler(this.text_diachi_KeyUp);
            // 
            // text_ma
            // 
            this.text_ma.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.text_ma.Location = new System.Drawing.Point(160, 92);
            this.text_ma.Name = "text_ma";
            this.text_ma.Size = new System.Drawing.Size(268, 22);
            this.text_ma.TabIndex = 26;
            this.text_ma.KeyUp += new System.Windows.Forms.KeyEventHandler(this.text_diachi_KeyUp);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(479, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 18);
            this.label5.TabIndex = 25;
            this.label5.Text = "Điện thoại";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(484, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 18);
            this.label4.TabIndex = 24;
            this.label4.Text = "Địa chỉ";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 18);
            this.label3.TabIndex = 23;
            this.label3.Text = "Tên khách hàng";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 18);
            this.label6.TabIndex = 22;
            this.label6.Text = "Mã khách hàng";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(158, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 29);
            this.label2.TabIndex = 20;
            this.label2.Text = "Tìm kiếm";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 51);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(884, 185);
            this.panel3.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Pink;
            this.groupBox2.Controls.Add(this.mks_phone);
            this.groupBox2.Controls.Add(this.text_diachi);
            this.groupBox2.Controls.Add(this.text_ten);
            this.groupBox2.Controls.Add(this.text_ma);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.text_search);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(884, 185);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // text_search
            // 
            this.text_search.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.text_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_search.Location = new System.Drawing.Point(337, 40);
            this.text_search.Multiline = true;
            this.text_search.Name = "text_search";
            this.text_search.Size = new System.Drawing.Size(418, 29);
            this.text_search.TabIndex = 21;
            this.text_search.TextChanged += new System.EventHandler(this.text_search_TextChanged);
            // 
            // data_Khachhang
            // 
            this.data_Khachhang.BackgroundColor = System.Drawing.Color.White;
            this.data_Khachhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_Khachhang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.data_Khachhang.Location = new System.Drawing.Point(3, 18);
            this.data_Khachhang.Name = "data_Khachhang";
            this.data_Khachhang.RowHeadersWidth = 51;
            this.data_Khachhang.RowTemplate.Height = 24;
            this.data_Khachhang.Size = new System.Drawing.Size(878, 212);
            this.data_Khachhang.TabIndex = 0;
            this.data_Khachhang.Click += new System.EventHandler(this.data_Khachhang_Click);
            // 
            // btn_dong
            // 
            this.btn_dong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_dong.BackColor = System.Drawing.Color.Pink;
            this.btn_dong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dong.ImageIndex = 5;
            this.btn_dong.ImageList = this.imageList1;
            this.btn_dong.Location = new System.Drawing.Point(742, 247);
            this.btn_dong.Name = "btn_dong";
            this.btn_dong.Size = new System.Drawing.Size(132, 40);
            this.btn_dong.TabIndex = 28;
            this.btn_dong.Text = "Đóng";
            this.btn_dong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_dong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_dong.UseVisualStyleBackColor = false;
            this.btn_dong.Click += new System.EventHandler(this.btn_dong_Click);
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
            // btn_boqua
            // 
            this.btn_boqua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_boqua.BackColor = System.Drawing.Color.Pink;
            this.btn_boqua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_boqua.ImageIndex = 6;
            this.btn_boqua.ImageList = this.imageList1;
            this.btn_boqua.Location = new System.Drawing.Point(597, 248);
            this.btn_boqua.Name = "btn_boqua";
            this.btn_boqua.Size = new System.Drawing.Size(132, 40);
            this.btn_boqua.TabIndex = 27;
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
            this.btn_xoa.Location = new System.Drawing.Point(453, 247);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(132, 40);
            this.btn_xoa.TabIndex = 26;
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
            this.btn_luu.Location = new System.Drawing.Point(311, 247);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(134, 40);
            this.btn_luu.TabIndex = 25;
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
            this.btn_capnhap.Location = new System.Drawing.Point(162, 247);
            this.btn_capnhap.Name = "btn_capnhap";
            this.btn_capnhap.Size = new System.Drawing.Size(141, 40);
            this.btn_capnhap.TabIndex = 23;
            this.btn_capnhap.Text = "Cập Nhập";
            this.btn_capnhap.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_capnhap.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_capnhap.UseVisualStyleBackColor = false;
            this.btn_capnhap.Click += new System.EventHandler(this.btn_capnhap_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.data_Khachhang);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(884, 233);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btn_them
            // 
            this.btn_them.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_them.BackColor = System.Drawing.Color.Pink;
            this.btn_them.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.ForeColor = System.Drawing.Color.Black;
            this.btn_them.ImageKey = "pngtree-add-vector-icon-png-image_470700.jpg";
            this.btn_them.ImageList = this.imageList1;
            this.btn_them.Location = new System.Drawing.Point(12, 247);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(141, 40);
            this.btn_them.TabIndex = 29;
            this.btn_them.Text = "Thêm";
            this.btn_them.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_them.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Pink;
            this.panel2.Controls.Add(this.btn_them);
            this.panel2.Controls.Add(this.btn_dong);
            this.panel2.Controls.Add(this.btn_boqua);
            this.panel2.Controls.Add(this.btn_xoa);
            this.panel2.Controls.Add(this.btn_luu);
            this.panel2.Controls.Add(this.btn_capnhap);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 236);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(884, 302);
            this.panel2.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 51);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Pink;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(884, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH MỤC KHÁCH HÀNG";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Khachhang
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::QUANLYBANHANG.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(884, 538);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Khachhang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Khachhang";
            this.Load += new System.EventHandler(this.Khachhang_Load);
            this.panel3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_Khachhang)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox mks_phone;
        private System.Windows.Forms.TextBox text_diachi;
        private System.Windows.Forms.TextBox text_ten;
        private System.Windows.Forms.TextBox text_ma;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox text_search;
        private System.Windows.Forms.DataGridView data_Khachhang;
        private System.Windows.Forms.Button btn_dong;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btn_boqua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.Button btn_capnhap;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}