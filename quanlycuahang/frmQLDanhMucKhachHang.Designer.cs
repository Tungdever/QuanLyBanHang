namespace quanlycuahang
{
    partial class frmQLDanhMucKhachHang
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
            this.dgvKH = new System.Windows.Forms.DataGridView();
            this.pnl = new System.Windows.Forms.Panel();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtDChi = new System.Windows.Forms.TextBox();
            this.txtCty = new System.Windows.Forms.TextBox();
            this.lblTenCty = new System.Windows.Forms.Label();
            this.lblTPho = new System.Windows.Forms.Label();
            this.lblDChi = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtCity = new System.Windows.Forms.ComboBox();
            this.ColKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKH)).BeginInit();
            this.pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvKH
            // 
            this.dgvKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColKH,
            this.ColCty,
            this.ColAddress,
            this.ColCity,
            this.ColSDT});
            this.dgvKH.Location = new System.Drawing.Point(12, 203);
            this.dgvKH.Name = "dgvKH";
            this.dgvKH.RowHeadersWidth = 51;
            this.dgvKH.RowTemplate.Height = 24;
            this.dgvKH.Size = new System.Drawing.Size(901, 180);
            this.dgvKH.TabIndex = 11;
            this.dgvKH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKH_CellClick);
            // 
            // pnl
            // 
            this.pnl.Controls.Add(this.txtCity);
            this.pnl.Controls.Add(this.txtPhone);
            this.pnl.Controls.Add(this.txtDChi);
            this.pnl.Controls.Add(this.txtCty);
            this.pnl.Controls.Add(this.lblTenCty);
            this.pnl.Controls.Add(this.lblTPho);
            this.pnl.Controls.Add(this.lblDChi);
            this.pnl.Controls.Add(this.lblPhone);
            this.pnl.Controls.Add(this.txtID);
            this.pnl.Controls.Add(this.lblID);
            this.pnl.Location = new System.Drawing.Point(3, 2);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(901, 195);
            this.pnl.TabIndex = 12;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(597, 89);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(304, 22);
            this.txtPhone.TabIndex = 19;
            // 
            // txtDChi
            // 
            this.txtDChi.Location = new System.Drawing.Point(116, 149);
            this.txtDChi.Name = "txtDChi";
            this.txtDChi.Size = new System.Drawing.Size(785, 22);
            this.txtDChi.TabIndex = 18;
            // 
            // txtCty
            // 
            this.txtCty.Location = new System.Drawing.Point(116, 87);
            this.txtCty.Name = "txtCty";
            this.txtCty.Size = new System.Drawing.Size(347, 22);
            this.txtCty.TabIndex = 17;
            // 
            // lblTenCty
            // 
            this.lblTenCty.AutoSize = true;
            this.lblTenCty.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenCty.Location = new System.Drawing.Point(17, 87);
            this.lblTenCty.Name = "lblTenCty";
            this.lblTenCty.Size = new System.Drawing.Size(85, 23);
            this.lblTenCty.TabIndex = 16;
            this.lblTenCty.Text = "Tên Cty:";
            // 
            // lblTPho
            // 
            this.lblTPho.AutoSize = true;
            this.lblTPho.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTPho.Location = new System.Drawing.Point(482, 22);
            this.lblTPho.Name = "lblTPho";
            this.lblTPho.Size = new System.Drawing.Size(107, 23);
            this.lblTPho.TabIndex = 15;
            this.lblTPho.Text = "Thành Phố:";
            // 
            // lblDChi
            // 
            this.lblDChi.AutoSize = true;
            this.lblDChi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDChi.Location = new System.Drawing.Point(17, 149);
            this.lblDChi.Name = "lblDChi";
            this.lblDChi.Size = new System.Drawing.Size(80, 23);
            this.lblDChi.TabIndex = 14;
            this.lblDChi.Text = "Địa Chỉ:";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(482, 87);
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
            this.lblID.Size = new System.Drawing.Size(79, 23);
            this.lblID.TabIndex = 11;
            this.lblID.Text = "Mã KH:";
            // 
            // btnReload
            // 
            this.btnReload.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.ForeColor = System.Drawing.Color.Blue;
            this.btnReload.Location = new System.Drawing.Point(12, 404);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(124, 53);
            this.btnReload.TabIndex = 13;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Blue;
            this.btnAdd.Location = new System.Drawing.Point(148, 404);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(110, 53);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.Blue;
            this.btnEdit.Location = new System.Drawing.Point(270, 404);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(110, 53);
            this.btnEdit.TabIndex = 15;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Blue;
            this.btnSave.Location = new System.Drawing.Point(395, 404);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 53);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Blue;
            this.btnCancel.Location = new System.Drawing.Point(532, 404);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 53);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Huỷ";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.Blue;
            this.btnRemove.Location = new System.Drawing.Point(669, 404);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(110, 53);
            this.btnRemove.TabIndex = 18;
            this.btnRemove.Text = "Xoá";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(820, 404);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(84, 53);
            this.btnExit.TabIndex = 19;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtCity
            // 
            this.txtCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCity.FormattingEnabled = true;
            this.txtCity.Location = new System.Drawing.Point(595, 20);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(157, 28);
            this.txtCity.TabIndex = 22;
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
            // ColCty
            // 
            this.ColCty.DataPropertyName = "TenCty";
            this.ColCty.HeaderText = "Tên Cty";
            this.ColCty.MinimumWidth = 6;
            this.ColCty.Name = "ColCty";
            this.ColCty.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColCty.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColCty.Width = 125;
            // 
            // ColAddress
            // 
            this.ColAddress.DataPropertyName = "DiaChi";
            this.ColAddress.HeaderText = "Địa Chỉ";
            this.ColAddress.MinimumWidth = 6;
            this.ColAddress.Name = "ColAddress";
            this.ColAddress.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColAddress.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColAddress.Width = 125;
            // 
            // ColCity
            // 
            this.ColCity.DataPropertyName = "ThanhPho";
            this.ColCity.HeaderText = "Thành Phố";
            this.ColCity.MinimumWidth = 6;
            this.ColCity.Name = "ColCity";
            this.ColCity.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColCity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColCity.Width = 125;
            // 
            // ColSDT
            // 
            this.ColSDT.DataPropertyName = "DienThoai";
            this.ColSDT.HeaderText = "Điện Thoại";
            this.ColSDT.MinimumWidth = 6;
            this.ColSDT.Name = "ColSDT";
            this.ColSDT.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColSDT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColSDT.Width = 125;
            // 
            // frmQLDanhMucKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 485);
            this.Controls.Add(this.dgvKH);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.pnl);
            this.Name = "frmQLDanhMucKhachHang";
            this.Text = "frmQLDanhMucKhachHang";
            this.Load += new System.EventHandler(this.frmQLDanhMucKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKH)).EndInit();
            this.pnl.ResumeLayout(false);
            this.pnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvKH;
        private System.Windows.Forms.Panel pnl;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtDChi;
        private System.Windows.Forms.TextBox txtCty;
        private System.Windows.Forms.Label lblTenCty;
        private System.Windows.Forms.Label lblTPho;
        private System.Windows.Forms.Label lblDChi;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ComboBox txtCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCty;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSDT;
    }
}