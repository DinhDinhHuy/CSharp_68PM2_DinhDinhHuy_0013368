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

            // txt_lop.Text = row.Cells["lop"].Value?.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string HoVaTen = txt_hoten.Text;
            string MaSinhVien = txt_mssv.Text;
            DateTime NgaySinh = txt_date.Value;
            string GioiTinh = txt_gioitinh.Text;
            // string Lop = txt_lop.Text;

            sinh_vien sv = new sinh_vien();

            sv.ma_sv = MaSinhVien;
            sv.ho_ten = HoVaTen;
            sv.ngay_sinh = NgaySinh;
            sv.gioitinh = GioiTinh;
            // sv.ma_lop = Lop;

            DataClasses1DataContext db = new DataClasses1DataContext();

            db.sinh_viens.InsertOnSubmit(sv);
            db.SubmitChanges();

            loadData();
        }
    }
}