namespace QLThietBi
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
            grbDanhSachThietBi = new GroupBox();
            dgvDanhSachThietBi = new DataGridView();
            grbThongTinThietBi = new GroupBox();
            txtDonGia = new TextBox();
            txtTenThietBi = new TextBox();
            txtMaThietBi = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            grbThaoTac = new GroupBox();
            btnXoa = new Button();
            btnSua = new Button();
            btnThoat = new Button();
            btnThem = new Button();
            grbDanhSachThietBi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachThietBi).BeginInit();
            grbThongTinThietBi.SuspendLayout();
            grbThaoTac.SuspendLayout();
            SuspendLayout();
            // 
            // grbDanhSachThietBi
            // 
            grbDanhSachThietBi.Controls.Add(dgvDanhSachThietBi);
            grbDanhSachThietBi.Location = new Point(12, 23);
            grbDanhSachThietBi.Name = "grbDanhSachThietBi";
            grbDanhSachThietBi.Size = new Size(590, 422);
            grbDanhSachThietBi.TabIndex = 0;
            grbDanhSachThietBi.TabStop = false;
            grbDanhSachThietBi.Text = "Danh sách Thiết bị";
            // 
            // dgvDanhSachThietBi
            // 
            dgvDanhSachThietBi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhSachThietBi.Location = new Point(6, 42);
            dgvDanhSachThietBi.Name = "dgvDanhSachThietBi";
            dgvDanhSachThietBi.RowHeadersWidth = 62;
            dgvDanhSachThietBi.Size = new Size(578, 373);
            dgvDanhSachThietBi.TabIndex = 0;
            dgvDanhSachThietBi.CellClick += dgvDanhSachThietBi_CellClick;
            // 
            // grbThongTinThietBi
            // 
            grbThongTinThietBi.Controls.Add(txtDonGia);
            grbThongTinThietBi.Controls.Add(txtTenThietBi);
            grbThongTinThietBi.Controls.Add(txtMaThietBi);
            grbThongTinThietBi.Controls.Add(label3);
            grbThongTinThietBi.Controls.Add(label2);
            grbThongTinThietBi.Controls.Add(label1);
            grbThongTinThietBi.Location = new Point(608, 37);
            grbThongTinThietBi.Name = "grbThongTinThietBi";
            grbThongTinThietBi.Size = new Size(337, 231);
            grbThongTinThietBi.TabIndex = 1;
            grbThongTinThietBi.TabStop = false;
            grbThongTinThietBi.Text = "Thông Tin Thiết Bị";
            // 
            // txtDonGia
            // 
            txtDonGia.Location = new Point(142, 156);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(182, 31);
            txtDonGia.TabIndex = 5;
            txtDonGia.KeyPress += txtDonGia_KeyPress;
            // 
            // txtTenThietBi
            // 
            txtTenThietBi.Location = new Point(142, 94);
            txtTenThietBi.Name = "txtTenThietBi";
            txtTenThietBi.Size = new Size(182, 31);
            txtTenThietBi.TabIndex = 4;
            // 
            // txtMaThietBi
            // 
            txtMaThietBi.Location = new Point(142, 42);
            txtMaThietBi.Name = "txtMaThietBi";
            txtMaThietBi.Size = new Size(182, 31);
            txtMaThietBi.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 156);
            label3.Name = "label3";
            label3.Size = new Size(132, 25);
            label3.TabIndex = 2;
            label3.Text = "Đơn Giá (VND):";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 94);
            label2.Name = "label2";
            label2.Size = new Size(104, 25);
            label2.TabIndex = 1;
            label2.Text = "Tên Thiết Bị:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 42);
            label1.Name = "label1";
            label1.Size = new Size(103, 25);
            label1.TabIndex = 0;
            label1.Text = "Mã Thiết Bị:";
            // 
            // grbThaoTac
            // 
            grbThaoTac.Controls.Add(btnXoa);
            grbThaoTac.Controls.Add(btnSua);
            grbThaoTac.Controls.Add(btnThoat);
            grbThaoTac.Controls.Add(btnThem);
            grbThaoTac.Location = new Point(608, 274);
            grbThaoTac.Name = "grbThaoTac";
            grbThaoTac.Size = new Size(337, 171);
            grbThaoTac.TabIndex = 2;
            grbThaoTac.TabStop = false;
            grbThaoTac.Text = "Thao Tác";
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(170, 105);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(112, 34);
            btnXoa.TabIndex = 3;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(19, 105);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(112, 34);
            btnSua.TabIndex = 2;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(170, 43);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(112, 34);
            btnThoat.TabIndex = 1;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(19, 43);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(112, 34);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(957, 450);
            Controls.Add(grbThaoTac);
            Controls.Add(grbThongTinThietBi);
            Controls.Add(grbDanhSachThietBi);
            Name = "Form1";
            Text = "Quản Lý Thiết Bị / Vật Tư - VP105";
            Load += Form1_Load;
            grbDanhSachThietBi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachThietBi).EndInit();
            grbThongTinThietBi.ResumeLayout(false);
            grbThongTinThietBi.PerformLayout();
            grbThaoTac.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbDanhSachThietBi;
        private DataGridView dgvDanhSachThietBi;
        private GroupBox grbThongTinThietBi;
        private TextBox txtDonGia;
        private TextBox txtTenThietBi;
        private TextBox txtMaThietBi;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox grbThaoTac;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThoat;
        private Button btnThem;
    }
}
