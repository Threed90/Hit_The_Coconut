namespace HitTheCoconut
{
    partial class GameSkin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameSkin));
            this.PlayBtn = new System.Windows.Forms.Button();
            this.PauseBtn = new System.Windows.Forms.Button();
            this.ReplayBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.ScoreCounter = new System.Windows.Forms.Label();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.FruitCounter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PlayBtn
            // 
            this.PlayBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PlayBtn.BackgroundImage")));
            this.PlayBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PlayBtn.FlatAppearance.BorderSize = 0;
            this.PlayBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayBtn.Location = new System.Drawing.Point(36, 369);
            this.PlayBtn.Name = "PlayBtn";
            this.PlayBtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.PlayBtn.Size = new System.Drawing.Size(120, 44);
            this.PlayBtn.TabIndex = 0;
            this.PlayBtn.UseVisualStyleBackColor = true;
            this.PlayBtn.UseWaitCursor = true;
            this.PlayBtn.Click += new System.EventHandler(this.PlayBtn_Click);
            this.PlayBtn.MouseEnter += new System.EventHandler(this.PlayBtn_MouseEnter);
            this.PlayBtn.MouseLeave += new System.EventHandler(this.PlayBtn_MouseLeave);
            // 
            // PauseBtn
            // 
            this.PauseBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PauseBtn.BackgroundImage")));
            this.PauseBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PauseBtn.FlatAppearance.BorderSize = 0;
            this.PauseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PauseBtn.Location = new System.Drawing.Point(36, 451);
            this.PauseBtn.Name = "PauseBtn";
            this.PauseBtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.PauseBtn.Size = new System.Drawing.Size(120, 44);
            this.PauseBtn.TabIndex = 1;
            this.PauseBtn.UseVisualStyleBackColor = true;
            this.PauseBtn.UseWaitCursor = true;
            this.PauseBtn.Click += new System.EventHandler(this.PauseBtn_Click);
            this.PauseBtn.MouseEnter += new System.EventHandler(this.PauseBtn_MouseEnter);
            this.PauseBtn.MouseLeave += new System.EventHandler(this.PauseBtn_MouseLeave);
            // 
            // ReplayBtn
            // 
            this.ReplayBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ReplayBtn.BackgroundImage")));
            this.ReplayBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ReplayBtn.FlatAppearance.BorderSize = 0;
            this.ReplayBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReplayBtn.Location = new System.Drawing.Point(36, 538);
            this.ReplayBtn.Name = "ReplayBtn";
            this.ReplayBtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ReplayBtn.Size = new System.Drawing.Size(120, 44);
            this.ReplayBtn.TabIndex = 2;
            this.ReplayBtn.UseVisualStyleBackColor = true;
            this.ReplayBtn.UseWaitCursor = true;
            this.ReplayBtn.Click += new System.EventHandler(this.ReplayBtn_Click);
            this.ReplayBtn.MouseEnter += new System.EventHandler(this.ReplayBtn_MouseEnter);
            this.ReplayBtn.MouseLeave += new System.EventHandler(this.ReplayBtn_MouseLeave);
            // 
            // ExitBtn
            // 
            this.ExitBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ExitBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ExitBtn.BackgroundImage")));
            this.ExitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ExitBtn.FlatAppearance.BorderSize = 0;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.Location = new System.Drawing.Point(36, 629);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ExitBtn.Size = new System.Drawing.Size(120, 44);
            this.ExitBtn.TabIndex = 3;
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.UseWaitCursor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            this.ExitBtn.MouseEnter += new System.EventHandler(this.ExitBtn_MouseEnter);
            this.ExitBtn.MouseLeave += new System.EventHandler(this.ExitBtn_MouseLeave);
            // 
            // ScoreCounter
            // 
            this.ScoreCounter.AutoSize = true;
            this.ScoreCounter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ScoreCounter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ScoreCounter.Font = new System.Drawing.Font("Showcard Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ScoreCounter.ForeColor = System.Drawing.Color.Green;
            this.ScoreCounter.Location = new System.Drawing.Point(973, 637);
            this.ScoreCounter.Name = "ScoreCounter";
            this.ScoreCounter.Size = new System.Drawing.Size(148, 38);
            this.ScoreCounter.TabIndex = 4;
            this.ScoreCounter.Text = "Score: 0";
            this.ScoreCounter.UseWaitCursor = true;
            // 
            // GameTimer
            // 
            this.GameTimer.Interval = 500;
            this.GameTimer.Tick += new System.EventHandler(this.TimerEvent);
            // 
            // FruitCounter
            // 
            this.FruitCounter.AutoSize = true;
            this.FruitCounter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FruitCounter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FruitCounter.Font = new System.Drawing.Font("Showcard Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FruitCounter.ForeColor = System.Drawing.Color.Green;
            this.FruitCounter.Location = new System.Drawing.Point(746, 637);
            this.FruitCounter.Name = "FruitCounter";
            this.FruitCounter.Size = new System.Drawing.Size(162, 38);
            this.FruitCounter.TabIndex = 5;
            this.FruitCounter.Text = "Fruits: 0";
            this.FruitCounter.UseWaitCursor = true;
            // 
            // GameSkin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 720);
            this.Controls.Add(this.FruitCounter);
            this.Controls.Add(this.ScoreCounter);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.ReplayBtn);
            this.Controls.Add(this.PauseBtn);
            this.Controls.Add(this.PlayBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GameSkin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.UseWaitCursor = true;
            this.Click += new System.EventHandler(this.GameSkin_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PlayBtn;
        private System.Windows.Forms.Button PauseBtn;
        private System.Windows.Forms.Button ReplayBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Label ScoreCounter;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Label FruitCounter;
    }
}
