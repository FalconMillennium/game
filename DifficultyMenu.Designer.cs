namespace WinFormsApp1
{
    partial class DifficultyMenu
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
            this.Easy = new System.Windows.Forms.Button();
            this.Medium = new System.Windows.Forms.Button();
            this.Hard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Easy
            // 
            this.Easy.Location = new System.Drawing.Point(141, 37);
            this.Easy.Name = "Easy";
            this.Easy.Size = new System.Drawing.Size(195, 42);
            this.Easy.TabIndex = 0;
            this.Easy.Text = "Easy";
            this.Easy.UseVisualStyleBackColor = true;
            this.Easy.Click += new System.EventHandler(this.Easy_Click);
            // 
            // Medium
            // 
            this.Medium.Location = new System.Drawing.Point(141, 114);
            this.Medium.Name = "Medium";
            this.Medium.Size = new System.Drawing.Size(195, 42);
            this.Medium.TabIndex = 1;
            this.Medium.Text = "Medium";
            this.Medium.UseVisualStyleBackColor = true;
            this.Medium.Click += new System.EventHandler(this.Medium_Click);
            // 
            // Hard
            // 
            this.Hard.Location = new System.Drawing.Point(141, 194);
            this.Hard.Name = "Hard";
            this.Hard.Size = new System.Drawing.Size(195, 42);
            this.Hard.TabIndex = 2;
            this.Hard.Text = "Hard";
            this.Hard.UseVisualStyleBackColor = true;
            this.Hard.Click += new System.EventHandler(this.Hard_Click);
            // 
            // DifficultyMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 271);
            this.Controls.Add(this.Hard);
            this.Controls.Add(this.Medium);
            this.Controls.Add(this.Easy);
            this.Name = "DifficultyMenu";
            this.Text = "DifficultyMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private Button Easy;
        private Button Medium;
        private Button Hard;
    }
}