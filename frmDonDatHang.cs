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
    public partial class frmDonDatHang : Form
    {
        private int vitri;
        private string mavt;
        private string soluong;
        private string dongia;

        public frmDonDatHang()
        {
            InitializeComponent();
        }

        private void datHangBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsDH.EndEdit();
            this.taManager.UpdateAll(this.dataset);
        }

        private void frmDonDatHang_Load(object sender, EventArgs e)
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

                this.taDSVT.Connection.ConnectionString = Program.connstr;
                this.taDSVT.Fill(this.dataset.sp_dsVT);

                this.taDH.Connection.ConnectionString = Program.connstr;
                this.taDH.Fill(this.dataset.DatHang);

                this.taCTDDH.Connection.ConnectionString = Program.connstr;
                this.taCTDDH.Fill(this.dataset.CTDDH);

                this.taPhieuNhap.Connection.ConnectionString = Program.connstr;
                this.taPhieuNhap.Fill(this.dataset.PhieuNhap);

                //this.dataset.EnforceConstraints = true;

                if (Program.mGroup == "congty")
                {
                    btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnGhi.Enabled = btnUndo.Enabled = false;
                    btnGhiVT.Enabled = btnThemVT.Enabled = false;
                    btnReload.Enabled = labelCN.Enabled = cmbCN.Enabled = true;
                    pnDDH.Enabled = false;

                    //gcCTDDH.ReadOnly = true;
                }
                else
                {
                    btnSua.Enabled = btnXoa.Enabled = btnUndo.Enabled = btnReload.Enabled = btnThem.Enabled = true;
                    labelCN.Enabled = cmbCN.Enabled = btnGhi.Enabled = false;
                    gcDH.Enabled = true;
                    pnDDH.Enabled = false;
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
            gcDH.Enabled = true;
            pnDDH.Enabled = false;
        }

        private void DisEnableForm()
        {
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnReload.Enabled = false;
            btnGhi.Enabled = btnUndo.Enabled = true;
            gcDH.Enabled = false;
            pnDDH.Enabled = true;
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
            //vitri = bdsDH.Position;
            bdsDH.AddNew();

            DisEnableForm();
            btnGhi.Enabled = true;
            txtMaNV.Text = Program.username;
            txtMaNV.Enabled = false;
        }

        private int ktDonDatHang(string maDDH)
        {
            int result = 1;
            string lenh = string.Format("EXEC sp_timDonDatHang {0}", maDDH);
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
            if (txtMaDDH.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Mã đơn đặt hàng không được thiếu !", "", MessageBoxButtons.OK);
                txtMaDDH.Focus();
                return;
            }

            if (txtMaDDH.Text.Length > 8)
            {
                MessageBox.Show("Mã đơn đặt hàng không được quá 8 kí tự !", "", MessageBoxButtons.OK);
                txtMaDDH.Focus();
                return;
            }
            if (txtMaDDH.Enabled == true)
            {
                try
                {
                    if (ktDonDatHang(txtMaDDH.Text) == 1)
                    {
                        MessageBox.Show("Mã đơn đặt hàng không được trùng !", "", MessageBoxButtons.OK);
                        txtMaDDH.Focus();
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }

            if (txtNGAY.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Ngày không được thiếu !", "", MessageBoxButtons.OK);
                txtNGAY.Focus();
                return;
            }

            if (txtNCC.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Nhà cung cấp không được thiếu!", "", MessageBoxButtons.OK);
                txtNCC.Focus();
                return;
            }

            //if (txtMaNV.Text.Trim() == string.Empty)
            //{
            //    MessageBox.Show("Mã nhân viên không được thiếu !", "", MessageBoxButtons.OK);
            //    return;
            //}

            try
            {
                bdsDH.EndEdit();
                bdsDH.ResetCurrentItem();

                this.taDH.Connection.ConnectionString = Program.connstr;
                this.taDH.Update(this.dataset.DatHang);

                MessageBox.Show("Ghi thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi Đơn Đặt Hàng .\n" + ex.Message);
                return;
            }

            EnableForm();
            LoadTable();
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsCTDDH.Count > 0)
            {
                MessageBox.Show("Đơn đặt hàng đã có chi tiết Đơn Đặt Hàng nên không thể xóa !", "", MessageBoxButtons.OK);
                return;
            }

            if (bdsPhieuNhap.Count > 0)
            {
                MessageBox.Show("Đơn đặt hàng đã có phiếu nhập nên không thể xóa !", "", MessageBoxButtons.OK);
                return;
            }

            else if (MessageBox.Show("Bạn có thật sự muốn xóa ??? ", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    bdsDH.RemoveCurrent();

                    this.taDH.Connection.ConnectionString = Program.connstr;
                    this.taDH.Update(this.dataset.DatHang);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa đơn đặt hàng. Bạn hãy xóa lại \n", ex.Message, MessageBoxButtons.OK);
                    this.taDH.Fill(this.dataset.DatHang);
                    return;
                }
            }
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //vitri = bdsDH.Position;
            DisEnableForm();
            txtMaDDH.Enabled = false;
        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsDH.CancelEdit();
            //if (btnThem.Enabled == false)
            //bdsDH.Position = vitri;
            LoadTable();
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.taDH.Connection.ConnectionString = Program.connstr;
            this.taDH.Fill(this.dataset.DatHang);
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (pnDDH.Enabled || gcCTDDH.Enabled)
            {
                if (MessageBox.Show("Dữ liệu chưa được lưu vào Database! \n Bạn thực sự muốn xóa?", "Thông báo",
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

        private void btnThemVT_Click(object sender, EventArgs e)
        {
            bdsCTDDH.AddNew();
            DisEnableForm();
            gcDH.Enabled = true;
            btnGhi.Enabled = pnDDH.Enabled = false;
        }

        private bool KiemTraVatTuTrenView(string maVT)
        {
            for (int index = 0; index < bdsCTDDH.Count - 1; index++)
            {
                if (((DataRowView)bdsCTDDH[index])["MAVT"].ToString().Equals(maVT))
                {
                    return false;
                }
            }
            return true;
        }

        private void btnGhiVT_Click(object sender, EventArgs e)
        {
            mavt = ((DataRowView)bdsCTDDH[bdsCTDDH.Count - 1])["MAVT"].ToString();
            soluong = ((DataRowView)bdsCTDDH[bdsCTDDH.Count - 1])["SOLUONG"].ToString();
            dongia = ((DataRowView)bdsCTDDH[bdsCTDDH.Count - 1])["DONGIA"].ToString();

            if (mavt == String.Empty)
            {
                MessageBox.Show("Vật tư không được thiếu!", "", MessageBoxButtons.OK);
                return;
            }

            if (KiemTraVatTuTrenView(mavt) == false)
            {
                MessageBox.Show("Vật tư không được trùng!", "", MessageBoxButtons.OK);
                bdsCTDDH.RemoveCurrent();
                return;
            }

            if (soluong == string.Empty)
            {
                MessageBox.Show("Số lượng không được thiếu!", "", MessageBoxButtons.OK);
                return;
            }

            if (dongia == string.Empty)
            {
                MessageBox.Show("Đơn giá không được thiếu!", "", MessageBoxButtons.OK);
                return;
            }

            try
            {
                bdsCTDDH.EndEdit();
                bdsCTDDH.ResetCurrentItem();

                MessageBox.Show("Ghi thành công !!!");

                this.taCTDDH.Connection.ConnectionString = Program.connstr;
                this.taCTDDH.Update(this.dataset.CTDDH);
            }
            catch (Exception) { }
            EnableForm();
        }

        
        //private void btnXoaVT_Click(object sender, EventArgs e)
        //{
        //    if (MessageBox.Show("Bạn thực sự muốn xóa !", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
        //    {
        //        bdsCTDDH.RemoveCurrent();
        //    }

        //    this.taCTDDH.Connection.ConnectionString = Program.connstr;
        //    this.taCTDDH.Update(this.dataset.CTDDH);
        //}
    }
}
