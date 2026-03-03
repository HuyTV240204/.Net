namespace Lab08_studnetMS
{
    partial class frmSinhVien
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
            components = new System.ComponentModel.Container();
            dataGridViewSinhVien = new DataGridView();
            bindingSource1 = new BindingSource(components);
            label1 = new Label();
            txtmasoSV = new TextBox();
            txtHoTen = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtSoDT = new TextBox();
            label6 = new Label();
            txtDiaChi = new TextBox();
            label7 = new Label();
            dtpNgaySinh = new DateTimePicker();
            gbGioiTinh = new GroupBox();
            radioButton_Nu = new RadioButton();
            radioButton_Nam = new RadioButton();
            comboBox_MaKhoa = new ComboBox();
            buttonAdd = new Button();
            buttonDelete = new Button();
            buttonSave = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSinhVien).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            gbGioiTinh.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewSinhVien
            // 
            dataGridViewSinhVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSinhVien.Location = new Point(12, 165);
            dataGridViewSinhVien.Name = "dataGridViewSinhVien";
            dataGridViewSinhVien.RowHeadersWidth = 51;
            dataGridViewSinhVien.Size = new Size(1048, 273);
            dataGridViewSinhVien.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 5);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 1;
            label1.Text = "Mã số SV";
            // 
            // txtmasoSV
            // 
            txtmasoSV.Location = new Point(97, 2);
            txtmasoSV.Name = "txtmasoSV";
            txtmasoSV.Size = new Size(146, 27);
            txtmasoSV.TabIndex = 2;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(97, 35);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(146, 27);
            txtHoTen.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 38);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 3;
            label2.Text = "Họ tên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 71);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 5;
            label3.Text = "Ngày sinh";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 104);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 7;
            label4.Text = "Giới tính";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(297, 73);
            label5.Name = "label5";
            label5.Size = new Size(68, 20);
            label5.TabIndex = 13;
            label5.Text = "Mã Khoa";
            // 
            // txtSoDT
            // 
            txtSoDT.Location = new Point(417, 35);
            txtSoDT.Name = "txtSoDT";
            txtSoDT.Size = new Size(146, 27);
            txtSoDT.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(297, 40);
            label6.Name = "label6";
            label6.Size = new Size(102, 20);
            label6.TabIndex = 11;
            label6.Text = "Số Điện Thoại";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(417, 2);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(146, 27);
            txtDiaChi.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(297, 7);
            label7.Name = "label7";
            label7.Size = new Size(55, 20);
            label7.TabIndex = 9;
            label7.Text = "Địa chỉ";
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Location = new Point(97, 68);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.RightToLeft = RightToLeft.No;
            dtpNgaySinh.Size = new Size(146, 27);
            dtpNgaySinh.TabIndex = 15;
            // 
            // gbGioiTinh
            // 
            gbGioiTinh.Controls.Add(radioButton_Nu);
            gbGioiTinh.Controls.Add(radioButton_Nam);
            gbGioiTinh.Location = new Point(97, 101);
            gbGioiTinh.Name = "gbGioiTinh";
            gbGioiTinh.Size = new Size(208, 50);
            gbGioiTinh.TabIndex = 16;
            gbGioiTinh.TabStop = false;
            gbGioiTinh.Text = "Giới tính";
            // 
            // radioButton_Nu
            // 
            radioButton_Nu.AutoSize = true;
            radioButton_Nu.Location = new Point(97, 23);
            radioButton_Nu.Name = "radioButton_Nu";
            radioButton_Nu.Size = new Size(50, 24);
            radioButton_Nu.TabIndex = 1;
            radioButton_Nu.TabStop = true;
            radioButton_Nu.Text = "Nữ";
            radioButton_Nu.UseVisualStyleBackColor = true;
            // 
            // radioButton_Nam
            // 
            radioButton_Nam.AutoSize = true;
            radioButton_Nam.Location = new Point(12, 23);
            radioButton_Nam.Name = "radioButton_Nam";
            radioButton_Nam.Size = new Size(62, 24);
            radioButton_Nam.TabIndex = 0;
            radioButton_Nam.TabStop = true;
            radioButton_Nam.Text = "Nam";
            radioButton_Nam.UseVisualStyleBackColor = true;
            // 
            // comboBox_MaKhoa
            // 
            comboBox_MaKhoa.FormattingEnabled = true;
            comboBox_MaKhoa.Location = new Point(417, 68);
            comboBox_MaKhoa.Name = "comboBox_MaKhoa";
            comboBox_MaKhoa.Size = new Size(151, 28);
            comboBox_MaKhoa.TabIndex = 17;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(619, 7);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(105, 30);
            buttonAdd.TabIndex = 18;
            buttonAdd.Text = "Thêm mới";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(619, 43);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(105, 30);
            buttonDelete.TabIndex = 19;
            buttonDelete.Text = "Xóa";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(619, 79);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(105, 30);
            buttonSave.TabIndex = 20;
            buttonSave.Text = "Lưu";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // frmSinhVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1072, 450);
            Controls.Add(buttonSave);
            Controls.Add(buttonDelete);
            Controls.Add(buttonAdd);
            Controls.Add(comboBox_MaKhoa);
            Controls.Add(gbGioiTinh);
            Controls.Add(dtpNgaySinh);
            Controls.Add(label5);
            Controls.Add(txtSoDT);
            Controls.Add(label6);
            Controls.Add(txtDiaChi);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtHoTen);
            Controls.Add(label2);
            Controls.Add(txtmasoSV);
            Controls.Add(label1);
            Controls.Add(dataGridViewSinhVien);
            Name = "frmSinhVien";
            Text = "frmSinhVien";
            Load += frmSinhVien_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewSinhVien).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            gbGioiTinh.ResumeLayout(false);
            gbGioiTinh.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewSinhVien;
        private BindingSource bindingSource1;
        private Label label1;
        private TextBox txtmasoSV;
        private TextBox txtHoTen;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtSoDT;
        private Label label6;
        private TextBox txtDiaChi;
        private Label label7;
        private DateTimePicker dtpNgaySinh;
        private GroupBox gbGioiTinh;
        private RadioButton radioButton_Nu;
        private RadioButton radioButton_Nam;
        private ComboBox comboBox_MaKhoa;
        private Button buttonAdd;
        private Button buttonDelete;
        private Button buttonSave;
    }
}