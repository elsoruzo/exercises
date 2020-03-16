namespace DoorsAbstractFactory.Models
{
    using System;
    using System.Collections.Generic;

    public class SedaFactory : DoorAbstractFactory
    {

        public SedaFactory(string modelName) : base (modelName)
        {
            BulildDoorCollection();
        }

        public override IList<IDoor> DoorCollection { get; set; } = new List<IDoor>();

        public override IList<IDoor> CreateClassicDoor(IDoorBlooprint blooprint, int amounth)
        {
            var door = ConvertBlooprintToDoor(blooprint);
            door.Design = "ClassicSeda";
            return CreateListOfDoors(door, amounth);
        }

        public override IList<IDoor> CreateModernDoor(IDoorBlooprint blooprint, int amounth)
        {
            var door = ConvertBlooprintToDoor(blooprint);
            door.Design = "ClassicSeda";
            return CreateListOfDoors(door, amounth);
        }

        protected override void BulildDoorCollection()
        {
            var sedaA = new SedaA();
            var sedaB = new SedaB();
            DoorCollection = new List<IDoor>();
            DoorCollection.Add(sedaA);
            DoorCollection.Add(sedaB);
        }
    }
}
