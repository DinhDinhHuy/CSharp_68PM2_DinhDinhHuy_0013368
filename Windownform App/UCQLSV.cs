using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Windownform_App
{
    public partial class UCQLSV : UserControl
    {
        int pageSize = 1;
        int currentPage = 1;
        int totalPage = 1;

        List<sinh_vien> danhSachSinhVien = new List<sinh_vien>();

        public UCQLSV()
        {
            InitializeComponent();

            DataQLSV.AutoGenerateColumns = false;

            maSV.DataPropertyName = "ma_sv";
            hoten.DataPropertyName = "ho_ten";
            gioitinh.DataPropertyName = "gioitinh";
            ngaysinh.DataPropertyName = "ngay_sinh";
            lop.DataPropertyName = "ma_lop";

            DataQLSV.CellClick += DataQLSV_CellClick;

            btnSua.Click += btnSua_Click;
            btnXoa.Click += btnXoa_Click;
            btnLamMoi.Click += btnLamMoi_Click;
            btn_timkiem.Click += btn_timkiem_Click;

            btnFirst.Click += btnFirst_Click;
            btnPrevious.Click += btnPrevious_Click;
            btnNext.Click += btnNext_Click;
            btnLast.Click += btnLast_Click;
        }

        private void UCQLSV_Load(object sender, EventArgs e)
        {
            LoadLopHoc();
            loadData();
        }

        private void LoadLopHoc()
        {
            DataClasses1DataContext db = new DataClasses1DataContext();

            cbo_lop.DataSource = db.lop_hocs.ToList();
            cbo_lop.DisplayMember = "ten_lop";
            cbo_lop.ValueMember = "ma_lop";
            cbo_lop.SelectedIndex = -1;
        }

        private void loadData()
        {
            DataClasses1DataContext db = new DataClasses1DataContext();

            danhSachSinhVien = db.sinh_viens.ToList();

            currentPage = 1;
            HienThiTheoTrang();
        }

        private void HienThiTheoTrang()
        {
            totalPage = (int)Math.Ceiling((double)danhSachSinhVien.Count / pageSize);

            if (totalPage == 0) totalPage = 1;
            if (currentPage < 1) currentPage = 1;
            if (currentPage > totalPage) currentPage = totalPage;

            List<sinh_vien> data = danhSachSinhVien
                .Skip((currentPage - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            DataQLSV.DataSource = null;
            DataQLSV.DataSource = data;

            lblTrang.Text = "Trang " + currentPage + "/" + totalPage;
            lblTongBanGhi.Text = danhSachSinhVien.Count + " bản ghi";
        }

        private void DataQLSV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = DataQLSV.Rows[e.RowIndex];

            txt_mssv.Text = row.Cells["maSV"].Value?.ToString();
            txt_hoten.Text = row.Cells["hoten"].Value?.ToString();
            txt_gioitinh.Text = row.Cells["gioitinh"].Value?.ToString();

            if (row.Cells["ngaysinh"].Value != null)
            {
                txt_date.Value = Convert.ToDateTime(row.Cells["ngaysinh"].Value);
            }

            if (row.Cells["lop"].Value != null)
            {
                cbo_lop.SelectedValue = row.Cells["lop"].Value.ToString();
            }

            txt_mssv.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string MaSinhVien = txt_mssv.Text.Trim();
            string HoVaTen = txt_hoten.Text.Trim();
            string GioiTinh = txt_gioitinh.Text.Trim();
            DateTime NgaySinh = txt_date.Value;

            if (MaSinhVien == "" || HoVaTen == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ mã sinh viên và họ tên!");
                return;
            }

            if (cbo_lop.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn lớp học!");
                return;
            }

            string Lop = cbo_lop.SelectedValue.ToString();

            DataClasses1DataContext db = new DataClasses1DataContext();

            sinh_vien check = db.sinh_viens.FirstOrDefault(x => x.ma_sv == MaSinhVien);

            if (check != null)
            {
                MessageBox.Show("Mã sinh viên đã tồn tại!");
                return;
            }

            sinh_vien sv = new sinh_vien();

            sv.ma_sv = MaSinhVien;
            sv.ho_ten = HoVaTen;
            sv.gioitinh = GioiTinh;
            sv.ngay_sinh = NgaySinh;
            sv.ma_lop = Lop;

            db.sinh_viens.InsertOnSubmit(sv);
            db.SubmitChanges();

            MessageBox.Show("Thêm sinh viên thành công!");

            loadData();
            LamMoiForm();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string MaSinhVien = txt_mssv.Text.Trim();

            if (MaSinhVien == "")
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần sửa!");
                return;
            }

            if (cbo_lop.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn lớp học!");
                return;
            }

            DataClasses1DataContext db = new DataClasses1DataContext();

            sinh_vien sv = db.sinh_viens.FirstOrDefault(x => x.ma_sv == MaSinhVien);

            if (sv == null)
            {
                MessageBox.Show("Không tìm thấy sinh viên!");
                return;
            }

            sv.ho_ten = txt_hoten.Text.Trim();
            sv.gioitinh = txt_gioitinh.Text.Trim();
            sv.ngay_sinh = txt_date.Value;
            sv.ma_lop = cbo_lop.SelectedValue.ToString();

            db.SubmitChanges();

            MessageBox.Show("Cập nhật sinh viên thành công!");

            loadData();
            LamMoiForm();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string MaSinhVien = txt_mssv.Text.Trim();

            if (MaSinhVien == "")
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần xóa!");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Bạn có chắc muốn xóa sinh viên này không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.No) return;

            DataClasses1DataContext db = new DataClasses1DataContext();

            sinh_vien sv = db.sinh_viens.FirstOrDefault(x => x.ma_sv == MaSinhVien);

            if (sv == null)
            {
                MessageBox.Show("Không tìm thấy sinh viên!");
                return;
            }

            db.sinh_viens.DeleteOnSubmit(sv);
            db.SubmitChanges();

            MessageBox.Show("Xóa sinh viên thành công!");

            loadData();
            LamMoiForm();
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            string keyword = txt_timkiem.Text.Trim().ToLower();

            DataClasses1DataContext db = new DataClasses1DataContext();

            danhSachSinhVien = db.sinh_viens
                .Where(x =>
                    keyword == "" ||
                    x.ma_sv.ToLower().Contains(keyword) ||
                    x.ho_ten.ToLower().Contains(keyword) ||
                    (x.ma_lop != null && x.ma_lop.ToLower().Contains(keyword)))
                .ToList();

            currentPage = 1;
            HienThiTheoTrang();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoiForm();
            LoadLopHoc();
            loadData();
        }

        private void LamMoiForm()
        {
            txt_mssv.Clear();
            txt_hoten.Clear();
            txt_gioitinh.Text = "";
            txt_timkiem.Clear();

            cbo_lop.SelectedIndex = -1;

            txt_date.Value = DateTime.Now;

            txt_mssv.ReadOnly = false;
            txt_mssv.Focus();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            currentPage = 1;
            HienThiTheoTrang();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            currentPage--;
            HienThiTheoTrang();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            currentPage++;
            HienThiTheoTrang();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            currentPage = totalPage;
            HienThiTheoTrang();
        }
    }
}