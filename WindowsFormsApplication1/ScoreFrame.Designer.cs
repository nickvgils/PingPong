namespace WindowsFormsApplication1
{
    partial class ScoreFrame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScoreFrame));
            this.scorePanel = new System.Windows.Forms.DataGridView();
            this.menubarPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Speler1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Speler2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.scorePanel)).BeginInit();
            this.menubarPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // scorePanel
            // 
            this.scorePanel.AllowUserToAddRows = false;
            this.scorePanel.AllowUserToDeleteRows = false;
            this.scorePanel.AllowUserToResizeRows = false;
            this.scorePanel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.scorePanel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Datum,
            this.Speler1,
            this.Speler2,
            this.Score});
            this.scorePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scorePanel.Location = new System.Drawing.Point(0, 51);
            this.scorePanel.Name = "scorePanel";
            this.scorePanel.ReadOnly = true;
            this.scorePanel.RowTemplate.Height = 24;
            this.scorePanel.Size = new System.Drawing.Size(603, 384);
            this.scorePanel.TabIndex = 0;
            // 
            // menubarPanel
            // 
            this.menubarPanel.BackColor = System.Drawing.Color.Teal;
            this.menubarPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.menubarPanel.Controls.Add(this.label1);
            this.menubarPanel.Controls.Add(this.exitButton);
            this.menubarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.menubarPanel.Location = new System.Drawing.Point(0, 0);
            this.menubarPanel.Name = "menubarPanel";
            this.menubarPanel.Size = new System.Drawing.Size(603, 51);
            this.menubarPanel.TabIndex = 1;
            this.menubarPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menubarPanel_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(231, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 36);
            this.label1.TabIndex = 5;
            this.label1.Text = "Score";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
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
            this.exitButton.Location = new System.Drawing.Point(554, 11);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(27, 27);
            this.exitButton.TabIndex = 3;
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Datum
            // 
            this.Datum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Datum.HeaderText = "Datum";
            this.Datum.Name = "Datum";
            this.Datum.ReadOnly = true;
            this.Datum.Width = 78;
            // 
            // Speler1
            // 
            this.Speler1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Speler1.HeaderText = "Speler1";
            this.Speler1.Name = "Speler1";
            this.Speler1.ReadOnly = true;
            this.Speler1.Width = 86;
            // 
            // Speler2
            // 
            this.Speler2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Speler2.HeaderText = "Speler2";
            this.Speler2.Name = "Speler2";
            this.Speler2.ReadOnly = true;
            this.Speler2.Width = 86;
            // 
            // Score
            // 
            this.Score.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Score.HeaderText = "Score";
            this.Score.Name = "Score";
            this.Score.ReadOnly = true;
            this.Score.Width = 74;
            // 
            // ScoreFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 435);
            this.Controls.Add(this.scorePanel);
            this.Controls.Add(this.menubarPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ScoreFrame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ScoreFrame";
            ((System.ComponentModel.ISupportInitialize)(this.scorePanel)).EndInit();
            this.menubarPanel.ResumeLayout(false);
            this.menubarPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView scorePanel;
        private System.Windows.Forms.Panel menubarPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Speler1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Speler2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Score;
    }
}