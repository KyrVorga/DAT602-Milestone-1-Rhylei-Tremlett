namespace StageOne
{
    partial class Game
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
            this.leaderboard_box = new System.Windows.Forms.ListBox();
            this.label_leaderboard = new System.Windows.Forms.Label();
            this.chat_box = new System.Windows.Forms.ListBox();
            this.label_chat = new System.Windows.Forms.Label();
            this.chat_input = new System.Windows.Forms.TextBox();
            this.update_chat_button = new System.Windows.Forms.Button();
            this.update_leaderboard_button = new System.Windows.Forms.Button();
            this.settings_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // leaderboard_box
            // 
            this.leaderboard_box.FormattingEnabled = true;
            this.leaderboard_box.ItemHeight = 25;
            this.leaderboard_box.Items.AddRange(new object[] {
            "item",
            "item1"});
            this.leaderboard_box.Location = new System.Drawing.Point(15, 47);
            this.leaderboard_box.Name = "leaderboard_box";
            this.leaderboard_box.Size = new System.Drawing.Size(252, 179);
            this.leaderboard_box.TabIndex = 0;
            // 
            // label_leaderboard
            // 
            this.label_leaderboard.AutoSize = true;
            this.label_leaderboard.Location = new System.Drawing.Point(15, 19);
            this.label_leaderboard.Name = "label_leaderboard";
            this.label_leaderboard.Size = new System.Drawing.Size(112, 25);
            this.label_leaderboard.TabIndex = 1;
            this.label_leaderboard.Text = "Leaderboard";
            // 
            // chat_box
            // 
            this.chat_box.FormattingEnabled = true;
            this.chat_box.ItemHeight = 25;
            this.chat_box.Location = new System.Drawing.Point(15, 297);
            this.chat_box.Name = "chat_box";
            this.chat_box.Size = new System.Drawing.Size(252, 179);
            this.chat_box.TabIndex = 2;
            // 
            // label_chat
            // 
            this.label_chat.AutoSize = true;
            this.label_chat.Location = new System.Drawing.Point(15, 269);
            this.label_chat.Name = "label_chat";
            this.label_chat.Size = new System.Drawing.Size(48, 25);
            this.label_chat.TabIndex = 3;
            this.label_chat.Text = "Chat";
            // 
            // chat_input
            // 
            this.chat_input.Location = new System.Drawing.Point(15, 494);
            this.chat_input.MaxLength = 500;
            this.chat_input.Name = "chat_input";
            this.chat_input.PlaceholderText = "Enter Message";
            this.chat_input.Size = new System.Drawing.Size(252, 31);
            this.chat_input.TabIndex = 4;
            // 
            // update_chat_button
            // 
            this.update_chat_button.Location = new System.Drawing.Point(139, 260);
            this.update_chat_button.Name = "update_chat_button";
            this.update_chat_button.Size = new System.Drawing.Size(128, 34);
            this.update_chat_button.TabIndex = 5;
            this.update_chat_button.Text = "Update";
            this.update_chat_button.UseVisualStyleBackColor = true;
            this.update_chat_button.Click += new System.EventHandler(this.update_chat_button_Click);
            // 
            // update_leaderboard_button
            // 
            this.update_leaderboard_button.Location = new System.Drawing.Point(139, 7);
            this.update_leaderboard_button.Name = "update_leaderboard_button";
            this.update_leaderboard_button.Size = new System.Drawing.Size(128, 34);
            this.update_leaderboard_button.TabIndex = 6;
            this.update_leaderboard_button.Text = "Update";
            this.update_leaderboard_button.UseVisualStyleBackColor = true;
            this.update_leaderboard_button.Click += new System.EventHandler(this.update_leaderboard_button_Click);
            // 
            // settings_button
            // 
            this.settings_button.Location = new System.Drawing.Point(928, 19);
            this.settings_button.Name = "settings_button";
            this.settings_button.Size = new System.Drawing.Size(90, 41);
            this.settings_button.TabIndex = 7;
            this.settings_button.Text = "Settings";
            this.settings_button.UseVisualStyleBackColor = true;
            this.settings_button.Click += new System.EventHandler(this.settings_button_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 581);
            this.Controls.Add(this.settings_button);
            this.Controls.Add(this.update_leaderboard_button);
            this.Controls.Add(this.update_chat_button);
            this.Controls.Add(this.chat_input);
            this.Controls.Add(this.label_chat);
            this.Controls.Add(this.chat_box);
            this.Controls.Add(this.label_leaderboard);
            this.Controls.Add(this.leaderboard_box);
            this.Name = "Game";
            this.Text = "Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox leaderboard_box;
        private Label label_leaderboard;
        private ListBox chat_box;
        private Label label_chat;
        private TextBox chat_input;
        private Button update_chat_button;
        private Button update_leaderboard_button;
        private Button settings_button;
    }
}