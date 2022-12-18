namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public string _message;
        public string _enemyResponse;
        
        public Form1()
        {
            InitializeComponent();
            UpdateGame();
        }
        private void UpdateGame()
        {
            PlayerHPValue.Text = $"{Game._playerHP}";
            PlayerManaValue.Text = $"{Game._playerMana}";
            EnemyHPValue.Text = $"{Game._enemyHP}";
            if (Game._playerHP <= 0 || Game._enemyHP <= 0)
            {
                PopUp popup = new();
                if (Game._playerHP <= 0)
                {
                popup.GameLose();
                popup.ShowDialog();
               }
                else if (Game._enemyHP <= 0)
                {
                popup.GameWin();
                popup.ShowDialog();
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
/*            DifficultyMenu difficulty = new DifficultyMenu();
            difficulty.ShowDialog();*/
        }
        private void PlayerAttack_Click(object sender, EventArgs e)
        {
            Actions Attack = new("Attack", Game.TurnNumber, out _message);
            OutMessage.Text = _message;
     //       Game.AdvanceTurn(ref Game._turnToken);
            Game.EnemyLogic(Game.TurnNumber, out _enemyResponse);
            EnemyResponse.Text = _enemyResponse;
            UpdateGame();
        }

        private void PlayerRegenHP_Click(object sender, EventArgs e)
        {
            Actions RegenHP = new("RegenHP", Game.TurnNumber, out _message);
            OutMessage.Text = _message;
       //     Game.AdvanceTurn(ref Game._turnToken);
            Game.EnemyLogic(Game.TurnNumber, out _enemyResponse);
            EnemyResponse.Text = _enemyResponse;
            UpdateGame();
        }
        private void PlayerRegenMana_Click(object sender, EventArgs e)
        {
            Actions RegenMana = new("RegenMana", Game.TurnNumber, out _message);
            OutMessage.Text = _message;
            //        Game.AdvanceTurn(ref Game._turnToken);
            Game.EnemyLogic(Game.TurnNumber, out _enemyResponse);
            EnemyResponse.Text = _enemyResponse;
            UpdateGame();
        }
        private void PlayerCastSpell_Click(object sender, EventArgs e)
        {
            SpellWindow spells = new();
            spells.Show();
            if (SpellWindow.IsCast == true)
            {
                Game.EnemyLogic(Game.TurnNumber, out _enemyResponse);
                EnemyResponse.Text = _enemyResponse;
                UpdateGame();
            }
        }
        private void Message_Click(object sender, EventArgs e)
        {

        }


    }
}