using WinFormsApp1;

public class Difficulty : Game
{
    public static int DifficultyLevel { get; set; }
    public float DifficultyModPlayer { get; set; }
    public float DifficultyModEnemy { get; set; }
    public static int I { get; set; } = 1;

    public float DiffModPlayer(int DifficultyLevel)
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
    public Difficulty()
    {
            DiffModPlayer(DifficultyLevel);
            DifficultyModEnemy = 2.0f - DifficultyModPlayer;
    }
}