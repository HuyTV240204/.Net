using System.Windows.Forms;

namespace Lab04_bt04
{
    public partial class frmThaotacso : Form
    {
        public frmThaotacso()
        {
            InitializeComponent();
        }

        private void txtSoNguyen_TextChanged(object sender, EventArgs e)
        {
            Control ctrSonguyen = (Control)sender;
            if (ctrSonguyen.Text.Length > 0)
                if (!char.IsDigit(ctrSonguyen.Text[ctrSonguyen.Text.Length - 1]))
                    this.errSonguyen.SetError(ctrSonguyen, "Vui lòng nhập số nguyên");
                else
                    this.errSonguyen.Clear();

        }

        private void btKetthuc_Click(object sender, EventArgs e)
        {

        }


        private void btCapNhat_Click(object sender, EventArgs e)
        {
            lstKetQua.Items.Add(txtSoNguyen.Text);
            txtSoNguyen.Text = "";
            txtSoNguyen.Focus();
        }

        
        private void lstKetQua_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmThaotacso_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                e.Cancel = true;
        }

        private void btLecuoi_Click(object sender, EventArgs e)
        {
            int n = lstKetQua.Items.Count; //Số mục trong lst
            for (int i = n - 1; i >= 0; i--)
            {
                if (int.Parse(lstKetQua.Items[i].ToString()) % 2 == 1)
                {
                    string s = lstKetQua.Items[i].ToString();//Lay gia tri muc gia tri lẻ
                    lstKetQua.SelectedItem = s;//Chon muc co gia tri le
                    break; //Thuc hien duoc so le dau (tu duoi len) thi ket thuc vong lap
                }
            }
        }
        private void btXoaphantudangchon_Click(object sender, EventArgs e)
        {
            int n = lstKetQua.SelectedItems.Count; //Số mục dang duoc chon trong lstKetqua
            for (int i = n - 1; i >= 0; i--)
                lstKetQua.Items.Remove(lstKetQua.SelectedItems[i].ToString());

        }
        private void btXoaphantudau_Click(object sender, EventArgs e)
        {
            lstKetQua.Items.Remove(lstKetQua.Items[0].ToString());
        }
        private void btXoaphantucuoi_Click(object sender, EventArgs e)
        {
            int n = lstKetQua.Items.Count;
            lstKetQua.Items.Remove(lstKetQua.Items[n - 1].ToString());
        }

        private void btTang2_Click(object sender, EventArgs e)
        {
            int n = lstKetQua.Items.Count;
            for (int i = 0; i < n; i++)
            {
                int tam = int.Parse(lstKetQua.Items[i].ToString()) + 2;
                lstKetQua.Items.RemoveAt(i);
                lstKetQua.Items.Insert(i, tam.ToString());
            }
        }

        private void btChonchandau_Click_1(object sender, EventArgs e)
        {
            int n = lstKetQua.Items.Count;
            for (int i = 0; i < n; i++)
            {
                if (int.Parse(lstKetQua.Items[i].ToString()) % 2 == 0)
                {
                    string s = lstKetQua.Items[i].ToString();
                    lstKetQua.SelectedItem = s;
                    break;
                }
            }
        }
    }
}
