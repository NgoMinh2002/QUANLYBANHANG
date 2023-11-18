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
    public partial class NhaCungCap : Form
    {
        DataTable tbNCC;
        string sql;
        public NhaCungCap()
        {
            InitializeComponent();
        }

        private void NhaCungCap_Load(object sender, EventArgs e)
        {
            if (account.loainguoidung == 2)
            {
                this.btn_them.Enabled = false;
                this.btn_capnhap.Enabled = false;
                this.btn_luu.Enabled = false;
                this.btn_xoa.Enabled = false;
                this.text_ma.Enabled = false;
                this.text_ten.Enabled = false;
            }
            text_ma.Enabled = false;
            btn_luu.Enabled = false;
            btn_boqua.Enabled = false;
            loadDataNCC();
        }

        private void loadDataNCC()
        {
           
            tbNCC = connect.query("Select * from NhaCC"); //Đọc dữ liệu từ bảng
            data_NCC.DataSource = tbNCC; //Nguồn dữ liệu
            data_NCC.Columns[0].HeaderText = "Số thứ tự";                         //
            data_NCC.Columns[1].HeaderText = "Mã nhà cung cấp";
            data_NCC.Columns[2].HeaderText = "Tên nhà cung cấp";
            data_NCC.Columns[0].Width =80;
            data_NCC.Columns[1].Width = 200;
            data_NCC.Columns[2].Width = 300;
            data_NCC.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            data_NCC.EditMode = DataGridViewEditMode.EditProgrammatically; //Không cho sửa dữ liệu trực tiếp
        }

        private void data_NCC_Click(object sender, EventArgs e)
        {
            if (btn_them.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                text_ma.Focus();
                return;
            }
            if (tbNCC.Rows.Count == 0) //Nếu không có dữ liệu
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            text_ma.Text = data_NCC.CurrentRow.Cells["MaNCC"].Value.ToString();
            text_ten.Text = data_NCC.CurrentRow.Cells["TenNCC"].Value.ToString();
            btn_capnhap.Enabled = true;
            btn_xoa.Enabled = true;
            btn_boqua.Enabled = true;
        }
        private void ResetValue()
        {
            text_ma.Text = "";
            text_ten.Text = "";
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            loadDataNCC();
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
            if (text_ten.Text.Trim().Length == 0) //Nếu chưa nhập tên nhà cung cấp
            {
                MessageBox.Show("Bạn phải nhập tên nhà cung cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
               text_ten.Focus();
                return;
            }
            sql = "Select MaNCC From NhaCC where MaNCC=N'" + text_ma.Text.Trim() + "'";
            if (connect.checkKhoa(sql))
            {
                MessageBox.Show("Mã nhà cung cấp này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                text_ma.Focus();
                return;
            }

            sql = "INSERT INTO NhaCC VALUES('" +
                text_ma.Text + "',N'" + text_ten.Text + "')";
           connect.RunQuery(sql); //Thực hiện câu lệnh sql
            loadDataNCC(); //Nạp lại DataGridView
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
            if (tbNCC.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (text_ma.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (text_ten.Text.Trim().Length == 0) //nếu chưa nhập tên nhà cung cấp
            {
                MessageBox.Show("Bạn chưa nhập tên nhà cung cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            sql = "UPDATE NhaCC SET TenNCC=N'" +
                text_ten.Text.ToString() +
                "' WHERE MaNCC=N'" + text_ma.Text + "'";
             connect.RunQuery(sql);
            loadDataNCC();
            ResetValue();

            btn_boqua.Enabled = false;
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (tbNCC.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (text_ma.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá "+text_ten.Text+" không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE NhaCC WHERE MaNCC=N'" + text_ma.Text + "'";
               connect.RunQuery(sql);
                loadDataNCC();
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

        private void text_ma_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void text_ten_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void btn_dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void text_search_TextChanged(object sender, EventArgs e)
        {
            string rowFilter = string.Format("{0} like '{1}'", "TenNCC", "*" + text_search.Text + "*");
            (data_NCC.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
        }

        
    }
}
