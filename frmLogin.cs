using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_VT
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            string chuoiketnoi = "Data Source=DESKTOP-IOHOU00\\SERVER_1;Initial Catalog=QL_VATTU;Integrated Security=True";
            Program.conn.ConnectionString = chuoiketnoi;
            Program.conn.Open();
            DataTable dt = new DataTable();
            dt = Program.ExecSqlDataTable("SELECT * FROM V_DS_PHANMANH");
            Program.bds_dspm.DataSource = dt;
            cmbCN.DataSource = dt;
            cmbCN.DisplayMember = "TENCN";
            cmbCN.ValueMember = "TENSERVER";
            cmbCN.SelectedIndex = -1;
        }

        private void cmbCN_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Program.servername = cmbCN.SelectedValue.ToString();
            }
            catch (Exception) { };
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text.Trim() == "" || txtPassword.Text.Trim() == "")
            {
                MessageBox.Show("Login name và mật mã không được trống", "", MessageBoxButtons.OK);
                return;
            }

            Program.mlogin = txtUser.Text;
            Program.password = txtPassword.Text;

            if (Program.KetNoi() == 0) return;

            Program.mChinhanh = cmbCN.SelectedIndex;

            Program.mloginDN = Program.mlogin;
            Program.passwordDN = Program.password;

            string strLenh = "EXEC sp_login '" + Program.mlogin + "'";

            Program.myReader = Program.ExecSqlDataReader(strLenh);
            if (Program.myReader == null) return;
            Program.myReader.Read(); // đọc 1 dòng

            // sp_login trả về 3 cột
            Program.username = Program.myReader.GetString(0);     // Lay user name, đọc cột đầu tiên
            if (Convert.IsDBNull(Program.username))
            {
                MessageBox.Show("Login bạn nhập không có quyền truy cập dữ liệu\n Bạn xem lại username, password", "", MessageBoxButtons.OK);
                return;
            }
            Program.mHoten = Program.myReader.GetString(1);
            Program.mGroup = Program.myReader.GetString(2);
            Program.myReader.Close();
            Program.conn.Close();
            //MessageBox.Show("Nhan vien - Nhom : " + Program.mHoten + " - " + Program.mGroup, "", MessageBoxButtons.OK);
            frmMain f = new frmMain();
            f.Show();
            this.Hide();
            f.FormClosed += (o, w) => this.Show();

            f.MANV.Text = "Mã nhân viên : " + Program.username;
            f.HOTEN.Text = "Họ tên : " + Program.mHoten;
            f.NHOM.Text = "Nhóm : " + Program.mGroup;
        }
    }
}

