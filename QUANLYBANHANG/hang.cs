using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlTypes;

namespace QUANLYBANHANG
{
    public partial class hang : Form
    {
        DataTable Tbhanghoa;
        string sql;
        public hang()
        {
            InitializeComponent();
        }
        private void HangHoa_Load(object sender, EventArgs e)
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
            pc_hinhanh.Image = null;
            text_hinhanh.Text = "";
        }

        private void LoadDataHangHoa()
        {
            Tbhanghoa = connect.query("Select * from Hanghoa");
            data_hanghoa.DataSource = Tbhanghoa;
            data_hanghoa.DataSource = Tbhanghoa;
            data_hanghoa.Columns[0].HeaderText = "Mã hàng";
            data_hanghoa.Columns[1].HeaderText = "Tên hàng";
            data_hanghoa.Columns[2].HeaderText = "Mã Loại";
            data_hanghoa.Columns[3].HeaderText = "Nhà cung cấp";
            data_hanghoa.Columns[4].HeaderText = "Số lượng";
            data_hanghoa.Columns[5].HeaderText = "Đơn giá nhập";
            data_hanghoa.Columns[6].HeaderText = "Đơn giá bán";
            data_hanghoa.Columns[7].HeaderText = "Hình Ảnh";
            data_hanghoa.Columns[0].Width = 120;
            data_hanghoa.Columns[1].Width = 140;
            data_hanghoa.Columns[2].Width = 120;
            data_hanghoa.Columns[3].Width = 120;
            data_hanghoa.Columns[4].Width = 120;
            data_hanghoa.Columns[5].Width = 150;
            data_hanghoa.Columns[6].Width = 150;
            data_hanghoa.Columns[7].Width = 200;
            data_hanghoa.AllowUserToAddRows = false;
            data_hanghoa.EditMode = DataGridViewEditMode.EditProgrammatically;

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
            //  sql = "SELECT HinhAnh FROM Hanghoa WHERE MaHang=N'" + text_ma.Text + "'";
            //  text_hinhanh.Text = connect.GetFieldValues(sql);
            // pc_hinhanh.Image = Image.FromFile(text_hinhanh.Text);

            btn_capnhap.Enabled = true;
            btn_xoa.Enabled = true;
            btn_boqua.Enabled = true;
        }

        private void btn_open_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Filter = "Bitmap(*.bmp)|*.bmp|JPEG(*.jpg)|*.jpg|GIF(*.gif)|*.gif|All files(*.*)|*.*";
            dlgOpen.FilterIndex = 2;
            dlgOpen.Title = "Chọn ảnh minh hoạ cho sản phẩm";
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                pc_hinhanh.ImageLocation = dlgOpen.FileName;
                pc_hinhanh.Image = Image.FromFile(dlgOpen.FileName);
                text_hinhanh.Text = dlgOpen.FileName;
            }
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
        private byte[] imgeToByteArray(PictureBox pictureBox)
             {
                 MemoryStream memory = new MemoryStream();
                 pictureBox.Image.Save(memory, pictureBox.Image.RawFormat);
                 return memory.ToArray();
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
            if (text_hinhanh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn ảnh minh hoạ cho hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btn_open.Focus();
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
              int soluong = textsoluong.TextLength;
               double dongianhap = textdongia.TextLength;
               double dongiaban = textdongia.TextLength;
                byte[] anh = imgeToByteArray(pc_hinhanh);
        sql = "insert into Hanghoa values('" + mahang + "',N'"+tenhang+ "',N'"+loaihang+ "',N'"+nhacc+"','"+soluong+"','"+dongianhap+"','"+dongiaban+"','"+anh+"')";
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

        private void data_hanghoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void data_hanghoa_Click_1(object sender, EventArgs e)
        {

        }

        private void textgiaban_TextChanged(object sender, EventArgs e)
        {

        }
    }
        
}
