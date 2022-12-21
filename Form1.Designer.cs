namespace WinFormsApp1
{
    partial class Form1
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
            this.OutMessage = new System.Windows.Forms.Label();
            this.PlayerAttack = new System.Windows.Forms.Button();
            this.PlayerRegenHP = new System.Windows.Forms.Button();
            this.PlayerRegenMana = new System.Windows.Forms.Button();
            this.PlayerHP = new System.Windows.Forms.Label();
            this.PlayerMana = new System.Windows.Forms.Label();
            this.EnemyHP = new System.Windows.Forms.Label();
            this.EnemyResponse = new System.Windows.Forms.Label();
            this.PlayerHPValue = new System.Windows.Forms.Label();
            this.PlayerManaValue = new System.Windows.Forms.Label();
            this.EnemyHPValue = new System.Windows.Forms.Label();
            this.PlayerCastSpell = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OutMessage
            // 
            this.OutMessage.AutoSize = true;
            this.OutMessage.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OutMessage.Location = new System.Drawing.Point(435, 198);
            this.OutMessage.Name = "OutMessage";
            this.OutMessage.Size = new System.Drawing.Size(0, 23);
            this.OutMessage.TabIndex = 0;
            this.OutMessage.Click += new System.EventHandler(this.Message_Click);
            // 
            // PlayerAttack
            // 
            this.PlayerAttack.Location = new System.Drawing.Point(71, 477);
            this.PlayerAttack.Name = "PlayerAttack";
            this.PlayerAttack.Size = new System.Drawing.Size(163, 87);
            this.PlayerAttack.TabIndex = 2;
            this.PlayerAttack.Text = "Attack";
            this.PlayerAttack.UseVisualStyleBackColor = true;
            this.PlayerAttack.Click += new System.EventHandler(this.PlayerAttack_Click);
            // 
            // PlayerRegenHP
            // 
            this.PlayerRegenHP.Location = new System.Drawing.Point(385, 477);
            this.PlayerRegenHP.Name = "PlayerRegenHP";
            this.PlayerRegenHP.Size = new System.Drawing.Size(163, 87);
            this.PlayerRegenHP.TabIndex = 3;
            this.PlayerRegenHP.Text = "Restore HP";
            this.PlayerRegenHP.UseVisualStyleBackColor = true;
            this.PlayerRegenHP.Click += new System.EventHandler(this.PlayerRegenHP_Click);
            // 
            // PlayerRegenMana
            // 
            this.PlayerRegenMana.Location = new System.Drawing.Point(705, 477);
            this.PlayerRegenMana.Name = "PlayerRegenMana";
            this.PlayerRegenMana.Size = new System.Drawing.Size(163, 87);
            this.PlayerRegenMana.TabIndex = 4;
            this.PlayerRegenMana.Text = "Restore Mana";
            this.PlayerRegenMana.UseVisualStyleBackColor = true;
            this.PlayerRegenMana.Click += new System.EventHandler(this.PlayerRegenMana_Click);
            // 
            // PlayerHP
            // 
            this.PlayerHP.AutoSize = true;
            this.PlayerHP.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlayerHP.Location = new System.Drawing.Point(25, 39);
            this.PlayerHP.Name = "PlayerHP";
            this.PlayerHP.Size = new System.Drawing.Size(51, 23);
            this.PlayerHP.TabIndex = 5;
            this.PlayerHP.Text = "HP: ";
            // 
            // PlayerMana
            // 
            this.PlayerMana.AutoSize = true;
            this.PlayerMana.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlayerMana.Location = new System.Drawing.Point(406, 39);
            this.PlayerMana.Name = "PlayerMana";
            this.PlayerMana.Size = new System.Drawing.Size(76, 23);
            this.PlayerMana.TabIndex = 6;
            this.PlayerMana.Text = "Mana: ";
            // 
            // EnemyHP
            // 
            this.EnemyHP.AutoSize = true;
            this.EnemyHP.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EnemyHP.Location = new System.Drawing.Point(775, 39);
            this.EnemyHP.Name = "EnemyHP";
            this.EnemyHP.Size = new System.Drawing.Size(115, 23);
            this.EnemyHP.TabIndex = 7;
            this.EnemyHP.Text = "Enemy HP:";
            // 
            // EnemyResponse
            // 
            this.EnemyResponse.AutoSize = true;
            this.EnemyResponse.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EnemyResponse.Location = new System.Drawing.Point(435, 294);
            this.EnemyResponse.Name = "EnemyResponse";
            this.EnemyResponse.Size = new System.Drawing.Size(0, 23);
            this.EnemyResponse.TabIndex = 8;
            // 
            // PlayerHPValue
            // 
            this.PlayerHPValue.AutoSize = true;
            this.PlayerHPValue.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlayerHPValue.Location = new System.Drawing.Point(82, 39);
            this.PlayerHPValue.Name = "PlayerHPValue";
            this.PlayerHPValue.Size = new System.Drawing.Size(0, 23);
            this.PlayerHPValue.TabIndex = 9;
            // 
            // PlayerManaValue
            // 
            this.PlayerManaValue.AutoSize = true;
            this.PlayerManaValue.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlayerManaValue.Location = new System.Drawing.Point(488, 39);
            this.PlayerManaValue.Name = "PlayerManaValue";
            this.PlayerManaValue.Size = new System.Drawing.Size(0, 23);
            this.PlayerManaValue.TabIndex = 10;
            // 
            // EnemyHPValue
            // 
            this.EnemyHPValue.AutoSize = true;
            this.EnemyHPValue.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EnemyHPValue.Location = new System.Drawing.Point(896, 39);
            this.EnemyHPValue.Name = "EnemyHPValue";
            this.EnemyHPValue.Size = new System.Drawing.Size(0, 23);
            this.EnemyHPValue.TabIndex = 11;
            // 
            // PlayerCastSpell
            // 
            this.PlayerCastSpell.Location = new System.Drawing.Point(705, 322);
            this.PlayerCastSpell.Name = "PlayerCastSpell";
            this.PlayerCastSpell.Size = new System.Drawing.Size(163, 87);
            this.PlayerCastSpell.TabIndex = 4;
            this.PlayerCastSpell.Text = "Cast Spell";
            this.PlayerCastSpell.UseVisualStyleBackColor = true;
            this.PlayerCastSpell.Click += new System.EventHandler(this.PlayerCastSpell_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 610);
            this.Controls.Add(this.EnemyHPValue);
            this.Controls.Add(this.PlayerManaValue);
            this.Controls.Add(this.PlayerHPValue);
            this.Controls.Add(this.EnemyResponse);
            this.Controls.Add(this.EnemyHP);
            this.Controls.Add(this.PlayerMana);
            this.Controls.Add(this.PlayerHP);
            this.Controls.Add(this.PlayerCastSpell);
            this.Controls.Add(this.PlayerRegenMana);
            this.Controls.Add(this.PlayerRegenHP);
            this.Controls.Add(this.PlayerAttack);
            this.Controls.Add(this.OutMessage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Label OutMessage;
        private Button PlayerAttack;
        private Button PlayerRegenHP;
        private Button PlayerRegenMana;
        public Label PlayerHP;
        public Label PlayerMana;
        public Label EnemyHP;
        public Label EnemyResponse;
        public Label PlayerHPValue;
        public Label PlayerManaValue;
        public Label EnemyHPValue;
        private Button PlayerCastSpell;
    }
}