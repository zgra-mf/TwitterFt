using Newtonsoft.Json.Linq;
using System.IO;
using System.Net;


namespace TwitterFt
{
    class Front
    {
        public string gues_token;


        /// <summary>
        /// urlの情報取得
        /// </summary>
        /// <param name="url">取得したいurl</param>
        /// <param name="isPost">postにするか</param>
        /// <returns></returns>
        public JObject Requests(string url, bool isPost)
        {
            JObject respone = null;
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                if (isPost == true)
                    request.Method = "POST";
                request.Headers.Add("authorization", "Bearer AAAAAAAAAAAAAAAAAAAAANRILgAAAAAAnNwIzUejRCOuH5E6I8xnZz4puTs%3D1Zv7ttfk8LF81IUq16cHjhLTvJu4FA33AGWWjCpTnA");
                request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/96.0.4664.93 Safari/537.36";
                request.Headers.Add("x-guest-token", gues_token);
                var httpResponse = (HttpWebResponse)request.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    respone = JObject.Parse(streamReader.ReadToEnd());
                }
            }
            catch (WebException e)
            {
                using (HttpWebResponse response = (HttpWebResponse)e.Response)
                {
                    string ttt = @"{'error':'error'}";
                    respone = JObject.Parse(ttt);
                }
            }
            return respone;
        }


        /// <summary>
        /// ゲストtoken生成 (初期生成)
        /// </summary>
        public void Create_guest_token()
        {
            JObject respones_ = null;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://api.twitter.com/1.1/guest/activate.json");
            request.Method = "POST";
            request.Headers.Add("authorization", "Bearer AAAAAAAAAAAAAAAAAAAAANRILgAAAAAAnNwIzUejRCOuH5E6I8xnZz4puTs%3D1Zv7ttfk8LF81IUq16cHjhLTvJu4FA33AGWWjCpTnA");
            request.UserAgent ="Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/96.0.4664.93 Safari/537.36";
            var httpResponse = (HttpWebResponse)request.GetResponse();

            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                respones_ = JObject.Parse(streamReader.ReadToEnd());
            }

            gues_token = (string)respones_["guest_token"];
        }


        /// <summary>
        /// ユーザープロフィールを取得
        /// </summary>
        /// <param name="userid">ユーザーID</param>
        /// <returns>ユーザー情報</returns>
        public JObject Get_user(string userid)
        {
            JObject respone = Requests($"https://api.twitter.com/1.1/users/show.json?screen_name={userid}", false);
            return respone;
        }


        /// <summary>
        /// IDの使用判定
        /// </summary>
        /// <param name="userID">ユーザーID</param>
        /// <returns>使用状態</returns>
        public JObject Get_ID_al(string userID)
        {
            JObject respone = Requests($"https://twitter.com/i/api/i/users/username_available.json?username={userID}", false);
            return respone;
        }


        /// <summary>
        /// ユーザー固有ID取得
        /// </summary>
        /// <param name="userID">ユーザーID</param>
        /// <returns>ユーザー固有ID</returns>
        public string Get_userID(string userID)
        {
            JObject respone = Requests($"https://api.twitter.com/1.1/users/show.json?screen_name={userID}", false);
            return (string)respone["id_str"]; ;
        }


        /// <summary>
        /// ユーザーのツイートを取得
        /// </summary>
        /// <param name="userID">ユーザーID</param>
        /// <returns>ツイート(json)</returns>
        public JObject Get_tweets(string userID)
        {
            string id_str = Get_userID(userID);
            JObject tweets = Requests($"https://api.twitter.com/2/timeline/profile/{id_str}.json", false);
            return tweets;
        }


        /// <summary>
        /// ツイート検索
        /// </summary>
        /// <param name="texts">検索内容</param>
        /// <returns>検索結果</returns>
        public JObject Get_search(string texts)
        {
            JObject respones = Requests($"https://twitter.com/i/api/2/search/adaptive.json?q={texts}&tweet_search_mode=live", false);
            return respones;
        }

    }
}