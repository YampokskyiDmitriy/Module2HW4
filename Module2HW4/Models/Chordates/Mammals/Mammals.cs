using Module2HW4.Models.Enums;

namespace Module2HW4.Models.Chordates.Mammals
{
    public abstract class Mammals : Chordates
    {
        public abstract MammalsType MammalsType { get; }
        public override ChordatesType ChordatesType => ChordatesType.Mammals;
    }
}
