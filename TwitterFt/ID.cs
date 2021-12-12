using System;
using Newtonsoft.Json.Linq;
using System.Windows.Forms;

namespace TwitterFt
{
    public partial class ID : Form
    {
        public ID()
        {
            InitializeComponent();
        }


        Front front = new Front();


        private void button1_Click(object sender, EventArgs e)
        {
            JObject ids = front.Get_ID_al(userID_.Text);
            reson_.Text = (string)ids["msg"];
        }


        private void ID_Load(object sender, EventArgs e)
        {
            front.Create_guest_token();
        }

    }
}
