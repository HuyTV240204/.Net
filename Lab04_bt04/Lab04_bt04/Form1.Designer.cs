namespace Lab04_bt04
{
    partial class frmThaotacso
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
            components = new System.ComponentModel.Container();
            lstKetQua = new ListBox();
            lb01 = new Label();
            txtSoNguyen = new TextBox();
            btCapNhat = new Button();
            groupBox1 = new GroupBox();
            btXoaphantucuoi = new Button();
            btXoaphantudau = new Button();
            btXoaphantudangchon = new Button();
            btLecuoi = new Button();
            btChonchandau = new Button();
            btTang2 = new Button();
            btKetthuc = new Button();
            errSonguyen = new ErrorProvider(components);
            errorProvider1 = new ErrorProvider(components);
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errSonguyen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lstKetQua
            // 
            lstKetQua.ForeColor = SystemColors.MenuHighlight;
            lstKetQua.FormattingEnabled = true;
            lstKetQua.Location = new Point(20, 92);
            lstKetQua.Name = "lstKetQua";
            lstKetQua.Size = new Size(331, 304);
            lstKetQua.TabIndex = 0;
            lstKetQua.SelectedIndexChanged += lstKetQua_SelectedIndexChanged;
            // 
            // lb01
            // 
            lb01.AutoSize = true;
            lb01.Location = new Point(42, 28);
            lb01.Name = "lb01";
            lb01.Size = new Size(116, 20);
            lb01.TabIndex = 1;
            lb01.Text = "Nhập số nguyên";
            // 
            // txtSoNguyen
            // 
            txtSoNguyen.Location = new Point(188, 29);
            txtSoNguyen.Name = "txtSoNguyen";
            txtSoNguyen.Size = new Size(369, 27);
            txtSoNguyen.TabIndex = 2;
            txtSoNguyen.TextChanged += txtSoNguyen_TextChanged;
            // 
            // btCapNhat
            // 
            btCapNhat.BackColor = SystemColors.MenuHighlight;
            btCapNhat.Location = new Point(601, 20);
            btCapNhat.Name = "btCapNhat";
            btCapNhat.Size = new Size(81, 44);
            btCapNhat.TabIndex = 3;
            btCapNhat.Text = "Cập nhật";
            btCapNhat.UseVisualStyleBackColor = false;
            btCapNhat.Click += btCapNhat_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveBorder;
            groupBox1.BackgroundImageLayout = ImageLayout.Zoom;
            groupBox1.Controls.Add(btXoaphantucuoi);
            groupBox1.Controls.Add(btXoaphantudau);
            groupBox1.Controls.Add(btXoaphantudangchon);
            groupBox1.Controls.Add(btLecuoi);
            groupBox1.Controls.Add(btChonchandau);
            groupBox1.Controls.Add(btTang2);
            groupBox1.Location = new Point(370, 83);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(408, 323);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chức năng";
            // 
            // btXoaphantucuoi
            // 
            btXoaphantucuoi.BackColor = Color.FromArgb(255, 255, 192);
            btXoaphantucuoi.Location = new Point(61, 264);
            btXoaphantucuoi.Name = "btXoaphantucuoi";
            btXoaphantucuoi.Size = new Size(285, 33);
            btXoaphantucuoi.TabIndex = 5;
            btXoaphantucuoi.Text = "Xóa phần tử cuối";
            btXoaphantucuoi.UseVisualStyleBackColor = false;
            btXoaphantucuoi.Click += btXoaphantucuoi_Click;
            // 
            // btXoaphantudau
            // 
            btXoaphantudau.BackColor = Color.FromArgb(192, 255, 192);
            btXoaphantudau.Location = new Point(60, 220);
            btXoaphantudau.Name = "btXoaphantudau";
            btXoaphantudau.Size = new Size(285, 33);
            btXoaphantudau.TabIndex = 4;
            btXoaphantudau.Text = "Xóa phần tử đầu";
            btXoaphantudau.UseVisualStyleBackColor = false;
            btXoaphantudau.Click += btXoaphantudau_Click;
            // 
            // btXoaphantudangchon
            // 
            btXoaphantudangchon.BackColor = Color.FromArgb(128, 255, 128);
            btXoaphantudangchon.Location = new Point(60, 172);
            btXoaphantudangchon.Name = "btXoaphantudangchon";
            btXoaphantudangchon.Size = new Size(285, 33);
            btXoaphantudangchon.TabIndex = 3;
            btXoaphantudangchon.Text = "Xóa phần tử đang chọn";
            btXoaphantudangchon.UseVisualStyleBackColor = false;
            btXoaphantudangchon.Click += btXoaphantudangchon_Click;
            // 
            // btLecuoi
            // 
            btLecuoi.BackColor = Color.Lime;
            btLecuoi.Location = new Point(59, 122);
            btLecuoi.Name = "btLecuoi";
            btLecuoi.Size = new Size(285, 33);
            btLecuoi.TabIndex = 2;
            btLecuoi.Text = "Chọn số lẻ cuối";
            btLecuoi.UseVisualStyleBackColor = false;
            btLecuoi.Click += btLecuoi_Click;
            // 
            // btChonchandau
            // 
            btChonchandau.BackColor = Color.FromArgb(0, 192, 0);
            btChonchandau.Location = new Point(59, 73);
            btChonchandau.Name = "btChonchandau";
            btChonchandau.Size = new Size(285, 33);
            btChonchandau.TabIndex = 1;
            btChonchandau.Text = "Chọn số chẵn đầu";
            btChonchandau.UseVisualStyleBackColor = false;
            btChonchandau.Click += btChonchandau_Click_1;
            // 
            // btTang2
            // 
            btTang2.BackColor = Color.Green;
            btTang2.Location = new Point(58, 26);
            btTang2.Name = "btTang2";
            btTang2.Size = new Size(285, 33);
            btTang2.TabIndex = 0;
            btTang2.Text = "Tăng mỗi phân tử lên 2";
            btTang2.UseVisualStyleBackColor = false;
            btTang2.Click += btTang2_Click;
            // 
            // btKetthuc
            // 
            btKetthuc.BackColor = Color.Red;
            btKetthuc.Location = new Point(29, 409);
            btKetthuc.Name = "btKetthuc";
            btKetthuc.Size = new Size(747, 36);
            btKetthuc.TabIndex = 5;
            btKetthuc.Text = "Kết thúc";
            btKetthuc.UseVisualStyleBackColor = false;
            btKetthuc.Click += btKetthuc_Click;
            // 
            // errSonguyen
            // 
            errSonguyen.ContainerControl = this;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmThaotacso
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            BackgroundImage = Properties.Resources.beautiful_natural_image_1844362_960_720;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 450);
            Controls.Add(btKetthuc);
            Controls.Add(groupBox1);
            Controls.Add(btCapNhat);
            Controls.Add(txtSoNguyen);
            Controls.Add(lb01);
            Controls.Add(lstKetQua);
            DoubleBuffered = true;
            ForeColor = SystemColors.ControlText;
            Name = "frmThaotacso";
            Text = "Thao tác số";
            FormClosing += frmThaotacso_FormClosing_1;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)errSonguyen).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstKetQua;
        private Label lb01;
        private TextBox txtSoNguyen;
        private Button btCapNhat;
        private GroupBox groupBox1;
        private Button btLecuoi;
        private Button btChonchandau;
        private Button btTang2;
        private Button btXoaphantucuoi;
        private Button btXoaphantudau;
        private Button btXoaphantudangchon;
        private Button btKetthuc;
        private ErrorProvider errSonguyen;
        private ErrorProvider errorProvider1;
    }
}
