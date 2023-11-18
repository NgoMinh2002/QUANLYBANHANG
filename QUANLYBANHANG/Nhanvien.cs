using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QUANLYBANHANG
{
    public partial class Nhanvien : Form
    {
        DataTable TbNhanVien;
        string sql, gt;
        public Nhanvien()
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

        private void Nhanvien_Load(object sender, EventArgs e)
        {
            text_ma.Enabled = false;
            btn_luu.Enabled = false;
            btn_boqua.Enabled = false;
            LoadNhanvien();
        }

        private void LoadNhanvien()
        {
            TbNhanVien = connect.query("Select * from NhanVien");
            data_nhanvien.DataSource = TbNhanVien; //Hiển thị vàodata_Khachhang

            data_nhanvien.Columns[0].HeaderText = "Mã nhân viên";
            data_nhanvien.Columns[1].HeaderText = "Tên nhân viên";
            data_nhanvien.Columns[2].HeaderText = "Giới tính";
            data_nhanvien.Columns[3].HeaderText = "Địa chỉ";
            data_nhanvien.Columns[4].HeaderText = "Điện thoại";
            data_nhanvien.Columns[5].HeaderText = "Ngày sinh";
            data_nhanvien.Columns[0].Width = 100;
            data_nhanvien.Columns[1].Width = 150;
            data_nhanvien.Columns[2].Width = 100;
            data_nhanvien.Columns[3].Width = 180;
            data_nhanvien.Columns[4].Width = 120;
            data_nhanvien.Columns[5].Width = 100;
            data_nhanvien.AllowUserToAddRows = false;
            data_nhanvien.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void data_nhanvien_Click(object sender, EventArgs e)
        {
            if (btn_them.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                text_ma.Focus();
                return;
            }
            if (TbNhanVien.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            text_ma.Text = data_nhanvien.CurrentRow.Cells["MaNV"].Value.ToString();
            text_ten.Text = data_nhanvien.CurrentRow.Cells["TenNV"].Value.ToString();
            if (data_nhanvien.CurrentRow.Cells["Gioitinh"].Value.ToString() == "Nam") Ck_gioitinh.Checked = true;
            else Ck_gioitinh.Checked = false;
            text_diachi.Text = data_nhanvien.CurrentRow.Cells["Diachi"].Value.ToString();
            mks_phone.Text = data_nhanvien.CurrentRow.Cells["Dienthoai"].Value.ToString();
            mks_ngaysinh.Text = data_nhanvien.CurrentRow.Cells["Ngaysinh"].Value.ToString();
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
            LoadNhanvien();
        }
        private void ResetValues()
        {
            text_ma.Text = "";
            text_ten.Text = "";
            Ck_gioitinh.Checked = false;
            text_diachi.Text = "";
            mks_ngaysinh.Text = "";
            mks_phone.Text = "";
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (text_ma.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                text_ma.Focus();
                return;
            }
            if (text_ten.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                text_ten.Focus();
                return;
            }
            if (text_diachi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                text_diachi.Focus();
                return;
            }
            if (mks_phone.Text == "(   )     -")
            {
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mks_phone.Focus();
                return;
            }
            if (mks_ngaysinh.Text == "  /  /")
            {
                MessageBox.Show("Bạn phải nhập ngày sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mks_ngaysinh.Focus();
                return;
            }
            if (!connect.IsDate(mks_ngaysinh.Text))
            {
                MessageBox.Show("Bạn phải nhập lại ngày sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                // mskNgaysinh.Text = "";
                mks_ngaysinh.Focus();
                return;
            }
            if (Ck_gioitinh.Checked == true)
                gt = "Nam";
            else
                gt = "Nữ";
            sql = "SELECT MaNV FROM NhanVien WHERE MaNV=N'" + text_ma.Text.Trim() + "'";
            if (connect.checkKhoa(sql))
            {
                MessageBox.Show("Mã nhân viên này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                text_ma.Focus();
                text_ma.Text = "";
                return;
            }
            sql = "INSERT INTO NhanVien VALUES (N'" + text_ma.Text.Trim() + "',N'" + text_ten.Text.Trim() + "',N'" + gt + "',N'" + text_diachi.Text.Trim() + "','" + mks_phone.Text + "','" + connect.ConvertDateTime(mks_ngaysinh.Text) + "')";
            connect.RunQuery(sql);
            LoadNhanvien();
            ResetValues();
            btn_xoa.Enabled = true;
            btn_them.Enabled = true;
            btn_capnhap.Enabled = true;
            btn_boqua.Enabled = false;
            btn_luu.Enabled = false;
            text_ma.Enabled = false;
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (TbNhanVien.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (text_ma.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa " + text_ten.Text + "  không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE NhanVien WHERE MaNV=N'" + text_ma.Text + "'";
                connect.RunQuery(sql);
                LoadNhanvien();
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

        private void mks_ngaysinh_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void text_search_TextChanged(object sender, EventArgs e)
        {
            connect.Open();
            TbNhanVien = connect.query("Select * from NhanVien where TenNV like N'%" + text_search.Text + "%'or MaNV like '%" + text_search.Text + "%'or Diachi like N'%" + text_search.Text + "%' or Dienthoai like'%" + text_search.Text + "%'");
            data_nhanvien.DataSource = TbNhanVien;
            data_nhanvien.AllowUserToAddRows = false;
            data_nhanvien.EditMode = DataGridViewEditMode.EditProgrammatically;
        }



        private void timkiem()
        {

        }
        private void btn_capnhap_Click(object sender, EventArgs e)
            {
                if (TbNhanVien.Rows.Count == 0)
                {
                    MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (text_ma.Text == "")
                {
                    MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (text_ten.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    text_ten.Focus();
                    return;
                }
                if (text_diachi.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    text_diachi.Focus();
                    return;
                }
                if (mks_phone.Text == "(   )     -")
                {
                    MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    mks_phone.Focus();
                    return;
                }
                if (mks_ngaysinh.Text == "  /  /")
                {
                    MessageBox.Show("Bạn phải nhập ngày sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    mks_ngaysinh.Focus();
                    return;
                }
                if (!connect.IsDate(mks_ngaysinh.Text))
                {
                    MessageBox.Show("Bạn phải nhập lại ngày sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    mks_ngaysinh.Text = "";
                    mks_ngaysinh.Focus();
                    return;
                }
                if (Ck_gioitinh.Checked == true)
                    gt = "Nam";
                else
                    gt = "Nữ";

                sql = "UPDATE NhanVien SET  TenNV=N'" + text_ten.Text.Trim().ToString() + "',Gioitinh=N'" + gt + "',Diachi=N'" + text_diachi.Text.Trim().ToString() + "',Dienthoai='" + mks_phone.Text.ToString() + "',Ngaysinh='" + connect.ConvertDateTime(mks_ngaysinh.Text) + "' WHERE MaNV=N'" + text_ma.Text + "'";
                connect.RunQuery(sql);
                LoadNhanvien();
                ResetValues();
                btn_boqua.Enabled = false;
            }
        }
    }

