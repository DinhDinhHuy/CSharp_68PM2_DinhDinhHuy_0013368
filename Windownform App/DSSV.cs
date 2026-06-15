using System;
using System.Linq;
using System.Windows.Forms;

namespace Windownform_App
{
    public partial class DSSV : Form
    {
        public DSSV(string maLop)
        {
            InitializeComponent();

            txt_maLop.Text = maLop;

            LoadData(maLop);
        }

        private void LoadData(string maLop)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();

            var ds = db.sinh_viens
                .Where(sv => sv.ma_lop == maLop)
                .Select(sv => new
                {
                    MaSV = sv.ma_sv,
                    HoTen = sv.ho_ten,
                    GioiTinh = sv.gioitinh,
                    NgaySinh = sv.ngay_sinh,
                    Lop = sv.ma_lop
                })
                .ToList();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ds;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}