using Newtonsoft.Json.Linq;
using System;
using System.Windows.Forms;

namespace TwitterFt
{
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }

        Front front = new Front();

        private void User_Load(object sender, EventArgs e)
        {
            front.Create_guest_token();
        }


        //取得ボタン
        private void button1_Click(object sender, EventArgs e)
        {
            JObject user_info = front.Get_user(userID.Text);
            Edit_view(user_info);
        }


        private void Edit_view(JObject users)
        {
            if (users.ToString().Contains("\"error\""))
            {
                MessageBox.Show("ユーザーが見つかりません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string icon_url = users["profile_image_url"].ToString().Replace("normal", "200x200");
            image_pic.LoadAsync(icon_url);
            name_.Text = (string)users["name"];
            location_.Text = (string)users["location"];

            if (users["entities"].ToString().Contains("\"url\":"))
                url_.Text = (string)users["entities"]["url"]["urls"][0]["expanded_url"];
            else
                url_.Text = "";
            follow_.Text = (string)users["friends_count"];
            follower_.Text = (string)users["followers_count"];
            create_.Text = (string)users["created_at"];
            tweet_.Text = (string)users["statuses_count"];
            favorite_.Text = (string)users["favourites_count"];
            decs_.Text = users["description"].ToString().Replace("\n", "\r\n");

        }

    }
}
