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
    public partial class DK_nguoidung : Form
    {
        DataTable tbdangky;
        string sql;
        public DK_nguoidung()
        {
            InitializeComponent();
        }

        private void DK_nguoidung_Load(object sender, EventArgs e)
        {
            text_ma.Enabled = false;
            btn_luu.Enabled = false;
            btn_boqua.Enabled = false;
            LoadDangky();
        }

        private void LoadDangky()
        {
            tbdangky = connect.query("select taikhoan,matkhau,case loainguoidung when 1 then N'Quản lí' when 2 then N'Nhân viên bán hàng' when 3 then N'Nhân viên kho'end as Loainguoidung from Dangnhap"); //Đọc dữ liệu từ bảng
            data_Dangky.DataSource = tbdangky; //Nguồn dữ liệu
            data_Dangky.Columns[0].HeaderText = "Tên người dùng";                         //
            data_Dangky.Columns[1].HeaderText = "Mật khẩu";
            data_Dangky.Columns[2].HeaderText = "Loại người dùng";
            data_Dangky.Columns[0].Width = 120;
            data_Dangky.Columns[1].Width = 200;
            data_Dangky.Columns[2].Width = 200;
            data_Dangky.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            data_Dangky.EditMode = DataGridViewEditMode.EditProgrammatically; //Không cho sửa dữ liệu trực tiếp
        }

        private void data_Dangky_Click(object sender, EventArgs e)
        {
            if (btn_them.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                text_ma.Focus();
                return;
            }
            if (tbdangky.Rows.Count == 0) //Nếu không có dữ liệu
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            text_ma.Text = data_Dangky.CurrentRow.Cells["taikhoan"].Value.ToString();
            text_Mk.Text = data_Dangky.CurrentRow.Cells["matkhau"].Value.ToString();
          cb_loainguoidung.Text = data_Dangky.CurrentRow.Cells["loainguoidung"].Value.ToString();
         
            btn_capnhap.Enabled = true;
            btn_xoa.Enabled = true;
            btn_boqua.Enabled = true;
        }
        private void ResetValue()
        {
            text_ma.Text = "";
            text_Mk.Text = "";
            cb_loainguoidung.Text = "1";
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            btn_capnhap.Enabled = false;
            btn_xoa.Enabled = false;
            btn_boqua.Enabled = true;
            btn_luu.Enabled = true;
            btn_them.Enabled = true;
            btn_them.Enabled = false;
            ResetValue(); //Xoá trắng các textbox
            text_ma.Enabled = true; //cho phép nhập mới
            text_ma.Focus();
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (text_ma.Text.Trim().Length == 0) //Nếu chưa nhập mã nhà cung cấp
            {
                MessageBox.Show("Bạn phải nhập mã nhà cung cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                text_ma.Focus();
                return;
            }
            if (text_Mk.Text.Trim().Length == 0) //Nếu chưa nhập tên nhà cung cấp
            {
                MessageBox.Show("Bạn phải nhập tên nhà cung cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                text_Mk.Focus();
                return;

            }
            if (cb_loainguoidung.Text.Trim().Length == 0) //Nếu chưa nhập tên nhà cung cấp
            {
                MessageBox.Show("Bạn phải nhập tên nhà cung cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cb_loainguoidung.Focus();
                return;
            }
            sql = "Select taikhoan From DangNhap where taikhoan=N'" + text_ma.Text.Trim() + "'";
            if (connect.checkKhoa(sql))
            {
                MessageBox.Show("Tài khoản  này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                text_ma.Focus();
                return;
            }

            sql = "INSERT INTO Dangnhap VALUES('" +
                text_ma.Text + "',N'" + text_Mk.Text + "','"+cb_loainguoidung.Text+"')";
            connect.RunQuery(sql); //Thực hiện câu lệnh sql
            LoadDangky(); //Nạp lại DataGridView
            ResetValue();
            btn_xoa.Enabled = true;
            btn_them.Enabled = true;
            btn_capnhap.Enabled = true;
            btn_boqua.Enabled = false;
            btn_luu.Enabled = false;
            text_ma.Enabled = false;
        }

        private void btn_capnhap_Click(object sender, EventArgs e)
        {
            if (tbdangky.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (text_ma.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (text_Mk.Text.Trim().Length == 0) //nếu chưa nhập tên nhà cung cấp
            {
                MessageBox.Show("Bạn chưa nhập khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;

            }

            if (cb_loainguoidung.Text.Trim().Length == 0) //nếu chưa nhập tên nhà cung cấp
            {
                MessageBox.Show("Bạn chưa chọn loại người dùng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            sql = "UPDATE Dangnhap SET matkhau='" +
                text_Mk.Text.ToString() +
                "',loainguoidung ='"+cb_loainguoidung.Text+"' WHERE taikhoan=N'" + text_ma.Text + "'";
            connect.RunQuery(sql);
            LoadDangky();
            ResetValue();

            btn_boqua.Enabled = false;
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (tbdangky.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (text_ma.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá " + text_ma.Text + " không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE DangNhap WHERE taikhoan=N'" + text_ma.Text + "'";
                connect.RunQuery(sql);
                LoadDangky();
                ResetValue();
            }
        }

        private void btn_boqua_Click(object sender, EventArgs e)
        {
            ResetValue();
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

        private void cb_loainguoidung_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }
    }
}
