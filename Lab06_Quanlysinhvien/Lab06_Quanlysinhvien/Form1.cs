namespace Lab06_Quanlysinhvien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        bool KiemTraMaSV(string ma)
        {
            for (int i = 0; i < lvSinhvien.Items.Count; i++)
            {
                if (lvSinhvien.Items[i].SubItems[2].Text.Trim() == ma)
                {
                    return false;
                }
            }
            for (int i = 0; i < lvDachon.Items.Count; i++)
            {
                if (lvDachon.Items[i].SubItems[2].Text.Trim() == ma)
                {
                    return false;
                }
            }
            return true;
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (txtMaSV.Text.Trim() == "" || txtHoten.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin sinh viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (KiemTraMaSV(txtMaSV.Text.Trim()) == false)
            {
                MessageBox.Show("Mã số sinh viên đã tồn tại, vui lòng nhập lại!");
                txtMaSV.SelectAll();
                txtMaSV.Focus();
            }

            else
            {
                int stt = lvSinhvien.Items.Count + 1;
                ListViewItem li = new ListViewItem(stt.ToString());
                li.SubItems.Add(txtMaSV.Text.Trim());
                li.SubItems.Add(txtHoten.Text.Trim());

                lvSinhvien.Items.Add(li);
                txtMaSV.Text = "";
                txtHoten.Text = "";
                txtMaSV.Focus();
            }

        }

        private void btClear_Click(object sender, EventArgs e)
        {
            int i = 0;
            while (i < lvSinhvien.Items.Count)
            {
                if (lvSinhvien.Items[i].Selected == true)
                {
                    lvSinhvien.Items.RemoveAt(i);
                }
                else
                {
                    i++;
                }
                danhSoThuTu(lvSinhvien);
            }
        }
        private void danhSoThuTu(ListView lv)
        {
            for (int i = 0; i < lv.Items.Count; i++)
            {
                lv.Items[i].Text = (i + 1).ToString();
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("bạn muốn thoát à!", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 5; i++)
            {
                ListViewItem li = new ListViewItem(i.ToString());
                li.SubItems.Add("SV" + i);
                li.SubItems.Add("Nguyễn Văn " + i);
                lvSinhvien.Items.Add(li);
            }
        }
        private void tim(ListView lv, string text)
        {
            text = text.ToUpper();
            for (int i = 0; i < lv.Items.Count; i++)
            {
                string maSV = lv.Items[i].SubItems[1].Text.ToUpper();
                string hoTen = lv.Items[i].SubItems[2].Text.ToUpper();
                if (maSV.Contains(text) || hoTen.Contains(text))
                {
                    lv.Items[i].Selected = true;
                    lv.Items[i].EnsureVisible();
                    lv.Items[i].Focused = true;
                }
                else
                {
                    lv.Items[i].Selected = false;
                }
            }
        }
        private void thucHienTim()
        {
            tim(lvSinhvien, txtTimKiem.Text);
            txtTimKiem.SelectAll();
            txtTimKiem.Focus();
        }

        private void txtTimKiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                thucHienTim();
            }
        }

        private void btTim_Click(object sender, EventArgs e)
        {
            thucHienTim();
        }

        private void btChon_Click(object sender, EventArgs e)
        {
            int i = 0;
            while (i < lvSinhvien.Items.Count)
            {
                if (lvSinhvien.Items[i].Selected == true)
                {
                    ListViewItem li = lvSinhvien.Items[i];
                    lvSinhvien.Items.RemoveAt(i);
                    lvDachon.Items.Add(li);
                }
                else
                {
                    i++;
                }
                danhSoThuTu(lvSinhvien);
            }
        }

        private void btTrave_Click(object sender, EventArgs e)
        {
            int i = 0;
            while (i < lvDachon.Items.Count)
            {
                if (lvDachon.Items[i].Selected == true)
                {
                    ListViewItem li = lvDachon.Items[i];
                    lvDachon.Items.RemoveAt(i);
                    lvSinhvien.Items.Add(li);
                }
                else
                {
                    i++;
                }
                danhSoThuTu(lvDachon);
            }
        }
    }
}
