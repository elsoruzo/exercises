namespace DoorsAbstractFactory.Models
{
    using System;
    using System.Collections.Generic;

    public class VegaFactory : DoorAbstractFactory
    {
        public VegaFactory(string modelName) : base(modelName)
        {
            BulildDoorCollection();
        }

        public override IList<IDoor> DoorCollection { get; set; }

        public override IList<IDoor> CreateClassicDoor(IDoorBlooprint blooprint, int amounth)
        {
            var door = ConvertBlooprintToDoor(blooprint);
            door.Design = "ClassicVega";
            return CreateListOfDoors(door, amounth);
        }

        public override IList<IDoor> CreateModernDoor(IDoorBlooprint blooprint, int amounth)
        {
            var door = ConvertBlooprintToDoor(blooprint);
            door.Design = "ModernVega";
            return CreateListOfDoors(door, amounth);
        }

        protected override void BulildDoorCollection()
        {
            var vegaA = new VegaA();
            var vegaB = new VegaB();
            DoorCollection = new List<IDoor>();
            DoorCollection.Add(vegaA);
            DoorCollection.Add(vegaB);
        }
    }
}
