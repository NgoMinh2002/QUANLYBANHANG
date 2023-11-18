namespace QUANLYBANHANG
{
    partial class DK_nguoidung
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DK_nguoidung));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cb_loainguoidung = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.data_Dangky = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.text_Mk = new System.Windows.Forms.TextBox();
            this.text_ma = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_them = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_dong = new System.Windows.Forms.Button();
            this.btn_boqua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_luu = new System.Windows.Forms.Button();
            this.btn_capnhap = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_Dangky)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Pink;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(895, 44);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(895, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "ĐĂNG KÝ NGƯỜI DÙNG";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Pink;
            this.panel2.Controls.Add(this.cb_loainguoidung);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.text_Mk);
            this.panel2.Controls.Add(this.text_ma);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(655, 313);
            this.panel2.TabIndex = 1;
            // 
            // cb_loainguoidung
            // 
            this.cb_loainguoidung.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_loainguoidung.FormattingEnabled = true;
            this.cb_loainguoidung.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cb_loainguoidung.Location = new System.Drawing.Point(210, 273);
            this.cb_loainguoidung.Name = "cb_loainguoidung";
            this.cb_loainguoidung.Size = new System.Drawing.Size(347, 24);
            this.cb_loainguoidung.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.data_Dangky);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(655, 176);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // data_Dangky
            // 
            this.data_Dangky.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.data_Dangky.BackgroundColor = System.Drawing.Color.White;
            this.data_Dangky.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_Dangky.Location = new System.Drawing.Point(3, 18);
            this.data_Dangky.Name = "data_Dangky";
            this.data_Dangky.RowHeadersWidth = 51;
            this.data_Dangky.RowTemplate.Height = 24;
            this.data_Dangky.Size = new System.Drawing.Size(649, 155);
            this.data_Dangky.TabIndex = 0;
            this.data_Dangky.Click += new System.EventHandler(this.data_Dangky_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Loại người dùng";
            // 
            // text_Mk
            // 
            this.text_Mk.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.text_Mk.Location = new System.Drawing.Point(210, 232);
            this.text_Mk.Name = "text_Mk";
            this.text_Mk.Size = new System.Drawing.Size(347, 22);
            this.text_Mk.TabIndex = 3;
            this.text_Mk.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cb_loainguoidung_KeyUp);
            // 
            // text_ma
            // 
            this.text_ma.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.text_ma.Location = new System.Drawing.Point(210, 193);
            this.text_ma.Name = "text_ma";
            this.text_ma.Size = new System.Drawing.Size(347, 22);
            this.text_ma.TabIndex = 2;
            this.text_ma.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cb_loainguoidung_KeyUp);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tài khoản";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mật khẩu";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Pink;
            this.panel3.Controls.Add(this.btn_them);
            this.panel3.Controls.Add(this.btn_dong);
            this.panel3.Controls.Add(this.btn_boqua);
            this.panel3.Controls.Add(this.btn_xoa);
            this.panel3.Controls.Add(this.btn_luu);
            this.panel3.Controls.Add(this.btn_capnhap);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(655, 44);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(240, 313);
            this.panel3.TabIndex = 2;
            // 
            // btn_them
            // 
            this.btn_them.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_them.BackColor = System.Drawing.Color.Pink;
            this.btn_them.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.ForeColor = System.Drawing.Color.Black;
            this.btn_them.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_them.ImageIndex = 8;
            this.btn_them.ImageList = this.imageList1;
            this.btn_them.Location = new System.Drawing.Point(44, 6);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(145, 50);
            this.btn_them.TabIndex = 36;
            this.btn_them.Text = "Thêm";
            this.btn_them.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_them.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "4856668.png");
            this.imageList1.Images.SetKeyName(1, "download12.png");
            this.imageList1.Images.SetKeyName(2, "icons8-available-updates-350.png");
            this.imageList1.Images.SetKeyName(3, "nut_them.jpg");
            this.imageList1.Images.SetKeyName(4, "open-file_40455.png");
            this.imageList1.Images.SetKeyName(5, "pngtree-delete-tool-icon-png-image_4438072.jpg");
            this.imageList1.Images.SetKeyName(6, "shutdown-vector-icon-png_256704.jpg");
            this.imageList1.Images.SetKeyName(7, "transparent-skip-icon-next-icon-essential-compilation-icon-5f6274ef2e0178.5408751" +
        "916002879831885.jpg");
            this.imageList1.Images.SetKeyName(8, "pngtree-add-vector-icon-png-image_470700.jpg");
            this.imageList1.Images.SetKeyName(9, "3405244.png");
            // 
            // btn_dong
            // 
            this.btn_dong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_dong.BackColor = System.Drawing.Color.Pink;
            this.btn_dong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dong.ImageIndex = 6;
            this.btn_dong.ImageList = this.imageList1;
            this.btn_dong.Location = new System.Drawing.Point(44, 267);
            this.btn_dong.Name = "btn_dong";
            this.btn_dong.Size = new System.Drawing.Size(145, 46);
            this.btn_dong.TabIndex = 31;
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
            this.btn_boqua.ImageIndex = 7;
            this.btn_boqua.ImageList = this.imageList1;
            this.btn_boqua.Location = new System.Drawing.Point(44, 215);
            this.btn_boqua.Name = "btn_boqua";
            this.btn_boqua.Size = new System.Drawing.Size(145, 46);
            this.btn_boqua.TabIndex = 35;
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
            this.btn_xoa.ImageIndex = 9;
            this.btn_xoa.ImageList = this.imageList1;
            this.btn_xoa.Location = new System.Drawing.Point(44, 166);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(145, 43);
            this.btn_xoa.TabIndex = 34;
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
            this.btn_luu.ImageIndex = 0;
            this.btn_luu.ImageList = this.imageList1;
            this.btn_luu.Location = new System.Drawing.Point(44, 114);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(145, 46);
            this.btn_luu.TabIndex = 33;
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
            this.btn_capnhap.ImageKey = "icons8-available-updates-350.png";
            this.btn_capnhap.ImageList = this.imageList1;
            this.btn_capnhap.Location = new System.Drawing.Point(44, 62);
            this.btn_capnhap.Name = "btn_capnhap";
            this.btn_capnhap.Size = new System.Drawing.Size(145, 46);
            this.btn_capnhap.TabIndex = 32;
            this.btn_capnhap.Text = "Cập Nhập";
            this.btn_capnhap.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_capnhap.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_capnhap.UseVisualStyleBackColor = false;
            this.btn_capnhap.Click += new System.EventHandler(this.btn_capnhap_Click);
            // 
            // DK_nguoidung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QUANLYBANHANG.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(895, 357);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DK_nguoidung";
            this.Text = "DK_nguoidung";
            this.Load += new System.EventHandler(this.DK_nguoidung_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data_Dangky)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView data_Dangky;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox text_Mk;
        private System.Windows.Forms.TextBox text_ma;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btn_dong;
        private System.Windows.Forms.Button btn_boqua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.Button btn_capnhap;
        private System.Windows.Forms.ComboBox cb_loainguoidung;
    }
}