/*
tasks:
player & enemy health + mana
each turn player can attack, heal or regen mana
if player hp <= 0 lose, if enemy hp <= 0 win
can't heal with 0 mana
might make this foundation into something more complex
 */
/*Game game = new();

game.RunGame();
*/
using WinFormsApp1;

public class Program
{
    static void Main()
    {
        DifficultyMenu diffmenu = new();
        diffmenu.ShowDialog();
        Form1 menu = new();
        menu.ShowDialog();
    }

}