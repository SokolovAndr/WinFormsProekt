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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void buttonVhod_MouseEnter(object sender, EventArgs e)
        {
            buttonVhod.BackColor = Color.LightGreen;
        }

        private void buttonVhod_MouseLeave(object sender, EventArgs e)
        {
            buttonVhod.BackColor = Color.White;
        }

        private void buttonRegist_MouseEnter(object sender, EventArgs e)
        {
            buttonRegist.BackColor = Color.LightGreen;
        }

        private void buttonRegist_MouseLeave(object sender, EventArgs e)
        {
            buttonRegist.BackColor = Color.White;
        }

        private void buttonRegist_Click(object sender, EventArgs e)
        {
            //создание экземпляра класса RegisterForm и вызов новой формы.
            
            RegisterForm register = new RegisterForm();
            if (register.ShowDialog() == DialogResult.OK)
            {
                Users users = new()
                {
                    Login = register.textBoxLoginRegistr.Text,
                    Password = register.textBoxParolRegist.Text
                };
                SingleTon.DB.Users.Add(users);
                SingleTon.DB.SaveChanges();
            }
        }

        private void buttonVhod_Click(object sender, EventArgs e)
        {
            var user = SingleTon.DB.Users.Where(u => u.Login == textBoxLogin.Text && u.Password == textBoxParol.Text).FirstOrDefault();
            if (user == null)
            {
                MessageBox.Show("Пользователь не найден!");
                return;
            }
            SingleTon.User = user;
            Main main = new Main();
            //Hide();

            textBoxLogin.Text = null;
            textBoxParol.Text = null;
            main.Show();

        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            textBoxParol.UseSystemPasswordChar = false;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            textBoxParol.UseSystemPasswordChar = true;
        }
    }
}
