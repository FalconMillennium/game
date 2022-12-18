/*
tasks:
player & enemy health + mana
each turn player can attack, heal or regen mana
if player hp <= 0 lose, if enemy hp <= 0 win
can't heal with 0 mana
might make this foundation into something more complex
 */
/*
 TODO next:
spells & status effects: duration handling by taking current turn, adding duration and applying the effect till current turn matches turn + duration
add another menu for this
game data handled thru json
 */
/*Game game = new();

game.RunGame();
*/
using WinFormsApp1;

public partial class Program
{
    static void Main()
    {
        DifficultyMenu diffmenu = new();
        diffmenu.ShowDialog();
        Form1 menu = new();
        menu.ShowDialog();
    }

}