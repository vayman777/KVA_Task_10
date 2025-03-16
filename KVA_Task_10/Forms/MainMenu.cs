using KVA_Task_10.Models;
using KVA_Task_10.Forms;

namespace KVA_Task_10
{
    public partial class MainMenu : Form
    {
        public User currentUser;
        public MainMenu()
        {
            InitializeComponent();
        }
        public void EnabledButtonSells()
        {
            if (currentUser != null)
            {
                �������ToolStripMenuItem.Enabled = true;
            }
            else �������ToolStripMenuItem.Enabled = false;
        }

        private void �����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ��������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" ��������� �����: 5 �����\n �����:�77��/98\n �����: ������� �.�.", "��������", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void �������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var salesForm = new SalesForm();
            salesForm.ShowDialog();
        }

        private void ������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var goodsForm = new GoodsForm(currentUser);
            goodsForm.ShowDialog();
        }

        private void �����������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var auth = new Auth(this);
            auth.ShowDialog();
        }
    }
}
