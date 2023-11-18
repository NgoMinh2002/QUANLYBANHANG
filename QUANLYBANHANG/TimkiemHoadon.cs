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
    public partial class TimkiemHoadon : Form
    {
        DataTable tblHDB;
        public TimkiemHoadon()
        {
            InitializeComponent();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string sql;
            if ((txtMaHDBan.Text == "") && (txtThang.Text == "") && (txtNam.Text == "") &&
               (txtManhanvien.Text == "") && (txtMakhach.Text == "") &&
               (txtTongtien.Text == ""))
            {
                MessageBox.Show("Hãy nhập một điều kiện tìm kiếm!!!", "Yêu cầu ...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = "SELECT * FROM Hoadon WHERE 1=1";
            if (txtMaHDBan.Text != "")
                sql = sql + " AND MaHDB Like N'%" + txtMaHDBan.Text + "%'";
            if (txtThang.Text != "")
                sql = sql + " AND MONTH(NgayBan) =" + txtThang.Text;
            if (txtNam.Text != "")
                sql = sql + " AND YEAR(NgayBan) =" + txtNam.Text;
            if (txtManhanvien.Text != "")
                sql = sql + " AND MaNV Like N'%" + txtManhanvien.Text + "%'";
            if (txtMakhach.Text != "")
                sql = sql + " AND MaKhach Like N'%" + txtMakhach.Text + "%'";
            if (txtTongtien.Text != "")
                sql = sql + " AND Tongtien <=" + txtTongtien.Text;
            tblHDB = connect.query(sql);
            if (tblHDB.Rows.Count == 0)
            {
                MessageBox.Show("Không có hóa đơn thỏa mãn điều kiện!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Có " + tblHDB.Rows.Count + " hóa đơn thỏa mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
          data_timkiem.DataSource = tblHDB;
            LoadDataGridView();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnTimlai_Click(object sender, EventArgs e)
        {
            ResetValues();
           data_timkiem.DataSource = null;
        }

        private void TimkiemHoadon_Load(object sender, EventArgs e)
        {
            ResetValues();
            LoadDataGridView();
        }
        private void ResetValues()
        {
            foreach (Control Ctl in this.Controls)
                if (Ctl is TextBox)
                    Ctl.Text = "";
            txtMaHDBan.Focus();
        }
        private void LoadDataGridView()
        {
            tblHDB = connect.query("Select * from Hoadon");
           data_timkiem.DataSource = tblHDB;
            data_timkiem.Columns[0].HeaderText = "Mã HĐB";
           data_timkiem.Columns[1].HeaderText = "Mã nhân viên";
           data_timkiem.Columns[2].HeaderText = "Ngày bán";
           data_timkiem.Columns[3].HeaderText = "Mã khách";
           data_timkiem.Columns[4].HeaderText = "Tổng tiền";
           data_timkiem.Columns[0].Width = 150;
           data_timkiem.Columns[1].Width = 100;
           data_timkiem.Columns[2].Width = 80;
           data_timkiem.Columns[3].Width = 80;
           data_timkiem.Columns[4].Width = 80;
           data_timkiem.AllowUserToAddRows = false;
           data_timkiem.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void txtTongtien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }
    }
}
