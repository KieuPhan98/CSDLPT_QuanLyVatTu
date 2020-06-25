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
    public partial class frmPhieuNhap : Form
    {
        private string mavt;
        private int soluong;
        private string maDDH;
        private object vitri;

        public frmPhieuNhap()
        {
            InitializeComponent();
        }

        private void phieuNhapBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsPhieuNhap.EndEdit();
            this.taManager.UpdateAll(this.dataset);
        }

        private void frmPhieuNhap_Load(object sender, EventArgs e)
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

                this.taCTPN.Connection.ConnectionString = Program.connstr;
                this.taCTPN.Fill(this.dataset.CTPN);

                this.taPhieuNhap.Connection.ConnectionString = Program.connstr;
                this.taPhieuNhap.Fill(this.dataset.PhieuNhap);

                this.taDatHang.Connection.ConnectionString = Program.connstr;
                this.taDatHang.Fill(this.dataset.DatHang);

                this.sp_dsVTTableAdapter.Fill(this.dataset.sp_dsVT);

                if (Program.mGroup == "congty")
                {
                    btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnGhi.Enabled = btnUndo.Enabled = false;
                    btnGhiCTPN.Enabled = btnThemCTPN.Enabled = false;
                    btnReload.Enabled = labelCN.Enabled = cmbCN.Enabled = true;
                    pnPhieuNhap.Enabled = false;
                    txtMaDDH.Enabled = fillToolStripButton.Enabled = false;
                }
                else
                {
                    btnSua.Enabled = btnXoa.Enabled = btnUndo.Enabled = btnReload.Enabled = btnThem.Enabled = true;
                    labelCN.Enabled = cmbCN.Enabled = btnGhi.Enabled = false;
                    gcPhieuNhap.Enabled = true;
                    pnPhieuNhap.Enabled = false;
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
            gcPhieuNhap.Enabled = true;
            pnPhieuNhap.Enabled = false;
        }

        private void DisEnableForm()
        {
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnReload.Enabled = false;
            btnGhi.Enabled = btnUndo.Enabled = true;
            gcPhieuNhap.Enabled = false;
            pnPhieuNhap.Enabled = true;
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
            vitri = bdsPhieuNhap.Position;
            bdsPhieuNhap.AddNew();

            DisEnableForm();
            btnGhi.Enabled = true;
            txtMaNV.Text = Program.username;
            txtMaNV.Enabled = false;
        }

        //private bool KtraPhieuNhapTrenView(string maPN)
        //{
        //    for (int index = 0; index < bdsPhieuNhap.Count - 1; index++)
        //    {
        //        if (((DataRowView)bdsPhieuNhap[index])["MAPN"].ToString().Trim().Equals(maPN))
        //        {
        //            return false;
        //        }
        //    }
        //    return true;
        //}

        private bool KtraDonDathangTrenView(string maDDH)
        {
            for (int index = 0; index < bdsPhieuNhap.Count - 1; index++)
            {
                if (((DataRowView)bdsPhieuNhap[index])["MasoDDH"].ToString().Equals(maDDH))
                {
                    return false;
                }
            }
            return true;
        }

        private int KiemTraPhieuNhap(string maPN)
        {
            int result = 1;
            string lenh = string.Format("EXEC sp_timPhieuNhap {0}", maPN);
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

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (KiemTraPhieuNhap(txtMaPN.Text) == 1)
            {
                MessageBox.Show("Mã Phiếu Nhập không được trùng !", "", MessageBoxButtons.OK);
                txtMaPN.Focus();
                return;
            }

            if (txtMaPN.Text == string.Empty)
            {
                MessageBox.Show("Mã Phiếu Nhập không được thiếu !", "", MessageBoxButtons.OK);
                txtMaPN.Focus();
                return;
            }

            if (txtMaPN.Text.Length > 8)
            {
                MessageBox.Show("Mã Phiếu Nhập không được hơn 8 ký tự !", "", MessageBoxButtons.OK);
                txtMaPN.Focus();
                return;
            }

            if (txtNgay.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Ngày không được thiếu !", "", MessageBoxButtons.OK);
                return;
            }

            if (cmbMaDDH.Text == string.Empty)
            {
                MessageBox.Show("Mã Đơn Đặt Hàng không được thiếu !", "", MessageBoxButtons.OK);
                return;
            }

            if (KtraDonDathangTrenView(cmbMaDDH.Text) == false)
            {
                MessageBox.Show("Đơn Đặt Hàng đã có phiếu nhập !", "", MessageBoxButtons.OK);
                return;
            }

            try
            {
                bdsPhieuNhap.EndEdit();
                bdsPhieuNhap.ResetCurrentItem();

                this.taPhieuNhap.Connection.ConnectionString = Program.connstr;
                this.taPhieuNhap.Update(this.dataset.PhieuNhap);

                MessageBox.Show("Ghi thành công!");
            }
            catch { }

            EnableForm();
            //LoadTable();
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsCTPN.Count > 0)
            {
                MessageBox.Show("Phiếu Nhập đã có Chi Tiết Phiếu Nhập nên không thể xóa !", "", MessageBoxButtons.OK);
                return;
            }

            else if (MessageBox.Show("Bạn thực sự muốn xóa ??", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    bdsPhieuNhap.RemoveCurrent();

                    this.taPhieuNhap.Connection.ConnectionString = Program.connstr;
                    this.taPhieuNhap.Update(this.dataset.PhieuNhap);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa đơn đặt hàng. Bạn hãy xóa lại \n", ex.Message, MessageBoxButtons.OK);
                    this.taPhieuNhap.Fill(this.dataset.PhieuNhap);
                    return;
                }
            }
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsPhieuNhap.Position;
            DisEnableForm();
            txtMaDDH.Enabled = txtMaPN.Enabled = txtMaNV.Enabled = false;
        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsPhieuNhap.CancelEdit();
            LoadTable();
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.taPhieuNhap.Connection.ConnectionString = Program.connstr;
            this.taPhieuNhap.Fill(this.dataset.PhieuNhap);
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (pnPhieuNhap.Enabled || gcCTPN.Enabled)
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

        private void btnThemCTPN_Click(object sender, EventArgs e)
        {
            txtMaDDH.Text = ((DataRowView)bdsDatHang[bdsDatHang.Position])["MasoDDH"].ToString();
            bdsCTPN.AddNew();
            DisEnableForm();
            gcPhieuNhap.Enabled = true;
            btnGhi.Enabled = pnPhieuNhap.Enabled = false;
            try
            {
                this.sp_danhsachVTtrongDDHTableAdapter.Fill(this.dataset.sp_danhsachVTtrongDDH, txtMaDDH.Text);
                this.repositoryItemLookUpEdit1.DataSource = this.sp_danhsachVTtrongDDHBindingSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private int ktSoLuongdathang(string maVT, string maDDH, int sluong)
        {
            int result = 1; // thoa
            string lenh = string.Format("EXEC sp_kiemtraSoLuongNhap {0}, {1}, {2}", maVT, maDDH, sluong);
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
                    result = 0; // ko thoa
                }
            }
            return result;
        }

        private bool KtraVattuTrenView(string maVT)
        {
            for (int index = 0; index < bdsCTPN.Count - 1; index++)
            {
                if (((DataRowView)bdsCTPN[index])["MAVT"].ToString().Equals(maVT))
                {
                    return false;
                }
            }
            return true;
        }

        private int TangSoLuongTon(string maVT, int soluong)
        {
            int result = 1;
            string lenh = string.Format("EXEC sp_TangSoLuongTon {0}, {1} ", maVT, soluong);
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

        private void btnGhiCTPN_Click(object sender, EventArgs e)
        {
            mavt = ((DataRowView)bdsCTPN[bdsCTPN.Count - 1])["MAVT"].ToString();
            maDDH = ((DataRowView)bdsDatHang[bdsDatHang.Position])["MasoDDH"].ToString();
           // int soluong = int.Parse(((DataRowView)bdsCTPN[bdsCTPN.Count - 1])["SOLUONG"].ToString());

            if (mavt == string.Empty)
            {
                MessageBox.Show("Vật tư không thể thiếu ! ", "", MessageBoxButtons.OK);
                return;
            }

            if (KtraVattuTrenView(mavt) == false)
            {
                MessageBox.Show("Vật tư đã được nhập ! ", "", MessageBoxButtons.OK);
                bdsCTPN.RemoveCurrent(); 
                return;
            }

            if (gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "SOLUONG").ToString() == string.Empty)
            {
                MessageBox.Show("Số lượng không thể thiếu! ", "", MessageBoxButtons.OK);
                return;
            }

            soluong = int.Parse((gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "SOLUONG").ToString()));

            if (soluong < 0)
            {
                MessageBox.Show("Số lượng không thể âm ! ", "", MessageBoxButtons.OK);
                return;
            }
            if (ktSoLuongdathang(mavt, maDDH, soluong) == 0)
            {
                MessageBox.Show("Số lượng nhập không được hơn số lượng đặt !", "", MessageBoxButtons.OK);
                return;
            }

            if (gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "DONGIA").ToString() == string.Empty)
            {
                MessageBox.Show("Đơn giá không được thiếu !", "", MessageBoxButtons.OK);
                return;
            }

            try
            {
                bdsCTPN.EndEdit();
                bdsCTPN.ResetCurrentItem();

                TangSoLuongTon(mavt, soluong);

                MessageBox.Show("Ghi thành công !!!");

                this.taCTPN.Connection.ConnectionString = Program.connstr;
                this.taCTPN.Update(this.dataset.CTPN);
                this.repositoryItemLookUpEdit1.DataSource = this.sp_dsVTBindingSource;
            }
            catch (Exception) { }
            EnableForm();
        }

        private void fillToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.sp_danhsachVTtrongDDHTableAdapter.Fill(this.dataset.sp_danhsachVTtrongDDH, txtMaDDH.Text);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //private int GiamSoLuongTon(string maVT, int soluong)
        //{
        //    int result = 1;
        //    string lenh = string.Format("EXEC sp_GiamSoLuongTon {0}, {1} ", maVT, soluong);
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

        //private void btnXoaCTPN_Click(object sender, EventArgs e)
        //{
        //    mavt = ((DataRowView)bdsCTPN[bdsCTPN.Position])["MAVT"].ToString();
        //    int soluong1 = int.Parse(((DataRowView)bdsCTPN[bdsCTPN.Position])["SOLUONG"].ToString());
        //    if (MessageBox.Show("Bạn thực sự muốn xóa !", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
        //    {
        //        bdsCTPN.RemoveCurrent();
        //    }

        //    GiamSoLuongTon(mavt, soluong1);

        //    this.taCTPN.Connection.ConnectionString = Program.connstr;
        //    this.taCTPN.Update(this.dataset.CTPN);
        //}
    }
}
