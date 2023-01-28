using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using WinFormsProekt.Models;

namespace WinFormsProekt
{
    public partial class ZayavkaForm : Form
    {
        public ZayavkaForm()
        {
            InitializeComponent();

            comboBox1.Items.Add("Не обработано");
            comboBox1.Items.Add("В обработке");
            comboBox1.Items.Add("Обработано");
            comboBox1.Items.Add("Требуется уточнение");
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (SingleTon.DB.Zayavki.Where(u => u.Client == textBox1.Text).Count() > 0)
            {
                MessageBox.Show("Имя клиента занято!");
                return;
            }
            if (SingleTon.DB.Zayavki.Where(u => u.Postavchik == textBox2.Text).Count() > 0)
            {
                MessageBox.Show("Имя поставщик занято!");
                return;
            }
           
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
