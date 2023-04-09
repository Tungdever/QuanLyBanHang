namespace quanlycuahang
{
    partial class frmQLDanhMucHoaDon
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.pnl = new System.Windows.Forms.Panel();
            this.dtpNgayLapHD = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayNhanHang = new System.Windows.Forms.DateTimePicker();
            this.lblNgayNhanHang = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.lblMaKH = new System.Windows.Forms.Label();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.lblNgayLapHD = new System.Windows.Forms.Label();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.lblMaHD = new System.Windows.Forms.Label();
            this.dgvNV = new System.Windows.Forms.DataGridView();
            this.ColHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNgayLapHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayNhanHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNV)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(840, 427);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(84, 53);
            this.btnExit.TabIndex = 46;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.Blue;
            this.btnRemove.Location = new System.Drawing.Point(689, 427);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(110, 53);
            this.btnRemove.TabIndex = 45;
            this.btnRemove.Text = "Xoá";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Blue;
            this.btnCancel.Location = new System.Drawing.Point(552, 427);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 53);
            this.btnCancel.TabIndex = 44;
            this.btnCancel.Text = "Huỷ";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Blue;
            this.btnSave.Location = new System.Drawing.Point(415, 427);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 53);
            this.btnSave.TabIndex = 43;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.Blue;
            this.btnEdit.Location = new System.Drawing.Point(290, 427);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(110, 53);
            this.btnEdit.TabIndex = 42;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Blue;
            this.btnAdd.Location = new System.Drawing.Point(168, 427);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(110, 53);
            this.btnAdd.TabIndex = 41;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnReload
            // 
            this.btnReload.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.ForeColor = System.Drawing.Color.Blue;
            this.btnReload.Location = new System.Drawing.Point(32, 427);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(124, 53);
            this.btnReload.TabIndex = 40;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // pnl
            // 
            this.pnl.Controls.Add(this.dtpNgayLapHD);
            this.pnl.Controls.Add(this.dtpNgayNhanHang);
            this.pnl.Controls.Add(this.lblNgayNhanHang);
            this.pnl.Controls.Add(this.txtMaNV);
            this.pnl.Controls.Add(this.txtMaKH);
            this.pnl.Controls.Add(this.lblMaKH);
            this.pnl.Controls.Add(this.lblMaNV);
            this.pnl.Controls.Add(this.lblNgayLapHD);
            this.pnl.Controls.Add(this.txtMaHD);
            this.pnl.Controls.Add(this.lblMaHD);
            this.pnl.Location = new System.Drawing.Point(23, 25);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(994, 195);
            this.pnl.TabIndex = 39;
            // 
            // dtpNgayLapHD
            // 
            this.dtpNgayLapHD.Location = new System.Drawing.Point(666, 23);
            this.dtpNgayLapHD.Name = "dtpNgayLapHD";
            this.dtpNgayLapHD.Size = new System.Drawing.Size(304, 22);
            this.dtpNgayLapHD.TabIndex = 26;
            // 
            // dtpNgayNhanHang
            // 
            this.dtpNgayNhanHang.Location = new System.Drawing.Point(666, 83);
            this.dtpNgayNhanHang.Name = "dtpNgayNhanHang";
            this.dtpNgayNhanHang.Size = new System.Drawing.Size(304, 22);
            this.dtpNgayNhanHang.TabIndex = 25;
            // 
            // lblNgayNhanHang
            // 
            this.lblNgayNhanHang.AutoSize = true;
            this.lblNgayNhanHang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayNhanHang.Location = new System.Drawing.Point(467, 82);
            this.lblNgayNhanHang.Name = "lblNgayNhanHang";
            this.lblNgayNhanHang.Size = new System.Drawing.Size(160, 23);
            this.lblNgayNhanHang.TabIndex = 22;
            this.lblNgayNhanHang.Text = "Ngày Nhận Hàng:";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(116, 149);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(287, 22);
            this.txtMaNV.TabIndex = 18;
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(116, 87);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(287, 22);
            this.txtMaKH.TabIndex = 17;
            // 
            // lblMaKH
            // 
            this.lblMaKH.AutoSize = true;
            this.lblMaKH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaKH.Location = new System.Drawing.Point(17, 87);
            this.lblMaKH.Name = "lblMaKH";
            this.lblMaKH.Size = new System.Drawing.Size(79, 23);
            this.lblMaKH.TabIndex = 16;
            this.lblMaKH.Text = "Mã KH:";
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaNV.Location = new System.Drawing.Point(17, 149);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(76, 23);
            this.lblMaNV.TabIndex = 14;
            this.lblMaNV.Text = "Mã NV:";
            // 
            // lblNgayLapHD
            // 
            this.lblNgayLapHD.AutoSize = true;
            this.lblNgayLapHD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayLapHD.Location = new System.Drawing.Point(467, 22);
            this.lblNgayLapHD.Name = "lblNgayLapHD";
            this.lblNgayLapHD.Size = new System.Drawing.Size(133, 23);
            this.lblNgayLapHD.TabIndex = 13;
            this.lblNgayLapHD.Text = "Ngày Lập HD:";
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(116, 22);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(139, 22);
            this.txtMaHD.TabIndex = 12;
            // 
            // lblMaHD
            // 
            this.lblMaHD.AutoSize = true;
            this.lblMaHD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaHD.Location = new System.Drawing.Point(17, 22);
            this.lblMaHD.Name = "lblMaHD";
            this.lblMaHD.Size = new System.Drawing.Size(79, 23);
            this.lblMaHD.TabIndex = 11;
            this.lblMaHD.Text = "Mã HĐ:";
            // 
            // dgvNV
            // 
            this.dgvNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColHD,
            this.ColKH,
            this.ColNV,
            this.ColNgayLapHD,
            this.colNgayNhanHang});
            this.dgvNV.Location = new System.Drawing.Point(23, 226);
            this.dgvNV.Name = "dgvNV";
            this.dgvNV.RowHeadersWidth = 51;
            this.dgvNV.RowTemplate.Height = 24;
            this.dgvNV.Size = new System.Drawing.Size(934, 180);
            this.dgvNV.TabIndex = 38;
            this.dgvNV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanVien_CellClick);
            // 
            // ColHD
            // 
            this.ColHD.DataPropertyName = "MaHD";
            this.ColHD.HeaderText = "Mã HĐ";
            this.ColHD.MinimumWidth = 6;
            this.ColHD.Name = "ColHD";
            this.ColHD.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColHD.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColHD.Width = 125;
            // 
            // ColKH
            // 
            this.ColKH.DataPropertyName = "MaKH";
            this.ColKH.HeaderText = "Mã KH";
            this.ColKH.MinimumWidth = 6;
            this.ColKH.Name = "ColKH";
            this.ColKH.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColKH.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColKH.Width = 125;
            // 
            // ColNV
            // 
            this.ColNV.DataPropertyName = "MaNV";
            this.ColNV.HeaderText = "Mã NV";
            this.ColNV.MinimumWidth = 6;
            this.ColNV.Name = "ColNV";
            this.ColNV.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColNV.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColNV.Width = 125;
            // 
            // ColNgayLapHD
            // 
            this.ColNgayLapHD.DataPropertyName = "NgayLapHD";
            this.ColNgayLapHD.HeaderText = "Ngày Lập HĐ";
            this.ColNgayLapHD.MinimumWidth = 6;
            this.ColNgayLapHD.Name = "ColNgayLapHD";
            this.ColNgayLapHD.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColNgayLapHD.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColNgayLapHD.Width = 125;
            // 
            // colNgayNhanHang
            // 
            this.colNgayNhanHang.DataPropertyName = "NgayNhanHang";
            this.colNgayNhanHang.HeaderText = "Ngày Nhận Hàng";
            this.colNgayNhanHang.MinimumWidth = 6;
            this.colNgayNhanHang.Name = "colNgayNhanHang";
            this.colNgayNhanHang.Width = 125;
            // 
            // frmQLDanhMucHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 552);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.pnl);
            this.Controls.Add(this.dgvNV);
            this.Name = "frmQLDanhMucHoaDon";
            this.Text = "frmQLDanhMucHoaDon";
            this.Load += new System.EventHandler(this.frmQLDanhMucNhanVien_Load);
            this.pnl.ResumeLayout(false);
            this.pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Panel pnl;
        private System.Windows.Forms.DateTimePicker dtpNgayNhanHang;
        private System.Windows.Forms.Label lblNgayNhanHang;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label lblMaKH;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.Label lblNgayLapHD;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Label lblMaHD;
        private System.Windows.Forms.DataGridView dgvNV;
        private System.Windows.Forms.DateTimePicker dtpNgayLapHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNgayLapHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayNhanHang;
    }
}