namespace DoorsAbstractFactory.Models
{
    using System.Linq;
    using System.Collections.Generic;

    public abstract class DoorAbstractFactory: IDoorFactory
    {
        protected string _modelName { get; set; }
        public DoorAbstractFactory(string modelName)
        {
            _modelName = modelName;
        }
        protected IDoor FindModel() 
        {
            return DoorCollection.ToList().Find(d => d.Model == _modelName);
        }

        protected  IDoor ConvertBlooprintToDoor(IDoorBlooprint blooprint)
        {
            var door = FindModel();
            door.High = blooprint.High != 0 ? blooprint.High : door.High;
            door.Width = blooprint.Width != 0 ? blooprint.Width : door.Width;
            door.Depth = blooprint.Depth != 0 ? blooprint.Depth : door.Depth;
            door.Color = blooprint.Color.Length != 0 ? blooprint.Color : door.Color;
            door.Material = blooprint.Material.Length != 0 ? blooprint.Material : door.Material;
            return door;
        }

        protected IList<IDoor> CreateListOfDoors(IDoor door, int amounth)
        {
            var lisOfDoors = new List<IDoor>();
            for(int i = 0; i < amounth; i++)
            {
                lisOfDoors.Add(door);
            }
            return lisOfDoors;
        }

        protected abstract void BulildDoorCollection();
        public abstract IList<IDoor> DoorCollection { get; set; }
        public abstract IList<IDoor> CreateClassicDoor(IDoorBlooprint blooprint, int amounth);
        public abstract IList<IDoor> CreateModernDoor(IDoorBlooprint blooprint, int amounth);

    }
} 
