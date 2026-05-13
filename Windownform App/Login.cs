using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windownform_App
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = txt_name.Text;
            string password = txt_password.Text;

            if(string.IsNullOrEmpty(name) || string.IsNullOrEmpty(password)) {
                MessageBox.Show("Vui lòng nhập đủ thông tin");
                return;
            }

            if (name == "0013368@st.huce.edu.vn" && password == "0013368")
            {
                MessageBox.Show("Đăng nhập thành công");
            } else
            {
                MessageBox.Show("Đăng nhập thất bại");
            }


        }
    }
}
