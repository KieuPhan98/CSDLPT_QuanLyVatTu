namespace QL_VT
{
    partial class frmTaoLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label maNVLabel;
            System.Windows.Forms.Label hotenLabel;
            this.dataset = new QL_VT.QL_VATTUDataSet();
            this.bdsDSNV = new System.Windows.Forms.BindingSource(this.components);
            this.taDSNV = new QL_VT.QL_VATTUDataSetTableAdapters.DanhSachNVTableAdapter();
            this.taManager = new QL_VT.QL_VATTUDataSetTableAdapters.TableAdapterManager();
            this.gbTaoLogin = new System.Windows.Forms.GroupBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.cmbHoTen = new System.Windows.Forms.ComboBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.bntTaoTK = new System.Windows.Forms.Button();
            this.radioBntUser = new System.Windows.Forms.RadioButton();
            this.radioBntChiNhanh = new System.Windows.Forms.RadioButton();
            this.radioBntCongTy = new System.Windows.Forms.RadioButton();
            this.txtPassWord = new System.Windows.Forms.TextBox();
            this.txtLoginName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            maNVLabel = new System.Windows.Forms.Label();
            hotenLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSNV)).BeginInit();
            this.gbTaoLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // maNVLabel
            // 
            maNVLabel.AutoSize = true;
            maNVLabel.Location = new System.Drawing.Point(287, 398);
            maNVLabel.Name = "maNVLabel";
            maNVLabel.Size = new System.Drawing.Size(141, 29);
            maNVLabel.TabIndex = 39;
            maNVLabel.Text = "UserName :";
            // 
            // hotenLabel
            // 
            hotenLabel.AutoSize = true;
            hotenLabel.Location = new System.Drawing.Point(618, 398);
            hotenLabel.Name = "hotenLabel";
            hotenLabel.Size = new System.Drawing.Size(95, 29);
            hotenLabel.TabIndex = 37;
            hotenLabel.Text = "Họ tên :";
            // 
            // dataset
            // 
            this.dataset.DataSetName = "QL_VATTUDataSet";
            this.dataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsDSNV
            // 
            this.bdsDSNV.DataMember = "DanhSachNV";
            this.bdsDSNV.DataSource = this.dataset;
            // 
            // taDSNV
            // 
            this.taDSNV.ClearBeforeFill = true;
            // 
            // taManager
            // 
            this.taManager.BackupDataSetBeforeUpdate = false;
            this.taManager.ChiNhanhTableAdapter = null;
            this.taManager.CTDDHTableAdapter = null;
            this.taManager.CTPNTableAdapter = null;
            this.taManager.CTPXTableAdapter = null;
            this.taManager.DanhSachNVTableAdapter = this.taDSNV;
            this.taManager.DatHangTableAdapter = null;
            this.taManager.NhanVienTableAdapter = null;
            this.taManager.PhieuNhapTableAdapter = null;
            this.taManager.PhieuXuatTableAdapter = null;
            this.taManager.UpdateOrder = QL_VT.QL_VATTUDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.taManager.VattuTableAdapter = null;
            // 
            // gbTaoLogin
            // 
            this.gbTaoLogin.BackColor = System.Drawing.Color.Transparent;
            this.gbTaoLogin.BackgroundImage = global::QL_VT.Properties.Resources.hinh_nen_goc_co_trui_hoa_sau_mua_dong_014746692;
            this.gbTaoLogin.Controls.Add(maNVLabel);
            this.gbTaoLogin.Controls.Add(this.txtUserName);
            this.gbTaoLogin.Controls.Add(hotenLabel);
            this.gbTaoLogin.Controls.Add(this.cmbHoTen);
            this.gbTaoLogin.Controls.Add(this.btnThoat);
            this.gbTaoLogin.Controls.Add(this.bntTaoTK);
            this.gbTaoLogin.Controls.Add(this.radioBntUser);
            this.gbTaoLogin.Controls.Add(this.radioBntChiNhanh);
            this.gbTaoLogin.Controls.Add(this.radioBntCongTy);
            this.gbTaoLogin.Controls.Add(this.txtPassWord);
            this.gbTaoLogin.Controls.Add(this.txtLoginName);
            this.gbTaoLogin.Controls.Add(this.label4);
            this.gbTaoLogin.Controls.Add(this.label2);
            this.gbTaoLogin.Controls.Add(this.label1);
            this.gbTaoLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbTaoLogin.Location = new System.Drawing.Point(0, 0);
            this.gbTaoLogin.Name = "gbTaoLogin";
            this.gbTaoLogin.Size = new System.Drawing.Size(1417, 854);
            this.gbTaoLogin.TabIndex = 0;
            this.gbTaoLogin.TabStop = false;
            // 
            // txtUserName
            // 
            this.txtUserName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsDSNV, "MaNV", true));
            this.txtUserName.Location = new System.Drawing.Point(453, 387);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(100, 35);
            this.txtUserName.TabIndex = 40;
            // 
            // cmbHoTen
            // 
            this.cmbHoTen.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsDSNV, "Hoten", true));
            this.cmbHoTen.DataSource = this.bdsDSNV;
            this.cmbHoTen.DisplayMember = "Hoten";
            this.cmbHoTen.FormattingEnabled = true;
            this.cmbHoTen.Location = new System.Drawing.Point(719, 390);
            this.cmbHoTen.Name = "cmbHoTen";
            this.cmbHoTen.Size = new System.Drawing.Size(255, 37);
            this.cmbHoTen.TabIndex = 38;
            this.cmbHoTen.ValueMember = "MaNV";
            this.cmbHoTen.SelectedIndexChanged += new System.EventHandler(this.cmbHoTen_SelectedIndexChanged);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Tomato;
            this.btnThoat.Location = new System.Drawing.Point(387, 594);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(166, 52);
            this.btnThoat.TabIndex = 35;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // bntTaoTK
            // 
            this.bntTaoTK.BackColor = System.Drawing.Color.Tomato;
            this.bntTaoTK.Location = new System.Drawing.Point(664, 594);
            this.bntTaoTK.Name = "bntTaoTK";
            this.bntTaoTK.Size = new System.Drawing.Size(211, 52);
            this.bntTaoTK.TabIndex = 36;
            this.bntTaoTK.Text = "Tạo Tài Khoản";
            this.bntTaoTK.UseVisualStyleBackColor = false;
            this.bntTaoTK.Click += new System.EventHandler(this.bntTaoTK_Click);
            // 
            // radioBntUser
            // 
            this.radioBntUser.AutoSize = true;
            this.radioBntUser.Location = new System.Drawing.Point(879, 477);
            this.radioBntUser.Name = "radioBntUser";
            this.radioBntUser.Size = new System.Drawing.Size(95, 33);
            this.radioBntUser.TabIndex = 34;
            this.radioBntUser.TabStop = true;
            this.radioBntUser.Text = "User";
            this.radioBntUser.UseVisualStyleBackColor = true;
            // 
            // radioBntChiNhanh
            // 
            this.radioBntChiNhanh.AutoSize = true;
            this.radioBntChiNhanh.Location = new System.Drawing.Point(647, 477);
            this.radioBntChiNhanh.Name = "radioBntChiNhanh";
            this.radioBntChiNhanh.Size = new System.Drawing.Size(156, 33);
            this.radioBntChiNhanh.TabIndex = 33;
            this.radioBntChiNhanh.TabStop = true;
            this.radioBntChiNhanh.Text = "Chi Nhánh";
            this.radioBntChiNhanh.UseVisualStyleBackColor = true;
            // 
            // radioBntCongTy
            // 
            this.radioBntCongTy.AutoSize = true;
            this.radioBntCongTy.Location = new System.Drawing.Point(453, 477);
            this.radioBntCongTy.Name = "radioBntCongTy";
            this.radioBntCongTy.Size = new System.Drawing.Size(125, 33);
            this.radioBntCongTy.TabIndex = 32;
            this.radioBntCongTy.TabStop = true;
            this.radioBntCongTy.Text = "Công ty";
            this.radioBntCongTy.UseVisualStyleBackColor = true;
            // 
            // txtPassWord
            // 
            this.txtPassWord.Location = new System.Drawing.Point(453, 319);
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.Size = new System.Drawing.Size(181, 35);
            this.txtPassWord.TabIndex = 31;
            // 
            // txtLoginName
            // 
            this.txtLoginName.Location = new System.Drawing.Point(453, 248);
            this.txtLoginName.Name = "txtLoginName";
            this.txtLoginName.Size = new System.Drawing.Size(181, 35);
            this.txtLoginName.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(287, 481);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 29);
            this.label4.TabIndex = 28;
            this.label4.Text = "Role :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(287, 322);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 29);
            this.label2.TabIndex = 29;
            this.label2.Text = "PassWord :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(287, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 29);
            this.label1.TabIndex = 26;
            this.label1.Text = "LoginName :";
            // 
            // frmTaoLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QL_VT.Properties.Resources.hinh_nen_goc_co_trui_hoa_sau_mua_dong_014746692;
            this.ClientSize = new System.Drawing.Size(1417, 854);
            this.Controls.Add(this.gbTaoLogin);
            this.Name = "frmTaoLogin";
            this.Text = "Tạo Login";
            this.Load += new System.EventHandler(this.frmTaoLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSNV)).EndInit();
            this.gbTaoLogin.ResumeLayout(false);
            this.gbTaoLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private QL_VATTUDataSet dataset;
        private System.Windows.Forms.BindingSource bdsDSNV;
        private QL_VATTUDataSetTableAdapters.DanhSachNVTableAdapter taDSNV;
        private QL_VATTUDataSetTableAdapters.TableAdapterManager taManager;
        private System.Windows.Forms.GroupBox gbTaoLogin;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.ComboBox cmbHoTen;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button bntTaoTK;
        private System.Windows.Forms.RadioButton radioBntUser;
        private System.Windows.Forms.RadioButton radioBntChiNhanh;
        private System.Windows.Forms.RadioButton radioBntCongTy;
        private System.Windows.Forms.TextBox txtPassWord;
        private System.Windows.Forms.TextBox txtLoginName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}