namespace QUANLYBANHANG
{
    partial class Loaihang
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
            System.Windows.Forms.ImageList imageList1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loaihang));
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.data_loai = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_dong = new System.Windows.Forms.Button();
            this.btn_boqua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_luu = new System.Windows.Forms.Button();
            this.btn_capnhap = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.text_search = new System.Windows.Forms.TextBox();
            this.text_ten = new System.Windows.Forms.TextBox();
            this.text_ma = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_loai)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            imageList1.TransparentColor = System.Drawing.Color.White;
            imageList1.Images.SetKeyName(0, "icons8-available-updates-350.png");
            imageList1.Images.SetKeyName(1, "4856668.png");
            imageList1.Images.SetKeyName(2, "png-clipart-computer-icons-shutdown-others-miscellaneous-blue.png");
            imageList1.Images.SetKeyName(3, "shutdown-vector-icon-png_256704.jpg");
            imageList1.Images.SetKeyName(4, "png-transparent-computer-icons-button-electrical-switches-circuit-diagram-turn-of" +
        "f-free-miscellaneous-blue-text-thumbnail.png");
            imageList1.Images.SetKeyName(5, "3405244.png");
            imageList1.Images.SetKeyName(6, "pngtree-add-vector-icon-png-image_470700.jpg");
            imageList1.Images.SetKeyName(7, "transparent-skip-icon-next-icon-essential-compilation-icon-5f6274ef2e0178.5408751" +
        "916002879831885.jpg");
            imageList1.Images.SetKeyName(8, "1200px-OOjs_UI_icon_search-ltr.svg.png");
            // 
            // panel3
            // 
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Name = "panel3";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.data_loai);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // data_loai
            // 
            this.data_loai.BackgroundColor = System.Drawing.Color.Pink;
            this.data_loai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.data_loai, "data_loai");
            this.data_loai.Name = "data_loai";
            this.data_loai.RowTemplate.Height = 24;
            this.data_loai.Click += new System.EventHandler(this.data_loai_Click);
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
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // btn_them
            // 
            resources.ApplyResources(this.btn_them, "btn_them");
            this.btn_them.BackColor = System.Drawing.Color.Pink;
            this.btn_them.ForeColor = System.Drawing.Color.Black;
            this.btn_them.ImageList = imageList1;
            this.btn_them.Name = "btn_them";
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_dong
            // 
            resources.ApplyResources(this.btn_dong, "btn_dong");
            this.btn_dong.BackColor = System.Drawing.Color.Pink;
            this.btn_dong.ImageList = imageList1;
            this.btn_dong.Name = "btn_dong";
            this.btn_dong.UseVisualStyleBackColor = false;
            this.btn_dong.Click += new System.EventHandler(this.btn_dong_Click);
            // 
            // btn_boqua
            // 
            resources.ApplyResources(this.btn_boqua, "btn_boqua");
            this.btn_boqua.BackColor = System.Drawing.Color.Pink;
            this.btn_boqua.ImageList = imageList1;
            this.btn_boqua.Name = "btn_boqua";
            this.btn_boqua.UseVisualStyleBackColor = false;
            this.btn_boqua.Click += new System.EventHandler(this.btn_boqua_Click);
            // 
            // btn_xoa
            // 
            resources.ApplyResources(this.btn_xoa, "btn_xoa");
            this.btn_xoa.BackColor = System.Drawing.Color.Pink;
            this.btn_xoa.ImageList = imageList1;
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_luu
            // 
            resources.ApplyResources(this.btn_luu, "btn_luu");
            this.btn_luu.BackColor = System.Drawing.Color.Pink;
            this.btn_luu.ImageList = imageList1;
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.UseVisualStyleBackColor = false;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // btn_capnhap
            // 
            resources.ApplyResources(this.btn_capnhap, "btn_capnhap");
            this.btn_capnhap.BackColor = System.Drawing.Color.Pink;
            this.btn_capnhap.ForeColor = System.Drawing.Color.Black;
            this.btn_capnhap.ImageList = imageList1;
            this.btn_capnhap.Name = "btn_capnhap";
            this.btn_capnhap.UseVisualStyleBackColor = false;
            this.btn_capnhap.Click += new System.EventHandler(this.btn_capnhap_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label1);
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.Name = "panel4";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Pink;
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.MediumBlue;
            this.label1.Name = "label1";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Pink;
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.text_search);
            this.panel5.Controls.Add(this.text_ten);
            this.panel5.Controls.Add(this.text_ma);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.label2);
            resources.ApplyResources(this.panel5, "panel5");
            this.panel5.Name = "panel5";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // text_search
            // 
            resources.ApplyResources(this.text_search, "text_search");
            this.text_search.Name = "text_search";
            // 
            // text_ten
            // 
            resources.ApplyResources(this.text_ten, "text_ten");
            this.text_ten.Name = "text_ten";
            this.text_ten.KeyUp += new System.Windows.Forms.KeyEventHandler(this.text_ten_KeyUp);
            // 
            // text_ma
            // 
            resources.ApplyResources(this.text_ma, "text_ma");
            this.text_ma.Name = "text_ma";
            this.text_ma.KeyUp += new System.Windows.Forms.KeyEventHandler(this.text_ma_KeyUp);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // Loaihang
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Name = "Loaihang";
            this.Load += new System.EventHandler(this.Loaihang_Load);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data_loai)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox text_search;
        private System.Windows.Forms.TextBox text_ten;
        private System.Windows.Forms.TextBox text_ma;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_dong;
        private System.Windows.Forms.Button btn_boqua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.Button btn_capnhap;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView data_loai;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
    }
}