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
    public partial class AddSalesForm : Form
    {
        private SalesForm _salesForm;
        public AddSalesForm(SalesForm salesForm)
        {
            _salesForm = salesForm;
            InitializeComponent();
            LoadCategoryInComboBox();
            LoadUsersInComboBox();
        }

        private async void LoadCategoryInComboBox()
        {
            using var context = new AuctionDbContext();
            var categoryList = await context.Items.ToArrayAsync();
            comboBox1.Items.AddRange(categoryList);
            comboBox1.SelectedIndex = 0;

        }

        private async void LoadUsersInComboBox()
        {
            using var context = new AuctionDbContext();
            var usersList = await context.Users.ToArrayAsync();
            comboBox2.Items.AddRange(usersList);
            comboBox2.SelectedIndex = 0;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using AuctionDbContext dbContext = new AuctionDbContext();
            var currentItem = dbContext.Items.FirstOrDefault(c => c.Name == comboBox1.Text);
            var currentBuyer = dbContext.Users.FirstOrDefault(c => c.Name == comboBox2.Text);
            if (currentItem == null)
                MessageBox.Show("Неверная категория");

            var newSale = new Sale
            {
                ItemId = currentItem.Id,
                StartPrice = Convert.ToDouble(numericUpDown1.Value),
                EndPrice = Convert.ToDouble(numericUpDown2.Value),
                StartSale = DateTime.Now,
                BuyerId = currentBuyer.Id,
            };

            dbContext.Sales.Add(newSale);
            dbContext.SaveChanges();
            _salesForm.UpdateData();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown2.Minimum = numericUpDown1.Value;
        }
    }
}
