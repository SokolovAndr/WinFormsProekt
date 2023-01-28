using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsProekt
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void buttonOk_MouseEnter(object sender, EventArgs e)
        {
            buttonOk.BackColor = Color.LightGreen;
        }

        private void buttonOk_MouseLeave(object sender, EventArgs e)
        {
            buttonOk.BackColor = Color.White;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (SingleTon.DB.Users.Where(u => u.Login == textBoxLoginRegistr.Text).Count() > 0)
            {
                MessageBox.Show("Логин занят!");
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
