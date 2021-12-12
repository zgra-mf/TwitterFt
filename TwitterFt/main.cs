using System;
using System.Windows.Forms;

namespace TwitterFt
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }


        private void ユーザー情報ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.MdiParent = this;
            user.Show();
        }


        private void main_Load(object sender, EventArgs e)
        {

        }

        private void iD使用確認ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ID iD = new ID();
            iD.MdiParent = this;
            iD.Show();
        }


        private void 検索ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search search = new Search();
            search.MdiParent = this;
            search.Show();
        }
    }
}
