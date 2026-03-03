namespace Lab08_studnetMS
{
    partial class frmKhoa
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
            label1 = new Label();
            label2 = new Label();
            txtMaKhoa = new TextBox();
            txtTenKhoa = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(68, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã Khoa";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 42);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 1;
            label2.Text = "Tên Khoa";
            // 
            // txtMaKhoa
            // 
            txtMaKhoa.Location = new Point(108, 6);
            txtMaKhoa.Name = "txtMaKhoa";
            txtMaKhoa.Size = new Size(287, 27);
            txtMaKhoa.TabIndex = 2;
            // 
            // txtTenKhoa
            // 
            txtTenKhoa.Location = new Point(108, 42);
            txtTenKhoa.Name = "txtTenKhoa";
            txtTenKhoa.Size = new Size(287, 27);
            txtTenKhoa.TabIndex = 3;
            // 
            // frmKhoa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(478, 469);
            Controls.Add(txtTenKhoa);
            Controls.Add(txtMaKhoa);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmKhoa";
            Text = "Danh Mục Khoa";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtMaKhoa;
        private TextBox txtTenKhoa;
    }
}