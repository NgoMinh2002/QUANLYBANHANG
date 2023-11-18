using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYBANHANG
{
    public partial class Hanghoa : Form
    {
        DataTable Tbhanghoa;
        string sql;
        public Hanghoa()
        {
            InitializeComponent();
        }

        private void Hanghoa_Load(object sender, EventArgs e)
        {
            text_ma.Enabled = false;
            btn_luu.Enabled = false;
            btn_boqua.Enabled = false;
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
            textdongia.Text = "0";
            textgiaban.Text = "0";
            textsoluong.Text = "";
            textsoluong.Enabled = true;
            textdongia.Enabled = false;
            textgiaban.Enabled = false;


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

        private void btn_them_Click(object sender, EventArgs e)
        {
            btn_capnhap.Enabled = false;
            btn_xoa.Enabled = false;
            btn_boqua.Enabled = true;
            btn_luu.Enabled = true;
            btn_them.Enabled = false;
            ResetValues();
            text_ma.Enabled = true;
            text_ma.Focus();
            textsoluong.Enabled = true;
            textgiaban.Enabled = false;
            textdongia.Enabled = true;
        }


        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (text_ma.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                text_ma.Focus();
                return;
            }
            if (tex_ten.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tex_ten.Focus();
                return;
            }
            if (cb_loaihang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên loại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cb_loaihang.Focus();
                return;
            }
            if (cb_nhacungcap.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải tên nhà cung cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cb_nhacungcap.Focus();
                return;
            }

            sql = "SELECT MaHang FROM Hanghoa WHERE MaHang=N'" + text_ma.Text.Trim() + "'";
            if (connect.checkKhoa(sql))
            {
                MessageBox.Show("Mã hàng này đã tồn tại, bạn phải chọn mã hàng khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                text_ma.Focus();
                return;
            }
            string mahang = text_ma.Text;

            string tenhang = tex_ten.Text;
            string loaihang = cb_loaihang.SelectedValue.ToString();
            string nhacc = cb_nhacungcap.SelectedValue.ToString();
            string soluong = textsoluong.Text;
            string dongianhap = textdongia.Text;
          
            sql = "insert into Hanghoa values('" + mahang + "',N'" + tenhang + "',N'" + loaihang + "',N'" + nhacc + "','" + soluong + "','" + dongianhap + "','" + textgiaban.Text.Trim().Replace(",", ".") + "')";
            connect.RunQuery(sql);
            ResetValues();
            LoadDataHangHoa();
            btn_xoa.Enabled = true;
            btn_them.Enabled = true;
            btn_capnhap.Enabled = true;
            btn_boqua.Enabled = false;
            btn_luu.Enabled = false;
            text_ma.Enabled = false;
        }



        private void data_hanghoa_Click(object sender, EventArgs e)
        {
            String maNCC, maLoai;
            if (btn_them.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                text_ma.Focus();
                return;
            }
            if (Tbhanghoa.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            text_ma.Text = data_hanghoa.CurrentRow.Cells["MaHang"].Value.ToString();
            tex_ten.Text = data_hanghoa.CurrentRow.Cells["TenHang"].Value.ToString();
            maLoai = data_hanghoa.CurrentRow.Cells["Maloai"].Value.ToString();
            sql = "Select Tenloai from Loaihang where Maloai=N'" + maLoai + "'";
            cb_loaihang.Text = connect.GetFieldValues(sql);
            maNCC = data_hanghoa.CurrentRow.Cells["MaNCC"].Value.ToString();
            sql = "SELECT TenNCC FROM NhaCC WHERE MaNCC=N'" + maNCC + "'";
            cb_nhacungcap.Text = connect.GetFieldValues(sql);
            textsoluong.Text = data_hanghoa.CurrentRow.Cells["Soluong"].Value.ToString();
            textdongia.Text = data_hanghoa.CurrentRow.Cells["Dongianhap"].Value.ToString();
            textgiaban.Text = data_hanghoa.CurrentRow.Cells["Dongiaban"].Value.ToString();
            textdongia.Enabled = true;
            btn_capnhap.Enabled = true;
            btn_xoa.Enabled = true;
            btn_boqua.Enabled = true;
        }

        private void btn_capnhap_Click(object sender, EventArgs e)
        {
            if (Tbhanghoa.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (text_ma.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                text_ma.Focus();
                return;
            }
            if (tex_ten.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tex_ten.Focus();
                return;
            }
            if (cb_loaihang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập loại hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cb_loaihang.Focus();
                return;
            }
            if (cb_nhacungcap.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập chất liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cb_nhacungcap.Focus();
                return;
            }
            if (textdongia.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập đơn giá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tex_ten.Focus();
                return;
            }
            if (textsoluong.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập đơn giá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textsoluong.Focus();
                return;
            }
            sql = "UPDATE Hanghoa SET TenHang =N'" + tex_ten.Text.Trim().ToString() +
           "',Maloai=N'" + cb_loaihang.SelectedValue.ToString() +
           "',MaNCC=N'" + cb_nhacungcap.SelectedValue.ToString() +
           "',Soluong='" + textsoluong.Text.ToString() +
           "',Dongianhap='" + textdongia.Text.Replace(",", ".") + "',Dongiaban='" + textgiaban.Text.Trim().Replace(",", ".") + "' WHERE MaHang='" + text_ma.Text + "'";
            connect.RunQuery(sql);
            LoadDataHangHoa();
            ResetValues();
            btn_boqua.Enabled = false;
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (Tbhanghoa.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (text_ma.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá " + tex_ten.Text + " bản ghi này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE Hanghoa WHERE MaHang=N'" + text_ma.Text + "'";
                connect.RunSqlDel(sql);
                LoadDataHangHoa();
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

        private void textgiaban_TextChanged(object sender, EventArgs e)
        {

        }

        private void textdongia_TextChanged(object sender, EventArgs e)
        {
            double gn, gb;
            gn = Convert.ToDouble(textdongia.Text);
            gb = gn + (gn / 10);
            textgiaban.Text = gb.ToString();


        }
    }
}
