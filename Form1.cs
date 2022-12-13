namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        /*        public string UserInput { get; set; }*/
        /*        public int i = 0;*/
        public string _message;
        public string _enemyResponse;
/*        public int _playerHP = Game.PlayerHP;
        public int _playerMana = Game._playerMana;
        public int _enemyHP = Game.EnemyHP;*/
        
        public Form1()
        {
            InitializeComponent();
            UpdateGame();
        }
        private void UpdateGame()
        {
            PopUp popup = new();
            PlayerHPValue.Text = $"{Game.PlayerHP}";
            PlayerManaValue.Text = $"{Game._playerMana}";
            EnemyHPValue.Text = $"{Game.EnemyHP}";
            if(Game.PlayerHP <= 0)
            {
                popup.GameLose();
                popup.ShowDialog();
            }
            else if(Game.EnemyHP <= 0) 
            {
                popup.GameWin();
                popup.ShowDialog();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
/*            DifficultyMenu difficulty = new DifficultyMenu();
            difficulty.ShowDialog();*/
        }

      /*  private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button1_Click(sender, e);
        }*/

        private void PlayerAttack_Click(object sender, EventArgs e)
        {
            Actions Attack = new("Attack", ref Game._turnToken, out _message);
            OutMessage.Text = _message;
     //       Game.AdvanceTurn(ref Game._turnToken);
            Game.EnemyLogic(ref Game._turnToken, out _enemyResponse);
            EnemyResponse.Text = _enemyResponse;
            UpdateGame();
        }

        private void PlayerRegenHP_Click(object sender, EventArgs e)
        {
            Actions RegenHP = new("RegenHP", ref Game._turnToken, out _message);
            OutMessage.Text = _message;
       //     Game.AdvanceTurn(ref Game._turnToken);
            Game.EnemyLogic(ref Game._turnToken, out _enemyResponse);
            EnemyResponse.Text = _enemyResponse;
            UpdateGame();
        }
        private void PlayerRegenMana_Click(object sender, EventArgs e)
        {
            Actions RegenMana = new("RegenMana", ref Game._turnToken, out _message);
            OutMessage.Text = _message;
    //        Game.AdvanceTurn(ref Game._turnToken);
            Game.EnemyLogic(ref Game._turnToken, out _enemyResponse);
            EnemyResponse.Text = _enemyResponse;
            UpdateGame();
        }
        private void Message_Click(object sender, EventArgs e)
        {

        }
    }
}