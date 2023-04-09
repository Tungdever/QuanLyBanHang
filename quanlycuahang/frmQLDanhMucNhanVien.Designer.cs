namespace quanlycuahang
{
    partial class frmQLDanhMucNhanVien
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
            this.dtpNgayNV = new System.Windows.Forms.DateTimePicker();
            this.cboxNu = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtHoLot = new System.Windows.Forms.TextBox();
            this.lblHoLot = new System.Windows.Forms.Label();
            this.lblTen = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.dgvNV = new System.Windows.Forms.DataGridView();
            this.ColNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColHo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNu = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColNgayNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.btnExit.TabIndex = 37;
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
            this.btnRemove.TabIndex = 36;
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
            this.btnCancel.TabIndex = 35;
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
            this.btnSave.TabIndex = 34;
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
            this.btnEdit.TabIndex = 33;
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
            this.btnAdd.TabIndex = 32;
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
            this.btnReload.TabIndex = 31;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // pnl
            // 
            this.pnl.Controls.Add(this.dtpNgayNV);
            this.pnl.Controls.Add(this.cboxNu);
            this.pnl.Controls.Add(this.label2);
            this.pnl.Controls.Add(this.txtDiaChi);
            this.pnl.Controls.Add(this.lblDiaChi);
            this.pnl.Controls.Add(this.txtPhone);
            this.pnl.Controls.Add(this.txtTen);
            this.pnl.Controls.Add(this.txtHoLot);
            this.pnl.Controls.Add(this.lblHoLot);
            this.pnl.Controls.Add(this.lblTen);
            this.pnl.Controls.Add(this.lblPhone);
            this.pnl.Controls.Add(this.txtID);
            this.pnl.Controls.Add(this.lblID);
            this.pnl.Location = new System.Drawing.Point(23, 25);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(901, 195);
            this.pnl.TabIndex = 30;
            // 
            // dtpNgayNV
            // 
            this.dtpNgayNV.Location = new System.Drawing.Point(591, 82);
            this.dtpNgayNV.Name = "dtpNgayNV";
            this.dtpNgayNV.Size = new System.Drawing.Size(304, 22);
            this.dtpNgayNV.TabIndex = 25;
            // 
            // cboxNu
            // 
            this.cboxNu.AutoSize = true;
            this.cboxNu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.cboxNu.Location = new System.Drawing.Point(379, 18);
            this.cboxNu.Name = "cboxNu";
            this.cboxNu.Size = new System.Drawing.Size(58, 27);
            this.cboxNu.TabIndex = 24;
            this.cboxNu.Text = "Nữ";
            this.cboxNu.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(476, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 23);
            this.label2.TabIndex = 22;
            this.label2.Text = "Ngày NV:";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(591, 148);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(307, 24);
            this.txtDiaChi.TabIndex = 21;
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaChi.Location = new System.Drawing.Point(476, 146);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(73, 23);
            this.lblDiaChi.TabIndex = 20;
            this.lblDiaChi.Text = "Địa Chỉ";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(591, 24);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(304, 22);
            this.txtPhone.TabIndex = 19;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(116, 149);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(287, 22);
            this.txtTen.TabIndex = 18;
            // 
            // txtHoLot
            // 
            this.txtHoLot.Location = new System.Drawing.Point(116, 87);
            this.txtHoLot.Name = "txtHoLot";
            this.txtHoLot.Size = new System.Drawing.Size(287, 22);
            this.txtHoLot.TabIndex = 17;
            // 
            // lblHoLot
            // 
            this.lblHoLot.AutoSize = true;
            this.lblHoLot.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoLot.Location = new System.Drawing.Point(17, 87);
            this.lblHoLot.Name = "lblHoLot";
            this.lblHoLot.Size = new System.Drawing.Size(77, 23);
            this.lblHoLot.TabIndex = 16;
            this.lblHoLot.Text = "Họ Lót:";
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTen.Location = new System.Drawing.Point(17, 149);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(49, 23);
            this.lblTen.TabIndex = 14;
            this.lblTen.Text = "Tên:";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(476, 22);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(109, 23);
            this.lblPhone.TabIndex = 13;
            this.lblPhone.Text = "Điện Thoại:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(116, 22);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(139, 22);
            this.txtID.TabIndex = 12;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(17, 22);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(76, 23);
            this.lblID.TabIndex = 11;
            this.lblID.Text = "Mã NV:";
            // 
            // dgvNV
            // 
            this.dgvNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColNV,
            this.ColHo,
            this.ColTen,
            this.ColNu,
            this.ColNgayNV,
            this.colDiaChi,
            this.colDienThoai});
            this.dgvNV.Location = new System.Drawing.Point(23, 226);
            this.dgvNV.Name = "dgvNV";
            this.dgvNV.RowHeadersWidth = 51;
            this.dgvNV.RowTemplate.Height = 24;
            this.dgvNV.Size = new System.Drawing.Size(943, 180);
            this.dgvNV.TabIndex = 29;
            this.dgvNV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanVien_CellClick);
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
            // ColHo
            // 
            this.ColHo.DataPropertyName = "Ho";
            this.ColHo.HeaderText = "Họ";
            this.ColHo.MinimumWidth = 6;
            this.ColHo.Name = "ColHo";
            this.ColHo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColHo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColHo.Width = 125;
            // 
            // ColTen
            // 
            this.ColTen.DataPropertyName = "Ten";
            this.ColTen.HeaderText = "Tên";
            this.ColTen.MinimumWidth = 6;
            this.ColTen.Name = "ColTen";
            this.ColTen.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColTen.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColTen.Width = 125;
            // 
            // ColNu
            // 
            this.ColNu.DataPropertyName = "Nu";
            this.ColNu.FalseValue = "false";
            this.ColNu.HeaderText = "Nữ";
            this.ColNu.MinimumWidth = 6;
            this.ColNu.Name = "ColNu";
            this.ColNu.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColNu.TrueValue = "true";
            this.ColNu.Width = 125;
            // 
            // ColNgayNV
            // 
            this.ColNgayNV.DataPropertyName = "NgayNV";
            this.ColNgayNV.HeaderText = "Ngày NV";
            this.ColNgayNV.MinimumWidth = 6;
            this.ColNgayNV.Name = "ColNgayNV";
            this.ColNgayNV.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColNgayNV.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColNgayNV.Width = 125;
            // 
            // colDiaChi
            // 
            this.colDiaChi.DataPropertyName = "DiaChi";
            this.colDiaChi.HeaderText = "Địa Chỉ";
            this.colDiaChi.MinimumWidth = 6;
            this.colDiaChi.Name = "colDiaChi";
            this.colDiaChi.Width = 125;
            // 
            // colDienThoai
            // 
            this.colDienThoai.DataPropertyName = "DienThoai";
            this.colDienThoai.HeaderText = "Điện Thoại";
            this.colDienThoai.MinimumWidth = 6;
            this.colDienThoai.Name = "colDienThoai";
            this.colDienThoai.Width = 125;
            // 
            // frmQLDanhMucNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 518);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.pnl);
            this.Controls.Add(this.dgvNV);
            this.Name = "frmQLDanhMucNhanVien";
            this.Text = "frmQLNhanVien";
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
        private System.Windows.Forms.DateTimePicker dtpNgayNV;
        private System.Windows.Forms.CheckBox cboxNu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtHoLot;
        private System.Windows.Forms.Label lblHoLot;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.DataGridView dgvNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColHo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTen;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColNu;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNgayNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDienThoai;
    }
}