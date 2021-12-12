
namespace TwitterFt
{
    partial class User
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.userID = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.image_pic = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.name_ = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.location_ = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.url_ = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.decs_ = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.follow_ = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.follower_ = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.create_ = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tweet_ = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.favorite_ = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.image_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "ユーザーID";
            // 
            // userID
            // 
            this.userID.Location = new System.Drawing.Point(100, 5);
            this.userID.Name = "userID";
            this.userID.Size = new System.Drawing.Size(152, 21);
            this.userID.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(255, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 25);
            this.button1.TabIndex = 2;
            this.button1.Text = "取得";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // image_pic
            // 
            this.image_pic.Location = new System.Drawing.Point(10, 30);
            this.image_pic.Name = "image_pic";
            this.image_pic.Size = new System.Drawing.Size(200, 200);
            this.image_pic.TabIndex = 3;
            this.image_pic.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 14);
            this.label2.TabIndex = 4;
            this.label2.Text = "名前";
            // 
            // name_
            // 
            this.name_.Location = new System.Drawing.Point(250, 35);
            this.name_.Name = "name_";
            this.name_.Size = new System.Drawing.Size(160, 21);
            this.name_.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(210, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 14);
            this.label3.TabIndex = 6;
            this.label3.Text = "位置";
            // 
            // location_
            // 
            this.location_.Location = new System.Drawing.Point(250, 60);
            this.location_.Name = "location_";
            this.location_.Size = new System.Drawing.Size(160, 21);
            this.location_.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 14);
            this.label4.TabIndex = 8;
            this.label4.Text = "URL";
            // 
            // url_
            // 
            this.url_.Location = new System.Drawing.Point(35, 230);
            this.url_.Name = "url_";
            this.url_.Size = new System.Drawing.Size(375, 21);
            this.url_.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 14);
            this.label5.TabIndex = 10;
            this.label5.Text = "自己紹介";
            // 
            // decs_
            // 
            this.decs_.Location = new System.Drawing.Point(10, 270);
            this.decs_.Multiline = true;
            this.decs_.Name = "decs_";
            this.decs_.Size = new System.Drawing.Size(395, 150);
            this.decs_.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(210, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 14);
            this.label6.TabIndex = 12;
            this.label6.Text = "フォロー";
            // 
            // follow_
            // 
            this.follow_.Location = new System.Drawing.Point(280, 85);
            this.follow_.Name = "follow_";
            this.follow_.Size = new System.Drawing.Size(130, 21);
            this.follow_.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(210, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 14);
            this.label7.TabIndex = 14;
            this.label7.Text = "フォロワー";
            // 
            // follower_
            // 
            this.follower_.Location = new System.Drawing.Point(280, 110);
            this.follower_.Name = "follower_";
            this.follower_.Size = new System.Drawing.Size(130, 21);
            this.follower_.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(210, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 14);
            this.label8.TabIndex = 16;
            this.label8.Text = "作成日";
            // 
            // create_
            // 
            this.create_.Font = new System.Drawing.Font("UD デジタル 教科書体 N-B", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.create_.Location = new System.Drawing.Point(255, 135);
            this.create_.Name = "create_";
            this.create_.Size = new System.Drawing.Size(160, 20);
            this.create_.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(210, 165);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 14);
            this.label9.TabIndex = 18;
            this.label9.Text = "ツイート数";
            // 
            // tweet_
            // 
            this.tweet_.Location = new System.Drawing.Point(280, 160);
            this.tweet_.Name = "tweet_";
            this.tweet_.Size = new System.Drawing.Size(130, 21);
            this.tweet_.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(210, 190);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 14);
            this.label10.TabIndex = 20;
            this.label10.Text = "いいね数";
            // 
            // favorite_
            // 
            this.favorite_.Location = new System.Drawing.Point(280, 185);
            this.favorite_.Name = "favorite_";
            this.favorite_.Size = new System.Drawing.Size(130, 21);
            this.favorite_.TabIndex = 21;
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 433);
            this.Controls.Add(this.favorite_);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tweet_);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.create_);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.follower_);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.follow_);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.decs_);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.url_);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.location_);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.name_);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.image_pic);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.userID);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("UD デジタル 教科書体 N-B", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.Name = "User";
            this.ShowIcon = false;
            this.Text = "ユーザー情報";
            this.Load += new System.EventHandler(this.User_Load);
            ((System.ComponentModel.ISupportInitialize)(this.image_pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox userID;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox image_pic;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox name_;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox location_;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox url_;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox decs_;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox follow_;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox follower_;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox create_;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tweet_;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox favorite_;
    }
}