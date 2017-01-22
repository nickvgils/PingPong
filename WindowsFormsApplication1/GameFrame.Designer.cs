namespace WindowsFormsApplication1
{
    partial class GameFrame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameFrame));
            this.menubarPanel = new System.Windows.Forms.Panel();
            this.scoreButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.chatPanel = new System.Windows.Forms.Panel();
            this.messagesBox = new System.Windows.Forms.RichTextBox();
            this.sendingTextBox = new System.Windows.Forms.RichTextBox();
            this.sendingButton = new System.Windows.Forms.Button();
            this.gamePanel = new System.Windows.Forms.Panel();
            this.player1 = new System.Windows.Forms.PictureBox();
            this.player2 = new System.Windows.Forms.PictureBox();
            this.ball = new System.Windows.Forms.PictureBox();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.menubarPanel.SuspendLayout();
            this.chatPanel.SuspendLayout();
            this.gamePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            this.SuspendLayout();
            // 
            // menubarPanel
            // 
            this.menubarPanel.BackColor = System.Drawing.Color.Teal;
            this.menubarPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.menubarPanel.Controls.Add(this.scoreButton);
            this.menubarPanel.Controls.Add(this.label1);
            this.menubarPanel.Controls.Add(this.minimizeButton);
            this.menubarPanel.Controls.Add(this.exitButton);
            this.menubarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.menubarPanel.Location = new System.Drawing.Point(0, 0);
            this.menubarPanel.Name = "menubarPanel";
            this.menubarPanel.Size = new System.Drawing.Size(1421, 51);
            this.menubarPanel.TabIndex = 0;
            this.menubarPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // scoreButton
            // 
            this.scoreButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("scoreButton.BackgroundImage")));
            this.scoreButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.scoreButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.scoreButton.Enabled = false;
            this.scoreButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.scoreButton.FlatAppearance.BorderSize = 0;
            this.scoreButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(173)))));
            this.scoreButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(173)))));
            this.scoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scoreButton.Location = new System.Drawing.Point(1300, 12);
            this.scoreButton.Name = "scoreButton";
            this.scoreButton.Size = new System.Drawing.Size(24, 24);
            this.scoreButton.TabIndex = 6;
            this.scoreButton.UseVisualStyleBackColor = true;
            this.scoreButton.Click += new System.EventHandler(this.scoreButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(562, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 36);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ping Pong";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            // 
            // minimizeButton
            // 
            this.minimizeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("minimizeButton.BackgroundImage")));
            this.minimizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.minimizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizeButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.minimizeButton.FlatAppearance.BorderSize = 0;
            this.minimizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(173)))));
            this.minimizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(173)))));
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.Location = new System.Drawing.Point(1350, 9);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(27, 27);
            this.minimizeButton.TabIndex = 4;
            this.minimizeButton.UseVisualStyleBackColor = true;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exitButton.BackgroundImage")));
            this.exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(200)))));
            this.exitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(173)))));
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Location = new System.Drawing.Point(1383, 9);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(27, 27);
            this.exitButton.TabIndex = 3;
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // chatPanel
            // 
            this.chatPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(187)))), ((int)(((byte)(182)))));
            this.chatPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chatPanel.Controls.Add(this.messagesBox);
            this.chatPanel.Controls.Add(this.sendingTextBox);
            this.chatPanel.Controls.Add(this.sendingButton);
            this.chatPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.chatPanel.Location = new System.Drawing.Point(1163, 51);
            this.chatPanel.Name = "chatPanel";
            this.chatPanel.Size = new System.Drawing.Size(258, 695);
            this.chatPanel.TabIndex = 1;
            // 
            // messagesBox
            // 
            this.messagesBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(187)))), ((int)(((byte)(182)))));
            this.messagesBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.messagesBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.messagesBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.messagesBox.ForeColor = System.Drawing.Color.Black;
            this.messagesBox.Location = new System.Drawing.Point(0, 0);
            this.messagesBox.Name = "messagesBox";
            this.messagesBox.ReadOnly = true;
            this.messagesBox.Size = new System.Drawing.Size(256, 621);
            this.messagesBox.TabIndex = 5;
            this.messagesBox.Text = "";
            // 
            // sendingTextBox
            // 
            this.sendingTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sendingTextBox.Enabled = false;
            this.sendingTextBox.Location = new System.Drawing.Point(0, 627);
            this.sendingTextBox.Name = "sendingTextBox";
            this.sendingTextBox.Size = new System.Drawing.Size(199, 67);
            this.sendingTextBox.TabIndex = 2;
            this.sendingTextBox.Text = "";
            this.sendingTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.sendingTextBox_KeyDown);
            this.sendingTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.sendingTextBox_KeyUp);
            // 
            // sendingButton
            // 
            this.sendingButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sendingButton.Enabled = false;
            this.sendingButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.sendingButton.FlatAppearance.BorderSize = 0;
            this.sendingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendingButton.ForeColor = System.Drawing.Color.White;
            this.sendingButton.Location = new System.Drawing.Point(200, 627);
            this.sendingButton.Name = "sendingButton";
            this.sendingButton.Size = new System.Drawing.Size(57, 67);
            this.sendingButton.TabIndex = 1;
            this.sendingButton.Text = "Send";
            this.sendingButton.UseVisualStyleBackColor = true;
            this.sendingButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // gamePanel
            // 
            this.gamePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gamePanel.Controls.Add(this.player1);
            this.gamePanel.Controls.Add(this.player2);
            this.gamePanel.Controls.Add(this.ball);
            this.gamePanel.Controls.Add(this.scoreLabel);
            this.gamePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gamePanel.Location = new System.Drawing.Point(0, 51);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.Size = new System.Drawing.Size(1163, 695);
            this.gamePanel.TabIndex = 5;
            this.gamePanel.Visible = false;
            // 
            // player1
            // 
            this.player1.BackColor = System.Drawing.Color.Black;
            this.player1.Location = new System.Drawing.Point(480, 670);
            this.player1.Name = "player1";
            this.player1.Size = new System.Drawing.Size(202, 18);
            this.player1.TabIndex = 3;
            this.player1.TabStop = false;
            // 
            // player2
            // 
            this.player2.BackColor = System.Drawing.Color.Black;
            this.player2.Location = new System.Drawing.Point(480, 5);
            this.player2.Name = "player2";
            this.player2.Size = new System.Drawing.Size(202, 18);
            this.player2.TabIndex = 2;
            this.player2.TabStop = false;
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ball.Location = new System.Drawing.Point(566, 327);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(30, 30);
            this.ball.TabIndex = 4;
            this.ball.TabStop = false;
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.ForeColor = System.Drawing.Color.Silver;
            this.scoreLabel.Location = new System.Drawing.Point(526, 275);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(125, 135);
            this.scoreLabel.TabIndex = 6;
            this.scoreLabel.Text = "0";
            // 
            // GameFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1421, 746);
            this.Controls.Add(this.gamePanel);
            this.Controls.Add(this.chatPanel);
            this.Controls.Add(this.menubarPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GameFrame";
            this.Text = "Form1";
            this.menubarPanel.ResumeLayout(false);
            this.menubarPanel.PerformLayout();
            this.chatPanel.ResumeLayout(false);
            this.gamePanel.ResumeLayout(false);
            this.gamePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menubarPanel;
        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Panel chatPanel;
        private System.Windows.Forms.RichTextBox sendingTextBox;
        private System.Windows.Forms.Button sendingButton;
        private System.Windows.Forms.PictureBox player1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.RichTextBox messagesBox;
        private System.Windows.Forms.Panel gamePanel;
        private System.Windows.Forms.PictureBox player2;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Button scoreButton;
    }
}

