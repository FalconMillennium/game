using System.Windows.Forms;

public class Game
{
    public static int _playerHP;
    public static int _enemyHP; 
    public static int _playerMana;
    public static int _enemyMana;
    public static int DiceSides { get; private set; }
    public static int DiceAmount { get; private set; }
    public static int DiceRoll { get; private set; }
    public static Enemies _enemy;
    public static Actor Entity { get; set; }
    public static ulong TurnNumber { get; private set; } = 1;
/*    public static int NumberCheck(int number, int rangeMin, int rangeMax)
    {
        bool isCorrect = false;
        while (!isCorrect || number < rangeMin || number > rangeMax)
        {
            if (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Not a number.");
                isCorrect = false;
            }
            else isCorrect = true;
        }
        return number;
    }*/
/*    public void RunGame()
    {
        while (IsRunning)
        {


         *//*   actions.Attack(PlayerHP, actions.EnemyDamage, diff.DifficultyModPlayer, (Actor)1);
            actions.Attack(EnemyHP, actions.PlayerDamage, diff.DifficultyModEnemy, "Enemy");*/

/*            actions.Regen(PlayerHP, diff.DifficultyModPlayer, ref _playerMana, "Player");
            if (EnemyHP <= 15)
                actions.Regen(EnemyHP, diff.DifficultyModEnemy, ref _enemyMana, "Enemy");*//*
        }
        if(PlayerHP <= 0 || EnemyHP <= 0) { IsRunning = false; }
    }*/
   /* public string ConsoleOutput(string entity, )
    {


    }*/
/*    public static int PlayerChoice()
    {
        Console.WriteLine($"[1] Attack [2] Heal [3] Restore Mana");
        Choice = NumberCheck(Choice, 1, 3);
        return Choice;
    }*/
    public static int RollDice(int diceAmount, int diceSides)
    {
        DiceRoll = 0;
        Random rand = new();
        for (int i = 0; i < diceAmount; i++)
        {
            DiceRoll += rand.Next(1, diceSides+1);
        }
        return DiceRoll;
    }
    public static int EnemyType()
    {
        int number = _enemyHP switch
        {
            < 18 => 1,
            < 27 => 2,
            < 36 => 3,
            _ => 4,
        };
        return number;
    }
    public static void AdvanceTurn() => TurnNumber++;
    public static void EnemyLogic(ulong turnToken, out string response)
    {
        response = null;
        Random rand = new();
        int decision = rand.Next(1, 4);
        switch(decision)
        {
            case 1: Actions EnemyAttack = new("Attack", TurnNumber, out response); break;
            case 2: if (_enemyHP <= 15) { Actions EnemyHPRegen = new("RegenHP", TurnNumber, out response); break; } else goto case 1;
            case 3: if (_enemyMana <= 5) { Actions EnemyManaRegen = new("RegenMana", TurnNumber, out response); break; } else goto case 1;
        }
    }
    static Game()
    {
        Difficulty diff = new();
        _playerHP = (int)(Math.Round(Math.Max(12, RollDice(5, 9)) * Difficulty.DifficultyModPlayer));
        _enemyHP = (int)(Math.Round(Math.Max(12, RollDice(5, 9)) * Difficulty.DifficultyModEnemy));
        _playerMana = (int)(Math.Round(Math.Max(4, RollDice(2, 6)) * Difficulty.DifficultyModPlayer));
        _enemyMana = (int)(Math.Round(Math.Max(4, RollDice(2, 6)) * Difficulty.DifficultyModEnemy));
        _enemy = (Enemies)EnemyType();
    }
}

public enum Enemies {Goblin = 1, Orc, Demon, Dragon }
public enum Actor {Player = 1, Enemy = 2 }