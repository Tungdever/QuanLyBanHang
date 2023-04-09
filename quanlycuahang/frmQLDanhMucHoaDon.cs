using quanlycuahang.BS_layer;
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
    public partial class frmQLDanhMucHoaDon : Form
    {
        bool Them;
        string err;
        BLHoaDon dbHD = new BLHoaDon();
        public frmQLDanhMucHoaDon()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            try
            {
                // Đưa dữ liệu lên DataGridView 
                dgvNV.DataSource = dbHD.LayHoaDon();
                // Thay đổi độ rộng cột
                dgvNV.AutoResizeColumns();
                // Xóa trống các đối tượng trong Panel
                this.txtMaHD.ResetText();
                this.txtMaKH.ResetText();
                this.txtMaNV.ResetText();
                this.dtpNgayLapHD.ResetText();
                this.dtpNgayNhanHang.ResetText();
                
                // Không cho thao tác trên các nút Lưu / Hủy
                this.btnSave.Enabled = false;
                this.btnCancel.Enabled = false;
                this.pnl.Enabled = false;
                // Cho thao tác trên các nút Thêm / Sửa / Xóa /Thoát
                this.btnAdd.Enabled = true;
                this.btnEdit.Enabled = true;
                this.btnRemove.Enabled = true;

                //
                dgvNhanVien_CellClick(null, null);
            }
            catch
            {
                MessageBox.Show("Không lấy được nội dung trong table HOADON. Lỗi rồi!!!");
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
            txtMaHD.Enabled = true;
            // Xóa trống các đối tượng trong Panel
            this.txtMaHD.ResetText();
            this.txtMaKH.ResetText();
            this.txtMaNV.ResetText();
            this.dtpNgayLapHD.ResetText();
            this.dtpNgayNhanHang.ResetText();
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
            txtMaHD.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!txtMaHD.Text.Trim().Equals(""))
            {
                // Thêm dữ liệu
                if (Them)
                {
                    try
                    {
                        dbHD.ThemHoaDon(txtMaHD.Text, txtMaKH.Text, txtMaNV.Text, dtpNgayLapHD.Value, dtpNgayNhanHang.Value, ref err);
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
                        dbHD.CapNhatHoaDon(txtMaHD.Text, txtMaKH.Text, txtMaNV.Text, dtpNgayLapHD.Value, dtpNgayNhanHang.Value, ref err);
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
                MessageBox.Show("Hoá đơn chưa có. Lỗi rồi!");
                txtMaHD.Focus();
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Kích hoạt biến Sửa
            Them = false;
            // Cho phép thao tác trên Panel
            this.pnl.Enabled = true;
            dgvNhanVien_CellClick(null, null);
            // Cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnSave.Enabled = true;
            this.btnCancel.Enabled = true;
            this.pnl.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            this.btnAdd.Enabled = false;
            this.btnEdit.Enabled = false;
            this.btnRemove.Enabled = false;

            // Đưa con trỏ đến TextField txtMaKH
            this.txtMaHD.Enabled = false;
            this.txtMaKH.Focus();
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
                    dbHD.XoaHoaDon(ref err, txtMaHD.Text);
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
            this.txtMaHD.ResetText();
            this.txtMaKH.ResetText();
            this.txtMaNV.ResetText();
            this.dtpNgayLapHD.ResetText();
            this.dtpNgayNhanHang.ResetText();
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

        private void frmQLDanhMucNhanVien_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            try
            {
                int r = dgvNV.CurrentCell.RowIndex;
                this.txtMaHD.Text =
                dgvNV.Rows[r].Cells[0].Value.ToString();
                this.txtMaKH.Text =
                dgvNV.Rows[r].Cells[1].Value.ToString();
                this.txtMaNV.Text =
                dgvNV.Rows[r].Cells[2].Value.ToString();
                if (DateTime.TryParse(dgvNV.Rows[r].Cells[3].Value?.ToString(), out DateTime NgayLapHD))
                {
                    this.dtpNgayLapHD.Value = NgayLapHD;
                }
                if (DateTime.TryParse(dgvNV.Rows[r].Cells[4].Value?.ToString(), out DateTime NgayNhanHang))
                {
                    this.dtpNgayNhanHang.Value = NgayNhanHang;
                }
            }
            catch
            {
                MessageBox.Show("Dòng này không có dữ liệu");
            }
        }

    }
}
