namespace House
{
    public interface IHasExteriorDoor
    {
        string DoorDescription { get; }
        string DoorLocation { get; set; }
    }
}