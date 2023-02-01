using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsProekt.Models;

namespace WinFormsProekt
{
    public partial class KontragentForm : Form
    {
        public KontragentForm()
        {
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (SingleTon.DB.Kontragents.Where(u => u.Name == textBoxKontragent.Text).Count() > 0)
            {
                //MessageBox.Show("Название организации занято!");
                MessageBox.Show($"Название организации занято!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                //MessageBox.Show("Вы успешно создали контрагента!");
                MessageBox.Show($"Вы успешно создали контрагента!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonOk_MouseEnter(object sender, EventArgs e)
        {
            buttonOk.BackColor = Color.LightGreen;
        }

        private void buttonOk_MouseLeave(object sender, EventArgs e)
        {
            buttonOk.BackColor = Color.White;
        }
    }
}
