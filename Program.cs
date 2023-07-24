using OOPAdventure;
using static System.Console;

Text.LoadLanguage(new English());

WriteLine(Text.Language.ChooseYourName);

var name = ReadLine();

if (name == String.Empty)
{
    name = Text.Language.DefaultName;
}

var player = new Player(name);

WriteLine(Text.Language.Welcome, player.Name);

var house = new House(player);