using System.Windows.Forms;

namespace House
{
    public partial class Form1 : Form
    {
        private OutsideWithDoor _frontYard;
        private OutsideWithDoor _backYard;
        private Outside _garden;
        private RoomWithDoor _livingRoom;
        private RoomWithDoor _kitchen;
        private Room _diningRoom;

        public Form1()
        {
            InitializeComponent();
            CreateObjects();
        }

        public void CreateObjects()
        {
            _frontYard = new OutsideWithDoor("Front Yard", false, "An Oak Door With A Brass Knob");
            _backYard = new OutsideWithDoor("Back Yard", true, "A Screen Door");
            _garden = new Outside("Garden", false);
            _livingRoom = new RoomWithDoor("Living Room", "Antique Carpet", "An Oak Door With A Brass Knob");
            _kitchen = new RoomWithDoor("Kitchen", "Stainless Steel appliances", "A Screen Door");
            _diningRoom = new Room("Dining Room", "Crystal Chandelier");

            _frontYard.Exits = new Location[] {_backYard, _garden};
            _backYard.Exits = new Location[] {_frontYard, _garden};
            _garden.Exits = new Location[] {_frontYard, _backYard};
            _livingRoom.Exits = new Location[] {_diningRoom};
            _kitchen.Exits = new Location[] {_diningRoom};
            _diningRoom.Exits = new Location[] {_livingRoom, _kitchen};
            
        }
    }
}
