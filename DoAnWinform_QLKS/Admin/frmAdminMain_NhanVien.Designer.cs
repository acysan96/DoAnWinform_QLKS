
namespace DoAnWinform_QLKS.Admin
{
    partial class frmAdminMain_NhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminMain_NhanVien));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.cbPermission = new System.Windows.Forms.ComboBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.rdNu = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.txtSoDT = new System.Windows.Forms.TextBox();
            this.rdNam = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.cbTimNV = new System.Windows.Forms.ComboBox();
            this.dtGVNhanVien = new System.Windows.Forms.DataGridView();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chứcNăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qLHDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qLHàngHóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qLKháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qLPhòngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qLLoạiPhòngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qLNhàCungCấpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qLDịchVụToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qLPhiếuChiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLoadData = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.imageList3 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVNhanVien)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtFullName);
            this.groupBox1.Controls.Add(this.cbPermission);
            this.groupBox1.Controls.Add(this.txtMaNV);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.dtpNgaySinh);
            this.groupBox1.Controls.Add(this.rdNu);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtMatKhau);
            this.groupBox1.Controls.Add(this.txtTaiKhoan);
            this.groupBox1.Controls.Add(this.txtSoDT);
            this.groupBox1.Controls.Add(this.rdNam);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(12, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(710, 171);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhân viên";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(116, 129);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(119, 20);
            this.txtFullName.TabIndex = 96;
            // 
            // cbPermission
            // 
            this.cbPermission.FormattingEnabled = true;
            this.cbPermission.Items.AddRange(new object[] {
            "Admin",
            "Employee",
            "Không cấp quyền"});
            this.cbPermission.Location = new System.Drawing.Point(116, 86);
            this.cbPermission.Name = "cbPermission";
            this.cbPermission.Size = new System.Drawing.Size(119, 21);
            this.cbPermission.TabIndex = 116;
            this.cbPermission.SelectedIndexChanged += new System.EventHandler(this.cbPermission_SelectedIndexChanged);
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(116, 47);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(119, 20);
            this.txtMaNV.TabIndex = 93;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 95;
            this.label4.Text = "Họ tên nhân viên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 94;
            this.label3.Text = "Permission:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 92;
            this.label2.Text = "Mã nhân viên:";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(341, 129);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(119, 20);
            this.txtDiaChi.TabIndex = 103;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(341, 83);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(119, 20);
            this.dtpNgaySinh.TabIndex = 101;
            // 
            // rdNu
            // 
            this.rdNu.AutoSize = true;
            this.rdNu.Location = new System.Drawing.Point(421, 48);
            this.rdNu.Name = "rdNu";
            this.rdNu.Size = new System.Drawing.Size(39, 17);
            this.rdNu.TabIndex = 99;
            this.rdNu.TabStop = true;
            this.rdNu.Text = "Nữ";
            this.rdNu.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(504, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 104;
            this.label9.Text = "Số ĐT:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(490, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 106;
            this.label10.Text = "Tài khoản:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(493, 132);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 108;
            this.label11.Text = "Mật khẩu:";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(569, 129);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(119, 20);
            this.txtMatKhau.TabIndex = 109;
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Location = new System.Drawing.Point(569, 86);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(119, 20);
            this.txtTaiKhoan.TabIndex = 107;
            // 
            // txtSoDT
            // 
            this.txtSoDT.Location = new System.Drawing.Point(569, 47);
            this.txtSoDT.Name = "txtSoDT";
            this.txtSoDT.Size = new System.Drawing.Size(119, 20);
            this.txtSoDT.TabIndex = 105;
            // 
            // rdNam
            // 
            this.rdNam.AutoSize = true;
            this.rdNam.Location = new System.Drawing.Point(340, 48);
            this.rdNam.Name = "rdNam";
            this.rdNam.Size = new System.Drawing.Size(47, 17);
            this.rdNam.TabIndex = 98;
            this.rdNam.TabStop = true;
            this.rdNam.Text = "Nam";
            this.rdNam.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(278, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 102;
            this.label7.Text = "Địa chỉ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(264, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 100;
            this.label6.Text = "Ngày sinh:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(271, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 97;
            this.label5.Text = "Giới tính:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.Control;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(371, 323);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(249, 24);
            this.label12.TabIndex = 118;
            this.label12.Text = "DANH SÁCH NHÂN VIÊN";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Navy;
            this.groupBox2.Controls.Add(this.btnTim);
            this.groupBox2.Controls.Add(this.cbTimNV);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(12, 224);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(268, 110);
            this.groupBox2.TabIndex = 117;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm nhân viên";
            // 
            // btnTim
            // 
            this.btnTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTim.ImageKey = "imageres.dll_I00b1_0409.ico";
            this.btnTim.ImageList = this.imageList1;
            this.btnTim.Location = new System.Drawing.Point(145, 37);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(117, 40);
            this.btnTim.TabIndex = 27;
            this.btnTim.Text = "Tìm nhân viên";
            this.btnTim.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Add-Male-User-icon.png");
            this.imageList1.Images.SetKeyName(1, "change_cus.png");
            this.imageList1.Images.SetKeyName(2, "delete_cus.png");
            this.imageList1.Images.SetKeyName(3, "imageres.dll_I00b1_0409.ico");
            this.imageList1.Images.SetKeyName(4, "registrationicon.png");
            this.imageList1.Images.SetKeyName(5, "75519.png");
            this.imageList1.Images.SetKeyName(6, "wisedatarecoveryfree-icon.png");
            // 
            // cbTimNV
            // 
            this.cbTimNV.FormattingEnabled = true;
            this.cbTimNV.Location = new System.Drawing.Point(6, 48);
            this.cbTimNV.Name = "cbTimNV";
            this.cbTimNV.Size = new System.Drawing.Size(133, 21);
            this.cbTimNV.TabIndex = 30;
            // 
            // dtGVNhanVien
            // 
            this.dtGVNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGVNhanVien.Location = new System.Drawing.Point(12, 350);
            this.dtGVNhanVien.Name = "dtGVNhanVien";
            this.dtGVNhanVien.Size = new System.Drawing.Size(897, 198);
            this.dtGVNhanVien.TabIndex = 115;
            this.dtGVNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGWNhanVien_CellClick);
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "registrationicon.png");
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.chứcNăngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(919, 24);
            this.menuStrip1.TabIndex = 119;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngXuấtToolStripMenuItem});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // chứcNăngToolStripMenuItem
            // 
            this.chứcNăngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.qLHDToolStripMenuItem,
            this.qLHàngHóaToolStripMenuItem,
            this.qLKháchHàngToolStripMenuItem,
            this.qLPhòngToolStripMenuItem,
            this.qLLoạiPhòngToolStripMenuItem,
            this.qLNhàCungCấpToolStripMenuItem,
            this.qLDịchVụToolStripMenuItem,
            this.qLPhiếuChiToolStripMenuItem});
            this.chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
            this.chứcNăngToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.chứcNăngToolStripMenuItem.Text = "Chức năng";
            // 
            // qLHDToolStripMenuItem
            // 
            this.qLHDToolStripMenuItem.Name = "qLHDToolStripMenuItem";
            this.qLHDToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.qLHDToolStripMenuItem.Text = "Quản lý hóa đơn";
            this.qLHDToolStripMenuItem.Click += new System.EventHandler(this.qLHDToolStripMenuItem_Click);
            // 
            // qLHàngHóaToolStripMenuItem
            // 
            this.qLHàngHóaToolStripMenuItem.Name = "qLHàngHóaToolStripMenuItem";
            this.qLHàngHóaToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.qLHàngHóaToolStripMenuItem.Text = "Quản lý hàng hóa";
            this.qLHàngHóaToolStripMenuItem.Click += new System.EventHandler(this.qLHàngHóaToolStripMenuItem_Click);
            // 
            // qLKháchHàngToolStripMenuItem
            // 
            this.qLKháchHàngToolStripMenuItem.Name = "qLKháchHàngToolStripMenuItem";
            this.qLKháchHàngToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.qLKháchHàngToolStripMenuItem.Text = "Quản lý khách hàng";
            this.qLKháchHàngToolStripMenuItem.Click += new System.EventHandler(this.qLKháchHàngToolStripMenuItem_Click);
            // 
            // qLPhòngToolStripMenuItem
            // 
            this.qLPhòngToolStripMenuItem.Name = "qLPhòngToolStripMenuItem";
            this.qLPhòngToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.qLPhòngToolStripMenuItem.Text = "Quản lý phòng";
            this.qLPhòngToolStripMenuItem.Click += new System.EventHandler(this.qLPhòngToolStripMenuItem_Click);
            // 
            // qLLoạiPhòngToolStripMenuItem
            // 
            this.qLLoạiPhòngToolStripMenuItem.Name = "qLLoạiPhòngToolStripMenuItem";
            this.qLLoạiPhòngToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.qLLoạiPhòngToolStripMenuItem.Text = "Quản lý loại phòng";
            this.qLLoạiPhòngToolStripMenuItem.Click += new System.EventHandler(this.qLLoạiPhòngToolStripMenuItem_Click);
            // 
            // qLNhàCungCấpToolStripMenuItem
            // 
            this.qLNhàCungCấpToolStripMenuItem.Name = "qLNhàCungCấpToolStripMenuItem";
            this.qLNhàCungCấpToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.qLNhàCungCấpToolStripMenuItem.Text = "Quản lý nhà cung cấp";
            this.qLNhàCungCấpToolStripMenuItem.Click += new System.EventHandler(this.qLNhàCungCấpToolStripMenuItem_Click);
            // 
            // qLDịchVụToolStripMenuItem
            // 
            this.qLDịchVụToolStripMenuItem.Name = "qLDịchVụToolStripMenuItem";
            this.qLDịchVụToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.qLDịchVụToolStripMenuItem.Text = "Quản lý dịch vụ";
            this.qLDịchVụToolStripMenuItem.Click += new System.EventHandler(this.qLDịchVụToolStripMenuItem_Click);
            // 
            // qLPhiếuChiToolStripMenuItem
            // 
            this.qLPhiếuChiToolStripMenuItem.Name = "qLPhiếuChiToolStripMenuItem";
            this.qLPhiếuChiToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.qLPhiếuChiToolStripMenuItem.Text = "Quản lý Phiếu chi";
            this.qLPhiếuChiToolStripMenuItem.Click += new System.EventHandler(this.qLPhiếuChiToolStripMenuItem_Click);
            // 
            // btnLoadData
            // 
            this.btnLoadData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnLoadData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoadData.ImageKey = "wisedatarecoveryfree-icon.png";
            this.btnLoadData.ImageList = this.imageList1;
            this.btnLoadData.Location = new System.Drawing.Point(774, 307);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(118, 40);
            this.btnLoadData.TabIndex = 120;
            this.btnLoadData.Text = "Load Data";
            this.btnLoadData.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLoadData.UseVisualStyleBackColor = false;
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Red;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.ImageKey = "75519.png";
            this.btnThoat.ImageList = this.imageList1;
            this.btnThoat.Location = new System.Drawing.Point(774, 261);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(118, 40);
            this.btnThoat.TabIndex = 114;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.LimeGreen;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.ImageKey = "delete_cus.png";
            this.btnXoa.ImageList = this.imageList1;
            this.btnXoa.Location = new System.Drawing.Point(635, 261);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(126, 40);
            this.btnXoa.TabIndex = 113;
            this.btnXoa.Text = "Xóa nhân viên";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.ImageKey = "change_cus.png";
            this.btnSua.ImageList = this.imageList1;
            this.btnSua.Location = new System.Drawing.Point(491, 261);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(129, 40);
            this.btnSua.TabIndex = 112;
            this.btnSua.Text = "Sửa nhân viên";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.LimeGreen;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.ImageKey = "Add-Male-User-icon.png";
            this.btnThem.ImageList = this.imageList1;
            this.btnThem.Location = new System.Drawing.Point(335, 260);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(137, 40);
            this.btnThem.TabIndex = 111;
            this.btnThem.Text = "Thêm nhân viên";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.LimeGreen;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.ImageKey = "registrationicon.png";
            this.btnClear.ImageList = this.imageList2;
            this.btnClear.Location = new System.Drawing.Point(743, 153);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(149, 65);
            this.btnClear.TabIndex = 110;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // imageList3
            // 
            this.imageList3.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList3.ImageStream")));
            this.imageList3.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList3.Images.SetKeyName(0, "Logout.png");
            this.imageList3.Images.SetKeyName(1, "9-512.png");
            this.imageList3.Images.SetKeyName(2, "Customer.png");
            this.imageList3.Images.SetKeyName(3, "PhanQuyen.png");
            this.imageList3.Images.SetKeyName(4, "Room.png");
            this.imageList3.Images.SetKeyName(5, "sort.png");
            this.imageList3.Images.SetKeyName(6, "CheckIn.png");
            this.imageList3.Images.SetKeyName(7, "Services.png");
            this.imageList3.Images.SetKeyName(8, "Untitled-7-512.png");
            // 
            // frmAdminMain_NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DoAnWinform_QLKS.Properties.Resources.hinh_nen_powerpoint_dep_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(919, 556);
            this.Controls.Add(this.btnLoadData);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dtGVNhanVien);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmAdminMain_NhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ NHÂN VIÊN";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAdminMain_FormClosing);
            this.Load += new System.EventHandler(this.frmAdminMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGVNhanVien)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.ComboBox cbTimNV;
        private System.Windows.Forms.ComboBox cbPermission;
        private System.Windows.Forms.DataGridView dtGVNhanVien;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSoDT;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rdNu;
        private System.Windows.Forms.RadioButton rdNam;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chứcNăngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qLHDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qLHàngHóaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qLKháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qLPhòngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qLLoạiPhòngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qLNhàCungCấpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qLDịchVụToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qLPhiếuChiToolStripMenuItem;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.Button btnLoadData;
        private System.Windows.Forms.ImageList imageList3;
    }
}