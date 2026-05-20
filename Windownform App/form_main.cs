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
    public partial class form_main : Form
    {
        public form_main()
        {
            InitializeComponent();
        }

        private void LoadUserControl(UserControl uc)
        {
            panelMain.Controls.Clear();

            uc.Dock = DockStyle.Fill;

            panelMain.Controls.Add(uc);
        }

        private void quảnLýSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UCQLSV ucqlsv = new UCQLSV();
            LoadUserControl(ucqlsv);
        }

        private void quảnLýLớpHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UCQLLH ucqllh = new UCQLLH();
            LoadUserControl(ucqllh);
        }
    }
}
