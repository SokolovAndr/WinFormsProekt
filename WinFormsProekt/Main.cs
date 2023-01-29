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
using Microsoft.Data.Sqlite;

namespace WinFormsProekt
{
    public partial class Main : Form
    {
        

        public Main()
        {
            InitializeComponent();
            LoadData();
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
        private void buttonShowAll_MouseEnter(object sender, EventArgs e)
        {
            buttonShowAll.BackColor = Color.LightGreen;
        }

        private void buttonShowAll_MouseLeave(object sender, EventArgs e)
        {
            buttonShowAll.BackColor = Color.White;
        }

        //Цветовая индикация кнопок конец

        private void buttonShowAll_Click(object sender, EventArgs e)
        {
     
        }

        private void LoadData()
        {
            //создание строки подключения к БД

            
            //string connectString = "Data Source=MSSqlLocalDB; Integrated Security=True";

            string connectString = "Data Source=WinFormsProekt.db;";

            //Server=(localdb)\mssqllocaldb;Database=Blogging;Trusted_Connection=True;

            //создание экземпляра класса для подключения к БД

            SqliteConnection myConnection = new SqliteConnection(connectString);
        
            //Откроем подключение

            myConnection.Open();

            string query = "SELECT * FROM Zayavki ORDER BY Id";

            //создаем экземпляр класса SqlCommand и передаем ему в конструктор запрос и объект который устанавливает запрос с БД

            SqliteCommand command = new SqliteCommand(query, myConnection);
        
            //создаем экземпляр клааса sqlreqder для чтения данных из БД

            SqliteDataReader reader = command.ExecuteReader(); // метод ExecuteReader объекта command

            //создаем список List элементами которого будет строковый массив

            List<string[]> data = new List<string[]>(); //будем читать данные из БД. Каждая строка - строковый массив 
        
            while (reader.Read())
            {
                data.Add(new string[5]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();

            }
            reader.Close();
            myConnection.Close();

            foreach (string[] s in data)
            {
                dataGridView1.Rows.Add(s);
            }
        }


    }
}
