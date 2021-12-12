using System;
using Newtonsoft.Json.Linq;
using System.Windows.Forms;
using System.Collections.Generic;

namespace TwitterFt
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        Front front = new Front();
        public List<string> url_ = new List<string>();


        private void search_Load(object sender, EventArgs e)
        {
            front.Create_guest_token();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            respo_.Items.Clear();
            url_.Clear();
            var texts = new List<string>();
            var namess = new List<string>();
            JObject tweet = null;
            
            if (modes_.SelectedIndex == 0)
                tweet = front.Get_tweets(searchT_.Text);
            else
                tweet = front.Get_search(searchT_.Text);

            if (tweet == null)
            {
                MessageBox.Show("ユーザーが見つかりません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            foreach (var tweets in tweet["globalObjects"]["tweets"])
            {
                foreach (var tweets1 in tweets)
                {
                    string id_st = (string)tweets1["user_id_str"];
                    namess.Add((string)tweet["globalObjects"]["users"][id_st]["name"]);
                    texts.Add((string)tweets1["text"]);
                    url_.Add($"https://twitter.com/{tweet["globalObjects"]["users"][id_st]["screen_name"]}/status/{tweets1["id_str"]}");
                }
            }
            for (int i=0;i < namess.Count; i++)
            {
                respo_.Items.Add(namess[i]).SubItems.Add(texts[i]);
            }

        }


        private void respo__DoubleClick(object sender, EventArgs e)
        {
            int index = respo_.SelectedItems[0].Index;
            if (index >= 0)
            {
                System.Diagnostics.Process.Start(url_[index]);
            }

        }


        private void button2_Click(object sender, EventArgs e)
        {
            Hint hint = new Hint();
            hint.MdiParent = this.MdiParent;
            hint.Show();
        }

    }
}
