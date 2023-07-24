namespace OOPAdventure;

public partial class House
{
    public Room CurretRoom { get; set; }

    public void GoToRoom(int index)
    {
        if (CurretRoom != null)
        {
            CurretRoom.Visited = true;
        }

        CurretRoom = Rooms[index];
    }

    public void GoToStartingRoom()
    {
        GoToRoom(_rnd.Next(0, Rooms.Length));
    }
}