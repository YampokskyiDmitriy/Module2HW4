using Module2HW4.Models.Enums;

namespace Module2HW4.Models.Chordates.Mammals
{
    public class Elephant : Mammals
    {
        public ElephantType ElephantType { get; set; }
        public override MammalsType MammalsType => MammalsType.Proboscidean;
    }
}
