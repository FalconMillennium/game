using WinFormsApp1;

public class Difficulty : Game
{
    public static int DifficultyLevel { get; set; }
    public static float DifficultyModPlayer { get; private set; }
    public static float DifficultyModEnemy { get; private set; }

    public static float DiffModPlayer(int DifficultyLevel)
    {
        DifficultyModPlayer = DifficultyLevel switch
        {
            1 => 1.25f,
            2 => 1,
            3 => 0.75f,
            _ => 1
        };
        return DifficultyModPlayer;
    }        
/*    static Difficulty()
    {
        DifficultyMenu menu = new();
        menu.ShowDialog();
    }*/
    static Difficulty()
    {
            DiffModPlayer(DifficultyLevel);
            DifficultyModEnemy = 2.0f - DifficultyModPlayer;
    }
}