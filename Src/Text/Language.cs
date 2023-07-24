namespace OOPAdventure;

// Will hold all the properties for all the text for our game
public abstract class Language
{
    public string Welcome { get; protected set; } = "";
    public string ChooseYourName { get; protected set; } = "";
    public string DefaultName { get; protected set; } = "";
    public string DefaultRoomName { get; set; } = "";
    public string DefaultRoomDescription { get; set; } = "";
}
