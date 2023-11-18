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
    public partial class TimkiemHanghoa : Form
    {
        DataTable Tbhanghoa;
        string sql;
        public TimkiemHanghoa()
        {
            InitializeComponent();
        }

      

        private void TimkiemHanghoa_Load(object sender, EventArgs e)
        {
           
        
            connect.FillCombo("Select MaNCC,TenNCC from NhaCC", cb_nhacungcap, "MaNCC", "TenNCC");
            cb_nhacungcap.SelectedIndex = -1;
            connect.FillCombo("Select Maloai,Tenloai from Loaihang", cb_loaihang, "Maloai", "Tenloai");
            cb_loaihang.SelectedIndex = -1;
            LoadDataHangHoa();
            ResetValues();
        }
        private void ResetValues()
        {
            text_ma.Text = "";
            tex_ten.Text = "";
            cb_loaihang.Text = "";
            cb_nhacungcap.Text = "";
            textsoluong.Text = "";
           
          


        }
        private void LoadDataHangHoa()
        {
            Tbhanghoa = connect.query("Select * from Hanghoa");
            data_hanghoa.DataSource = Tbhanghoa;
            data_hanghoa.Columns[0].HeaderText = "Mã hàng";
            data_hanghoa.Columns[1].HeaderText = "Tên hàng";
            data_hanghoa.Columns[2].HeaderText = "Mã Loại";
            data_hanghoa.Columns[3].HeaderText = "Nhà cung cấp";
            data_hanghoa.Columns[4].HeaderText = "Số lượng";
            data_hanghoa.Columns[5].HeaderText = "Đơn giá nhập";
            data_hanghoa.Columns[6].HeaderText = "Đơn giá bán";
            data_hanghoa.Columns[0].Width = 120;
            data_hanghoa.Columns[1].Width = 140;
            data_hanghoa.Columns[2].Width = 120;
            data_hanghoa.Columns[3].Width = 120;
            data_hanghoa.Columns[4].Width = 120;
            data_hanghoa.Columns[5].Width = 150;
            data_hanghoa.Columns[6].Width = 150;
            data_hanghoa.AllowUserToAddRows = false;
            data_hanghoa.EditMode = DataGridViewEditMode.EditProgrammatically;

        }

        private void btn_dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            string sql;
            if ((text_ma.Text == "") && (tex_ten.Text == "") && (cb_loaihang.Text == "") && (cb_nhacungcap.Text =="")&& (textsoluong.Text==""))
            {
                MessageBox.Show("Bạn hãy nhập điều kiện tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = "SELECT * from Hanghoa WHERE 1=1";
            if (text_ma.Text != "")
                sql += " AND MaHang LIKE N'%" + text_ma.Text + "%'";
            if (tex_ten.Text != "")
                sql += " AND TenHang LIKE N'%" + tex_ten.Text + "%'";
            if (textsoluong.Text != "")
                sql += " AND Soluong LIKE N'%" + textsoluong.Text + "%'";
            if (cb_nhacungcap.Text != "")
                sql += " AND MaNCC LIKE N'%" + cb_nhacungcap.SelectedValue + "%'";
            if (cb_loaihang.Text != "")
                sql += " AND Maloai LIKE N'%" + cb_loaihang.SelectedValue + "%'";
            Tbhanghoa = connect.query(sql);
            if (Tbhanghoa.Rows.Count == 0)
                MessageBox.Show("Không có hàng hóa thoả mãn điều kiện tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("Có " + Tbhanghoa.Rows.Count + "  hàng hóa thoả mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
           data_hanghoa.DataSource = Tbhanghoa;
        
        }

        private void btn_boqua_Click(object sender, EventArgs e)
        {
            ResetValues();
        }

        private void btnHT_Click(object sender, EventArgs e)
        {
            LoadDataHangHoa();
        }
    }
}
