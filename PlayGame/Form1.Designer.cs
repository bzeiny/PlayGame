
namespace PlayGame
{
    partial class PlayGameLabel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayGameLabel));
            this.StartButtonLabel = new System.Windows.Forms.Button();
            this.CountdownLabel3 = new System.Windows.Forms.Label();
            this.GoLabel = new System.Windows.Forms.Label();
            this.GameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StartButtonLabel
            // 
            this.StartButtonLabel.AccessibleName = "StartButtonLabel";
            this.StartButtonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButtonLabel.Location = new System.Drawing.Point(150, 85);
            this.StartButtonLabel.Name = "StartButtonLabel";
            this.StartButtonLabel.Size = new System.Drawing.Size(164, 38);
            this.StartButtonLabel.TabIndex = 0;
            this.StartButtonLabel.Text = "Start Game";
            this.StartButtonLabel.UseVisualStyleBackColor = true;
            this.StartButtonLabel.Click += new System.EventHandler(this.button1_Click);
            // 
            // CountdownLabel3
            // 
            this.CountdownLabel3.AccessibleName = "CountdownLabel3";
            this.CountdownLabel3.Font = new System.Drawing.Font("Oswald", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountdownLabel3.ForeColor = System.Drawing.Color.Cornsilk;
            this.CountdownLabel3.Location = new System.Drawing.Point(147, 163);
            this.CountdownLabel3.Name = "CountdownLabel3";
            this.CountdownLabel3.Size = new System.Drawing.Size(170, 23);
            this.CountdownLabel3.TabIndex = 1;
            this.CountdownLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CountdownLabel3.Click += new System.EventHandler(this.CountdownLabel3_Click);
            // 
            // GoLabel
            // 
            this.GoLabel.AccessibleName = "GoLabel";
            this.GoLabel.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoLabel.Location = new System.Drawing.Point(182, 126);
            this.GoLabel.Name = "GoLabel";
            this.GoLabel.Size = new System.Drawing.Size(100, 23);
            this.GoLabel.TabIndex = 4;
            this.GoLabel.Text = "GO!";
            this.GoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.GoLabel.Click += new System.EventHandler(this.GoLabel_Click);
            // 
            // GameLabel
            // 
            this.GameLabel.AccessibleName = "GameLabel";
            this.GameLabel.AutoSize = true;
            this.GameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameLabel.ForeColor = System.Drawing.Color.DarkMagenta;
            this.GameLabel.Location = new System.Drawing.Point(181, 9);
            this.GameLabel.Name = "GameLabel";
            this.GameLabel.Size = new System.Drawing.Size(111, 25);
            this.GameLabel.TabIndex = 5;
            this.GameLabel.Text = "PlayGame";
            this.GameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PlayGameLabel
            // 
            this.AccessibleName = "PlayGameLabel";
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(442, 248);
            this.Controls.Add(this.GameLabel);
            this.Controls.Add(this.GoLabel);
            this.Controls.Add(this.CountdownLabel3);
            this.Controls.Add(this.StartButtonLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PlayGameLabel";
            this.Text = "PlayGame";
            this.Load += new System.EventHandler(this.PlayGame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartButtonLabel;
        private System.Windows.Forms.Label CountdownLabel3;
        private System.Windows.Forms.Label GoLabel;
        private System.Windows.Forms.Label GameLabel;
    }
}

