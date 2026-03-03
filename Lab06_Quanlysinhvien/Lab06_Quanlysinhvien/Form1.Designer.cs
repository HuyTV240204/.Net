namespace Lab06_Quanlysinhvien
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
            txtMaSV = new TextBox();
            txtHoten = new TextBox();
            btThem = new Button();
            btClear = new Button();
            btExit = new Button();
            label3 = new Label();
            btTim = new Button();
            txtTimKiem = new TextBox();
            label4 = new Label();
            btChon = new Button();
            btTrave = new Button();
            btChonhet = new Button();
            btTravehet = new Button();
            lvSinhvien = new ListView();
            columnStt = new ColumnHeader();
            columMaSV = new ColumnHeader();
            columnHoten = new ColumnHeader();
            lvDachon = new ListView();
            columnSTT1 = new ColumnHeader();
            columnMaSV1 = new ColumnHeader();
            columnHoten1 = new ColumnHeader();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.InactiveBorder;
            label1.Location = new Point(46, 18);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã SV";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(151, 16);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 1;
            label2.Text = "Họ tên";
            // 
            // txtMaSV
            // 
            txtMaSV.Location = new Point(12, 41);
            txtMaSV.Name = "txtMaSV";
            txtMaSV.Size = new Size(107, 27);
            txtMaSV.TabIndex = 2;
            // 
            // txtHoten
            // 
            txtHoten.Location = new Point(151, 41);
            txtHoten.Name = "txtHoten";
            txtHoten.Size = new Size(125, 27);
            txtHoten.TabIndex = 3;
            // 
            // btThem
            // 
            btThem.BackgroundImage = Properties.Resources.beautiful_natural_image_1844362_960_720;
            btThem.ForeColor = SystemColors.ButtonFace;
            btThem.Location = new Point(308, 31);
            btThem.Name = "btThem";
            btThem.Size = new Size(79, 47);
            btThem.TabIndex = 4;
            btThem.Text = "Cập nhật";
            btThem.UseVisualStyleBackColor = true;
            btThem.Click += btThem_Click;
            // 
            // btClear
            // 
            btClear.BackgroundImageLayout = ImageLayout.Zoom;
            btClear.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btClear.ForeColor = SystemColors.ActiveCaptionText;
            btClear.ImageAlign = ContentAlignment.MiddleLeft;
            btClear.Location = new Point(406, 18);
            btClear.Name = "btClear";
            btClear.Size = new Size(120, 77);
            btClear.TabIndex = 5;
            btClear.Text = "Xóa";
            btClear.UseVisualStyleBackColor = true;
            btClear.Click += btClear_Click;
            // 
            // btExit
            // 
            btExit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btExit.ForeColor = SystemColors.ButtonHighlight;
            btExit.Image = Properties.Resources.Genshin_Impact_Mavuika;
            btExit.Location = new Point(567, 27);
            btExit.Name = "btExit";
            btExit.Size = new Size(139, 53);
            btExit.TabIndex = 6;
            btExit.Text = "Thoát";
            btExit.UseVisualStyleBackColor = true;
            btExit.Click += btExit_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 117);
            label3.Name = "label3";
            label3.Size = new Size(138, 20);
            label3.TabIndex = 7;
            label3.Text = "Danh sách sinh viên";
            // 
            // btTim
            // 
            btTim.Location = new Point(200, 117);
            btTim.Name = "btTim";
            btTim.Size = new Size(94, 29);
            btTim.TabIndex = 8;
            btTim.Text = "Tìm kiếm";
            btTim.UseVisualStyleBackColor = true;
            btTim.Click += btTim_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(308, 114);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(251, 27);
            txtTimKiem.TabIndex = 9;
            txtTimKiem.KeyPress += txtTimKiem_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(610, 117);
            label4.Name = "label4";
            label4.Size = new Size(134, 20);
            label4.TabIndex = 10;
            label4.Text = "Danh sách đã chọn";
            // 
            // btChon
            // 
            btChon.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btChon.Location = new Point(376, 177);
            btChon.Name = "btChon";
            btChon.Size = new Size(94, 39);
            btChon.TabIndex = 11;
            btChon.Text = ">";
            btChon.UseVisualStyleBackColor = true;
            btChon.Click += btChon_Click;
            // 
            // btTrave
            // 
            btTrave.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btTrave.Location = new Point(376, 231);
            btTrave.Name = "btTrave";
            btTrave.Size = new Size(94, 44);
            btTrave.TabIndex = 12;
            btTrave.Text = "<";
            btTrave.UseVisualStyleBackColor = true;
            btTrave.Click += btTrave_Click;
            // 
            // btChonhet
            // 
            btChonhet.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btChonhet.Location = new Point(378, 290);
            btChonhet.Name = "btChonhet";
            btChonhet.Size = new Size(90, 46);
            btChonhet.TabIndex = 13;
            btChonhet.Text = ">>";
            btChonhet.UseVisualStyleBackColor = true;
            // 
            // btTravehet
            // 
            btTravehet.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btTravehet.Location = new Point(376, 354);
            btTravehet.Name = "btTravehet";
            btTravehet.Size = new Size(90, 46);
            btTravehet.TabIndex = 14;
            btTravehet.Text = "<<";
            btTravehet.UseVisualStyleBackColor = true;
            // 
            // lvSinhvien
            // 
            lvSinhvien.Columns.AddRange(new ColumnHeader[] { columnStt, columMaSV, columnHoten });
            lvSinhvien.FullRowSelect = true;
            lvSinhvien.Location = new Point(31, 152);
            lvSinhvien.Name = "lvSinhvien";
            lvSinhvien.Size = new Size(328, 277);
            lvSinhvien.TabIndex = 17;
            lvSinhvien.UseCompatibleStateImageBehavior = false;
            lvSinhvien.View = View.Details;
            // 
            // columnStt
            // 
            columnStt.Text = "STT";
            // 
            // columMaSV
            // 
            columMaSV.DisplayIndex = 2;
            columMaSV.Text = "Mã Sinh Viên";
            columMaSV.Width = 140;
            // 
            // columnHoten
            // 
            columnHoten.DisplayIndex = 1;
            columnHoten.Text = "Họ tên";
            columnHoten.Width = 120;
            // 
            // lvDachon
            // 
            lvDachon.Columns.AddRange(new ColumnHeader[] { columnSTT1, columnMaSV1, columnHoten1 });
            lvDachon.FullRowSelect = true;
            lvDachon.Location = new Point(486, 152);
            lvDachon.Name = "lvDachon";
            lvDachon.Size = new Size(312, 277);
            lvDachon.TabIndex = 18;
            lvDachon.UseCompatibleStateImageBehavior = false;
            lvDachon.View = View.Details;
            // 
            // columnSTT1
            // 
            columnSTT1.Text = "STT";
            // 
            // columnMaSV1
            // 
            columnMaSV1.DisplayIndex = 2;
            columnMaSV1.Text = "Mã Sinh Viên";
            columnMaSV1.Width = 120;
            // 
            // columnHoten1
            // 
            columnHoten1.DisplayIndex = 1;
            columnHoten1.Text = "Họ Tên";
            columnHoten1.Width = 120;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.new_moon_event_backgrounds_with_the_genshin_logo_removed_v0_20375y7uoyre1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(lvDachon);
            Controls.Add(lvSinhvien);
            Controls.Add(btTravehet);
            Controls.Add(btChonhet);
            Controls.Add(btTrave);
            Controls.Add(btChon);
            Controls.Add(label4);
            Controls.Add(txtTimKiem);
            Controls.Add(btTim);
            Controls.Add(label3);
            Controls.Add(btExit);
            Controls.Add(btClear);
            Controls.Add(btThem);
            Controls.Add(txtHoten);
            Controls.Add(txtMaSV);
            Controls.Add(label2);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "Quản Lý Sinh Viên";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtMaSV;
        private TextBox txtHoten;
        private Button btThem;
        private Button btClear;
        private Button btExit;
        private Label label3;
        private Button btTim;
        private TextBox txtTimKiem;
        private Label label4;
        private Button btChon;
        private Button btTrave;
        private Button btChonhet;
        private Button btTravehet;
        private ListBox lbDanhsachsinhvien;
        private ListBox lbDachon;
        private ListView lvSinhvien;
        private ListView lvDachon;
        private ColumnHeader columnStt;
        private ColumnHeader columnHoten;
        private ColumnHeader columMaSV;
        private ColumnHeader columnSTT1;
        private ColumnHeader columnHoten1;
        private ColumnHeader columnMaSV1;
    }
}
