﻿using quanlycuahang.BS_layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlycuahang
{
    public partial class frmQLDanhMucSanPham : Form
    {
        bool Them;
        string err;
        BLSanPham dbKH = new BLSanPham();
        public frmQLDanhMucSanPham()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            try
            {
                // Đưa dữ liệu lên DataGridView
                dgvKH.DataSource = dbKH.LaySanPham();
                // Thay đổi độ rộng cột
                dgvKH.AutoResizeColumns();
                // Xóa trống các đối tượng trong Panel
                this.txtID.ResetText();
                this.txtTenSP.ResetText();
                this.txtDonGia.ResetText();
                this.txtDVT.ResetText();
                // Không cho thao tác trên các nút Lưu / Hủy
                this.btnSave.Enabled = false;
                this.btnCancel.Enabled = false;
                this.pnl.Enabled = false;
                // Cho thao tác trên các nút Thêm / Sửa / Xóa /Thoát
                this.btnAdd.Enabled = true;
                this.btnEdit.Enabled = true;
                this.btnRemove.Enabled = true;

                //
                dgvSP_CellClick(null, null);
            }
            catch
            {
                MessageBox.Show("Không lấy được nội dung trong table SANPHAM. Lỗi rồi!!!");
            }
        }
        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Khai báo biến traloi
            DialogResult traloi;
            // Hiện hộp thoại hỏi đáp
            traloi = MessageBox.Show("Chắc không?", "Trả lời",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            // Kiểm tra có nhắp chọn nút Ok không?
            if (traloi == DialogResult.OK) this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Them = true;
            txtID.Enabled = true;
            // Xóa trống các đối tượng trong Panel
            this.txtID.ResetText();
            this.txtTenSP.ResetText();
            this.txtDonGia.ResetText();
            this.txtDVT.ResetText();
            // Cho thao tác trên các nút Lưu / Hủy / Panel
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            pnl.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnRemove.Enabled = false;
            btnExit.Enabled = false;
            // Đưa con trỏ đến TextField txtMaKH
            txtID.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!txtID.Text.Trim().Equals(""))
            {
                // Thêm dữ liệu
                if (Them)
                {
                    try
                    {
                        dbKH.ThemSanPham(txtID.Text, txtTenSP.Text, txtDVT.Text, float.Parse(txtDonGia.Text), ref err);
                        // Load lại dữ liệu trên DataGridView
                        LoadData();
                        // Thông báo
                        MessageBox.Show("Đã thêm xong!");
                    }
                    catch
                    {
                        MessageBox.Show("Không thêm được. Lỗi rồi!");
                    }
                }
                else // sua doi
                {
                    try
                    {
                        dbKH.CapNhatSanPham(txtID.Text, txtTenSP.Text, txtDVT.Text, float.Parse(txtDonGia.Text), ref err);
                        LoadData();
                        // Thông báo
                        MessageBox.Show("Đã sửa xong!");
                    }
                    catch
                    {
                        MessageBox.Show("Không sửa được. Lỗi rồi!");
                    }
                }

            }
            else
            {
                MessageBox.Show("Sản phẩm chưa có. Lỗi rồi!");
                txtID.Focus();
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Kích hoạt biến Sửa
            Them = false;
            // Cho phép thao tác trên Panel
            this.pnl.Enabled = true;
            dgvSP_CellClick(null, null);
            // Cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnSave.Enabled = true;
            this.btnCancel.Enabled = true;
            this.pnl.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            this.btnAdd.Enabled = false;
            this.btnEdit.Enabled = false;
            this.btnRemove.Enabled = false;

            // Đưa con trỏ đến TextField txtMaKH
            this.txtID.Enabled = false;
            this.txtTenSP.Focus();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            // Hiện hộp thoại hỏi đáp
            traloi = MessageBox.Show("Chắc xóa không?", "Trả lời",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            // Kiểm tra có nhắp chọn nút Ok không?
            if (traloi == DialogResult.OK)
            {
                try
                {
                    dbKH.XoaSanPham(ref err, txtID.Text);
                    LoadData();
                    // Thông báo
                    MessageBox.Show("Đã xóa xong!");
                }
                catch
                {
                    MessageBox.Show("Không xóa được. Lỗi rồi!!!");
                }

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Xóa trống các đối tượng trong Panel
            this.txtID.ResetText();
            this.txtTenSP.ResetText();
            this.txtDonGia.ResetText();
            this.txtDVT.ResetText();
            // Cho thao tác trên các nút Thêm / Sửa / Xóa / Thoát
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            btnRemove.Enabled = true;
            btnExit.Enabled = true;
            // Không cho thao tác trên các nút Lưu / Hủy / Panel
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            pnl.Enabled = false;
        }

        private void frmQLDanhMucThanhPho_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            try
            {
                // Thứ tự dòng hiện hành
                int r = dgvKH.CurrentCell.RowIndex;
                // Chuyển thông tin lên panel
                this.txtID.Text =
                dgvKH.Rows[r].Cells[0].Value.ToString();
                this.txtTenSP.Text =
                dgvKH.Rows[r].Cells[1].Value.ToString();
                this.txtDVT.Text =
                dgvKH.Rows[r].Cells[2].Value.ToString();
                this.txtDonGia.Text =
                dgvKH.Rows[r].Cells[3].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Dòng này không có dữ liệu");
            }
        }

        private void frmQLDanhMucSanPham_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
