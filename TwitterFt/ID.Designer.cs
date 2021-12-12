
namespace TwitterFt
{
    partial class ID
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
            this.userID_ = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.reson_ = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "使用確認したいユーザーID";
            // 
            // userID_
            // 
            this.userID_.Location = new System.Drawing.Point(10, 30);
            this.userID_.Name = "userID_";
            this.userID_.Size = new System.Drawing.Size(140, 25);
            this.userID_.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "状態";
            // 
            // reson_
            // 
            this.reson_.Location = new System.Drawing.Point(10, 80);
            this.reson_.Multiline = true;
            this.reson_.Name = "reson_";
            this.reson_.Size = new System.Drawing.Size(210, 65);
            this.reson_.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(155, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 25);
            this.button1.TabIndex = 2;
            this.button1.Text = "実行";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 163);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.reson_);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.userID_);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("UD デジタル 教科書体 N-B", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.Name = "ID";
            this.ShowIcon = false;
            this.Text = "ID確認";
            this.Load += new System.EventHandler(this.ID_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox userID_;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox reson_;
        private System.Windows.Forms.Button button1;
    }
}