namespace TranMinhTu_6551071094_VP105_LTTQ
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvDanhSachThietBi = new DataGridView();
            txtThongTinThietBi = new Label();
            lblMaThietBi = new Label();
            lblTenThietBi = new Label();
            lblDonGia = new Label();
            txtMaThietBi = new TextBox();
            txtDonGia = new TextBox();
            txtTenThietBi = new TextBox();
            txtThaoTac = new Label();
            btnThem = new Button();
            btnThoat = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            txtDanhSachThietBi = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachThietBi).BeginInit();
            SuspendLayout();
            // 
            // dgvDanhSachThietBi
            // 
            dgvDanhSachThietBi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhSachThietBi.Location = new Point(12, 47);
            dgvDanhSachThietBi.Name = "dgvDanhSachThietBi";
            dgvDanhSachThietBi.RowHeadersWidth = 51;
            dgvDanhSachThietBi.Size = new Size(657, 457);
            dgvDanhSachThietBi.TabIndex = 0;
            dgvDanhSachThietBi.CellContentClick += dgvDanhSachThietBi_CellContentClick_1;
            // 
            // txtThongTinThietBi
            // 
            txtThongTinThietBi.AutoSize = true;
            txtThongTinThietBi.Location = new Point(685, 67);
            txtThongTinThietBi.Name = "txtThongTinThietBi";
            txtThongTinThietBi.Size = new Size(127, 20);
            txtThongTinThietBi.TabIndex = 1;
            txtThongTinThietBi.Text = "Thông tin thiết bị ";
            txtThongTinThietBi.Click += txtThongTinThietBi_Click;
            // 
            // lblMaThietBi
            // 
            lblMaThietBi.AutoSize = true;
            lblMaThietBi.Location = new Point(697, 103);
            lblMaThietBi.Name = "lblMaThietBi";
            lblMaThietBi.Size = new Size(84, 20);
            lblMaThietBi.TabIndex = 2;
            lblMaThietBi.Text = "Mã thiết bị:";
            // 
            // lblTenThietBi
            // 
            lblTenThietBi.AutoSize = true;
            lblTenThietBi.Location = new Point(697, 149);
            lblTenThietBi.Name = "lblTenThietBi";
            lblTenThietBi.Size = new Size(86, 20);
            lblTenThietBi.TabIndex = 3;
            lblTenThietBi.Text = "Tên thiết bị:";
            // 
            // lblDonGia
            // 
            lblDonGia.AutoSize = true;
            lblDonGia.Location = new Point(697, 196);
            lblDonGia.Name = "lblDonGia";
            lblDonGia.Size = new Size(110, 20);
            lblDonGia.TabIndex = 4;
            lblDonGia.Text = "Đơn giá (VND):";
            // 
            // txtMaThietBi
            // 
            txtMaThietBi.Location = new Point(815, 103);
            txtMaThietBi.Name = "txtMaThietBi";
            txtMaThietBi.Size = new Size(163, 27);
            txtMaThietBi.TabIndex = 5;
            txtMaThietBi.TextChanged += txtMaThietBi_TextChanged;
            // 
            // txtDonGia
            // 
            txtDonGia.Location = new Point(815, 196);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(163, 27);
            txtDonGia.TabIndex = 6;
            txtDonGia.TextChanged += txtDonGia_TextChanged;
            // 
            // txtTenThietBi
            // 
            txtTenThietBi.Location = new Point(815, 149);
            txtTenThietBi.Name = "txtTenThietBi";
            txtTenThietBi.Size = new Size(163, 27);
            txtTenThietBi.TabIndex = 7;
            txtTenThietBi.TextChanged += txtTenThietBi_TextChanged;
            // 
            // txtThaoTac
            // 
            txtThaoTac.AutoSize = true;
            txtThaoTac.Location = new Point(680, 286);
            txtThaoTac.Name = "txtThaoTac";
            txtThaoTac.Size = new Size(66, 20);
            txtThaoTac.TabIndex = 8;
            txtThaoTac.Text = "Thao tác";
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.DarkSeaGreen;
            btnThem.Location = new Point(697, 328);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(140, 36);
            btnThem.TabIndex = 9;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.IndianRed;
            btnThoat.Location = new Point(843, 328);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(140, 36);
            btnThoat.TabIndex = 10;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(697, 370);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(140, 36);
            btnSua.TabIndex = 11;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(843, 370);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(140, 36);
            btnXoa.TabIndex = 12;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // txtDanhSachThietBi
            // 
            txtDanhSachThietBi.AutoSize = true;
            txtDanhSachThietBi.Location = new Point(12, 27);
            txtDanhSachThietBi.Name = "txtDanhSachThietBi";
            txtDanhSachThietBi.Size = new Size(133, 20);
            txtDanhSachThietBi.TabIndex = 13;
            txtDanhSachThietBi.Text = "Danh Sách Thiết Bị";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(990, 516);
            Controls.Add(txtDanhSachThietBi);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThoat);
            Controls.Add(btnThem);
            Controls.Add(txtThaoTac);
            Controls.Add(txtTenThietBi);
            Controls.Add(txtDonGia);
            Controls.Add(txtMaThietBi);
            Controls.Add(lblDonGia);
            Controls.Add(lblTenThietBi);
            Controls.Add(lblMaThietBi);
            Controls.Add(txtThongTinThietBi);
            Controls.Add(dgvDanhSachThietBi);
            Name = "Form1";
            Text = "Quản lý thiết bị/Vật tư - VP105";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachThietBi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void NewMethod()
        {
            dgvDanhSachThietBi.CellContentClick += dgvDanhSachThietBi_CellContentClick;
        }

        #endregion

        private DataGridView dgvDanhSachThietBi;
        private Label txtThongTinThietBi;
        private Label lblMaThietBi;
        private Label lblTenThietBi;
        private Label lblDonGia;
        private TextBox txtMaThietBi;
        private TextBox txtDonGia;
        private TextBox txtTenThietBi;
        private Label txtThaoTac;
        private Button btnThem;
        private Button btnThoat;
        private Button btnSua;
        private Button btnXoa;
        private Label txtDanhSachThietBi;
    }
}
