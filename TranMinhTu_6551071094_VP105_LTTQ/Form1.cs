using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;    
using System.Data;
using System.Globalization;
using TranMinhTu_6551071094_VP105_LTTQ;
using TranMinhTu_6551071094_VP105_LTTQ.Models;
namespace TranMinhTu_6551071094_VP105_LTTQ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            LoadDanhSach();
            DatTrangThaiBanDau();
        }

        private void LoadDanhSach()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnStr))
                using (SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT MaThietBi, TenThietBi, DonGia FROM ThietBi", conn))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvDanhSachThietBi.DataSource = dt;
                }

                dgvDanhSachThietBi.Columns[0].HeaderText = "Mã thiết bị";
                dgvDanhSachThietBi.Columns[1].HeaderText = "Tên thiết bị";
                dgvDanhSachThietBi.Columns[2].HeaderText = "Đơn giá";
                dgvDanhSachThietBi.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể tải dữ liệu: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DatTrangThaiBanDau()
        {
            lblMaThietBi.Clear();
            lblTenThietBi.Clear();
            lblDonGia.Clear();
            lblMaThietBi.ReadOnly = false;

            btnThem.Enabled = true;
            btnThoat.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            dgvDanhSachThietBi.ClearSelection();
            lblMaThietBi.Focus();
        }
        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (char.IsControl(c)) return;
            if (char.IsControl(c) || char.IsDigit(c))
            {
                return;
            }

            if ((c == '.' || c == ',') && lblDonGia.Text.IndexOf('.') < 0 && lblDonGia.Text.IndexOf(',') < 0)
            {
                return;
            }

            e.Handled = true;
        }
        private bool LaSo(string s)
        {
            double kq;
            return double.TryParse(s.Replace(',', '.'), NumberStyles.Float,
                CultureInfo.InvariantCulture, out kq);
        }

        private bool KiemTraNhapDayDu()
        {
            if (lblMaThietBi.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mã thiết bị.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lblMaThietBi.Focus();
                return false;
            }

            if (lblTenThietBi.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tên thiết bị.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lblTenThietBi.Focus();
                return false;
            }

            if (lblDonGia.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập đơn giá.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lblDonGia.Focus();
                return false;
            }

            if (!LaSo(lblDonGia.Text.Trim()))
            {
                MessageBox.Show("Đơn giá phải là số nguyên hoặc số thực.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lblDonGia.Focus();
                lblDonGia.SelectAll();
                return false;
            }

            return true;
        }
        private void TextBox_TextChange(object sender, EventArgs e)
        {
            if (!btnThem.Enabled && !btnSua.Enabled && !btnXoa.Enabled && !lblMaThietBi.ReadOnly
                && ((TextBox)sender).Text.Length > 0)
            {
                btnThem.Enabled = true;
            }

        }







        //Hàm tự sinh ra//
        private void txtThongTinThietBi_Click(object sender, EventArgs e)
        {
            var kq = MessageBox.Show("Bạn có muốn thoát không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
                Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txbMaThietBi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbTenThietBi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbDonGia_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!KiemTraNhapDayDu())
            {
                return;
            }
            try
            {
                using (var db = new DuLieu_ThietBiContext())
                {
                    if (db.ThietBis.Any(s => s.MaThietBi == ma))
                    {
                        MessageBox.Show("Mã thiết bị \"" + MainMenuStrip + "\" đã tồn tại. Vui lòng nhập lại!",
                            "Trùng mã", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        lblMaThietBi.Focus();
                        lblMaThietBi.SelectAll();
                        return;
                    }

                    db.ThietBis.Add(new ThietBi
                    {
                        MaThietBi = ma,
                        TenThietBi = ten,
                        DonGia = dongia
                    });
                    db.SaveChanges();
                }
                LoadDanhSach();

                lblMaThietBi.Clear();
                lblTenThietBi.Clear();
                lblDonGia.Clear();
                btnThem.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm sinh viên: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có muốn thoát không?", "Xác nhận",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (kq == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!KiemTraNhap(out string ma, out string ten, out string diem))
                return;
            try
            {
                using (var db = new DuLieuContext())
                {
                    var sv = db.SinhViens.Find(ma); // lấy sinh viên đang chọn
                    if (sv != null)
                    {
                        sv.TenSinhVien = ten; // gán giá trị mới
                        sv.DiemTrungBinh = diem;
                        db.SaveChanges(); // EF tự sinh câu UPDATE
                    }
                }
                LoadDanhSach();
                DatTrangThaiBanDau();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật sinh viên: " + ex.Message, "Lỗi",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var kq = MessageBox.Show("Bạn có muốn xóa thiết bị này không?", "Xóa thiết bị",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq != DialogResult.Yes) return;

            try
            {
                string ma = lblMaThietBi.Text.Trim();
                using (var db = new DuLieu_ThietBiContext())
                {
                    var sv = db.ThietBis.Find(ma);
                    if (sv != null)
                    {
                        db.ThietBis.Remove(tb);
                        db.SaveChanges();
                    }
                }
                LoadDanhSach();
                DatTrangThaiBanDau();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa Thiết bị: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvDanhSachThietBi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDanhSachThietBi_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            DataGridViewRow row = dgvThietBi.Rows[e.RowIndex];
            txtMa.Text = Convert.ToString(row.Cells["MaSinhVien"].Value);
            txtTen.Text = Convert.ToString(row.Cells["TenSinhVien"].Value);
            txtDiem.Text = Convert.ToString(row.Cells["DiemTrungBinh"].Value);

            // Ma la khoa chinh nen khong cho sua khi dang chon mot dong
            txtMa.ReadOnly = true;

            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThem.Enabled = false;
        }

        private void txtMaThietBi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTenThietBi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDonGia_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
