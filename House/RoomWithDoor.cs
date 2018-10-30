namespace House
{
    public class RoomWithDoor : Room, IHasExteriorDoor
    {
        public RoomWithDoor(string name) : base(name)
        {
        }

        public int DoorDescription { get; }
        public string DoorLocation { get; set; }
    }
}