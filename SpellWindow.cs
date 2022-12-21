namespace WinFormsApp1
{
    public partial class SpellWindow : Form
    {
        public static bool IsCast { get; private set; } = false;
        public static ulong Duration { get; set; }
        public static int Potency { get; set; }
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
            Spells spell = new(SpellList.SelectedItem.ToString(), ref Game._playerMana, "Player");
            IsCast = true;
            Close();
        }
    }
}