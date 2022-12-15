public class Actions : Game
{
    /*    public float PlayerDamage { get; set; }
        public float EnemyDamage { get; set; }*/
    public int HPChange { get; set; }
    public int ManaChange { get; set; }
    //public string Action { get; set; }
    public int Attack(ref int HP, /*float Damage,*/ float difficultyMod, ulong _turnToken, out string message)
    {
        HPChange = 0;
        HP -= HPChange = (int)(Math.Round(RollDice(2, 6) * difficultyMod));
        if (_turnToken % 2 == 1)
        {
            message = $"You attack the {_enemy} for {Math.Abs(HPChange)} damage!";
        }
        else
        {
            message = $"The {_enemy} attacks you for {Math.Abs(HPChange)} damage!";
        }
        AdvanceTurn();
        return HP;
    }
    public void Regen(ref int HP, float difficultyMod, ref int mana, ulong _turnToken, out string message)
    {
        if (mana <= 0 && _turnToken % 2 == 1)
        {
            message = "You don't have enough mana!";
        }
        else
        {
            HP += HPChange = (int)(Math.Round(difficultyMod * RollDice(2, 5)));
            mana -= ManaChange = RollDice(1, 3);
            if (_turnToken % 2 == 1)
            {
                message = $"You used {ManaChange} mana to restore {HPChange} health!";
            }
            else
            {
                message = $"The {_enemy} used {ManaChange} mana to restore {HPChange} health!";
            }
        }
        AdvanceTurn();
    }
    public void Regen(ref int mana, float difficultyMod, ulong _turnToken, out string message)
    {
        ManaChange = 0;
        mana += ManaChange = (int)(Math.Round(difficultyMod * RollDice(1, 6)));
        if (_turnToken % 2 == 1) message = $"You restored {ManaChange} mana!";
        else message = $"The {_enemy} restored {ManaChange} mana!";
        AdvanceTurn();
    }
    public Actions()
    {
    }
    public Actions(string action, ulong _turnToken, out string message)
    {
        message = null;
        switch (action)
        {
            case "Attack":
                if (_turnToken % 2 == 1)
                    Attack(ref EnemyHP, /*PlayerDamage,*/ Difficulty.DifficultyModPlayer, _turnToken, out message);
                else
                    Attack(ref PlayerHP, /*EnemyDamage,*/ Difficulty.DifficultyModEnemy, _turnToken, out message);
                break;
            case "RegenHP":
                if (_turnToken % 2 == 1)
                    Regen(ref PlayerHP, Difficulty.DifficultyModPlayer, ref _playerMana, _turnToken, out message);
                else
                    Regen(ref EnemyHP, Difficulty.DifficultyModEnemy, ref _enemyMana, _turnToken, out message);
                break;
            case "RegenMana":
                if (_turnToken % 2 == 1)
                    Regen(ref _playerMana, Difficulty.DifficultyModPlayer, _turnToken, out message);
                else
                    Regen(ref _enemyMana, Difficulty.DifficultyModEnemy, _turnToken, out message);
                break;
        }
    }
}