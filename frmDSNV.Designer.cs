namespace QL_VT
{
    partial class frmDSNV
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPre = new System.Windows.Forms.Button();
            this.cmbCN = new System.Windows.Forms.ComboBox();
            this.txtCN = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnPre);
            this.panel1.Controls.Add(this.cmbCN);
            this.panel1.Controls.Add(this.txtCN);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1866, 268);
            this.panel1.TabIndex = 29;
            // 
            // btnPre
            // 
            this.btnPre.Location = new System.Drawing.Point(499, 178);
            this.btnPre.Name = "btnPre";
            this.btnPre.Size = new System.Drawing.Size(268, 58);
            this.btnPre.TabIndex = 24;
            this.btnPre.Text = "In";
            this.btnPre.UseVisualStyleBackColor = true;
            this.btnPre.Click += new System.EventHandler(this.btnPre_Click);
            // 
            // cmbCN
            // 
            this.cmbCN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCN.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCN.FormattingEnabled = true;
            this.cmbCN.Location = new System.Drawing.Point(466, 26);
            this.cmbCN.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCN.Name = "cmbCN";
            this.cmbCN.Size = new System.Drawing.Size(582, 42);
            this.cmbCN.TabIndex = 12;
            this.cmbCN.SelectedIndexChanged += new System.EventHandler(this.cmbCN_SelectedIndexChanged);
            // 
            // txtCN
            // 
            this.txtCN.AutoSize = true;
            this.txtCN.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCN.Location = new System.Drawing.Point(292, 29);
            this.txtCN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtCN.Name = "txtCN";
            this.txtCN.Size = new System.Drawing.Size(145, 34);
            this.txtCN.TabIndex = 23;
            this.txtCN.Text = "Chi Nhánh";
            // 
            // frmDSNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1866, 766);
            this.Controls.Add(this.panel1);
            this.Name = "frmDSNV";
            this.Text = "frmDSNV";
            this.Load += new System.EventHandler(this.frmDSNV_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbCN;
        private System.Windows.Forms.Label txtCN;
        private System.Windows.Forms.Button btnPre;
    }
}