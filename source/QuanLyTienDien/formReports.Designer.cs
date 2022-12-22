namespace QuanLyTienDien
{
    partial class formReports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formReports));
            this.label1 = new System.Windows.Forms.Label();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnXem1 = new DevExpress.XtraEditors.SimpleButton();
            this.cboKhuvuc = new System.Windows.Forms.ComboBox();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnXem2 = new DevExpress.XtraEditors.SimpleButton();
            this.cboSohoadon = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDongia = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chọn Khu vực";
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.AutoSize = true;
            this.groupControl1.Controls.Add(this.btnXem1);
            this.groupControl1.Controls.Add(this.cboKhuvuc);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Location = new System.Drawing.Point(98, 33);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(5);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(752, 144);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "Danh sách điện kế theo khu vực";
            // 
            // btnXem1
            // 
            this.btnXem1.Appearance.BackColor = System.Drawing.Color.Cyan;
            this.btnXem1.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXem1.Appearance.Options.UseBackColor = true;
            this.btnXem1.Appearance.Options.UseFont = true;
            this.btnXem1.Location = new System.Drawing.Point(562, 68);
            this.btnXem1.Margin = new System.Windows.Forms.Padding(4);
            this.btnXem1.Name = "btnXem1";
            this.btnXem1.Size = new System.Drawing.Size(118, 36);
            this.btnXem1.TabIndex = 4;
            this.btnXem1.Text = "Xem DS";
            this.btnXem1.Click += new System.EventHandler(this.btnXem1_Click);
            // 
            // cboKhuvuc
            // 
            this.cboKhuvuc.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.cboKhuvuc.FormattingEnabled = true;
            this.cboKhuvuc.Location = new System.Drawing.Point(179, 68);
            this.cboKhuvuc.Margin = new System.Windows.Forms.Padding(4);
            this.cboKhuvuc.Name = "cboKhuvuc";
            this.cboKhuvuc.Size = new System.Drawing.Size(312, 28);
            this.cboKhuvuc.TabIndex = 3;
            // 
            // groupControl2
            // 
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.AutoSize = true;
            this.groupControl2.Controls.Add(this.btnXem2);
            this.groupControl2.Controls.Add(this.cboSohoadon);
            this.groupControl2.Controls.Add(this.label2);
            this.groupControl2.Location = new System.Drawing.Point(98, 215);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(5);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(752, 141);
            this.groupControl2.TabIndex = 5;
            this.groupControl2.Text = "Hóa đơn tiền điện";
            // 
            // btnXem2
            // 
            this.btnXem2.Appearance.BackColor = System.Drawing.Color.Cyan;
            this.btnXem2.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXem2.Appearance.Options.UseBackColor = true;
            this.btnXem2.Appearance.Options.UseFont = true;
            this.btnXem2.Location = new System.Drawing.Point(530, 62);
            this.btnXem2.Margin = new System.Windows.Forms.Padding(4);
            this.btnXem2.Name = "btnXem2";
            this.btnXem2.Size = new System.Drawing.Size(150, 36);
            this.btnXem2.TabIndex = 4;
            this.btnXem2.Text = "Xem Hóa đơn";
            this.btnXem2.Click += new System.EventHandler(this.btnXem2_Click);
            // 
            // cboSohoadon
            // 
            this.cboSohoadon.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.cboSohoadon.FormattingEnabled = true;
            this.cboSohoadon.Location = new System.Drawing.Point(193, 67);
            this.cboSohoadon.Margin = new System.Windows.Forms.Padding(4);
            this.cboSohoadon.Name = "cboSohoadon";
            this.cboSohoadon.Size = new System.Drawing.Size(280, 28);
            this.cboSohoadon.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chọn Số hóa đơn";
            // 
            // btnDongia
            // 
            this.btnDongia.Appearance.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnDongia.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDongia.Appearance.Options.UseBackColor = true;
            this.btnDongia.Appearance.Options.UseFont = true;
            this.btnDongia.Location = new System.Drawing.Point(98, 389);
            this.btnDongia.Margin = new System.Windows.Forms.Padding(4);
            this.btnDongia.Name = "btnDongia";
            this.btnDongia.Size = new System.Drawing.Size(752, 36);
            this.btnDongia.TabIndex = 5;
            this.btnDongia.Text = "Bảng đơn giá tiền điện";
            this.btnDongia.Click += new System.EventHandler(this.btnDongia_Click);
            // 
            // formReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyTienDien.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(925, 470);
            this.Controls.Add(this.btnDongia);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formReports";
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.FormReports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.ComboBox cboKhuvuc;
        private DevExpress.XtraEditors.SimpleButton btnXem1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btnXem2;
        private System.Windows.Forms.ComboBox cboSohoadon;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton btnDongia;
    }
}