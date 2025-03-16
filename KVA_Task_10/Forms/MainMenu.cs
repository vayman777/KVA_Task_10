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
                ïğîäàæèToolStripMenuItem.Enabled = true;
            }
            else ïğîäàæèToolStripMenuItem.Enabled = false;
        }

        private void âûõîäToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void êîíòàêòûToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Ãîëóáèíàÿ ïî÷òà: 5 êğûøà\n Íîìåğ:À77ÌĞ/98\n Àâòîğ: Êîëîáîâ Â.À.", "Êîíòàêòû", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ïğîäàæèToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var salesForm = new SalesForm();
            salesForm.ShowDialog();
        }

        private void òîâàğûToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var goodsForm = new GoodsForm(currentUser);
            goodsForm.ShowDialog();
        }

        private void àâòîğèçàöèÿToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var auth = new Auth(this);
            auth.ShowDialog();
        }
    }
}
