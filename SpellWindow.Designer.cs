namespace WinFormsApp1
{
    partial class SpellWindow
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
            this.SpellList = new System.Windows.Forms.ListBox();
            this.CastSpell = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SpellList
            // 
            this.SpellList.FormattingEnabled = true;
            this.SpellList.ItemHeight = 15;
            this.SpellList.Location = new System.Drawing.Point(1, 2);
            this.SpellList.Name = "SpellList";
            this.SpellList.Size = new System.Drawing.Size(202, 499);
            this.SpellList.TabIndex = 0;
            this.SpellList.SelectedIndexChanged += new System.EventHandler(this.SpellList_SelectedIndexChanged);
            // 
            // CastSpell
            // 
            this.CastSpell.Location = new System.Drawing.Point(213, 405);
            this.CastSpell.Name = "CastSpell";
            this.CastSpell.Size = new System.Drawing.Size(132, 86);
            this.CastSpell.TabIndex = 1;
            this.CastSpell.Text = "Cast Spell";
            this.CastSpell.UseVisualStyleBackColor = true;
            this.CastSpell.Click += new System.EventHandler(this.CastSpell_Click);
            // 
            // SpellWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 503);
            this.Controls.Add(this.CastSpell);
            this.Controls.Add(this.SpellList);
            this.Name = "SpellWindow";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox SpellList;
        private Button CastSpell;
    }
}