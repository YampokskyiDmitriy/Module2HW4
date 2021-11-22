using Module2HW4.Models.Enums;

namespace Module2HW4.Models.Chordates.Mammals
{
    public class Lion : Mammals
    {
        public LionType LionType { get; set; }
        public override MammalsType MammalsType => MammalsType.Predatory;
    }
}
