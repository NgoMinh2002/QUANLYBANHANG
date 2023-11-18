
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cxcel = Microsoft.Office.Interop.Excel;

namespace QUANLYBANHANG
{
    public partial class Hoadon : Form
    {
        DataTable tbHoadon;
        string sql;
        public Hoadon()
        {
            InitializeComponent();
        }

        private void Hoadon_Load(object sender, EventArgs e)
        {

            btn_them.Enabled = true;
            btn_luu.Enabled = false;
            btn_Inhoadon.Enabled = true;
            text_maHDB.ReadOnly = true;
            text_tennv.ReadOnly = true;
            tex_tenkhach.ReadOnly = true;
            text_diachi.ReadOnly = true;
            texdienthoai.ReadOnly = true;
            text_tenhang.ReadOnly = true;
            textdongia.ReadOnly = true;
            textthanhtien.ReadOnly = true;
           // txt_tong.ReadOnly = true;
            textgiamgia.Text = "0";
            txt_tong.Text = "0000";
            connect.FillCombo("Select MaKhach,TenKhach From Khachhang", cb_khach, "MaKhach", "MaKhach");
            cb_khach.SelectedIndex = -1;
            connect.FillCombo("Select MaNV,TenNV from NhanVien ", cb_manv, "MaNV", "MaNV");
            cb_manv.SelectedIndex = -1;

            connect.FillCombo("SELECT MaHang, TenHang FROM Hanghoa", cbhanghoa, "MaHang", "MaHang");
            cbhanghoa.SelectedIndex = -1;
           
            if (text_maHDB.Text != "")
            {
                hoadon();
                btn_xoa.Enabled = true;
               btn_Inhoadon.Enabled = true;
              
            }
            loadHoadon();
        }
        private void hoadon()
        {
            string str;
            str = "SELECT NgayBan FROM Hoadon WHERE MaHDB = N'" + text_maHDB.Text + "'";
            date_ban.Text = connect.ConvertDateTime(connect.GetFieldValues(str));
            str = "SELECT MaNV FROM Hoadon WHERE MaHDB = N'" + text_maHDB.Text + "'";
            cb_manv.Text = connect.GetFieldValues(str);
            str = "SELECT MaKhach FROM Hoadon WHERE MaHDB = N'" + text_maHDB.Text + "'";
            cb_khach.Text = connect.GetFieldValues(str);
            str = "SELECT Tongtien FROM Hoadon WHERE MaHDB = N'" + text_maHDB.Text + "'";
            txt_tong.Text = connect.GetFieldValues(str);
            lavbangchu.Text = "Bằng chữ: " + connect.ChuyenSoSangChuoi(Double.Parse(txt_tong.Text));
        }
        private void loadHoadon()
        {
            sql = "SELECT a.MaHang, b.TenHang, a.Soluong, b.Dongiaban, a.Giamgia,a.Thanhtien FROM HoaDon_CT AS a, Hanghoa AS b WHERE   a.MaHang=b.MaHang";
            tbHoadon = connect.query(sql);
            data_hoadon.DataSource = tbHoadon;
            data_hoadon.Columns[0].HeaderText = "Mã hàng";
            data_hoadon.Columns[1].HeaderText = "Tên hàng";
            data_hoadon.Columns[2].HeaderText = "Số lượng";
            data_hoadon.Columns[3].HeaderText = "Đơn giá";
            data_hoadon.Columns[4].HeaderText = "Giảm giá %";
            data_hoadon.Columns[5].HeaderText = "Thành tiền";
            data_hoadon.Columns[0].Width = 80;
            data_hoadon.Columns[1].Width = 160;
            data_hoadon.Columns[2].Width = 80;
            data_hoadon.Columns[3].Width = 90;
            data_hoadon.Columns[4].Width = 90;
            data_hoadon.Columns[5].Width = 90;
            data_hoadon.AllowUserToAddRows = false;
            data_hoadon.EditMode = DataGridViewEditMode.EditProgrammatically;

        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            btn_xoa.Enabled = true;
            btn_luu.Enabled = true;
            btn_Inhoadon.Enabled = false;
            btn_them.Enabled = false;
            ResetValues();
            text_maHDB.Text = connect.CreateKey("HDB");
           loadHoadon();
         
            
        }

        private void ResetValues()
        {
            loadHoadon();
            date_ban.Text = DateTime.Now.ToShortDateString();
            text_tenhang.Text = "";
            text_tennv.Text = "";
            text_maHDB.Text = "";
            tex_tenkhach.Text = "";
            txt_tong.Text = "000";
            text_tenhang.Text = "";
            cbhanghoa.Text = "";
            cb_khach.Text = "";
            cb_manv.Text = "";
            texdienthoai.Text = "";
            textdongia.Text = "0";
            textgiamgia.Text = "0";
            textsoluong.Text = "0";
            textthanhtien.Text = "0";
            textton.Text = "";
            text_diachi.Text = "";
            lavbangchu.Text = "";
            
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            string sql;
           double sl, slcon, tong, tongmoi;
            sql = "select MaHDB from Hoadon Where MaHDB ='" + text_maHDB + "'";
            if (!connect.checkKhoa(sql))
            {
                if (date_ban.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập ngày bán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   date_ban.Focus();
                    return;
                }
                if (cb_manv.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                  cb_manv.Focus();
                    return;
                }
                if (cb_khach.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   cb_khach.Focus();
                    return;
                }
                sql = " SET DATEFORMAT DMY INSERT INTO Hoadon(MaHDB, NgayBan, MaNV, MaKhach, Tongtien) VALUES (N'" + text_maHDB.Text.Trim() + "',N'" +
                       date_ban.Text + "',N'" + cb_manv.SelectedValue + "',N'" +
                        cb_khach.SelectedValue + "'," + txt_tong.Text.Trim().Replace(".", ".") + ")";
               connect.RunQuery(sql);
            }
            if (cbhanghoa.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
              cbhanghoa.Focus();
                return;
            }
            if ((textsoluong.Text.Trim().Length == 0) || (textsoluong.Text == "0"))
            {
                MessageBox.Show("Bạn phải nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
               textsoluong.Text = "";
               textsoluong.Focus();
                return;
            }
            if (textgiamgia.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập giảm giá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
              textgiamgia.Focus();
                return;
            }
            sql = "SELECT MaHang FROM HoaDon_CT WHERE MaHang=N'" + cbhanghoa.SelectedValue + "' AND MaHDB = N'" + text_maHDB.Text.Trim() + "'";
            if (connect.checkKhoa(sql))
            {
                MessageBox.Show("Mã hàng này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetValuesHang();
                cbhanghoa.Focus();
                return;
            }
            sl = Convert.ToDouble(connect.GetFieldValues("SELECT Soluong FROM Hanghoa WHERE MaHang = N'" +cbhanghoa.SelectedValue + "'"));
            if (Convert.ToDouble(textsoluong.Text) > sl)
            {
                MessageBox.Show("Số lượng mặt hàng này chỉ còn " + sl, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
               textsoluong.Text = "";
              textsoluong.Focus();
                return;
            }
            sql = "INSERT INTO HoaDon_CT(MaHDB,MaHang,Soluong,Dongiaban, Giamgia,Thanhtien) VALUES(N'" + text_maHDB.Text.Trim() + "',N'" + cbhanghoa.SelectedValue + "','" + textsoluong.Text + "','" + textdongia.Text.Trim().Replace(",", ".") + "'," + textgiamgia.Text + ",'" + textthanhtien.Text.Trim().Replace(",", ".") + "')";
            connect.RunQuery(sql);
            loadHoadon();
             slcon = sl - Convert.ToDouble(textsoluong.Text);
            sql = "UPDATE Hanghoa SET Soluong =" + slcon + " WHERE MaHang= N'" + cbhanghoa.SelectedValue + "'";
            connect.RunQuery(sql);
            tong = Convert.ToDouble(connect.GetFieldValues("SELECT Tongtien FROM Hoadon WHERE MaHDB = N'" + text_maHDB.Text + "'"));
            tongmoi = tong + Convert.ToDouble(textthanhtien.Text.Trim().Replace(",", "."));
            sql = "UPDATE Hoadon SET Tongtien ='" + tongmoi + "' WHERE MaHDB = N'" + text_maHDB.Text + "'";
            connect.RunQuery(sql);
             txt_tong.Text= tongmoi.ToString();
            lavbangchu.Text = "Bằng chữ: " + connect.ChuyenSoSangChuoi(Double.Parse(txt_tong.Text));
            ResetValuesHang();
            btn_xoa.Enabled = true;
            btn_them.Enabled = true;
            btn_Inhoadon.Enabled = true;
        }

        private void ResetValuesHang()
        {
            tex_tenkhach.Text = "";
            text_tenhang.Text = "";
            text_tennv.Text = "";
          cbhanghoa.Text = "";
           textsoluong.Text = "";
           textgiamgia.Text = "0";
            lavbangchu.Text = "";
           textthanhtien.Text = "0";
        }

        private void data_hoadon_DoubleClick(object sender, EventArgs e)
        {
            string MaHangxoa, sql;
            Double ThanhTienxoa, SoLuongxoa, sl, slcon, tong, tongmoi;
            if (tbHoadon.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if ((MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                //Xóa hàng và cập nhật lại số lượng hàng 
                MaHangxoa = data_hoadon.CurrentRow.Cells["MaHang"].Value.ToString();
                SoLuongxoa = Convert.ToDouble(data_hoadon.CurrentRow.Cells["Soluong"].Value.ToString());
                ThanhTienxoa = Convert.ToDouble(data_hoadon.CurrentRow.Cells["Thanhtien"].Value.ToString());
                sql = "DELETE HoaDon_CT WHERE MaHDB=N'" + text_maHDB.Text + "' AND MaHang = N'" + MaHangxoa + "'";
                connect.RunQuery(sql);
                // Cập nhật lại số lượng cho các mặt hàng
                sl = Convert.ToDouble(connect.GetFieldValues("SELECT Soluong FROM Hanghoa WHERE MaHang = N'" + MaHangxoa + "'"));
                slcon = sl + SoLuongxoa;
                sql = "UPDATE Hanghoa SET Soluong =" + slcon + " WHERE Mahang= N'" + MaHangxoa + "'";
                connect.RunQuery(sql);
                // Cập nhật lại tổng tiền cho hóa đơn bán
           //    tong = Convert.ToDouble(connect.GetFieldValues("SELECT Tongtien FROM Hoadon WHERE MaHDB = N'" + text_tenhang.Text + "'"));
           //     tongmoi = tong - ThanhTienxoa;
           //    sql = "UPDATE Hoadon SET Tongtien =" + tongmoi + " WHERE MaHDB = N'" + text_maHDB.Text + "'";
           //     connect.RunQuery(sql);
            //    txt_tong.Text = tongmoi.ToString();
            //   lavbangchu.Text = "Bằng chữ: " + connect.ChuyenSoSangChuoi(Double.Parse(tongmoi.ToString()));
               loadHoadon();
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            ResetValuesHang();
            ResetValues();
           btn_luu.Enabled = false;
           btn_them.Enabled = true;
           btn_Inhoadon.Enabled = true;
        }

        private void cb_manv_TextChanged(object sender, EventArgs e)
        {
            string str;
            if (cb_manv.Text == "")
               text_tennv.Text = "";
            // Khi chọn Mã nhân viên thì tên nhân viên tự động hiện ra
            str = "Select TenNV from NhanVien where MaNV =N'" + cb_manv.SelectedValue + "'";
           text_tennv.Text = connect.GetFieldValues(str);
        }

        private void cb_khach_TextChanged(object sender, EventArgs e)
        {
            string str;
            if (cb_khach.Text == "")
            {
               tex_tenkhach.Text = "";
               text_diachi.Text = "";
                texdienthoai.Text = "";
            }
            //Khi chọn Mã khách hàng thì các thông tin của khách hàng sẽ hiện ra
            str = "Select TenKhach from Khachhang where MaKhach = N'" + cb_khach.SelectedValue + "'";
          tex_tenkhach.Text = connect.GetFieldValues(str);
            str = "Select Diachi from Khachhang where MaKhach = N'" + cb_khach.SelectedValue + "'";
            text_diachi.Text = connect.GetFieldValues(str);
            str = "Select Dienthoai from Khachhang where MaKhach= N'" + cb_khach.SelectedValue + "'";
           texdienthoai.Text = connect.GetFieldValues(str);
        }

        private void cbhanghoa_TextChanged(object sender, EventArgs e)
        {
            string str;
            if (cbhanghoa.Text == "")
            {
               tex_tenkhach.Text = "";
               textdongia.Text = "";
            }
            // Khi chọn mã hàng thì các thông tin về hàng hiện ra
            str = "SELECT TenHang FROM Hanghoa WHERE MaHang =N'" + cbhanghoa.SelectedValue + "'";
          text_tenhang.Text = connect.GetFieldValues(str);
            str = "SELECT Dongiaban FROM Hanghoa WHERE MaHang =N'" + cbhanghoa.SelectedValue + "'";
           textdongia.Text = connect.GetFieldValues(str);
            str = "SELECT Soluong FROM Hanghoa WHERE MaHang =N'" + cbhanghoa.SelectedValue + "'";
           textton.Text = connect.GetFieldValues(str);
           
        }

        private void textsoluong_TextChanged(object sender, EventArgs e)
        {
            double tt, sl, dg, gg;
            if (textsoluong.Text == "")
                sl = 0;
            else
            //       sl = Convert.ToDouble(text_quantity.Text);
            if (!double.TryParse(textsoluong.Text, out sl)) { }
            if (textgiamgia.Text == "")
                gg = 0;
            else
            //      gg = Convert.ToDouble(text_discount.Text);
            if (!double.TryParse(textgiamgia.Text, out gg)) { }
            if (textdongia.Text == "")
                dg = 0;
            else
                //     dg = Convert.ToDouble(text_unit_price.Text);
                if (!double.TryParse(textdongia.Text, out dg)) { }


            tt = sl * dg - sl * dg * gg / 100;
            textthanhtien.Text = tt.ToString();
        }

        private void textgiamgia_TextChanged(object sender, EventArgs e)
        {
            double tt, sl, dg, gg;
            if (textsoluong.Text == "")
                sl = 0;
            else
            //       sl = Convert.ToDouble(text_quantity.Text);
            if (!double.TryParse(textsoluong.Text, out sl)) { }
            if (textgiamgia.Text == "")
                gg = 0;
            else
            //      gg = Convert.ToDouble(text_discount.Text);
            if (!double.TryParse(textgiamgia.Text, out gg)) { }
            if (textdongia.Text == "")
                dg = 0;
            else
                //     dg = Convert.ToDouble(text_unit_price.Text);
                if (!double.TryParse(textdongia.Text, out dg)) { }


            tt = sl * dg - sl * dg * gg / 100;
            textthanhtien.Text = tt.ToString();
        }

        private void textgiamgia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else e.Handled = true;
        }

        private void textsoluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else e.Handled = true;
        }

        private void Hoadon_FormClosing(object sender, FormClosingEventArgs e)
        {
            ResetValues();
        }

        private void btn_dong_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Inhoadon_Click(object sender, EventArgs e)
        {
           Cxcel.Application exApp = new Cxcel.Application();
            Cxcel.Workbook exBook; //Trong 1 chương trình Excel có nhiều Workbook
            Cxcel.Worksheet exSheet; //Trong 1 Workbook có nhiều Worksheet
            Cxcel.Range exRange;
            string sql;
            int hang = 0, cot = 0;
             DataTable tblThongtinHD, tblThongtinHang;
            exBook = exApp.Workbooks.Add(Cxcel.XlWBATemplate.xlWBATWorksheet);
            exSheet = exBook.Worksheets[1];
            // Định dạng chung
            exRange = exSheet.Cells[1, 1];
            exRange.Range["A1:Z300"].Font.Name = "Times new roman"; //Font chữ
            exRange.Range["A1:B3"].Font.Size = 10;
            exRange.Range["A1:B3"].Font.Bold = true;
            exRange.Range["A1:B3"].Font.ColorIndex = 5; //Màu xanh da trời
            exRange.Range["A1:A1"].ColumnWidth = 7;
            exRange.Range["B1:B1"].ColumnWidth = 15;
            exRange.Range["A1:B1"].MergeCells = true;
            exRange.Range["A1:B1"].HorizontalAlignment = Cxcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A1:B1"].Value = "Cửa hàng điện máy Picod";
            exRange.Range["A2:B2"].MergeCells = true;
            exRange.Range["A2:B2"].HorizontalAlignment = Cxcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:B2"].Value = "23 P.Láng Hạ, Chợ Dừa, Ba Đình, Hà Nội";
            exRange.Range["A3:B3"].MergeCells = true;
            exRange.Range["A3:B3"].HorizontalAlignment = Cxcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A3:B3"].Value = "Điện thoại: (84) 0983734793";
            exRange.Range["C2:E2"].Font.Size = 16;
            exRange.Range["C2:E2"].Font.Bold = true;
            exRange.Range["C2:E2"].Font.ColorIndex = 3; //Màu đỏ
            exRange.Range["C2:E2"].MergeCells = true;
            exRange.Range["C2:E2"].HorizontalAlignment = Cxcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C2:E2"].Value = "HÓA ĐƠN BÁN";
            // Biểu diễn thông tin chung của hóa đơn bán
            sql = "SELECT a.MaHDB, a.Ngayban, a.Tongtien, b.TenKhach, b.Diachi, b.Dienthoai, c.TenNV FROM Hoadon AS a, KhachHang AS b, NhanVien AS c WHERE a.MaHDB = N'" + text_maHDB.Text.Trim() + "' AND a.MaKhach = b.MaKhach AND a.MaNV = c.MaNV";
            tblThongtinHD = connect.query(sql);
            exRange.Range["B6:C9"].Font.Size = 12;
            exRange.Range["B6:B6"].Value = "Mã hóa đơn:";
            exRange.Range["C6:E6"].MergeCells = true;
            exRange.Range["C6:E6"].Value = tblThongtinHD.Rows[0][0].ToString();
            exRange.Range["B7:B7"].Value = "Khách hàng:";
            exRange.Range["C7:E7"].MergeCells = true;
            exRange.Range["C7:E7"].Value = tblThongtinHD.Rows[0][3].ToString();
            exRange.Range["B8:B8"].Value = "Địa chỉ:";
            exRange.Range["C8:E8"].MergeCells = true;
            exRange.Range["C8:E8"].Value = tblThongtinHD.Rows[0][4].ToString();
            exRange.Range["B9:B9"].Value = "Điện thoại:";
            exRange.Range["C9:E9"].MergeCells = true;
            exRange.Range["C9:E9"].Value = tblThongtinHD.Rows[0][5].ToString();
            //Lấy thông tin các mặt hàng
            sql = "SELECT b.TenHang, a.Soluong, b.Dongiaban, a.Giamgia, a.Thanhtien " +
                  "FROM HoaDon_CT AS a , Hanghoa AS b WHERE a.MaHDB = N'" +
                  text_maHDB.Text + "' AND a.MaHang = b.MaHang";
            tblThongtinHang = connect.query(sql);
            //Tạo dòng tiêu đề bảng
            exRange.Range["A11:F11"].Font.Bold = true;
            exRange.Range["A11:F11"].HorizontalAlignment = Cxcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C11:F11"].ColumnWidth = 12;
            exRange.Range["A11:A11"].Value = "STT";
            exRange.Range["B11:B11"].Value = "Tên hàng";
            exRange.Range["C11:C11"].Value = "Số lượng";
            exRange.Range["D11:D11"].Value = "Đơn giá";
            exRange.Range["E11:E11"].Value = "Giảm giá";
            exRange.Range["F11:F11"].Value = "Thành tiền";
            for (hang = 0; hang < tblThongtinHang.Rows.Count; hang++)
            {
                //Điền số thứ tự vào cột 1 từ dòng 12
                exSheet.Cells[1][hang + 12] = hang + 1;
                for (cot = 0; cot < tblThongtinHang.Columns.Count; cot++)
                //Điền thông tin hàng từ cột thứ 2, dòng 12
                {
                    exSheet.Cells[cot + 2][hang + 12] = tblThongtinHang.Rows[hang][cot].ToString();
                    if (cot == 3) exSheet.Cells[cot + 2][hang + 12] = tblThongtinHang.Rows[hang][cot].ToString() + "%";
                }
            }
            exRange = exSheet.Cells[cot][hang + 14];
            exRange.Font.Bold = true;
            exRange.Value2 = "Tổng tiền:";
            exRange = exSheet.Cells[cot + 1][hang + 14];
            exRange.Font.Bold = true;
            exRange.Value2 = tblThongtinHD.Rows[0][2].ToString();
            exRange = exSheet.Cells[1][hang + 15]; //Ô A1 
            exRange.Range["A1:F1"].MergeCells = true;
            exRange.Range["A1:F1"].Font.Bold = true;
            exRange.Range["A1:F1"].Font.Italic = true;
            exRange.Range["A1:F1"].HorizontalAlignment = Cxcel.XlHAlign.xlHAlignRight;
             exRange.Range["A1:F1"].Value = "Bằng chữ: " + connect.ChuyenSoSangChuoi(Double.Parse(tblThongtinHD.Rows[0][2].ToString()));
            exRange = exSheet.Cells[4][hang + 17]; //Ô A1 
            exRange.Range["A1:C1"].MergeCells = true;
            exRange.Range["A1:C1"].Font.Italic = true;
            exRange.Range["A1:C1"].HorizontalAlignment = Cxcel.XlHAlign.xlHAlignCenter;
            DateTime d = Convert.ToDateTime(tblThongtinHD.Rows[0][1]);
            exRange.Range["A1:C1"].Value = "Hà Nội, ngày " + d.Day + " tháng " + d.Month + " năm " + d.Year;
            exRange.Range["A2:C2"].MergeCells = true;
            exRange.Range["A2:C2"].Font.Italic = true;
            exRange.Range["A2:C2"].HorizontalAlignment = Cxcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:C2"].Value = "Nhân viên bán hàng";
            exRange.Range["A6:C6"].MergeCells = true;
            exRange.Range["A6:C6"].Font.Italic = true;
            exRange.Range["A6:C6"].HorizontalAlignment = Cxcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A6:C6"].Value = tblThongtinHD.Rows[0][6];
            exSheet.Name = "Hóa đơn nhập";
            exApp.Visible = true;
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            if (cboMaHDBan.Text == "")
            {
                MessageBox.Show("Bạn phải chọn một mã hóa đơn để tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboMaHDBan.Focus();
                return;
            }
           text_maHDB.Text = cboMaHDBan.Text;
            hoadon();
            sql = "SELECT a.MaHang, b.TenHang, a.Soluong, b.Dongiaban, a.Giamgia,a.Thanhtien FROM HoaDon_CT AS a, Hanghoa AS b WHERE a.MaHDB = N'" + text_maHDB.Text + "' And  a.MaHang=b.MaHang";
            tbHoadon = connect.query(sql);
            data_hoadon.DataSource = tbHoadon;
            data_hoadon.Columns[0].HeaderText = "Mã hàng";
            data_hoadon.Columns[1].HeaderText = "Tên hàng";
            data_hoadon.Columns[2].HeaderText = "Số lượng";
            data_hoadon.Columns[3].HeaderText = "Đơn giá";
            data_hoadon.Columns[4].HeaderText = "Giảm giá %";
            data_hoadon.Columns[5].HeaderText = "Thành tiền";
            data_hoadon.Columns[0].Width = 80;
            data_hoadon.Columns[1].Width = 160;
            data_hoadon.Columns[2].Width = 80;
            data_hoadon.Columns[3].Width = 90;
            data_hoadon.Columns[4].Width = 90;
            data_hoadon.Columns[5].Width = 90;
            data_hoadon.AllowUserToAddRows = false;
            data_hoadon.EditMode = DataGridViewEditMode.EditProgrammatically;
            btn_xoa.Enabled = true;
            btn_luu.Enabled = true;
            btn_Inhoadon.Enabled = true;
            cboMaHDBan.SelectedIndex = -1;
        }

        private void date_ban_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void textdongia_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboMaHDBan_DropDown(object sender, EventArgs e)
        {
            connect.FillCombo("SELECT MaHDB FROM Hoadon", cboMaHDBan, "MaHDB", "MaHDB");
            cboMaHDBan.SelectedIndex = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadHoadon();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double sl, slcon, slxoa;
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sql = "SELECT MaHang,Soluong FROM HoaDon_CT WHERE MaHDB = N'" + text_maHDB.Text + "'";
                DataTable tblHang = connect.query(sql);
                for (int hang = 0; hang <= tblHang.Rows.Count - 1; hang++)
                {
                    // Cập nhật lại số lượng cho các mặt hàng
                    sl = Convert.ToDouble(connect.GetFieldValues("SELECT Soluong FROM Hanghoa WHERE MaHang = N'" + tblHang.Rows[hang][0].ToString() + "'"));
                    slxoa = Convert.ToDouble(tblHang.Rows[hang][1].ToString());
                    slcon = sl + slxoa;
                    sql = "UPDATE Hanghoa SET Soluong =" + slcon + " WHERE MaHang= N'" + tblHang.Rows[hang][0].ToString() + "'";
                    connect.RunQuery(sql);
                }

                //Xóa chi tiết hóa đơn
                sql = "DELETE HoaDon_CT WHERE MaHDB=N'" + text_maHDB.Text + "'";
                connect.RunQuery(sql);

                //Xóa hóa đơn
                sql = "DELETE Hoadon WHERE MaHDB=N'" + text_maHDB.Text + "'";
                connect.RunSqlDel(sql);
                ResetValues();
                loadHoadon();
             
                btn_Inhoadon.Enabled = false;
            }   }
    }
}


