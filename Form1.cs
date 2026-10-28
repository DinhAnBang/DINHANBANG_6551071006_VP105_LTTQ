using Microsoft.EntityFrameworkCore;
using QLThietBi.Models;
using System.Xml.Serialization;

namespace QLThietBi
{
    public partial class Form1 : Form
    {
        private enum CheDoForm
        {
            Xem,
            Thêm,
            Sửa,
            Xóa

        }

        private CheDoForm CheDoHienTai = CheDoForm.Xem;
        private string? MaThietBiDangChon = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar))
            {
                return;
            }

            if ((e.KeyChar == '.' || e.KeyChar == ',') &&
                !txtDonGia.Text.Contains('.') && !txtDonGia.Text.Contains(','))
            {
                return;
            }

            e.Handled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadThietBiAsync();
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThoat.Enabled = true;
            btnThem.Enabled = true;
        }

        private async Task LoadThietBiAsync()
        {

            try
            {
                using var db = new DuLieu_ThietBiContext();
                var danhSach = await db.ThietBis
                    .AsNoTracking()
                    .OrderBy(thietbi => thietbi.MaThietBi)
                    .ToListAsync();
                dgvDanhSachThietBi.DataSource = danhSach;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Khong Load Duoc Thong Tin Thiet Bi!\n\n" + ex.Message, "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            var ketQua = MessageBox.Show(
                "Bạn có muốn thoát không?",
                "Xác nhận thoát",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (ketQua == DialogResult.Yes)
            {
                Close();
            }
        }

        private async void btnThem_Click(object sender, EventArgs e)
        {
            if (!DuLieuHopLe())
            {
                return;
            }

            try
            {
                using var db = new DuLieu_ThietBiContext();
                var thietBiMoi = new ThietBi();
                ganDuLieuForm(thietBiMoi);
                db.ThietBis.Add(thietBiMoi);
                await db.SaveChangesAsync();
                await LoadThietBiAsync();
                MessageBox.Show("Them Thanh Cong");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi: " + ex.Message);
            }
        }

        private bool DuLieuHopLe()
        {
            if (string.IsNullOrWhiteSpace(txtTenThietBi.Text))
            {
                MessageBox.Show("Ten thiet bi khong duoc trong");
                txtTenThietBi.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtDonGia.Text))
            {
                MessageBox.Show("Don gia khong duoc bo trong");
                txtDonGia.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtMaThietBi.Text))
            {
                MessageBox.Show("Ma Thiet Bi khong duoc bo trong");
                txtMaThietBi.Focus();
                return false;
            }

            return true;
        }

        private void ganDuLieuForm(ThietBi thietbi)
        {
            thietbi.MaThietBi = txtMaThietBi.Text.Trim();
            thietbi.TenThietBi = txtTenThietBi.Text.Trim();
            thietbi.DonGia = txtDonGia.Text.Trim();
        }

        private void dgvDanhSachThietBi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dgvDanhSachThietBi.Rows[e.RowIndex].DataBoundItem is not ThietBi thietbi) return;
            MaThietBiDangChon = thietbi.MaThietBi;
            txtTenThietBi.Text = thietbi.TenThietBi;
            txtDonGia.Text = thietbi.DonGia;
            txtMaThietBi.Text = thietbi.MaThietBi;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private async void btnSua_Click(object sender, EventArgs e)
        {
            if (!DuLieuHopLe()) return;
            try
            {
                using var db = new DuLieu_ThietBiContext();
                var hang = await db.ThietBis
                    .FirstOrDefaultAsync(thietbi => thietbi.MaThietBi == txtMaThietBi.Text);

                if(hang == null)
                {
                    MessageBox.Show("Khong tim thay thiet bi ");
                }
                ganDuLieuForm(hang);
                await db.SaveChangesAsync();
                await LoadThietBiAsync();
                MessageBox.Show("sua Thanh Cong");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi: " + ex.Message);
            }
        }
    }
}
