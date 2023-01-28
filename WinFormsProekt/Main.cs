using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using WinFormsProekt.Models;

namespace WinFormsProekt
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSozdat_Click(object sender, EventArgs e)
        {
            ZayavkaForm zayavka = new ZayavkaForm();
            if(zayavka.ShowDialog() == DialogResult.OK)
            {
                Zayavki zayavki = new()
                {
                    Client = zayavka.textBox1.Text,
                    Postavchik = zayavka.textBox2.Text,
                    Status = zayavka.comboBox1.Text,
                    Date = DateTime.Now,
                };
                SingleTon.DB.Zayavki.Add(zayavki);
                SingleTon.DB.SaveChanges();
            }
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {

        }

        //Цветовая индикация кнопок начало
        private void buttonSozdat_MouseEnter(object sender, EventArgs e)
        {
            buttonSozdat.BackColor = Color.LightGreen;
        }
        private void buttonSozdat_MouseLeave(object sender, EventArgs e)
        {
            buttonSozdat.BackColor = Color.White;
        }
        private void buttonDelete_MouseEnter(object sender, EventArgs e)
        {
            buttonDelete.BackColor = Color.LightGreen;
        }
        private void buttonDelete_MouseLeave(object sender, EventArgs e)
        {
            buttonDelete.BackColor = Color.White;
        }
        private void buttonClose_MouseEnter(object sender, EventArgs e)
        {
            buttonClose.BackColor = Color.LightGreen;
        }
        private void buttonClose_MouseLeave(object sender, EventArgs e)
        {
            buttonClose.BackColor = Color.White;
        }
        private void buttonRedact_MouseEnter(object sender, EventArgs e)
        {
            buttonRedact.BackColor = Color.LightGreen;
        }
        private void buttonRedact_MouseLeave(object sender, EventArgs e)
        {
            buttonRedact.BackColor = Color.White;
        }
        //Цветовая индикация кнопок конец
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
