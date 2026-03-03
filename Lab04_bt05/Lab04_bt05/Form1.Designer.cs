namespace Lab04_bt05
{
    partial class frmQuanlysinhvien
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
            txtHoten = new MaskedTextBox();
            btCapnhat = new Button();
            groupBox1 = new GroupBox();
            lstBandau = new ListBox();
            groupBox2 = new GroupBox();
            lstKetqua = new ListBox();
            btTraisangphai = new Button();
            btPhaisangtrai = new Button();
            btTatcatraisangphai = new Button();
            btTatcaphaisangtrai = new Button();
            btXoa = new Button();
            btKetthuc = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(240, 19);
            label1.Name = "label1";
            label1.Size = new Size(277, 38);
            label1.TabIndex = 0;
            label1.Text = "Danh sách sinh viên";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.UseMnemonic = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 87);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 1;
            label2.Text = "Họ và tên";
            // 
            // txtHoten
            // 
            txtHoten.Location = new Point(155, 80);
            txtHoten.Name = "txtHoten";
            txtHoten.Size = new Size(362, 27);
            txtHoten.TabIndex = 2;
            // 
            // btCapnhat
            // 
            btCapnhat.Location = new Point(539, 39);
            btCapnhat.Name = "btCapnhat";
            btCapnhat.Size = new Size(94, 68);
            btCapnhat.TabIndex = 3;
            btCapnhat.Text = "Cập nhật";
            btCapnhat.UseVisualStyleBackColor = true;
            btCapnhat.Click += btCapnhat_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lstBandau);
            groupBox1.Location = new Point(12, 131);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(236, 231);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lớp A";
            // 
            // lstBandau
            // 
            lstBandau.FormattingEnabled = true;
            lstBandau.Location = new Point(27, 31);
            lstBandau.Name = "lstBandau";
            lstBandau.Size = new Size(190, 184);
            lstBandau.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lstKetqua);
            groupBox2.Location = new Point(521, 131);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(250, 231);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Lớp B";
            // 
            // lstKetqua
            // 
            lstKetqua.FormattingEnabled = true;
            lstKetqua.Location = new Point(30, 31);
            lstKetqua.Name = "lstKetqua";
            lstKetqua.Size = new Size(190, 184);
            lstKetqua.TabIndex = 1;
            // 
            // btTraisangphai
            // 
            btTraisangphai.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btTraisangphai.Location = new Point(273, 204);
            btTraisangphai.Name = "btTraisangphai";
            btTraisangphai.Size = new Size(94, 48);
            btTraisangphai.TabIndex = 6;
            btTraisangphai.Text = ">";
            btTraisangphai.UseVisualStyleBackColor = true;
            btTraisangphai.Click += btTraisangphai_Click;
            // 
            // btPhaisangtrai
            // 
            btPhaisangtrai.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btPhaisangtrai.Location = new Point(399, 204);
            btPhaisangtrai.Name = "btPhaisangtrai";
            btPhaisangtrai.Size = new Size(94, 48);
            btPhaisangtrai.TabIndex = 7;
            btPhaisangtrai.Text = "<";
            btPhaisangtrai.UseVisualStyleBackColor = true;
            btPhaisangtrai.Click += btPhaisangtrai_Click;
            // 
            // btTatcatraisangphai
            // 
            btTatcatraisangphai.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btTatcatraisangphai.Location = new Point(273, 282);
            btTatcatraisangphai.Name = "btTatcatraisangphai";
            btTatcatraisangphai.Size = new Size(94, 48);
            btTatcatraisangphai.TabIndex = 8;
            btTatcatraisangphai.Text = ">>";
            btTatcatraisangphai.UseVisualStyleBackColor = true;
            btTatcatraisangphai.Click += btTatcatraisangphai_Click;
            // 
            // btTatcaphaisangtrai
            // 
            btTatcaphaisangtrai.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btTatcaphaisangtrai.Location = new Point(399, 282);
            btTatcaphaisangtrai.Name = "btTatcaphaisangtrai";
            btTatcaphaisangtrai.Size = new Size(94, 48);
            btTatcaphaisangtrai.TabIndex = 9;
            btTatcaphaisangtrai.Text = "<<";
            btTatcaphaisangtrai.UseVisualStyleBackColor = true;
            btTatcaphaisangtrai.Click += btTatcaphaisangtrai_Click;
            // 
            // btXoa
            // 
            btXoa.Location = new Point(74, 378);
            btXoa.Name = "btXoa";
            btXoa.Size = new Size(100, 46);
            btXoa.TabIndex = 10;
            btXoa.Text = "Xóa";
            btXoa.UseVisualStyleBackColor = true;
            // 
            // btKetthuc
            // 
            btKetthuc.Location = new Point(589, 378);
            btKetthuc.Name = "btKetthuc";
            btKetthuc.Size = new Size(100, 46);
            btKetthuc.TabIndex = 11;
            btKetthuc.Text = "Kết thúc";
            btKetthuc.UseVisualStyleBackColor = true;
            // 
            // frmQuanlysinhvien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 450);
            Controls.Add(btKetthuc);
            Controls.Add(btXoa);
            Controls.Add(btTatcaphaisangtrai);
            Controls.Add(btTatcatraisangphai);
            Controls.Add(btPhaisangtrai);
            Controls.Add(btTraisangphai);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btCapnhat);
            Controls.Add(txtHoten);
            Controls.Add(label2);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "frmQuanlysinhvien";
            Text = "Quản lý sinh viên";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private MaskedTextBox txtHoten;
        private Button btCapnhat;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btTraisangphai;
        private Button btPhaisangtrai;
        private Button btTatcatraisangphai;
        private Button btTatcaphaisangtrai;
        private Button btXoa;
        private Button btKetthuc;
        private ListBox lstBandau;
        private ListBox lstKetqua;
    }
}
