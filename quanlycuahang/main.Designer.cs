namespace quanlycuahang
{
    partial class main
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
            this.mnt = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.login = new System.Windows.Forms.ToolStripMenuItem();
            this.exit = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýDanhSáchMụcĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.city = new System.Windows.Forms.ToolStripMenuItem();
            this.danhMụcKháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhMụcNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhMụcSảnPhẩmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhMụcHoáĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhMụcChiTiếtHoáĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhMụcNgườiDùngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnt.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnt
            // 
            this.mnt.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnt.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.quảnLýDanhSáchMụcĐơnToolStripMenuItem});
            this.mnt.Location = new System.Drawing.Point(0, 0);
            this.mnt.Name = "mnt";
            this.mnt.Size = new System.Drawing.Size(800, 28);
            this.mnt.TabIndex = 0;
            this.mnt.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.login,
            this.exit});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.ShortcutKeyDisplayString = "Alt+T";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // login
            // 
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(177, 26);
            this.login.Text = "Đăng nhập";
            // 
            // exit
            // 
            this.exit.Name = "exit";
            this.exit.ShortcutKeyDisplayString = "";
            this.exit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.exit.Size = new System.Drawing.Size(177, 26);
            this.exit.Text = "Thoát";
            this.exit.Click += new System.EventHandler(this.exitClick);
            // 
            // quảnLýDanhSáchMụcĐơnToolStripMenuItem
            // 
            this.quảnLýDanhSáchMụcĐơnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.city,
            this.danhMụcKháchHàngToolStripMenuItem,
            this.danhMụcNhânViênToolStripMenuItem,
            this.danhMụcSảnPhẩmToolStripMenuItem,
            this.danhMụcHoáĐơnToolStripMenuItem,
            this.danhMụcChiTiếtHoáĐơnToolStripMenuItem,
            this.danhMụcNgườiDùngToolStripMenuItem});
            this.quảnLýDanhSáchMụcĐơnToolStripMenuItem.Name = "quảnLýDanhSáchMụcĐơnToolStripMenuItem";
            this.quảnLýDanhSáchMụcĐơnToolStripMenuItem.Size = new System.Drawing.Size(205, 24);
            this.quảnLýDanhSáchMụcĐơnToolStripMenuItem.Text = "Quản lý danh sách mục đơn";
            // 
            // city
            // 
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(267, 26);
            this.city.Text = "Danh mục thành phố";
            this.city.Click += new System.EventHandler(this.city_Click);
            // 
            // danhMụcKháchHàngToolStripMenuItem
            // 
            this.danhMụcKháchHàngToolStripMenuItem.Name = "danhMụcKháchHàngToolStripMenuItem";
            this.danhMụcKháchHàngToolStripMenuItem.Size = new System.Drawing.Size(267, 26);
            this.danhMụcKháchHàngToolStripMenuItem.Text = "Danh mục khách hàng";
            this.danhMụcKháchHàngToolStripMenuItem.Click += new System.EventHandler(this.KhachHangClick);
            // 
            // danhMụcNhânViênToolStripMenuItem
            // 
            this.danhMụcNhânViênToolStripMenuItem.Name = "danhMụcNhânViênToolStripMenuItem";
            this.danhMụcNhânViênToolStripMenuItem.Size = new System.Drawing.Size(267, 26);
            this.danhMụcNhânViênToolStripMenuItem.Text = "Danh mục nhân viên";
            this.danhMụcNhânViênToolStripMenuItem.Click += new System.EventHandler(this.NhanVienClick);
            // 
            // danhMụcSảnPhẩmToolStripMenuItem
            // 
            this.danhMụcSảnPhẩmToolStripMenuItem.Name = "danhMụcSảnPhẩmToolStripMenuItem";
            this.danhMụcSảnPhẩmToolStripMenuItem.Size = new System.Drawing.Size(267, 26);
            this.danhMụcSảnPhẩmToolStripMenuItem.Text = "Danh mục sản phẩm";
            // 
            // danhMụcHoáĐơnToolStripMenuItem
            // 
            this.danhMụcHoáĐơnToolStripMenuItem.Name = "danhMụcHoáĐơnToolStripMenuItem";
            this.danhMụcHoáĐơnToolStripMenuItem.Size = new System.Drawing.Size(267, 26);
            this.danhMụcHoáĐơnToolStripMenuItem.Text = "Danh mục hoá đơn";
            // 
            // danhMụcChiTiếtHoáĐơnToolStripMenuItem
            // 
            this.danhMụcChiTiếtHoáĐơnToolStripMenuItem.Name = "danhMụcChiTiếtHoáĐơnToolStripMenuItem";
            this.danhMụcChiTiếtHoáĐơnToolStripMenuItem.Size = new System.Drawing.Size(267, 26);
            this.danhMụcChiTiếtHoáĐơnToolStripMenuItem.Text = "Danh mục chi tiết hoá đơn";
            // 
            // danhMụcNgườiDùngToolStripMenuItem
            // 
            this.danhMụcNgườiDùngToolStripMenuItem.Name = "danhMụcNgườiDùngToolStripMenuItem";
            this.danhMụcNgườiDùngToolStripMenuItem.Size = new System.Drawing.Size(267, 26);
            this.danhMụcNgườiDùngToolStripMenuItem.Text = "Danh mục người dùng";
            this.danhMụcNgườiDùngToolStripMenuItem.Click += new System.EventHandler(this.NguoiDungClick);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mnt);
            this.Name = "main";
            this.Text = "main";
            this.mnt.ResumeLayout(false);
            this.mnt.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnt;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem login;
        private System.Windows.Forms.ToolStripMenuItem exit;
        private System.Windows.Forms.ToolStripMenuItem quảnLýDanhSáchMụcĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem city;
        private System.Windows.Forms.ToolStripMenuItem danhMụcKháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhMụcNhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhMụcSảnPhẩmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhMụcHoáĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhMụcChiTiếtHoáĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhMụcNgườiDùngToolStripMenuItem;
    }
}