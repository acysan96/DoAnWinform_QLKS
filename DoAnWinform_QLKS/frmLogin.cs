using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;
using BUL_QLKS;
using DTO_QLKS;

namespace DoAnWinform_QLKS
{
    public partial class frmLogin : Form
    {
        public static string PERMISSION = "";
        public frmLogin()
        {
            InitializeComponent();
        }
        User_BUL user_BUL = new User_BUL();
        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            PERMISSION = getPermission();
            if (txtUsername.Text == string.Empty)
            {
                MessageBox.Show("Nhập tài khoản");
            }
            else if (txtPassword.Text == string.Empty)
            {
                MessageBox.Show("Nhập password");
            }
            else
            {
                if (PERMISSION != string.Empty)
                {
                    if (PERMISSION.StartsWith("Admin"))
                    {
                        Admin.frmAdminMain_NhanVien fmAdmin = new Admin.frmAdminMain_NhanVien(this);
                        fmAdmin.Show();
                        this.Hide();
                        txtUsername.Clear();
                        txtUsername.Focus();
                        txtPassword.Clear();
                    }
                    else if (PERMISSION.StartsWith("Employee"))
                    {
                        Employee.frmEmployeeMain fmEmployee = new Employee.frmEmployeeMain(this);
                        fmEmployee.maNV = txtUsername.Text;
                        fmEmployee.Show();
                        this.Hide();
                        txtUsername.Clear();
                        txtUsername.Focus();
                        txtPassword.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Tài khoản và mật khẩu không đúng !");
                    }
                }
                else
                {
                    MessageBox.Show("Tài khoản và mật khẩu không đúng !");
                }
            }
        }
        private string getPermission()
        {
            string permission = "";
            string username = txtUsername.Text.ToUpper();
            string password = maHoaMD5(txtPassword.Text);
            User_DTO user_DTO = new User_DTO(username, password);
            if (user_BUL.login(user_DTO) != null)
            {
                foreach (DataRow dr in user_BUL.login(user_DTO).Rows)
                {
                    permission = dr["Permission"].ToString();
                }
            }
            return permission;
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có chắc chắn muốn thoát ứng dụng ?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Mã hóa MD5
        private string maHoaMD5(string chuoiMaHoa)
        {
            string str_md5 = "";
            byte[] mang = System.Text.Encoding.UTF8.GetBytes(chuoiMaHoa);

            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            mang = md5.ComputeHash(mang);

            foreach (byte b in mang)
            {
                str_md5 += b.ToString("X2");
            }
            return str_md5;
        }
    }
}
