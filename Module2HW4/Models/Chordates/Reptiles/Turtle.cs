using Module2HW4.Models.Enums;

namespace Module2HW4.Models.Chordates.Reptiles
{
    public class Turtle : Reptiles
    {
        public TurtleType TurtleType { get; set; }
        public override ReptilesType ReptilesType => ReptilesType.Turtles;
    }
}
