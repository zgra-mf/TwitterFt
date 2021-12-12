using System;
using System.Net;
using System.Windows.Forms;

namespace TwitterFt
{
    public partial class Hint : Form
    {
        public Hint()
        {
            InitializeComponent();
        }

        private void Hint_Load(object sender, EventArgs e)
        {
            using (WebClient client = new WebClient())
            {
                try
                {
                    client.Headers.Add("user-agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/96.0.4664.93 Safari/537.36");
                    byte[] texts = client.DownloadData("https://szay0.ojaru.jp/sss.txt");
                    textBox1.Text = System.Text.Encoding.GetEncoding("shift_jis").GetString(texts).Replace("\n", "\r\n");
                }
                catch (System.Net.WebException ex)
                {
                    //HTTPプロトコルエラーかどうか調べる
                    if (ex.Status == System.Net.WebExceptionStatus.ProtocolError)
                    {
                        //HttpWebResponseを取得
                        System.Net.HttpWebResponse errres =
                            (System.Net.HttpWebResponse)ex.Response;
                        //応答ステータスコードを表示する
                        textBox1.Text = $"{errres.StatusCode} : {errres.StatusDescription}";
                        
                    }
                    else
                        textBox1.Text = ex.Message;
                }

            }
        }

    }
}
