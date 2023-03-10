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
using System.Diagnostics;
using System.Data.SqlClient;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace WinFormsProekt
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            LoadData();
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
            dataGridView1.Rows.Clear();
            LoadData();
            checkBox1.Checked = false;
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

                dataGridView1.Rows.Clear();
                LoadData();
                checkBox1.Checked = false;
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            } 
        }
        private void buttonRedact_Click(object sender, EventArgs e)
        {
            //DialogResult dialogResult = MessageBox.Show("Вы уверены что хотите изменить заявку?", "Изменение заявки", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            //if (dialogResult == DialogResult.Yes)
            //{
            //    string connectString = "Data Source=WinFormsProekt.db;";                    //1.создание строки подключения к БД
            //    using (SqliteConnection myConnection = new SqliteConnection(connectString)) //2.создание экземпляра класса для подключения к БД + using
            //    {
            //        myConnection.Open();                                                    //3.Откроем подключение
            //        int id = int.Parse(dataGridView1.SelectedCells[0].Value.ToString());    //4.считали id из dataGridView по выбранной строке
            //        string query = $"SELECT * FROM Zayavki WHERE Id = {id}";                 //5.запрос в БД по id Заявки
            //        SqliteCommand command = new SqliteCommand(query, myConnection);         //6.создаем экземпляр класса SqlCommand и
            //                                                                                //7.передаем ему в конструктор запрос и объект который устанавливает запрос с БД
            //        SqliteDataReader reader = command.ExecuteReader();                      //8.создаем экземпляр клааса sqlreqder для чтения данных из БД

            //        List<string[]> data = new List<string[]>();                             //9.будем читать данные из БД. Каждая строка - строковый массив
            //        ZayavkaForm zayavka = new ZayavkaForm();                                //10.Инициализация формы
            //                                                                                //11.Вывод формы на экрна
            //        while (reader.Read())                                                   //12.Чтение и заполнение элементов на форме
            //        {
            //            data.Add(new string[7]);

            //            data[data.Count - 1][0] = reader[0].ToString();
            //            data[data.Count - 1][1] = reader[1].ToString();
            //            data[data.Count - 1][2] = reader[2].ToString();
            //            data[data.Count - 1][3] = reader[3].ToString();
            //            data[data.Count - 1][4] = reader[4].ToString();
            //            data[data.Count - 1][5] = reader[5].ToString();
            //            data[data.Count - 1][6] = reader[6].ToString();

            //        }
            //        reader.Close();
            //        myConnection.Close();

            //        foreach (string[] s in data)
            //        {
            //            zayavka.label5.Text = s[0];
            //            zayavka.textBox1.Text = s[1];
            //            zayavka.comboBoxKontr.Text = s[1];
            //            zayavka.textBox2.Text = s[2];
            //            zayavka.comboBoxKontr2.Text = s[2];
            //            zayavka.comboBox1.Text = s[3];
            //            zayavka.dateTimePicker1.Text = s[4];
            //            zayavka.textBoxZapros.Text = s[6];
            //            zayavka.textBoxOtvet.Text = s[5];
            //        }

            //        zayavka.ShowDialog();

            //        using (SqliteConnection myConnection2 = new SqliteConnection(connectString))
            //        {
            //            try
            //            {
            //                myConnection2.Open();

            //                string sql = $"UPDATE Zayavki SET " +
            //                    $"Client = @nameParam, " +
            //                    $"Postavchik = @nameParam2," +
            //                    $"Status = @nameParam3," +
            //                    $"Zapros = @nameParam4," +
            //                    $"Otvet =  @nameParam5 WHERE id = {id}";

            //                SqliteCommand command2 = new SqliteCommand(sql, myConnection2);

            //                SqliteParameter nameParam = new SqliteParameter("@nameParam", zayavka.textBox1.Text);
            //                command2.Parameters.Add(nameParam);

            //                SqliteParameter nameParam2 = new SqliteParameter("@nameParam2", zayavka.textBox2.Text);
            //                command2.Parameters.Add(nameParam2);

            //                SqliteParameter nameParam3 = new SqliteParameter("@nameParam3", zayavka.comboBox1.Text);
            //                command2.Parameters.Add(nameParam3);

            //                SqliteParameter nameParam4 = new SqliteParameter("@nameParam4", zayavka.textBoxZapros.Text);
            //                command2.Parameters.Add(nameParam4);

            //                SqliteParameter nameParam5 = new SqliteParameter("@nameParam5", zayavka.textBoxOtvet.Text);
            //                command2.Parameters.Add(nameParam5);

            //                command2.ExecuteNonQuery();

            //                MessageBox.Show($"Заявка № {id} изменена!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //                myConnection2.Close();
            //            }
            //            catch (Exception ex)
            //            {
            //                MessageBox.Show(ex.Message);
            //            }
            //        }
            //    }

            //    dataGridView1.Rows.Clear();
            //    LoadData();
            //    checkBox1.Checked = false;

            //}
            //else if (dialogResult == DialogResult.No)
            //{
            //    return;
            //}
            Change();
        }

        private void Change()
        {
            DialogResult dialogResult = MessageBox.Show("Вы уверены что хотите изменить заявку?", "Изменение заявки", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
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
                                                                                            //11.Вывод формы на экрна
                    while (reader.Read())                                                   //12.Чтение и заполнение элементов на форме
                    {
                        data.Add(new string[7]);

                        data[data.Count - 1][0] = reader[0].ToString();
                        data[data.Count - 1][1] = reader[1].ToString();
                        data[data.Count - 1][2] = reader[2].ToString();
                        data[data.Count - 1][3] = reader[3].ToString();
                        data[data.Count - 1][4] = reader[4].ToString();
                        data[data.Count - 1][5] = reader[5].ToString();
                        data[data.Count - 1][6] = reader[6].ToString();

                    }
                    reader.Close();
                    myConnection.Close();

                    foreach (string[] s in data)
                    {
                        zayavka.label5.Text = s[0];
                        zayavka.textBox1.Text = s[1];
                        zayavka.comboBoxKontr.Text = s[1];
                        zayavka.textBox2.Text = s[2];
                        zayavka.comboBoxKontr2.Text = s[2];
                        zayavka.comboBox1.Text = s[3];
                        zayavka.dateTimePicker1.Text = s[4];
                        zayavka.textBoxZapros.Text = s[6];
                        zayavka.textBoxOtvet.Text = s[5];
                    }

                    zayavka.ShowDialog();

                    using (SqliteConnection myConnection2 = new SqliteConnection(connectString))
                    {
                        try
                        {
                            myConnection2.Open();

                            string sql = $"UPDATE Zayavki SET " +
                                $"Client = @nameParam, " +
                                $"Postavchik = @nameParam2," +
                                $"Status = @nameParam3," +
                                $"Zapros = @nameParam4," +
                                $"Otvet =  @nameParam5 WHERE id = {id}";

                            SqliteCommand command2 = new SqliteCommand(sql, myConnection2);

                            SqliteParameter nameParam = new SqliteParameter("@nameParam", zayavka.textBox1.Text);
                            command2.Parameters.Add(nameParam);

                            SqliteParameter nameParam2 = new SqliteParameter("@nameParam2", zayavka.textBox2.Text);
                            command2.Parameters.Add(nameParam2);

                            SqliteParameter nameParam3 = new SqliteParameter("@nameParam3", zayavka.comboBox1.Text);
                            command2.Parameters.Add(nameParam3);

                            SqliteParameter nameParam4 = new SqliteParameter("@nameParam4", zayavka.textBoxZapros.Text);
                            command2.Parameters.Add(nameParam4);

                            SqliteParameter nameParam5 = new SqliteParameter("@nameParam5", zayavka.textBoxOtvet.Text);
                            command2.Parameters.Add(nameParam5);

                            command2.ExecuteNonQuery();

                            MessageBox.Show($"Заявка № {id} изменена!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            myConnection2.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }

                dataGridView1.Rows.Clear();
                LoadData();
                checkBox1.Checked = false;

            }
            else if (dialogResult == DialogResult.No)
            {
                return;
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
        
        #region "ZalivkaKnopok"
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
        #endregion

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Change();
        }
    }
}
