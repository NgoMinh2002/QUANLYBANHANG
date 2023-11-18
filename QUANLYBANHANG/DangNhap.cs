using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QUANLYBANHANG
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
            connect.Open();
            account.con = new SqlConnection(account.strconaccount);
            account.con.Open();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from Dangnhap where taikhoan=@tendangnhap and matkhau=@matkhau", account.con);
            cmd.Parameters.AddWithValue("@tendangnhap", txt_account.Text.Trim());
            cmd.Parameters.AddWithValue("@matkhau", txt_password.Text.Trim());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                account.tennguoidung = dt.Rows[0]["taikhoan"].ToString().Trim();
                account.loainguoidung = Convert.ToInt32(dt.Rows[0]["loainguoidung"]);

                Form_main f = new Form_main();
                f.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại, Sai tên người dùng hoặc mật khẩu", "Thông báo đăng nhập thất bại", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                txt_account.Text = "";
                txt_password.Text = "";
                txt_account.Focus();
            }
        }
    

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult exit = MessageBox.Show("Bạn có muốn thoát không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (exit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void show_pass_CheckedChanged(object sender, EventArgs e)
        {
            if (show_pass.Checked == true)
            {
                txt_password.PasswordChar = (char)0;
            }
            else
            {
                txt_password.PasswordChar = '*';
            }
        }
    }
}
