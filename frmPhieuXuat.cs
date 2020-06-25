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

namespace QL_VT
{
    public partial class frmPhieuXuat : Form
    {
        private int vitri;
        private string maVT;
        private string soluong;
        private string dongia;

        public frmPhieuXuat()
        {
            InitializeComponent();
        }

        private void phieuXuatBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsPhieuXuat.EndEdit();
            this.taManager.UpdateAll(this.dataset);
        }

        private void frmPhieuXuat_Load(object sender, EventArgs e)
        {
            LoadTable();

            cmbCN.DataSource = Program.bds_dspm.DataSource;
            cmbCN.DisplayMember = "TENCN";
            cmbCN.ValueMember = "TENSERVER";
            cmbCN.SelectedIndex = Program.mChinhanh;
        }

        private void LoadTable()
        {
            try
            {
                this.dataset.EnforceConstraints = false;

                this.taCTPX.Connection.ConnectionString = Program.connstr;
                this.taCTPX.Fill(this.dataset.CTPX);

                this.taPhieuXuat.Connection.ConnectionString = Program.connstr;
                this.taPhieuXuat.Fill(this.dataset.PhieuXuat);

                this.taDSVT.Fill(this.dataset.sp_dsVT);

                if (Program.mGroup == "congty")
                {
                    btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnGhi.Enabled = btnUndo.Enabled = false;
                    btnGhiCTPX.Enabled = btnThemCTPX.Enabled = false;
                    btnReload.Enabled = labelCN.Enabled = cmbCN.Enabled = true;
                    pnPhieuXuat.Enabled = false;
                }
                else
                {
                    btnSua.Enabled = btnXoa.Enabled = btnUndo.Enabled = btnReload.Enabled = btnThem.Enabled = true;
                    labelCN.Enabled = cmbCN.Enabled = btnGhi.Enabled = false;
                    gcPhieuXuat.Enabled = true;
                    pnPhieuXuat.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EnableForm()
        {
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnReload.Enabled = true;
            btnGhi.Enabled = btnUndo.Enabled = false;
            gcPhieuXuat.Enabled = true;
            pnPhieuXuat.Enabled = false;
        }

        private void DisEnableForm()
        {
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnReload.Enabled = false;
            btnGhi.Enabled = btnUndo.Enabled = true;
            gcPhieuXuat.Enabled = false;
            pnPhieuXuat.Enabled = true;
        }

        private void cmbCN_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCN.SelectedValue.ToString() == "System.Data.DataRowView")
                return;

            Program.servername = cmbCN.SelectedValue.ToString();

            if (cmbCN.SelectedIndex != Program.mChinhanh)
            {
                Program.mlogin = Program.remotelogin;
                Program.password = Program.remotepassword;
            }
            else
            {
                Program.mlogin = Program.mloginDN;
                Program.password = Program.passwordDN;
            }

            if (Program.KetNoi() == 0)
                MessageBox.Show("Lỗi kết nối về chi nhánh mới", string.Empty, MessageBoxButtons.OK);
            else
            {
                LoadTable();
            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsPhieuXuat.Position;
            bdsPhieuXuat.AddNew();

            DisEnableForm();
            btnGhi.Enabled = true;
            txtMaNV.Text = Program.username;
            txtMaNV.Enabled = false;
        }

        private int KiemTraPhieuXuat(string maPX)
        {
            int result = 1;
            string lenh = string.Format("EXEC sp_timPhieuXuat {0}", maPX);
            using (SqlConnection connection = new SqlConnection(Program.connstr))
            {
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand(lenh, connection);
                sqlCommand.CommandType = CommandType.Text;
                try
                {
                    sqlCommand.ExecuteNonQuery();
                }
                catch
                {
                    result = 0;
                }
            }
            return result;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (KiemTraPhieuXuat(txtMaPX.Text) == 1)
            {
                MessageBox.Show("Mã Phiếu Xuất không được trùng !", "", MessageBoxButtons.OK);
                txtMaPX.Focus();
                return;
            }

            if (txtMaPX.Text == string.Empty)
            {
                MessageBox.Show("Mã Phiếu Xuất không được thiếu !", "", MessageBoxButtons.OK);
                txtMaPX.Focus();
                return;
            }

            if (txtMaPX.Text.Length > 8)
            {
                MessageBox.Show("Mã Phiếu Xuất không được hơn 8 ký tự !", "", MessageBoxButtons.OK);
                txtMaPX.Focus();
                return;
            }

            if (txtNgay.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Ngày không được thiếu !", "", MessageBoxButtons.OK);
                return;
            }

            if (txtHoTenKH.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Họ tên Khách hàng không được thiếu !", "", MessageBoxButtons.OK);
                return;
            }

            try
            {
                bdsPhieuXuat.EndEdit();
                bdsPhieuXuat.ResetCurrentItem();

                this.taPhieuXuat.Connection.ConnectionString = Program.connstr;
                this.taPhieuXuat.Update(this.dataset.PhieuXuat);

                MessageBox.Show("Ghi thành công!");
            }
            catch
            {

            }
            EnableForm();
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsCTPX.Count > 0)
            {
                MessageBox.Show("Phiếu Xuất đã có Chi Tiết Phiếu xuất nên không thể xóa !", "", MessageBoxButtons.OK);
                return;
            }

            else if (MessageBox.Show("Bạn thực sự muốn xóa ??", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    bdsPhieuXuat.RemoveCurrent();

                    this.taPhieuXuat.Connection.ConnectionString = Program.connstr;
                    this.taPhieuXuat.Update(this.dataset.PhieuXuat);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa phiếu xuất. Bạn hãy xóa lại \n", ex.Message, MessageBoxButtons.OK);
                    this.taPhieuXuat.Fill(this.dataset.PhieuXuat);
                    return;
                }
            }
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsPhieuXuat.Position;
            DisEnableForm();
            txtMaPX.Enabled = txtMaNV.Enabled = false;
        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsPhieuXuat.CancelEdit();
            LoadTable();
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.taPhieuXuat.Connection.ConnectionString = Program.connstr;
            this.taPhieuXuat.Fill(this.dataset.PhieuXuat);
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (pnPhieuXuat.Enabled || gcCTPX.Enabled)
            {
                if (MessageBox.Show("Dữ liệu chưa được lưu vào Database! \n Bạn thực sự muốn thoát?", "Thông báo",
                    MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
        }

        private void btnThemCTPX_Click(object sender, EventArgs e)
        {
            bdsCTPX.AddNew();
            DisEnableForm();
            gcPhieuXuat.Enabled = true;
            btnGhi.Enabled = pnPhieuXuat.Enabled = false;
        }

        private bool KiemTraVatTuTrenView(string maVT)
        {
            for (int index = 0; index < bdsCTPX.Count - 1; index++)
            {
                if (((DataRowView)bdsCTPX[index])["MAVT"].ToString().Equals(maVT))
                {
                    return false;
                }
            }
            return true;
        }

        private int GiamSoLuongTon(string maVT, int soluong)
        {
            int result = 1;
            string lenh = string.Format("EXEC sp_GiamSoLuongTon {0}, {1} ", maVT, soluong);
            using (SqlConnection connection = new SqlConnection(Program.connstr))
            {
                connection.Open();
                SqlCommand sqlcmt = new SqlCommand(lenh, connection);
                sqlcmt.CommandType = CommandType.Text;
                try
                {
                    sqlcmt.ExecuteNonQuery();
                }
                catch
                {
                    result = 0;
                }
                return result;
            }
        }

        private void btnGhiCTPX_Click(object sender, EventArgs e)
        {
            maVT = ((DataRowView)bdsCTPX[bdsCTPX.Count - 1])["MAVT"].ToString();
            soluong = ((DataRowView)bdsCTPX[bdsCTPX.Count - 1])["SOLUONG"].ToString();
            dongia = ((DataRowView)bdsCTPX[bdsCTPX.Count - 1])["DONGIA"].ToString();

            if (maVT == String.Empty)
            {
                MessageBox.Show("Vật tư không được thiếu!", "", MessageBoxButtons.OK);
                return;
            }

            if (KiemTraVatTuTrenView(maVT) == false)
            {
                MessageBox.Show("Vật tư không được trùng!", "", MessageBoxButtons.OK);
                bdsCTPX.RemoveCurrent();
                return;
            }

            if (soluong == string.Empty)
            {
                MessageBox.Show("Số lượng không được thiếu!", "", MessageBoxButtons.OK);
                return;
            }

            int soluong1 = int.Parse(((DataRowView)bdsCTPX[bdsCTPX.Count - 1])["SOLUONG"].ToString());
            int temp = GiamSoLuongTon(maVT, soluong1);
            if (temp == 0)
            {
                MessageBox.Show("Vật tư không đủ số lượng để xuất!", "", MessageBoxButtons.OK);
                return;
            }

            if (dongia == string.Empty)
            {
                MessageBox.Show("Đơn giá không được thiếu!", "", MessageBoxButtons.OK);
                return;
            }

            try
            {
                bdsCTPX.EndEdit();
                bdsCTPX.ResetCurrentItem();

                //GiamSoLuongTon(maVT, soluong1);

                MessageBox.Show("Ghi thành công !!!");

                this.taCTPX.Connection.ConnectionString = Program.connstr;
                this.taCTPX.Update(this.dataset.CTPX);
            }
            catch (Exception) { }
            EnableForm();
        }

        //private int TangSoLuongTon(string maVT, int soluong)
        //{
        //    int result = 1;
        //    string lenh = string.Format("EXEC sp_TangSoLuongTon {0}, {1} ", maVT, soluong);
        //    using (SqlConnection connection = new SqlConnection(Program.connstr))
        //    {
        //        connection.Open();
        //        SqlCommand sqlcmt = new SqlCommand(lenh, connection);
        //        sqlcmt.CommandType = CommandType.Text;
        //        try
        //        {
        //            sqlcmt.ExecuteNonQuery();
        //        }
        //        catch
        //        {
        //            result = 0;
        //        }
        //        return result;
        //    }
        //}

        //private void btnXoaCTPX_Click(object sender, EventArgs e)
        //{
        //    maVT = ((DataRowView)bdsCTPX[bdsCTPX.Position])["MAVT"].ToString();
        //    int soluong1 = int.Parse(((DataRowView)bdsCTPX[bdsCTPX.Position])["SOLUONG"].ToString());

        //    if (MessageBox.Show("Bạn thực sự muốn xóa !", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
        //    {
        //        bdsCTPX.RemoveCurrent();
        //    }

        //    TangSoLuongTon(maVT, soluong1);

        //    this.taCTPX.Connection.ConnectionString = Program.connstr;
        //    this.taCTPX.Update(this.dataset.CTPX);
        //}
    }
}
