namespace Windownform_App
{
    partial class UCQLSV
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label label2;
            this.DataQLSV = new System.Windows.Forms.DataGridView();
            this.maSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_lop = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_gioitinh = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_date = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_hoten = new System.Windows.Forms.TextBox();
            this.txt_mssv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.txt_timkiem = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataQLSV)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            label2.Location = new System.Drawing.Point(22, 115);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(67, 16);
            label2.TabIndex = 2;
            label2.Text = "Họ và tên:";
            // 
            // DataQLSV
            // 
            this.DataQLSV.AllowUserToAddRows = false;
            this.DataQLSV.BackgroundColor = System.Drawing.Color.White;
            this.DataQLSV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataQLSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataQLSV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maSV,
            this.hoten,
            this.gioitinh,
            this.ngaysinh,
            this.lop});
            this.DataQLSV.Location = new System.Drawing.Point(3, 108);
            this.DataQLSV.Name = "DataQLSV";
            this.DataQLSV.RowHeadersVisible = false;
            this.DataQLSV.RowHeadersWidth = 51;
            this.DataQLSV.RowTemplate.Height = 24;
            this.DataQLSV.Size = new System.Drawing.Size(630, 537);
            this.DataQLSV.TabIndex = 3;
            // 
            // maSV
            // 
            this.maSV.HeaderText = "Mã SV";
            this.maSV.MinimumWidth = 6;
            this.maSV.Name = "maSV";
            this.maSV.Width = 125;
            // 
            // hoten
            // 
            this.hoten.HeaderText = "Họ và Tên";
            this.hoten.MinimumWidth = 6;
            this.hoten.Name = "hoten";
            this.hoten.Width = 125;
            // 
            // gioitinh
            // 
            this.gioitinh.HeaderText = "Giới Tính";
            this.gioitinh.MinimumWidth = 6;
            this.gioitinh.Name = "gioitinh";
            this.gioitinh.Width = 125;
            // 
            // ngaysinh
            // 
            this.ngaysinh.HeaderText = "Ngày Sinh";
            this.ngaysinh.MinimumWidth = 6;
            this.ngaysinh.Name = "ngaysinh";
            this.ngaysinh.Width = 125;
            // 
            // lop
            // 
            this.lop.HeaderText = "Lớp";
            this.lop.MinimumWidth = 6;
            this.lop.Name = "lop";
            this.lop.Width = 125;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_lop);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_gioitinh);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_date);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_hoten);
            this.groupBox1.Controls.Add(label2);
            this.groupBox1.Controls.Add(this.txt_mssv);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(408, 481);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sinh viên";
            // 
            // txt_lop
            // 
            this.txt_lop.FormattingEnabled = true;
            this.txt_lop.Location = new System.Drawing.Point(25, 405);
            this.txt_lop.Name = "txt_lop";
            this.txt_lop.Size = new System.Drawing.Size(358, 24);
            this.txt_lop.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(22, 371);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Lớp:";
            // 
            // txt_gioitinh
            // 
            this.txt_gioitinh.FormattingEnabled = true;
            this.txt_gioitinh.Location = new System.Drawing.Point(25, 316);
            this.txt_gioitinh.Name = "txt_gioitinh";
            this.txt_gioitinh.Size = new System.Drawing.Size(358, 24);
            this.txt_gioitinh.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(22, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Giới tính:";
            // 
            // txt_date
            // 
            this.txt_date.Location = new System.Drawing.Point(25, 228);
            this.txt_date.Name = "txt_date";
            this.txt_date.Size = new System.Drawing.Size(358, 22);
            this.txt_date.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(22, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ngày sinh:";
            // 
            // txt_hoten
            // 
            this.txt_hoten.Location = new System.Drawing.Point(25, 145);
            this.txt_hoten.Name = "txt_hoten";
            this.txt_hoten.Size = new System.Drawing.Size(358, 22);
            this.txt_hoten.TabIndex = 3;
            // 
            // txt_mssv
            // 
            this.txt_mssv.Location = new System.Drawing.Point(25, 63);
            this.txt_mssv.Name = "txt_mssv";
            this.txt_mssv.Size = new System.Drawing.Size(358, 22);
            this.txt_mssv.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(22, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sinh viên:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DataQLSV);
            this.panel1.Controls.Add(this.btn_timkiem);
            this.panel1.Controls.Add(this.txt_timkiem);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.panel1.Location = new System.Drawing.Point(467, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(637, 648);
            this.panel1.TabIndex = 6;
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_timkiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_timkiem.ForeColor = System.Drawing.Color.White;
            this.btn_timkiem.Location = new System.Drawing.Point(385, 45);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(123, 44);
            this.btn_timkiem.TabIndex = 2;
            this.btn_timkiem.Text = "Tìm";
            this.btn_timkiem.UseVisualStyleBackColor = false;
            // 
            // txt_timkiem
            // 
            this.txt_timkiem.Location = new System.Drawing.Point(17, 45);
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.Size = new System.Drawing.Size(348, 22);
            this.txt_timkiem.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(212, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tìm kiếm (Tên / Mã SV / Lớp):";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.button8);
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Location = new System.Drawing.Point(467, 678);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(637, 61);
            this.panel2.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(320, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(10, 16);
            this.label9.TabIndex = 6;
            this.label9.Text = "|";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(336, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 16);
            this.label8.TabIndex = 5;
            this.label8.Text = "0 bản ghi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(250, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "Trang 1/1";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(468, 0);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(86, 60);
            this.button8.TabIndex = 3;
            this.button8.Text = ">";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(551, 0);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(86, 60);
            this.button7.TabIndex = 2;
            this.button7.Text = ">>";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(83, 0);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(86, 60);
            this.button6.TabIndex = 1;
            this.button6.Text = "<";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(0, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(86, 60);
            this.button5.TabIndex = 0;
            this.button5.Text = "<<";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(12, 523);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 53);
            this.button1.TabIndex = 7;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(233, 523);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(187, 53);
            this.btnSua.TabIndex = 8;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(12, 604);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(187, 53);
            this.button3.TabIndex = 9;
            this.button3.Text = "Xóa";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Location = new System.Drawing.Point(233, 607);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(187, 53);
            this.btnLamMoi.TabIndex = 10;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            // 
            // UCQLSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "UCQLSV";
            this.Size = new System.Drawing.Size(1137, 780);
            this.Load += new System.EventHandler(this.UCQLSV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataQLSV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox txt_lop;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox txt_gioitinh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker txt_date;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_hoten;
        private System.Windows.Forms.TextBox txt_mssv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn lop;
        private System.Windows.Forms.Button btn_timkiem;
        private System.Windows.Forms.TextBox txt_timkiem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.DataGridView DataQLSV;
    }
}