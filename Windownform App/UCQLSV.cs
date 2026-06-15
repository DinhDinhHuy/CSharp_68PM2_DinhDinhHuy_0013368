using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Windownform_App
{
    public partial class UCQLSV : UserControl
    {
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
            btnLamMoi.Click += btnLamMoi_Click;
            btnXoa.Click += btnXoa_Click;
        }

        private void UCQLSV_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            DataClasses1DataContext db = new DataClasses1DataContext();

            List<sinh_vien> dssv = db.sinh_viens.ToList();

            DataQLSV.DataSource = null;
            DataQLSV.DataSource = dssv;
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

            txt_mssv.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string HoVaTen = txt_hoten.Text.Trim();
            string MaSinhVien = txt_mssv.Text.Trim();
            DateTime NgaySinh = txt_date.Value;
            string GioiTinh = txt_gioitinh.Text.Trim();

            if (MaSinhVien == "" || HoVaTen == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ mã sinh viên và họ tên!");
                return;
            }

            DataClasses1DataContext db = new DataClasses1DataContext();

            sinh_vien kt = db.sinh_viens.FirstOrDefault(x => x.ma_sv == MaSinhVien);

            if (kt != null)
            {
                MessageBox.Show("Mã sinh viên đã tồn tại!");
                return;
            }

            sinh_vien sv = new sinh_vien();

            sv.ma_sv = MaSinhVien;
            sv.ho_ten = HoVaTen;
            sv.ngay_sinh = NgaySinh;
            sv.gioitinh = GioiTinh;

            db.sinh_viens.InsertOnSubmit(sv);
            db.SubmitChanges();

            MessageBox.Show("Thêm sinh viên thành công!");

            loadData();
            LamMoiForm();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string MaSinhVien = txt_mssv.Text.Trim();

            DataClasses1DataContext db = new DataClasses1DataContext();

            sinh_vien sv = db.sinh_viens.FirstOrDefault(x => x.ma_sv == MaSinhVien);

            if (sv == null)
            {
                MessageBox.Show("Không tìm thấy sinh viên cần sửa!");
                return;
            }

            sv.ho_ten = txt_hoten.Text.Trim();
            sv.ngay_sinh = txt_date.Value;
            sv.gioitinh = txt_gioitinh.Text.Trim();

            db.SubmitChanges();

            MessageBox.Show("Cập nhật sinh viên thành công!");

            loadData();
            LamMoiForm();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoiForm();
        }

        private void LamMoiForm()
        {
            txt_mssv.Clear();
            txt_hoten.Clear();
            txt_gioitinh.Text = "";
            txt_date.Value = DateTime.Now;
            txt_mssv.ReadOnly = false;

            txt_mssv.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string MaSinhVien = txt_mssv.Text.Trim();

            if (string.IsNullOrEmpty(MaSinhVien))
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần xóa!");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Bạn có chắc muốn xóa sinh viên này không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.No)
                return;

            DataClasses1DataContext db = new DataClasses1DataContext();

            sinh_vien sv = db.sinh_viens
                             .FirstOrDefault(x => x.ma_sv == MaSinhVien);

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
    }
}