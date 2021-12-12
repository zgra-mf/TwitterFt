
namespace TwitterFt
{
    partial class Search
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
            this.modes_ = new System.Windows.Forms.ComboBox();
            this.options_ = new System.Windows.Forms.Label();
            this.searchT_ = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.respo_ = new System.Windows.Forms.ListView();
            this.nameS_ = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tweetN_ = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "サーチモード";
            // 
            // modes_
            // 
            this.modes_.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.modes_.FormattingEnabled = true;
            this.modes_.Items.AddRange(new object[] {
            "ユーザーツイート",
            "検索"});
            this.modes_.Location = new System.Drawing.Point(85, 5);
            this.modes_.Name = "modes_";
            this.modes_.Size = new System.Drawing.Size(120, 21);
            this.modes_.TabIndex = 1;
            // 
            // options_
            // 
            this.options_.AutoSize = true;
            this.options_.Location = new System.Drawing.Point(10, 35);
            this.options_.Name = "options_";
            this.options_.Size = new System.Drawing.Size(51, 13);
            this.options_.TabIndex = 2;
            this.options_.Text = "検索文字";
            // 
            // searchT_
            // 
            this.searchT_.Location = new System.Drawing.Point(85, 30);
            this.searchT_.Name = "searchT_";
            this.searchT_.Size = new System.Drawing.Size(365, 20);
            this.searchT_.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(455, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 25);
            this.button1.TabIndex = 4;
            this.button1.Text = "検索";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // respo_
            // 
            this.respo_.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameS_,
            this.tweetN_});
            this.respo_.HideSelection = false;
            this.respo_.Location = new System.Drawing.Point(10, 55);
            this.respo_.Name = "respo_";
            this.respo_.Size = new System.Drawing.Size(525, 245);
            this.respo_.TabIndex = 5;
            this.respo_.UseCompatibleStateImageBehavior = false;
            this.respo_.View = System.Windows.Forms.View.Details;
            this.respo_.DoubleClick += new System.EventHandler(this.respo__DoubleClick);
            // 
            // nameS_
            // 
            this.nameS_.Text = "名前";
            this.nameS_.Width = 110;
            // 
            // tweetN_
            // 
            this.tweetN_.Text = "ツイート";
            this.tweetN_.Width = 400;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(380, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "検索文字オプション";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 311);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.respo_);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.searchT_);
            this.Controls.Add(this.options_);
            this.Controls.Add(this.modes_);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("UD デジタル 教科書体 N-B", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.Name = "Search";
            this.ShowIcon = false;
            this.Text = "検索";
            this.Load += new System.EventHandler(this.search_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox modes_;
        private System.Windows.Forms.Label options_;
        private System.Windows.Forms.TextBox searchT_;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView respo_;
        private System.Windows.Forms.ColumnHeader nameS_;
        private System.Windows.Forms.ColumnHeader tweetN_;
        private System.Windows.Forms.Button button2;
    }
}