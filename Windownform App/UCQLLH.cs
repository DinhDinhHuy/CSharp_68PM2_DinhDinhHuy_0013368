using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Windownform_App
{
    public partial class UCQLLH : UserControl
    {
        int pageSize = 1;
        int currentPage = 1;
        int totalPage = 1;

        List<lop_hoc> danhSachLopHoc = new List<lop_hoc>();

        public UCQLLH()
        {
            InitializeComponent();

            dataGridView1.AutoGenerateColumns = false;

            colID.DataPropertyName = "ma_id";
            colMaLop.DataPropertyName = "ma_lop";
            colTenLop.DataPropertyName = "ten_lop";
            colGhiChu.DataPropertyName = "ghi_chu";

            this.Load += UCQLLH_Load;

            dataGridView1.CellClick += dataGridView1_CellClick;

            btnThem.Click += btnThem_Click;
            btnSua.Click += btnSua_Click;
            btnXoa.Click += btnXoa_Click;
            btnLamMoi.Click += btnLamMoi_Click;
            btn_timkiem.Click += btn_timkiem_Click;

            btnFirst.Click += btnFirst_Click;
            btnPrevious.Click += btnPrevious_Click;
            button7.Click += btnNext_Click;
            btnLast.Click += btnLast_Click;
        }

 
        private void UCQLLH_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            DataClasses1DataContext db = new DataClasses1DataContext();

            danhSachLopHoc = db.lop_hocs.ToList();

            currentPage = 1;
            HienThiTheoTrang();
        }

        private void HienThiTheoTrang()
        {
            totalPage = (int)Math.Ceiling((double)danhSachLopHoc.Count / pageSize);

            if (totalPage == 0)
                totalPage = 1;

            if (currentPage < 1)
                currentPage = 1;

            if (currentPage > totalPage)
                currentPage = totalPage;

            List<lop_hoc> data = danhSachLopHoc
                .Skip((currentPage - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = data;

            lblTrang.Text = "Trang " + currentPage + "/" + totalPage;
            lblTongBanGhi.Text = danhSachLopHoc.Count + " bản ghi";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            txt_id.Text = row.Cells["colID"].Value?.ToString();
            maLop.Text = row.Cells["colMaLop"].Value?.ToString();
            tenLop.Text = row.Cells["colTenLop"].Value?.ToString();
            ghiChu.Text = row.Cells["colGhiChu"].Value?.ToString();

            txt_id.ReadOnly = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int MaID;

            if (!int.TryParse(txt_id.Text.Trim(), out MaID))
            {
                MessageBox.Show("Mã ID phải là số!");
                return;
            }

            string MaLop = maLop.Text.Trim();
            string TenLop = tenLop.Text.Trim();
            string GhiChu = ghiChu.Text.Trim();

            if (MaLop == "" || TenLop == "")
            {
                MessageBox.Show("Vui lòng nhập mã lớp và tên lớp!");
                return;
            }

            DataClasses1DataContext db = new DataClasses1DataContext();

            lop_hoc check = db.lop_hocs.FirstOrDefault(x => x.ma_id == MaID);

            if (check != null)
            {
                MessageBox.Show("Mã ID đã tồn tại!");
                return;
            }

            lop_hoc lh = new lop_hoc();

            lh.ma_id = MaID;
            lh.ma_lop = MaLop;
            lh.ten_lop = TenLop;
            lh.ghi_chu = GhiChu;

            db.lop_hocs.InsertOnSubmit(lh);
            db.SubmitChanges();

            MessageBox.Show("Thêm lớp học thành công!");

            loadData();
            LamMoiForm();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int MaID;

            if (!int.TryParse(txt_id.Text.Trim(), out MaID))
            {
                MessageBox.Show("Vui lòng chọn lớp học cần sửa!");
                return;
            }

            DataClasses1DataContext db = new DataClasses1DataContext();

            lop_hoc lh = db.lop_hocs.FirstOrDefault(x => x.ma_id == MaID);

            if (lh == null)
            {
                MessageBox.Show("Không tìm thấy lớp học!");
                return;
            }

            lh.ma_lop = maLop.Text.Trim();
            lh.ten_lop = tenLop.Text.Trim();
            lh.ghi_chu = ghiChu.Text.Trim();

            db.SubmitChanges();

            MessageBox.Show("Cập nhật lớp học thành công!");

            loadData();
            LamMoiForm();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int MaID;

            if (!int.TryParse(txt_id.Text.Trim(), out MaID))
            {
                MessageBox.Show("Vui lòng chọn lớp học cần xóa!");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Bạn có chắc muốn xóa lớp học này không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.No)
                return;

            DataClasses1DataContext db = new DataClasses1DataContext();

            lop_hoc lh = db.lop_hocs.FirstOrDefault(x => x.ma_id == MaID);

            if (lh == null)
            {
                MessageBox.Show("Không tìm thấy lớp học!");
                return;
            }

            db.lop_hocs.DeleteOnSubmit(lh);
            db.SubmitChanges();

            MessageBox.Show("Xóa lớp học thành công!");

            loadData();
            LamMoiForm();
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            string keyword = txt_timkiem.Text.Trim().ToLower();

            DataClasses1DataContext db = new DataClasses1DataContext();

            danhSachLopHoc = db.lop_hocs
                .Where(x =>
                    keyword == "" ||
                    x.ma_id.ToString().Contains(keyword) ||
                    x.ma_lop.ToLower().Contains(keyword) ||
                    x.ten_lop.ToLower().Contains(keyword))
                .ToList();

            currentPage = 1;
            HienThiTheoTrang();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoiForm();
            loadData();
        }

        private void LamMoiForm()
        {
            txt_id.Clear();
            maLop.Clear();
            tenLop.Clear();
            ghiChu.Clear();
            txt_timkiem.Clear();

            txt_id.ReadOnly = false;
            txt_id.Focus();
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