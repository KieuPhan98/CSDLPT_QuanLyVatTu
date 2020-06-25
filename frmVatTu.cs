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
    public partial class frmVatTu : Form
    {
        private int vitri;
        //private string mavt;
        public frmVatTu()
        {
            InitializeComponent();
        }
                
        private void frmVatTu_Load(object sender, EventArgs e)
        {          
           // EnableForm();
            Loadtable();
        }

        private void Loadtable()
        {
            this.dataset.EnforceConstraints = false;

            this.taVT.Connection.ConnectionString = Program.connstr;
            this.taVT.Fill(this.dataset.Vattu);

            this.taCTDDH.Connection.ConnectionString = Program.connstr;
            this.taCTDDH.Fill(this.dataset.CTDDH);

            this.taCTPN.Connection.ConnectionString = Program.connstr;
            this.taCTPN.Fill(this.dataset.CTPN);

            this.taCTPX.Connection.ConnectionString = Program.connstr;
            this.taCTPX.Fill(this.dataset.CTPX);

            //this.dataSet.EnforceConstraints = true;

            if (Program.mGroup == "congty")
            {
                btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnGhi.Enabled = btnUndo.Enabled = false;
                btnReload.Enabled = true;
                gbVT.Enabled = false;

            }
            else
            {
                btnSua.Enabled = btnXoa.Enabled = btnUndo.Enabled = btnReload.Enabled = btnThem.Enabled = true;
                btnGhi.Enabled = false;
                gcVT.Enabled = true;
                gbVT.Enabled = false;
            }
        }

        private void EnableForm()
        {
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnReload.Enabled = true;
            btnGhi.Enabled = btnUndo.Enabled = false;
            gcVT.Enabled = true;
            gbVT.Enabled = false;
        }

        private void DisEnableForm()
        {
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnReload.Enabled = false;
            btnGhi.Enabled = btnUndo.Enabled = true;
            gcVT.Enabled = false;
            gbVT.Enabled = true;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsCTDDH.Count > 0)
            {
                MessageBox.Show("Vật tư có trong đơn đặt hàng nên không thể xóa !", "", MessageBoxButtons.OK);
                return;
            }
            else if (bdsCTPN.Count > 0)
            {
                MessageBox.Show("Vật tư có trong phiếu nhập nên không thể xóa !", "", MessageBoxButtons.OK);
                return;
            }
            else if (bdsCTPX.Count > 0)
            {
                MessageBox.Show("Vật tư có trong phiếu xuất nên không thể xóa !", "", MessageBoxButtons.OK);
                return;
            }
            else if (MessageBox.Show("Bạn có thật sự muốn xóa vật tư này ???", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    //mavt =((DataRowView)bdsVT[bdsVT.Position])["MAVT"].ToString(); 
                    bdsVT.RemoveCurrent();
                    this.taVT.Connection.ConnectionString = Program.connstr;
                    this.taVT.Update(this.dataset.Vattu);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa vật tư. Bạn hãy xóa lại \n", ex.Message, MessageBoxButtons.OK);
                    this.taVT.Fill(this.dataset.Vattu);
                    // bdsVT.Position = bdsVT.Find("MAVT", mavt);
                    return;
                }
            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsVT.Position;
            DisEnableForm();
            bdsVT.AddNew();

            txtMAVT.Enabled = true;
        }

        private int ktvattu(string mavt)
        {
            int result = 1;
            string lenh = string.Format("EXEC sp_timvattu {0}", mavt);
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
            if (txtMAVT.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Mã vật tư không được thiếu!", "", MessageBoxButtons.OK);
                txtMAVT.Focus();
                return;
            }
            if(txtMAVT.Text.Length > 4)
            {
                MessageBox.Show("Mã vật tư không được quá 4 kí tự !", "", MessageBoxButtons.OK);
                txtMAVT.Focus();
                return;
            }
            else if (txtMAVT.Text.Contains(" "))
            {
                MessageBox.Show("Mã vật tư không được chứa khoảng trắng!", "", MessageBoxButtons.OK);
                txtMAVT.Focus();
                return;
            }
            if (txtMAVT.Enabled == true)
            {
                try
                {
                    if (ktvattu(txtMAVT.EditValue.ToString()) == 1)
                    {
                        MessageBox.Show("Mã vật tư không được trùng!", "", MessageBoxButtons.OK);
                        txtMAVT.Focus();
                        return;
                    }
                }
                catch (Exception ex)
                {
                    //txtMAVT.SelectAll();
                    MessageBox.Show(ex.Message);
                    return;
                }               
            }
            if (txtTENVT.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Tên vật tư không được thiếu !", "", MessageBoxButtons.OK);
                txtTENVT.Focus();
                return;
            }
            if (txtDVT.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Đơn vị tính không được thiếu!", "", MessageBoxButtons.OK);
                txtDVT.Focus();
                return;
            }
            if (txtSLT.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Số lượng tồn không được thiếu !", "", MessageBoxButtons.OK);
                txtSLT.Focus();
                return;
            }
            try
            {
                bdsVT.EndEdit();
                bdsVT.ResetCurrentItem();

                this.taVT.Connection.ConnectionString = Program.connstr;
                this.taVT.Update(this.dataset.Vattu);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi ghi vật tư.." + ex.Message);
                return;
            }
            EnableForm();
            Loadtable();
        }

        private void vattuBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsVT.EndEdit();
            this.taVTManager.UpdateAll(this.dataset);
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsVT.Position;
            DisEnableForm();
            txtMAVT.Enabled = false;
        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsVT.CancelEdit();
            if (btnThem.Enabled == false)
                bdsVT.Position = vitri;
            Loadtable();
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gbVT.Enabled)
            {
                if(MessageBox.Show("Dữ liệu chưa được lưu vào Database! \nBạn có chắc chắn muốn thoát", "Thông báo", 
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

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Loadtable();
        }

    }
}