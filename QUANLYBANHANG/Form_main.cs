using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYBANHANG
{
    public partial class Form_main : Form
    {
        public Form_main()
        {
            InitializeComponent();
        }
        private Form currentFromChild;
        private void OpenChildFrom(Form chilForm)
        {
            if (currentFromChild != null)
            {
                currentFromChild.Close();
            }
            currentFromChild = chilForm;
            chilForm.TopLevel = false;
            chilForm.FormBorderStyle = FormBorderStyle.None;
            chilForm.Dock = DockStyle.Fill;
            panel_main.Controls.Add(chilForm);
            panel_main.Tag = chilForm;
           
            chilForm.BringToFront();
            chilForm.Show();
        }

        private void Form_main_Load(object sender, EventArgs e)
        {
            if (account.loainguoidung == 2)
            {
                this.menu_hanghoa.Enabled = false;
                this.BtnHangHoa.Enabled = false;
                this.DKND_form.Enabled = false;
                this.menu_NV.Enabled = false;
                this.btnNhanvien.Enabled = false;
                this.báoCáoNhậpXuấtToolStripMenuItem.Enabled = false;
               
            }
            else if(account.loainguoidung == 3)
            {
                this.btn_hoadon.Enabled = false;
                this.hoadon_from.Enabled = false;
                this.DKND_form.Enabled = false;
                this.btnkhach.Enabled = false;
                this.kháchHàngToolStripMenuItem.Enabled = false;
                this.menu_NV.Enabled = false;
                this.btnNhanvien.Enabled = false;
                this.tìmKiếmHàngHóaToolStripMenuItem.Enabled = false;
                this.tìmKiếmHóaĐơnToolStripMenuItem.Enabled = false;
                this.báoCáoDoanhThuToolStripMenuItem.Enabled = false;
            }

         }

        private void formNCC_Click(object sender, EventArgs e)
        {
            OpenChildFrom(new NhaCungCap());
        }

        private void form_loaihang_Click(object sender, EventArgs e)
        {
            OpenChildFrom(new Loaihang());
        }

        private void btnkhach_Click(object sender, EventArgs e)
        {
            OpenChildFrom(new Khachhang());
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildFrom(new Khachhang());
        }

        private void DKND_form_Click(object sender, EventArgs e)
        {
            OpenChildFrom(new DK_nguoidung());
        }

        private void dangxuat_menu_Click(object sender, EventArgs e)
        {
            DangNhap dangNhap = new DangNhap();
            dangNhap.Show();
            this.Hide();
        }

        private void menu_NV_Click(object sender, EventArgs e)
        {
            OpenChildFrom(new Nhanvien());
        }

        private void btnNhanvien_Click(object sender, EventArgs e)
        {
            OpenChildFrom(new Nhanvien());
        }

        private void BtnHangHoa_Click(object sender, EventArgs e)
        {
            OpenChildFrom(new Hanghoa());
        }

        private void menu_hanghoa_Click(object sender, EventArgs e)
        {
            OpenChildFrom(new Hanghoa());
        }

        private void hoadon_from_Click(object sender, EventArgs e)
        {
            OpenChildFrom(new Hoadon());
        }

      

        private void btn_hoadon_Click(object sender, EventArgs e)
        {
            OpenChildFrom(new Hoadon());
        }

        private void tìmKiếmHàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildFrom(new TimkiemHanghoa());
        }

        private void tìmKiếmHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildFrom(new TimkiemHoadon());
        }

        private void báoCáoNhậpXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildFrom(new BCnhapxuat());
        }

        private void báoCáoDoanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildFrom(new BaocaoDaonhthu());
        }

        private void thoátToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult Exit = MessageBox.Show("Do you want to escape?", "Notification", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (Exit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult Exit = MessageBox.Show("Do you want to escape?", "Notification", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (Exit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
