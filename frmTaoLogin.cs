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

namespace QL_VT
{
    public partial class frmTaoLogin : Form
    {
        public frmTaoLogin()
        {
            InitializeComponent();
        }

        private void danhSachNVBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsDSNV.EndEdit();
            this.taManager.UpdateAll(this.dataset);
        }

        private void frmTaoLogin_Load(object sender, EventArgs e)
        {
            this.dataset.EnforceConstraints = false;

            this.taDSNV.Connection.ConnectionString = Program.connstr;
            this.taDSNV.Fill(this.dataset.DanhSachNV);

            txtUserName.Enabled = false;

            if (Program.mGroup == "congty")
            {
                radioBntChiNhanh.Enabled = radioBntUser.Enabled = false;
            }
            if (Program.mGroup == "chinhanh")
            {
                radioBntCongTy.Enabled = false;
            }
            if (Program.mGroup == "user")
            {
                MessageBox.Show("Bạn không có quyền tạo Login !", "", MessageBoxButtons.OK);
                gbTaoLogin.Enabled = false;
            }
        }

        private bool CreateLogin(string loginName, string password, string username, string role)
        {
            bool result = true;
            string strLenh = string.Format("EXEC sp_createlogin {0},{1},{2},{3}", loginName, password, username, role);
            using (SqlConnection connection = new SqlConnection(Program.connstr))
            {
                connection.Open();
                SqlCommand sqlcmd = new SqlCommand(strLenh, connection);
                sqlcmd.CommandType = CommandType.Text;
                try
                {
                    sqlcmd.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    result = false;
                }
            }
            return result;
        }

        private bool ktraTrungTenLogin(string loginName)
        {
            bool result = true;
            string strLenh = string.Format("EXEC sp_ktratrungLoginName {0}", loginName);
            using(SqlConnection connection = new SqlConnection(Program.connstr))
            {
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand(strLenh, connection);
                sqlCommand.CommandType = CommandType.Text;
                try
                {
                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    result = false;
                }
                return result;
            }
        }

        private bool ktraTonTaiLogin(string userName)
        {
            bool result = true;
            string strLenh = string.Format("EXEC sp_ktraTonTaiLogin {0}", userName);
            using (SqlConnection connection = new SqlConnection(Program.connstr))
            {
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand(strLenh, connection);
                sqlCommand.CommandType = CommandType.Text;
                try
                {
                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    result = false;
                }
                return result;
            }
        }

        //private int ktra_trangthaixoa(int maNV)
        //{
        //    string lenh = string.Format("")
        //}
        private void bntTaoTK_Click(object sender, EventArgs e)
        {
            if (txtLoginName.Text.Trim() == string.Empty)
            {
                MessageBox.Show("LoginName không được thiếu !", "", MessageBoxButtons.OK);
                txtLoginName.Focus();
                return;
            }
            if (txtLoginName.Text.Contains(" "))
            {
                MessageBox.Show("LoginName không được có khoảng trống !", "", MessageBoxButtons.OK);
                txtLoginName.Focus();
                return;
            }
            if (ktraTrungTenLogin(txtLoginName.Text))
            {
                MessageBox.Show("LoginName bị trùng. Vui lòng chọn LoginName khác !", "", MessageBoxButtons.OK);
                txtLoginName.Focus();
                return;
            }
            if(ktraTonTaiLogin(txtUserName.Text))
            {
                MessageBox.Show("Nhân viên này đã có Login, Vui lòng chọn nhân viên khác!", "", MessageBoxButtons.OK);
                txtUserName.Focus();
                return;
            }
            if (txtPassWord.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Password không được thiếu !", "", MessageBoxButtons.OK);
                txtPassWord.Focus();
                return;
            }
            if ((radioBntChiNhanh.Checked || radioBntCongTy.Checked || radioBntUser.Checked) == false)
            {
                MessageBox.Show("Role không được thiếu !", "", MessageBoxButtons.OK);
                return;
            }

            try
            {
                String role = radioBntCongTy.Checked ? "congty" : (radioBntChiNhanh.Checked ? "chinhanh" : "user");
                CreateLogin(txtLoginName.Text, txtPassWord.Text, txtUserName.Text, role);
                MessageBox.Show("Tạo Login thành công!", "", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi.\n" + ex.Message);
                return;
            }
        }

        private void cmbHoTen_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtUserName.Text = cmbHoTen.SelectedValue.ToString();

            }
            catch (Exception)
            {

            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Dữ liệu Form Tạo Login vẫn chưa được lưu! \nBạn có chắn chắn muốn thoát?", "Thông báo",
                        MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
            else
            {

            }
        }
    }
}
