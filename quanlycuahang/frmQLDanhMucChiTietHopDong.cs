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
using System.Xml.Linq;

namespace quanlycuahang
{
    public partial class frmQLDanhMucChiTietHopDong : Form
    {
        bool Them;
        string err;
        BLChiTietHoaDon dbcthd = new BLChiTietHoaDon();
        public frmQLDanhMucChiTietHopDong()
        {
            InitializeComponent();
        }

        private void frmQLDanhMucChiTietHopDong_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        void LoadData()
        {
            try
            {
                // Đưa dữ liệu lên DataGridView
                dgvCTHD.DataSource = dbcthd.LayChiTietHoaDon();
                // Thay đổi độ rộng cột
                dgvCTHD.AutoResizeColumns();
                // Xóa trống các đối tượng trong Panel
                this.txtMaHD.ResetText();
                this.txtMaSP.ResetText();
                this.txtSoluong.ResetText();
                // Không cho thao tác trên các nút Lưu / Hủy
                this.btnSave.Enabled = false;
                this.btnCancel.Enabled = false;
                this.panel.Enabled = false;
                // Cho thao tác trên các nút Thêm / Sửa / Xóa /Thoát
                this.btnAdd.Enabled = true;
                this.btnEdit.Enabled = true;
                this.btnRemove.Enabled = true;

                //
                dgvCTHD_CellClick(null, null);
            }
            catch
            {
                MessageBox.Show("Không lấy được nội dung trong table THANHPHO. Lỗi rồi!!!");
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
            txtMaSP.Enabled = true;
            // Xóa trống các đối tượng trong Panel
            this.txtMaHD.ResetText();
            this.txtMaSP.ResetText();
            this.txtSoluong.ResetText();
            // Cho thao tác trên các nút Lưu / Hủy / Panel
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            panel.Enabled = true;
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
            if (!txtMaHD.Text.Trim().Equals("") && !txtMaSP.Text.Trim().Equals(""))
            {
                // Thêm dữ liệu
                if (Them)
                {
                    try
                    {
                        dbcthd.ThemChiTietHoaDon(txtMaHD.Text, txtMaSP.Text, float.Parse(txtSoluong.Text), ref err);
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
                        dbcthd.CapNhatChiTietHoaDon(txtMaHD.Text, txtMaSP.Text, float.Parse(txtSoluong.Text), ref err);
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
                MessageBox.Show("Thành phố chưa có. Lỗi rồi!");
                txtMaHD.Focus();
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Kích hoạt biến Sửa
            Them = false;
            // Cho phép thao tác trên Panel
            this.panel.Enabled = true;
            dgvCTHD_CellClick(null, null);
            // Cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnSave.Enabled = true;
            this.btnCancel.Enabled = true;
            this.panel.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            this.btnAdd.Enabled = false;
            this.btnEdit.Enabled = false;
            this.btnRemove.Enabled = false;

            // Đưa con trỏ đến TextField txtMaKH
            this.txtMaHD.Enabled = false;
            this.txtMaSP.Enabled = false;
            this.txtSoluong.Focus();
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
                    dbcthd.XoaChiTietHoaDon(ref err, txtMaHD.Text, txtMaSP.Text);
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
            this.txtMaSP.ResetText();
            this.txtSoluong.ResetText();
            // Cho thao tác trên các nút Thêm / Sửa / Xóa / Thoát
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            btnRemove.Enabled = true;
            btnExit.Enabled = true;
            // Không cho thao tác trên các nút Lưu / Hủy / Panel
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            panel.Enabled = false;
        }

        private void dgvCTHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            try
            {
                // Thứ tự dòng hiện hành
                int r = dgvCTHD.CurrentCell.RowIndex;
                // Chuyển thông tin lên panel
                this.txtMaHD.Text =
                dgvCTHD.Rows[r].Cells[0].Value.ToString();
                this.txtMaSP.Text =
                dgvCTHD.Rows[r].Cells[1].Value.ToString();
                this.txtSoluong.Text =
                dgvCTHD.Rows[r].Cells[2].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Dòng này không có dữ liệu");
            }
        }
    }
}
