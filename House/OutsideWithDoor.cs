namespace House
{
    public class OutsideWithDoor : Outside, IHasExteriorDoor
    {
        public OutsideWithDoor(string name) : base(name)
        {
        }

        public int DoorDescription { get; }
        public string DoorLocation { get; set; }
    }
}