using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using System.Xml;

namespace QL_VT
{
    public partial class frmNhanVien : Form
    {
        private int vitri;
        private string macn;
        private int maxMaNV;

        public frmNhanVien()
        {
            InitializeComponent();
            bdsNV.CurrentChanged += BdsNV_CurrentChanged;
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            //EnableForm();
            LoadTable();

            cmbCN.DataSource = Program.bds_dspm.DataSource;
            cmbCN.DisplayMember = "TENCN";
            cmbCN.ValueMember = "TENSERVER";
            //cmbCN.SelectedIndex = -1;
            cmbCN.SelectedIndex = Program.mChinhanh;

            maxMaNV = MaNV_new();
            //Console.WriteLine("Ma Nhan Vien MAX : " + maxMaNV);

        }
        
        private void LoadTable()
        {
            try
            {
                this.dataSet.EnforceConstraints = false;

                this.taCN.Connection.ConnectionString = Program.connstr;
                this.taCN.Fill(this.dataSet.ChiNhanh);

                this.taNV.Connection.ConnectionString = Program.connstr;
                this.taNV.Fill(this.dataSet.NhanVien);

                this.taDATHANG.Connection.ConnectionString = Program.connstr;
                this.taDATHANG.Fill(this.dataSet.DatHang);

                this.taPHIEUNHAP.Connection.ConnectionString = Program.connstr;
                this.taPHIEUNHAP.Fill(this.dataSet.PhieuNhap);

                this.taPHIEUXUAT.Connection.ConnectionString = Program.connstr;
                this.taPHIEUXUAT.Fill(this.dataSet.PhieuXuat);
     
                this.dataSet.EnforceConstraints = true;

                macn = ((DataRowView)bdsNV[0])["MACN"].ToString();

                if(Program.mGroup.Equals("congty"))
                {
                    btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnRefresh.Enabled = false;
                    btnGhi.Enabled = btnPhucHoi.Enabled = btnChuyenCN.Enabled = false;
                    cmbCN.Enabled = txtCN.Enabled = true;

                    btnTaoLogin.Enabled = true;
                }
                else if(Program.mGroup == "user")
                {
                    btnXoa.Enabled = btnSua.Enabled = btnRefresh.Enabled = true;
                    btnPhucHoi.Enabled = btnChuyenCN.Enabled = btnThem.Enabled = true;
                    cmbCN.Enabled = txtCN.Enabled = btnTaoLogin.Enabled = btnGhi.Enabled = false;
                    gcNV.Enabled = true;
                    gbNV.Enabled = false;
                }
                else
                {
                    btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnRefresh.Enabled = true;
                    btnPhucHoi.Enabled = btnChuyenCN.Enabled = true;
                    cmbCN.Enabled = txtCN.Enabled = btnGhi.Enabled = false;
                    btnTaoLogin.Enabled = true;
                    gcNV.Enabled = true;
                    gbNV.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }           
        }

        private void EnableForm()
        {
            gcNV.Enabled = true;
            gbNV.Enabled = false;

            btnThem.Enabled = true;
            btnSua.Enabled = true;

            btnXoa.Enabled = true;
            btnRefresh.Enabled = true;

            btnGhi.Enabled = false;
            btnPhucHoi.Enabled = false;
            btnHuy.Enabled = false;

            txtCN.Enabled = true;
            cmbCN.Enabled = true;
        }

        private void DisableForm()
        {
            gcNV.Enabled = false;
            gbNV.Enabled = true;

            btnThem.Enabled = false;
            btnSua.Enabled = false;

            btnXoa.Enabled = false;
            btnRefresh.Enabled = false;

            btnGhi.Enabled = true;
            btnPhucHoi.Enabled = true;
            btnHuy.Enabled = true;

            txtCN.Enabled = false;
            cmbCN.Enabled = false;

            btnChuyenCN.Enabled = false;
            
        }               
        
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsNV.Position;
            bdsNV.AddNew();
            txtMACN.Text = macn;
            txtTRANGTHAIXOA.Text = "0";
            DisableForm();        
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

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {         
                vitri = bdsNV.Position;
                DisableForm();
                btnChuyenCN.Enabled = txtMANV.Enabled = false;
        }

        private int ktMaNV(int manv)
        {
            int result = 1;
            string lenh = string.Format("EXEC sp_timnhanvien {0}", manv);
            using (SqlConnection connection = new SqlConnection(Program.connstr))
            {
                connection.Open();
                SqlCommand sqlcmd = new SqlCommand(lenh, connection);
                sqlcmd.CommandType = CommandType.Text;
                try
                {
                    sqlcmd.ExecuteNonQuery(); // trả về số dòng
                }
                catch (Exception)
                {
                    result = 0;
                }
                return result;
            }
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMANV.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Mã nhân viên không được thiếu !", string.Empty, MessageBoxButtons.OK);
                txtMANV.Focus();
                return;
            }

            if(txtMANV.Enabled == true)
            {
                try
                {
                    if (ktMaNV(int.Parse(txtMANV.EditValue.ToString())) == 1)
                    {
                        MessageBox.Show("Mã nhân viên không được trùng !", string.Empty, MessageBoxButtons.OK);
                        txtMANV.Focus();
                        return;
                    }
                }
                catch (Exception ex)
                {
                    txtMANV.SelectAll();
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
            
            if (txtHO.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Họ nhân viên không được thiếu !", string.Empty, MessageBoxButtons.OK);
                txtHO.Focus();
                return;
            }
            if (txtTEN.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Tên nhân viên không được thiếu !", string.Empty, MessageBoxButtons.OK);
                txtTEN.Focus();
                return;
            }
            if (txtDIACHI.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Địa chỉ không được thiếu !", string.Empty, MessageBoxButtons.OK);
                txtDIACHI.Focus();
                return;
            }
            if (dtpNGAYSINH.Text.Trim() == string.Empty)
            {               
                MessageBox.Show("Ngày sinh không được thiếu !", string.Empty, MessageBoxButtons.OK);
                dtpNGAYSINH.Focus();
                return;
            }
            if (txtLuong.Value < 4000000)
            {
                MessageBox.Show("Vui lòng nhập lương lớn hơn 4.000.000", "", MessageBoxButtons.OK);
                txtLuong.Focus();
                return;
            }

            try
            {
                bdsNV.EndEdit();
                bdsNV.ResetCurrentItem();

                this.taNV.Connection.ConnectionString = Program.connstr;
                this.taNV.Update(this.dataSet.NhanVien);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi nhân viên.\n" + ex.Message);
                return;
            }
            LoadTable();
        }              

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int manv = 0;
            if(bdsPHIEUXUAT.Count > 0)
            {
                MessageBox.Show("Không thể xóa nhân viên này vì đã lập phiếu", "", MessageBoxButtons.OK);
                return;
            }
            else if(bdsPHIEUNHAP.Count > 0)
            {
                MessageBox.Show("Không thể xóa nhân viên này vì đã lập phiếu", "", MessageBoxButtons.OK);
                return;
            }
            else if(bdsDATHANG.Count > 0)
            {
                MessageBox.Show("Không thể xóa nhân viên này vì đã lập phiếu", "", MessageBoxButtons.OK);
                return;
            }
            else if(txtMANV.Text.Trim() == Program.username)
            {
                MessageBox.Show("Bạn không thể xóa chính mình !", "", MessageBoxButtons.OK);
                return;
            }
            else if(MessageBox.Show("Bạn có thật sự muốn xóa nhân viên này ???", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    manv = int.Parse(((DataRowView)bdsNV[bdsNV.Position])["MANV"].ToString());
                    bdsNV.RemoveCurrent();
                    this.taNV.Connection.ConnectionString = Program.connstr;
                    this.taNV.Update(this.dataSet.NhanVien);
                }
                catch(Exception ex) 
                    {
                    MessageBox.Show("Lỗi xóa nhân viên. Bạn hãy xóa lại \n", ex.Message, MessageBoxButtons.OK);
                    this.taNV.Fill(this.dataSet.NhanVien);
                    bdsNV.Position = bdsNV.Find("MANV", manv);
                    return;
                    } 
            }
            if (bdsNV.Count == 0) btnXoa.Enabled = false;     
        }

        private void BdsNV_CurrentChanged(object sender, EventArgs e)
        {
            Console.WriteLine(bdsNV.Position);
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsNV.CancelEdit();

            if (btnThem.Enabled == false)
            LoadTable();
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(gbNV.Enabled)
            {
                if (MessageBox.Show("Dữ liệu Form Nhân Viên vẫn chưa lưu vào Database! \nBạn có chắn chắn muốn thoát?", "Thông báo",
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

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadTable();
        }

        private int MaNV_new()
        {
            int maxMaNV = 0;
            string lenh = string.Format("SELECT MAX(MANV) AS MAXNV FROM LINK1.QL_VATTU.dbo.NhanVien");
            using(SqlConnection connection = new SqlConnection(Program.connstr))
            {
                connection.Open();
                SqlCommand sqlcmt = new SqlCommand(lenh, connection);
                sqlcmt.CommandType = CommandType.Text;
                try
                {
                    maxMaNV = (Int32)sqlcmt.ExecuteScalar();

                } catch { }
            }
            return (maxMaNV + 1);
        }

        private int ChuyenNhanVien(int maNV_hientai, int maNV_moi)
        {
            int result = 1;
            string lenh = string.Format("EXEC sp_ChuyenNhanVien {0}, {1} ", maNV_hientai, maNV_moi);
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

        private void btnChuyenCN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if ((MessageBox.Show("Bạn chắc chắn muốn chuyển nhân viên này ?", "", MessageBoxButtons.OKCancel)) == DialogResult.OK)
            {
                int trangthaixoa = int.Parse(((DataRowView)bdsNV[bdsNV.Position])["TrangThaiXoa"].ToString());

                if (trangthaixoa == 1)
                {
                    MessageBox.Show("Nhân viên này đã nghỉ làm hoặc chuyển chi nhánh. Vui lòng chọn nhân viên khác !", "", MessageBoxButtons.OK);
                    return;
                }

                try
                {
                    int maNV = int.Parse(((DataRowView)bdsNV[bdsNV.Position])["MANV"].ToString());
                    ChuyenNhanVien(maNV, maxMaNV);
                    MessageBox.Show("Chuyển chi nhánh thành công ! \n Mã nhân viên mới là: " + MaNV_new(), "", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi chuyển chi nhánh" + ex.Message);
                    return;
                }
            }
            else
            {
                return;
            }
            
        }
    }
}
