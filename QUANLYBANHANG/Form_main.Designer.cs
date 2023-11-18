namespace QUANLYBANHANG
{
    partial class Form_main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_main));
            this.menu = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dangxuat_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DKND_form = new System.Windows.Forms.ToolStripMenuItem();
            this.trợGiúpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhMụcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_NV = new System.Windows.Forms.ToolStripMenuItem();
            this.kháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formNCC = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_hanghoa = new System.Windows.Forms.ToolStripMenuItem();
            this.nhậpXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.form_loaihang = new System.Windows.Forms.ToolStripMenuItem();
            this.hóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hoadon_from = new System.Windows.Forms.ToolStripMenuItem();
            this.tìmKiếmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tìmKiếmHàngHóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tìmKiếmHóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lậpBáoCáoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoDoanhThuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoTồnKhoĐầuKỳToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoTồnKhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoNhậpXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoSảnPhẩmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_main = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_hoadon = new System.Windows.Forms.Button();
            this.btnNhanvien = new System.Windows.Forms.Button();
            this.btnkhach = new System.Windows.Forms.Button();
            this.BtnHangHoa = new System.Windows.Forms.Button();
            this.trợGiúpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.giớiThiệuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.LightPink;
            this.menu.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.danhMụcToolStripMenuItem,
            this.hóaĐơnToolStripMenuItem,
            this.tìmKiếmToolStripMenuItem,
            this.lậpBáoCáoToolStripMenuItem,
            this.trợGiúpToolStripMenuItem1,
            this.thoátToolStripMenuItem1});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1179, 28);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dangxuat_menu,
            this.thoátToolStripMenuItem,
            this.DKND_form,
            this.trợGiúpToolStripMenuItem,
            this.giớiThiệuToolStripMenuItem});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // dangxuat_menu
            // 
            this.dangxuat_menu.BackColor = System.Drawing.Color.Pink;
            this.dangxuat_menu.Name = "dangxuat_menu";
            this.dangxuat_menu.Size = new System.Drawing.Size(238, 26);
            this.dangxuat_menu.Text = "Đăng xuất";
            this.dangxuat_menu.Click += new System.EventHandler(this.dangxuat_menu_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.BackColor = System.Drawing.Color.Pink;
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // DKND_form
            // 
            this.DKND_form.BackColor = System.Drawing.Color.Pink;
            this.DKND_form.Name = "DKND_form";
            this.DKND_form.Size = new System.Drawing.Size(238, 26);
            this.DKND_form.Text = "Đăng ký người dùng";
            this.DKND_form.Click += new System.EventHandler(this.DKND_form_Click);
            // 
            // trợGiúpToolStripMenuItem
            // 
            this.trợGiúpToolStripMenuItem.BackColor = System.Drawing.Color.Pink;
            this.trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem";
            this.trợGiúpToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.trợGiúpToolStripMenuItem.Text = "Trợ giúp";
            // 
            // danhMụcToolStripMenuItem
            // 
            this.danhMụcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_NV,
            this.kháchHàngToolStripMenuItem,
            this.formNCC,
            this.menu_hanghoa,
            this.nhậpXuấtToolStripMenuItem,
            this.form_loaihang});
            this.danhMụcToolStripMenuItem.Name = "danhMụcToolStripMenuItem";
            this.danhMụcToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.danhMụcToolStripMenuItem.Text = "Danh mục";
            // 
            // menu_NV
            // 
            this.menu_NV.BackColor = System.Drawing.Color.Pink;
            this.menu_NV.Name = "menu_NV";
            this.menu_NV.Size = new System.Drawing.Size(190, 26);
            this.menu_NV.Text = "Nhân viên";
            this.menu_NV.Click += new System.EventHandler(this.menu_NV_Click);
            // 
            // kháchHàngToolStripMenuItem
            // 
            this.kháchHàngToolStripMenuItem.BackColor = System.Drawing.Color.Pink;
            this.kháchHàngToolStripMenuItem.Name = "kháchHàngToolStripMenuItem";
            this.kháchHàngToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.kháchHàngToolStripMenuItem.Text = "Khách hàng";
            this.kháchHàngToolStripMenuItem.Click += new System.EventHandler(this.kháchHàngToolStripMenuItem_Click);
            // 
            // formNCC
            // 
            this.formNCC.BackColor = System.Drawing.Color.Pink;
            this.formNCC.Name = "formNCC";
            this.formNCC.Size = new System.Drawing.Size(190, 26);
            this.formNCC.Text = "Nhà cung cấp";
            this.formNCC.Click += new System.EventHandler(this.formNCC_Click);
            // 
            // menu_hanghoa
            // 
            this.menu_hanghoa.BackColor = System.Drawing.Color.Pink;
            this.menu_hanghoa.Name = "menu_hanghoa";
            this.menu_hanghoa.Size = new System.Drawing.Size(190, 26);
            this.menu_hanghoa.Text = "Hàng hóa";
            this.menu_hanghoa.Click += new System.EventHandler(this.menu_hanghoa_Click);
            // 
            // nhậpXuấtToolStripMenuItem
            // 
            this.nhậpXuấtToolStripMenuItem.BackColor = System.Drawing.Color.Pink;
            this.nhậpXuấtToolStripMenuItem.Name = "nhậpXuấtToolStripMenuItem";
            this.nhậpXuấtToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.nhậpXuấtToolStripMenuItem.Text = "Nhập xuất";
            // 
            // form_loaihang
            // 
            this.form_loaihang.BackColor = System.Drawing.Color.Pink;
            this.form_loaihang.Name = "form_loaihang";
            this.form_loaihang.Size = new System.Drawing.Size(190, 26);
            this.form_loaihang.Text = "Loại Hàng";
            this.form_loaihang.Click += new System.EventHandler(this.form_loaihang_Click);
            // 
            // hóaĐơnToolStripMenuItem
            // 
            this.hóaĐơnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hoadon_from});
            this.hóaĐơnToolStripMenuItem.Name = "hóaĐơnToolStripMenuItem";
            this.hóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.hóaĐơnToolStripMenuItem.Text = "Hóa Đơn";
            // 
            // hoadon_from
            // 
            this.hoadon_from.BackColor = System.Drawing.Color.Pink;
            this.hoadon_from.Name = "hoadon_from";
            this.hoadon_from.Size = new System.Drawing.Size(224, 26);
            this.hoadon_from.Text = "Hóa đơn bán hàng";
            this.hoadon_from.Click += new System.EventHandler(this.hoadon_from_Click);
            // 
            // tìmKiếmToolStripMenuItem
            // 
            this.tìmKiếmToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tìmKiếmHàngHóaToolStripMenuItem,
            this.tìmKiếmHóaĐơnToolStripMenuItem});
            this.tìmKiếmToolStripMenuItem.Name = "tìmKiếmToolStripMenuItem";
            this.tìmKiếmToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.tìmKiếmToolStripMenuItem.Text = "Tìm kiếm";
            // 
            // tìmKiếmHàngHóaToolStripMenuItem
            // 
            this.tìmKiếmHàngHóaToolStripMenuItem.Name = "tìmKiếmHàngHóaToolStripMenuItem";
            this.tìmKiếmHàngHóaToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.tìmKiếmHàngHóaToolStripMenuItem.Text = "Tìm Kiếm hàng hóa";
            this.tìmKiếmHàngHóaToolStripMenuItem.Click += new System.EventHandler(this.tìmKiếmHàngHóaToolStripMenuItem_Click);
            // 
            // tìmKiếmHóaĐơnToolStripMenuItem
            // 
            this.tìmKiếmHóaĐơnToolStripMenuItem.Name = "tìmKiếmHóaĐơnToolStripMenuItem";
            this.tìmKiếmHóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.tìmKiếmHóaĐơnToolStripMenuItem.Text = "Tìm Kiếm Hóa Đơn";
            this.tìmKiếmHóaĐơnToolStripMenuItem.Click += new System.EventHandler(this.tìmKiếmHóaĐơnToolStripMenuItem_Click);
            // 
            // lậpBáoCáoToolStripMenuItem
            // 
            this.lậpBáoCáoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.báoCáoDoanhThuToolStripMenuItem,
            this.báoCáoTồnKhoĐầuKỳToolStripMenuItem,
            this.báoCáoTồnKhoToolStripMenuItem,
            this.báoCáoNhậpXuấtToolStripMenuItem,
            this.báoCáoSảnPhẩmToolStripMenuItem});
            this.lậpBáoCáoToolStripMenuItem.Name = "lậpBáoCáoToolStripMenuItem";
            this.lậpBáoCáoToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
            this.lậpBáoCáoToolStripMenuItem.Text = "Lập báo cáo";
            // 
            // báoCáoDoanhThuToolStripMenuItem
            // 
            this.báoCáoDoanhThuToolStripMenuItem.BackColor = System.Drawing.Color.Pink;
            this.báoCáoDoanhThuToolStripMenuItem.Name = "báoCáoDoanhThuToolStripMenuItem";
            this.báoCáoDoanhThuToolStripMenuItem.Size = new System.Drawing.Size(264, 26);
            this.báoCáoDoanhThuToolStripMenuItem.Text = "Báo cáo doanh thu";
            this.báoCáoDoanhThuToolStripMenuItem.Click += new System.EventHandler(this.báoCáoDoanhThuToolStripMenuItem_Click);
            // 
            // báoCáoTồnKhoĐầuKỳToolStripMenuItem
            // 
            this.báoCáoTồnKhoĐầuKỳToolStripMenuItem.BackColor = System.Drawing.Color.Pink;
            this.báoCáoTồnKhoĐầuKỳToolStripMenuItem.Name = "báoCáoTồnKhoĐầuKỳToolStripMenuItem";
            this.báoCáoTồnKhoĐầuKỳToolStripMenuItem.Size = new System.Drawing.Size(264, 26);
            this.báoCáoTồnKhoĐầuKỳToolStripMenuItem.Text = "Báo cáo tồn kho đâu kỳ";
            // 
            // báoCáoTồnKhoToolStripMenuItem
            // 
            this.báoCáoTồnKhoToolStripMenuItem.BackColor = System.Drawing.Color.Pink;
            this.báoCáoTồnKhoToolStripMenuItem.Name = "báoCáoTồnKhoToolStripMenuItem";
            this.báoCáoTồnKhoToolStripMenuItem.Size = new System.Drawing.Size(264, 26);
            this.báoCáoTồnKhoToolStripMenuItem.Text = "Báo cáo tồn kho";
            // 
            // báoCáoNhậpXuấtToolStripMenuItem
            // 
            this.báoCáoNhậpXuấtToolStripMenuItem.BackColor = System.Drawing.Color.Pink;
            this.báoCáoNhậpXuấtToolStripMenuItem.Name = "báoCáoNhậpXuấtToolStripMenuItem";
            this.báoCáoNhậpXuấtToolStripMenuItem.Size = new System.Drawing.Size(264, 26);
            this.báoCáoNhậpXuấtToolStripMenuItem.Text = "Báo cáo nhập xuất";
            this.báoCáoNhậpXuấtToolStripMenuItem.Click += new System.EventHandler(this.báoCáoNhậpXuấtToolStripMenuItem_Click);
            // 
            // báoCáoSảnPhẩmToolStripMenuItem
            // 
            this.báoCáoSảnPhẩmToolStripMenuItem.BackColor = System.Drawing.Color.Pink;
            this.báoCáoSảnPhẩmToolStripMenuItem.Name = "báoCáoSảnPhẩmToolStripMenuItem";
            this.báoCáoSảnPhẩmToolStripMenuItem.Size = new System.Drawing.Size(264, 26);
            this.báoCáoSảnPhẩmToolStripMenuItem.Text = "Báo cáo sản phẩm";
            // 
            // thoátToolStripMenuItem1
            // 
            this.thoátToolStripMenuItem1.Name = "thoátToolStripMenuItem1";
            this.thoátToolStripMenuItem1.Size = new System.Drawing.Size(66, 24);
            this.thoátToolStripMenuItem1.Text = "Thoát";
            this.thoátToolStripMenuItem1.Click += new System.EventHandler(this.thoátToolStripMenuItem1_Click);
            // 
            // panel_main
            // 
            this.panel_main.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_main.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_main.BackgroundImage")));
            this.panel_main.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_main.Location = new System.Drawing.Point(85, 141);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(1018, 689);
            this.panel_main.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightPink;
            this.panel1.Controls.Add(this.btn_hoadon);
            this.panel1.Controls.Add(this.btnNhanvien);
            this.panel1.Controls.Add(this.btnkhach);
            this.panel1.Controls.Add(this.BtnHangHoa);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1179, 34);
            this.panel1.TabIndex = 1;
            // 
            // btn_hoadon
            // 
            this.btn_hoadon.BackColor = System.Drawing.Color.Pink;
            this.btn_hoadon.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_hoadon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hoadon.Location = new System.Drawing.Point(333, 0);
            this.btn_hoadon.Name = "btn_hoadon";
            this.btn_hoadon.Size = new System.Drawing.Size(105, 34);
            this.btn_hoadon.TabIndex = 3;
            this.btn_hoadon.Text = "Hóa Đơn";
            this.btn_hoadon.UseVisualStyleBackColor = false;
            this.btn_hoadon.Click += new System.EventHandler(this.btn_hoadon_Click);
            // 
            // btnNhanvien
            // 
            this.btnNhanvien.BackColor = System.Drawing.Color.Pink;
            this.btnNhanvien.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnNhanvien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhanvien.Location = new System.Drawing.Point(218, 0);
            this.btnNhanvien.Name = "btnNhanvien";
            this.btnNhanvien.Size = new System.Drawing.Size(115, 34);
            this.btnNhanvien.TabIndex = 2;
            this.btnNhanvien.Text = "Nhân Viên";
            this.btnNhanvien.UseVisualStyleBackColor = false;
            this.btnNhanvien.Click += new System.EventHandler(this.btnNhanvien_Click);
            // 
            // btnkhach
            // 
            this.btnkhach.BackColor = System.Drawing.Color.Pink;
            this.btnkhach.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnkhach.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnkhach.Location = new System.Drawing.Point(109, 0);
            this.btnkhach.Name = "btnkhach";
            this.btnkhach.Size = new System.Drawing.Size(109, 34);
            this.btnkhach.TabIndex = 1;
            this.btnkhach.Text = "Khách hàng";
            this.btnkhach.UseVisualStyleBackColor = false;
            this.btnkhach.Click += new System.EventHandler(this.btnkhach_Click);
            // 
            // BtnHangHoa
            // 
            this.BtnHangHoa.BackColor = System.Drawing.Color.Pink;
            this.BtnHangHoa.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnHangHoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHangHoa.Location = new System.Drawing.Point(0, 0);
            this.BtnHangHoa.Name = "BtnHangHoa";
            this.BtnHangHoa.Size = new System.Drawing.Size(109, 34);
            this.BtnHangHoa.TabIndex = 0;
            this.BtnHangHoa.Text = "Hàng hóa";
            this.BtnHangHoa.UseVisualStyleBackColor = false;
            this.BtnHangHoa.Click += new System.EventHandler(this.BtnHangHoa_Click);
            // 
            // trợGiúpToolStripMenuItem1
            // 
            this.trợGiúpToolStripMenuItem1.Name = "trợGiúpToolStripMenuItem1";
            this.trợGiúpToolStripMenuItem1.Size = new System.Drawing.Size(85, 24);
            this.trợGiúpToolStripMenuItem1.Text = "Trợ giúp";
            // 
            // giớiThiệuToolStripMenuItem
            // 
            this.giớiThiệuToolStripMenuItem.BackColor = System.Drawing.Color.Pink;
            this.giớiThiệuToolStripMenuItem.Name = "giớiThiệuToolStripMenuItem";
            this.giớiThiệuToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.giớiThiệuToolStripMenuItem.Text = "Giới thiệu";
            // 
            // Form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1179, 884);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu;
            this.Name = "Form_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form_main";
            this.Load += new System.EventHandler(this.Form_main_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dangxuat_menu;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DKND_form;
        private System.Windows.Forms.ToolStripMenuItem trợGiúpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhMụcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu_NV;
        private System.Windows.Forms.ToolStripMenuItem kháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formNCC;
        private System.Windows.Forms.ToolStripMenuItem menu_hanghoa;
        private System.Windows.Forms.ToolStripMenuItem nhậpXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hóaĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hoadon_from;
        private System.Windows.Forms.ToolStripMenuItem tìmKiếmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lậpBáoCáoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem báoCáoDoanhThuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem báoCáoTồnKhoĐầuKỳToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem báoCáoTồnKhoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem báoCáoNhậpXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem báoCáoSảnPhẩmToolStripMenuItem;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.ToolStripMenuItem form_loaihang;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_hoadon;
        private System.Windows.Forms.Button btnNhanvien;
        private System.Windows.Forms.Button btnkhach;
        private System.Windows.Forms.Button BtnHangHoa;
        private System.Windows.Forms.ToolStripMenuItem tìmKiếmHàngHóaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tìmKiếmHóaĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giớiThiệuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trợGiúpToolStripMenuItem1;
    }
}