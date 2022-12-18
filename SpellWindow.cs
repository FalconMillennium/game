using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class SpellWindow : Form
    {
        public static bool IsCast { get; private set; } = false;
        public SpellWindow()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            SpellList.Items.AddRange(Spells.spellNames.ToArray());
        }

        private void SpellList_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void CastSpell_Click(object sender, EventArgs e)
        {
            IsCast = false;
            Spells spell = new(SpellList.SelectedItem.ToString(), ref Game._playerMana);
            StatusEffects effect = new("Player") { Duration = spell.Duration, Potency = spell.Potency };
            IsCast = true;
            Close();
        }
    }
}
