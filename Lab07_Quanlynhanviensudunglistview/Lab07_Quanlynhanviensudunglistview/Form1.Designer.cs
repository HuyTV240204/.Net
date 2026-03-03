namespace Lab07_Quanlynhanviensudunglistview
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            groupBox1 = new GroupBox();
            tbNgaySinh = new DateTimePicker();
            btXoa = new Button();
            btSua = new Button();
            btThoat = new Button();
            tbDiaChi = new TextBox();
            tbDienThoai = new TextBox();
            tbHoTen = new TextBox();
            label5 = new Label();
            label4 = new Label();
            btThem = new Button();
            groupBox2 = new GroupBox();
            lvDanhSachNhanVien = new ListView();
            columnThem = new ColumnHeader();
            columnXoa = new ColumnHeader();
            columnsua = new ColumnHeader();
            columnSodienthoai = new ColumnHeader();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Tahoma", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(221, 235, 248);
            label1.Location = new Point(110, 3);
            label1.Name = "label1";
            label1.Size = new Size(655, 72);
            label1.TabIndex = 0;
            label1.Text = "Danh Mục Nhân Viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 28);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 0;
            label2.Text = "Họ tên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 66);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 1;
            label3.Text = "Ngày sinh";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(tbNgaySinh);
            groupBox1.Controls.Add(btXoa);
            groupBox1.Controls.Add(btSua);
            groupBox1.Controls.Add(btThoat);
            groupBox1.Controls.Add(tbDiaChi);
            groupBox1.Controls.Add(tbDienThoai);
            groupBox1.Controls.Add(tbHoTen);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.FromArgb(221, 235, 248);
            groupBox1.Location = new Point(12, 80);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(824, 186);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin chi tiết";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // tbNgaySinh
            // 
            tbNgaySinh.Location = new Point(118, 61);
            tbNgaySinh.Name = "tbNgaySinh";
            tbNgaySinh.Size = new Size(243, 27);
            tbNgaySinh.TabIndex = 8;
            // 
            // btXoa
            // 
            btXoa.BackColor = Color.FromArgb(118, 126, 233);
            btXoa.ForeColor = Color.FromArgb(221, 235, 248);
            btXoa.Location = new Point(232, 125);
            btXoa.Name = "btXoa";
            btXoa.Size = new Size(175, 55);
            btXoa.TabIndex = 3;
            btXoa.Text = "Xóa";
            btXoa.UseVisualStyleBackColor = false;
            btXoa.Click += btXoa_Click;
            // 
            // btSua
            // 
            btSua.BackColor = Color.FromArgb(118, 126, 233);
            btSua.ForeColor = Color.FromArgb(221, 235, 248);
            btSua.Location = new Point(426, 125);
            btSua.Name = "btSua";
            btSua.Size = new Size(175, 55);
            btSua.TabIndex = 4;
            btSua.Text = "Sửa";
            btSua.UseVisualStyleBackColor = false;
            btSua.Click += btSua_Click;
            // 
            // btThoat
            // 
            btThoat.BackColor = Color.FromArgb(118, 126, 233);
            btThoat.ForeColor = Color.FromArgb(221, 235, 248);
            btThoat.Location = new Point(617, 125);
            btThoat.Name = "btThoat";
            btThoat.Size = new Size(166, 55);
            btThoat.TabIndex = 5;
            btThoat.Text = "Thoát";
            btThoat.UseVisualStyleBackColor = false;
            btThoat.Click += btThoat_Click;
            // 
            // tbDiaChi
            // 
            tbDiaChi.BackColor = Color.FromArgb(221, 235, 248);
            tbDiaChi.Location = new Point(489, 59);
            tbDiaChi.Name = "tbDiaChi";
            tbDiaChi.Size = new Size(294, 27);
            tbDiaChi.TabIndex = 7;
            // 
            // tbDienThoai
            // 
            tbDienThoai.BackColor = Color.FromArgb(221, 235, 248);
            tbDienThoai.Location = new Point(489, 21);
            tbDienThoai.Name = "tbDienThoai";
            tbDienThoai.Size = new Size(294, 27);
            tbDienThoai.TabIndex = 6;
            // 
            // tbHoTen
            // 
            tbHoTen.BackColor = Color.FromArgb(221, 235, 248);
            tbHoTen.Location = new Point(118, 21);
            tbHoTen.Name = "tbHoTen";
            tbHoTen.Size = new Size(243, 27);
            tbHoTen.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(391, 66);
            label5.Name = "label5";
            label5.Size = new Size(56, 20);
            label5.TabIndex = 3;
            label5.Text = "Địa chỉ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(391, 28);
            label4.Name = "label4";
            label4.Size = new Size(84, 20);
            label4.TabIndex = 2;
            label4.Text = "Điện Thoại";
            // 
            // btThem
            // 
            btThem.BackColor = Color.FromArgb(118, 126, 233);
            btThem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btThem.ForeColor = Color.FromArgb(221, 235, 248);
            btThem.Location = new Point(37, 205);
            btThem.Name = "btThem";
            btThem.Size = new Size(175, 55);
            btThem.TabIndex = 2;
            btThem.Text = "Thêm";
            btThem.UseVisualStyleBackColor = false;
            btThem.Click += btThem_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(lvDanhSachNhanVien);
            groupBox2.ForeColor = Color.FromArgb(221, 235, 248);
            groupBox2.Location = new Point(12, 266);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(824, 288);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin chung";
            // 
            // lvDanhSachNhanVien
            // 
            lvDanhSachNhanVien.BackColor = Color.FromArgb(95, 98, 165);
            lvDanhSachNhanVien.Columns.AddRange(new ColumnHeader[] { columnThem, columnXoa, columnsua, columnSodienthoai });
            lvDanhSachNhanVien.ForeColor = Color.FromArgb(221, 235, 248);
            lvDanhSachNhanVien.GridLines = true;
            lvDanhSachNhanVien.Location = new Point(6, 26);
            lvDanhSachNhanVien.Name = "lvDanhSachNhanVien";
            lvDanhSachNhanVien.Size = new Size(812, 246);
            lvDanhSachNhanVien.TabIndex = 0;
            lvDanhSachNhanVien.UseCompatibleStateImageBehavior = false;
            lvDanhSachNhanVien.View = View.Details;
            // 
            // columnThem
            // 
            columnThem.Text = "Họ Tên";
            columnThem.Width = 240;
            // 
            // columnXoa
            // 
            columnXoa.Text = "Ngày sinh";
            columnXoa.TextAlign = HorizontalAlignment.Center;
            columnXoa.Width = 190;
            // 
            // columnsua
            // 
            columnsua.Text = "Địa chỉ";
            columnsua.TextAlign = HorizontalAlignment.Center;
            columnsua.Width = 190;
            // 
            // columnSodienthoai
            // 
            columnSodienthoai.Text = "Điện thoại";
            columnSodienthoai.TextAlign = HorizontalAlignment.Center;
            columnSodienthoai.Width = 190;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(58, 38, 123);
            BackgroundImage = Properties.Resources.clorinde;
            ClientSize = new Size(867, 566);
            Controls.Add(groupBox2);
            Controls.Add(btThem);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Danh mục nhân viên";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private GroupBox groupBox1;
        private DateTimePicker tbNgaySinh;
        private TextBox tbDiaChi;
        private TextBox tbDienThoai;
        private TextBox tbHoTen;
        private Label label5;
        private Label label4;
        private Button btThem;
        private Button btXoa;
        private Button btSua;
        private Button btThoat;
        private GroupBox groupBox2;
        private ListView lvDanhSachNhanVien;
        private ColumnHeader columnThem;
        private ColumnHeader columnXoa;
        private ColumnHeader columnsua;
        private ColumnHeader columnSodienthoai;
    }
}
