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
    public partial class Khachhang : Form
    {
        DataTable tbkhachhang;
        string sql;
        public Khachhang()
        {
            InitializeComponent();
            text_search.ForeColor = Color.LightGray;
            text_search.Text = "Nhập giá trị tìm kiếm";
            this.text_search.Leave += new System.EventHandler(this.text_search_leave);
            this.text_search.Enter += new System.EventHandler(this.textBox1_Enter);
           
        }
        private void text_search_leave(object sender, EventArgs e)
        {
            if (text_search.Text == "")
            {
                text_search.Text = "Nhập giá trị tìm kiếm";
                text_search.ForeColor = Color.Gray;

            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (text_search.Text == "Nhập giá trị tìm kiếm")
            {
                text_search.Text = "";
                text_search.ForeColor = Color.Black;
            }
        }
        private void Khachhang_Load(object sender, EventArgs e)
        {
            
            text_ma.Enabled = false;
            btn_luu.Enabled = false;
            btn_boqua.Enabled = false;
            LoadDatakhach();
        }

        private void LoadDatakhach()
        {
           tbkhachhang = connect.query("Select * from Khachhang");
           data_Khachhang.DataSource = tbkhachhang; //Hiển thị vàodata_Khachhang
           data_Khachhang.Columns[0].HeaderText = "Mã khách";
           data_Khachhang.Columns[1].HeaderText = "Tên khách";
           data_Khachhang.Columns[2].HeaderText = "Địa chỉ";
           data_Khachhang.Columns[3].HeaderText = "Điện thoại";
           data_Khachhang.Columns[0].Width = 130;
           data_Khachhang.Columns[1].Width = 180;
           data_Khachhang.Columns[2].Width = 200;
           data_Khachhang.Columns[3].Width = 200;
           data_Khachhang.AllowUserToAddRows = false;
           data_Khachhang.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void data_Khachhang_Click(object sender, EventArgs e)
        {
            if (btn_them.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
               text_ma.Focus();
                return;
            }
            if (tbkhachhang.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            text_ma.Text = data_Khachhang.CurrentRow.Cells["MaKhach"].Value.ToString();
            text_ten.Text = data_Khachhang.CurrentRow.Cells["TenKhach"].Value.ToString();
            text_diachi.Text = data_Khachhang.CurrentRow.Cells["Diachi"].Value.ToString();
            mks_phone.Text = data_Khachhang.CurrentRow.Cells["Dienthoai"].Value.ToString();
            btn_capnhap.Enabled = true;
            btn_xoa.Enabled = true;
            btn_boqua.Enabled = true;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            btn_capnhap.Enabled = false;
            btn_xoa.Enabled = false;
            btn_boqua.Enabled = true;
            btn_luu.Enabled = true;
            btn_them.Enabled = false;
            ResetValues(); //Xoá trắng các textbox
            text_ma.Enabled = true; //cho phép nhập mới
            text_ma.Focus();
            LoadDatakhach();
        }

        private void ResetValues()
        {
            text_ma.Text = "";
            text_ten.Text = "";
            text_diachi.Text = "";
            mks_phone.Text = "";
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (text_ma.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã khách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                text_ma.Focus();
                return;
            }
            if (text_ten.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên khách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                text_ten.Focus();
                return;
            }
            if (text_diachi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                text_diachi.Focus();
                return;
            }
            if (mks_phone.Text == "(  )    -")
            {
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mks_phone.Focus();
                return;
            }
            //Kiểm tra đã tồn tại mã khách chưa
            sql = "SELECT MaKhach FROM Khachhang WHERE MaKhach=N'" +text_ma.Text.Trim() + "'";
            if (connect.checkKhoa(sql))
            {
                MessageBox.Show("Mã khách này đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                text_ma.Focus();
                return;
            }
            //Chèn thêm
            sql = "INSERT INTO KhachHang VALUES (N'" + text_ma.Text.Trim() +
                "',N'" + text_ten.Text.Trim() + "',N'" +text_diachi.Text.Trim() + "','" + mks_phone.Text + "')";
            connect.RunQuery(sql);
            LoadDatakhach();
            ResetValues();
            btn_xoa.Enabled = true;
            btn_them.Enabled = true;
            btn_capnhap.Enabled = true;
            btn_boqua.Enabled = false;
            btn_luu.Enabled = false;
            text_ma.Enabled = false;
        }

        private void btn_capnhap_Click(object sender, EventArgs e)
        {
            if (tbkhachhang.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (text_ma.Text == "")
            {
                MessageBox.Show("Bạn phải chọn bản ghi cần sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (text_ten.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên khách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                text_ten.Focus();
                return;
            }
            if (text_diachi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                text_diachi.Focus();
                return;
            }
            if (mks_phone.Text == "(  )    -")
            {
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mks_phone.Focus();
                return;
            }
            sql = "UPDATE Khachhang SET TenKhach=N'" + text_ten.Text.Trim().ToString() + "',Diachi=N'" +
              text_diachi.Text.Trim().ToString() + "',Dienthoai='" +mks_phone.Text.ToString() +
                "' WHERE MaKhach=N'" +text_ma.Text + "'";
            connect.RunQuery(sql);
            LoadDatakhach();
            ResetValues();
            btn_boqua.Enabled = false;
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (tbkhachhang.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (text_ma.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá bản ghi này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE Khachhang WHERE MaKhach=N'" + text_ma.Text + "'";
                connect.RunQuery(sql);
                LoadDatakhach();
                ResetValues();
            }
        }

        private void btn_boqua_Click(object sender, EventArgs e)
        {
            ResetValues();
           btn_boqua.Enabled = false;
            btn_them.Enabled = true;
           btn_xoa.Enabled = true;
            btn_capnhap.Enabled = true;
           btn_luu.Enabled = false;
           text_ma.Enabled = false;
        }

        private void btn_dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void text_diachi_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void text_search_TextChanged(object sender, EventArgs e)
        {
            connect.Open();
            tbkhachhang = connect.query("Select * from Khachhang where MaKhach like N'%" + text_search.Text + "%'or TenKhach like N'%" + text_search.Text + "%'or Diachi like N'%" + text_search.Text + "%' or Dienthoai like'%" + text_search.Text + "%'");
            data_Khachhang.DataSource = tbkhachhang;
            data_Khachhang.AllowUserToAddRows = false;
            data_Khachhang.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
    }
}
