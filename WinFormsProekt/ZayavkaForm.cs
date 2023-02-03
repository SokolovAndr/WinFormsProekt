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
using Microsoft.Data.Sqlite;

namespace WinFormsProekt
{
    public partial class ZayavkaForm : Form
    {
        public ZayavkaForm()
        {
            InitializeComponent();
            ZapolnenieComboBoxov();
        }

        private void ZapolnenieComboBoxov()
        {
            comboBox1.Items.Add("Не обработано");
            comboBox1.Items.Add("В обработке");
            comboBox1.Items.Add("Обработано");
            comboBox1.Items.Add("Требуется уточнение");

            string sqlExpression = "SELECT Name FROM Kontragents";
            using (var connection = new SqliteConnection("Data Source=WinFormsProekt.db;"))
            {
                connection.Open();
                SqliteCommand command = new SqliteCommand(sqlExpression, connection);
                using (SqliteDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows) // если есть данные
                    {
                        while (reader.Read())   // построчно считываем данные
                        {
                            comboBoxKontr.Items.Add(reader.GetValue(0));
                            comboBoxKontr2.Items.Add(reader.GetValue(0));
                        }
                    }
                }
                connection.Close();
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
          
            DialogResult = DialogResult.OK;
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KontragentForm kontragent = new KontragentForm();
            if (kontragent.ShowDialog() == DialogResult.OK)
            {
                Kontragents kontragents = new()
                {
                    Name = kontragent.textBoxKontragent.Text
                };
                SingleTon.DB.Kontragents.Add(kontragents);
                SingleTon.DB.SaveChanges();
            }
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackColor = Color.LightGreen;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.White;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.LightGreen;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;
        }
        
        private void buttonSave_MouseEnter(object sender, EventArgs e)
        {
            buttonSave.BackColor = Color.LightGreen;
        }

        private void buttonSave_MouseLeave(object sender, EventArgs e)
        {
            buttonSave.BackColor = Color.White;
        }

        private void comboBoxKontr_SelectedValueChanged(object sender, EventArgs e)
        {
            string vybor = comboBoxKontr.SelectedItem.ToString();
            textBox1.Text = vybor;
        }

        private void comboBoxKontr2_SelectedValueChanged(object sender, EventArgs e)
        {
            string vybor = comboBoxKontr2.SelectedItem.ToString();
            textBox2.Text = vybor;
        }

        private void buttonSaceChanges_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
