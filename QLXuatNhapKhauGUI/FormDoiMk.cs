using QLXuatNhapKhau;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using DAL;

namespace QLXuatNhapKhauGUI
{
    public partial class FormDoiMk : Form
    {
        public FormDoiMk()
        {
            InitializeComponent();
        }

        private void FormDoiMk_Load(object sender, EventArgs e)
        {
            textUserName.Text = UserInfo.Username;
        }
        UserAccountRepositoryDoiMK doimk = new UserAccountRepositoryDoiMK();
        private void checkMK_CheckedChanged(object sender, EventArgs e)
        {
            if (checkMK.Checked)
            {
                textMK.PasswordChar = '\0';
                textXacNhanMK.PasswordChar = '\0';
            }
            else
            {
                textMK.PasswordChar = '*';
                textXacNhanMK.PasswordChar = '*';
            }
        }
        

        private void buttonHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textMK.Text) || string.IsNullOrEmpty(textXacNhanMK.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            if (textMK.Text == textXacNhanMK.Text) 
            {
                doimk.UpdatePassword(textUserName.Text, textMK.Text);
                MessageBox.Show("Đổi mật khẩu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else 
            {
                MessageBox.Show("Xác nhận mật khẩu không đúng !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
