namespace House
{
    public interface IHasExteriorDoor
    {
        int DoorDescription { get; }
        string DoorLocation { get; set; }
    }
}