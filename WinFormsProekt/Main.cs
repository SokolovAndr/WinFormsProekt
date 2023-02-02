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
using Timer = System.Windows.Forms.Timer;
using System.Diagnostics;

namespace WinFormsProekt
{
    public partial class Main : Form
    {

        Timer Timer;
        public Main()
        {
            InitializeComponent();
            LoadData();

            //Удалить комментирование после отладки кнопок Удалить и редактировать
            //Timer = new Timer();
            //Timer.Interval = 1000;
            //Timer.Tick += (s, e) => {
            //    dataGridView1.Rows.Clear();
            //    LoadData();
            //};
            //Timer.Start();

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
                    Zapros = zayavka.textBoxZapros.Text,
                    Otvet = zayavka.textBoxOtvet.Text,
                };
                SingleTon.DB.Zayavki.Add(zayavki);
                SingleTon.DB.SaveChanges();
            }
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы уверены что хотите удалить заявку?", "Удаление заявки", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                string connectString = @"Data Source=WinFormsProekt.db";

                using (SqliteConnection conn = new SqliteConnection(connectString))
                {
                    conn.Open();

                    int id = int.Parse(dataGridView1.SelectedCells[0].Value.ToString());
                    string sql = $"DELETE FROM Zayavki WHERE id = {id}";
                    SqliteCommand cmd = new SqliteCommand(sql, conn);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show($"Заявка № {id} удалена!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                Close();
            } 
        }

        private void buttonRedact_Click(object sender, EventArgs e)
        {
            {
                string connectString = "Data Source=WinFormsProekt.db;";                    //1.создание строки подключения к БД
                using (SqliteConnection myConnection = new SqliteConnection(connectString)) //2.создание экземпляра класса для подключения к БД + using
                {
                    myConnection.Open();                                                    //3.Откроем подключение
                    int id = int.Parse(dataGridView1.SelectedCells[0].Value.ToString());    //4.считали id из dataGridView по выбранной строке
                    string query = $"SELECT * FROM Zayavki WHERE Id = {id}";                 //5.запрос в БД по id Заявки
                    SqliteCommand command = new SqliteCommand(query, myConnection);         //6.создаем экземпляр класса SqlCommand и
                                                                                            //7.передаем ему в конструктор запрос и объект который устанавливает запрос с БД
                    SqliteDataReader reader = command.ExecuteReader();                      //8.создаем экземпляр клааса sqlreqder для чтения данных из БД

                    List<string[]> data = new List<string[]>();                             //9.будем читать данные из БД. Каждая строка - строковый массив
                    ZayavkaForm zayavka = new ZayavkaForm();                                //10.Инициализация формы
                    zayavka.ShowDialog();                                                   //11.Вывод формы на экрна
                    while (reader.Read())                                                   //12.Чтение и заполнение элементов на форме
                    {
                        data.Add(new string[6]);

                        //data[data.Count - 1][0] = zayavka.id;
                        data[data.Count - 1][0] = zayavka.textBox1.Text;
                        data[data.Count - 1][1] = zayavka.textBox2.Text;
                        data[data.Count - 1][2] = zayavka.comboBox1.Text;
                        data[data.Count - 1][3] = zayavka.dateTimePicker1.Text;
                        data[data.Count - 1][4] = zayavka.textBoxZapros.Text;
                        data[data.Count - 1][5] = zayavka.textBoxOtvet.Text;

                    }
                    reader.Close();
                    myConnection.Close();

                }

            }
        }
        private void LoadData()
        {
            //создание строки подключения к БД

            string connectString = "Data Source=WinFormsProekt.db;";

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
                data.Add(new string[7]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString().Remove(19); //здесь удаляем лишниме символы в строке с датой
                data[data.Count - 1][5] = reader[5].ToString();
                data[data.Count - 1][6] = reader[6].ToString();

            }
            reader.Close();
            myConnection.Close();

            foreach (string[] s in data)
            {
                dataGridView1.Rows.Add(s);
            }

            PrintTable();
        }
        private void buttonShowAll_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            LoadData();
            checkBox1.Checked = false;
        }
        private void buttonClose_Click(object sender, EventArgs e)
        {
            //Timer.Stop();
            Close();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //ZayavkaForm zayavka = new ZayavkaForm();
            //zayavka.Show();

        }
        private void PrintTable()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (Convert.ToString(row.Cells[3].Value) == "Обработано")
                {
                    row.DefaultCellStyle.BackColor = Color.LimeGreen;
                }
                if (Convert.ToString(row.Cells[3].Value) == "Не обработано")
                {
                    row.DefaultCellStyle.BackColor = Color.LightCoral;
                }
                if (Convert.ToString(row.Cells[3].Value) == "В обработке")
                {
                    row.DefaultCellStyle.BackColor = Color.LightGreen;
                }
                if (Convert.ToString(row.Cells[3].Value) == "Требуется уточнение")
                {
                    row.DefaultCellStyle.BackColor = Color.Gold;
                }
            }    
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

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                dataGridView1.Rows.Clear();
                LoadDataForCheckBox();
            }
            else
            {
                dataGridView1.Rows.Clear();
                LoadData();
            }
        }

        private void LoadDataForCheckBox()
        {
            //dataGridView1.Rows.Clear();
            //создание строки подключения к БД

            string connectString = "Data Source=WinFormsProekt.db;";

            //создание экземпляра класса для подключения к БД

            SqliteConnection myConnection = new SqliteConnection(connectString);

            //Откроем подключение

            myConnection.Open();
           
            string query = "SELECT * FROM Zayavki WHERE Status != 'Обработано'";

            //создаем экземпляр класса SqlCommand и передаем ему в конструктор запрос и объект который устанавливает запрос с БД

            SqliteCommand command = new SqliteCommand(query, myConnection);

            //создаем экземпляр клааса sqlreqder для чтения данных из БД

            SqliteDataReader reader = command.ExecuteReader(); // метод ExecuteReader объекта command

            //создаем список List элементами которого будет строковый массив

            List<string[]> data = new List<string[]>(); //будем читать данные из БД. Каждая строка - строковый массив 

            while (reader.Read())
            {
                data.Add(new string[7]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString().Remove(19); //здесь удаляем лишниме символы в строке с датой
                data[data.Count - 1][5] = reader[5].ToString();
                data[data.Count - 1][6] = reader[6].ToString();

            }
            reader.Close();
            myConnection.Close();

            foreach (string[] s in data)
            {
                dataGridView1.Rows.Add(s);
            }

            PrintTable();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                VisitMyGitHub();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open link that was clicked.");
            }
        }

        private void VisitMyGitHub()
        {
            linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("IExplore.exe", "http://github.com/SokolovAndr");
        }


        //Цветовая индикация кнопок конец
    }
}
