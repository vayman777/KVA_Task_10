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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KVA_Task_10.Forms
{
    public partial class AddGoodsForm : Form
    {
        private GoodsForm _goodsForm;
        public AddGoodsForm(GoodsForm goodsForm)
        {
            _goodsForm = goodsForm;
            InitializeComponent();
            LoadCategoryInComboBox();
        }
        private async void LoadCategoryInComboBox()
        {
            using var context = new AuctionDbContext();
            var categoryList = await context.TypeItems.ToArrayAsync();
            comboBox1.Items.AddRange(categoryList);
            comboBox1.SelectedIndex = 0;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using AuctionDbContext dbContext = new AuctionDbContext();
            var currentCategory = dbContext.TypeItems.FirstOrDefault(c => c.Name == comboBox1.Text);
            if (currentCategory == null)
                MessageBox.Show("sdfd");

            var newGood = new Item
            {
                Name = textBox1.Text,
                EstimatedPrice = Convert.ToDouble(numericUpDown1.Value),
                Description = textBox2.Text,
                TypeItemId = currentCategory.Id,
                DateCreate = DateTime.Now,
                OwnerItemId = _goodsForm._currentUser.Id,
            };

            dbContext.Items.Add(newGood);
            dbContext.SaveChanges();
            _goodsForm.UpdateData();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
