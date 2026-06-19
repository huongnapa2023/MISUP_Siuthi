namespace MISUP.WinForms
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel pnlSidebar, pnlTop, pnlContent;
        private System.Windows.Forms.Label lblLogo, lblTitle;
        private System.Windows.Forms.Button btnSanPham, btnTaiKhoan, btnLogout;

        protected override void Dispose(bool disposing) { if (disposing && (components != null)) { components.Dispose(); } base.Dispose(disposing); }

        private void InitializeComponent()
        {
            pnlSidebar = new Panel();
            btnTaiKhoan = new Button();
            btnSanPham = new Button();
            btnLogout = new Button();
            lblLogo = new Label();
            pnlTop = new Panel();
            lblTitle = new Label();
            pnlContent = new Panel();
            pnlSidebar.SuspendLayout();
            pnlTop.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.ForestGreen;
            pnlSidebar.Controls.Add(btnTaiKhoan);
            pnlSidebar.Controls.Add(btnSanPham);
            pnlSidebar.Controls.Add(btnLogout);
            pnlSidebar.Controls.Add(lblLogo);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(220, 600);
            pnlSidebar.TabIndex = 2;
            // 
            // btnTaiKhoan
            // 
            btnTaiKhoan.Dock = DockStyle.Top;
            btnTaiKhoan.FlatAppearance.BorderSize = 0;
            btnTaiKhoan.FlatStyle = FlatStyle.Flat;
            btnTaiKhoan.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnTaiKhoan.ForeColor = SystemColors.ActiveBorder;
            btnTaiKhoan.Location = new Point(0, 160);
            btnTaiKhoan.Name = "btnTaiKhoan";
            btnTaiKhoan.Size = new Size(220, 60);
            btnTaiKhoan.TabIndex = 0;
            btnTaiKhoan.Text = "  👥 Tài khoản";
            btnTaiKhoan.TextAlign = ContentAlignment.MiddleLeft;
            btnTaiKhoan.UseVisualStyleBackColor = true;
            // 
            // btnSanPham
            // 
            btnSanPham.Cursor = Cursors.Hand;
            btnSanPham.Dock = DockStyle.Top;
            btnSanPham.FlatAppearance.BorderSize = 0;
            btnSanPham.FlatStyle = FlatStyle.Flat;
            btnSanPham.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnSanPham.ForeColor = SystemColors.ActiveBorder;
            btnSanPham.Location = new Point(0, 100);
            btnSanPham.Name = "btnSanPham";
            btnSanPham.Size = new Size(220, 60);
            btnSanPham.TabIndex = 1;
            btnSanPham.Text = "  📦 Quản lý Sản phẩm";
            btnSanPham.TextAlign = ContentAlignment.MiddleLeft;
            btnSanPham.UseVisualStyleBackColor = true;
            btnSanPham.Click += btnSanPham_Click;
            // 
            // btnLogout
            // 
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.Dock = DockStyle.Bottom;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnLogout.Location = new Point(0, 540);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(220, 60);
            btnLogout.TabIndex = 2;
            btnLogout.Text = "  🔴 Đăng xuất";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // lblLogo
            // 
            lblLogo.Dock = DockStyle.Top;
            lblLogo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblLogo.ForeColor = Color.Gold;
            lblLogo.Location = new Point(0, 0);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(220, 100);
            lblLogo.TabIndex = 3;
            lblLogo.Text = "MISU\nMARKET";
            lblLogo.TextAlign = ContentAlignment.MiddleCenter;
            lblLogo.Click += lblLogo_Click;
            // 
            // pnlTop
            // 
            pnlTop.BackColor = Color.WhiteSmoke;
            pnlTop.Controls.Add(lblTitle);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(220, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(780, 60);
            pnlTop.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.DimGray;
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(780, 60);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "TRANG CHỦ";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlContent
            // 
            pnlContent.BackColor = Color.White;
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(220, 60);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(780, 540);
            pnlContent.TabIndex = 0;
            // 
            // MainForm
            // 
            ClientSize = new Size(1000, 600);
            Controls.Add(pnlContent);
            Controls.Add(pnlTop);
            Controls.Add(pnlSidebar);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hệ thống Quản lý MISUP";
            pnlSidebar.ResumeLayout(false);
            pnlTop.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}
