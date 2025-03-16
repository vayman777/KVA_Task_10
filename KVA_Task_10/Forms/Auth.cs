using KVA_Task_10.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

namespace KVA_Task_10.Forms
{
    public partial class Auth : Form
    {
        private MainMenu _mainMenu;
        public Auth(MainMenu mainMenu)
        {
            _mainMenu = mainMenu;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new AuctionDbContext())
                {
                    var users = db.Users.AsNoTracking().ToList();
                    User? user = users.FirstOrDefault(p => p.Login == textBox1.Text && p.Password == textBox2.Text);
                    if (user != null)
                    {
                        _mainMenu.currentUser = user;
                        _mainMenu.EnabledButtonSells();
                        this.Hide();

                    }
                    else
                        MessageBox.Show("Неверный логин или пароль.Попробуйте ещё раз", "Ошибка", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
            }
            catch (System.InvalidOperationException)
            {
                MessageBox.Show("Не подключена БД", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
