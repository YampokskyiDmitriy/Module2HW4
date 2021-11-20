using Module2HW4.Models.Enums;

namespace Module2HW4.Models.Chordates.Reptiles
{
    public abstract class Reptiles : Chordates
    {
        public abstract ReptilesType ReptilesType { get; }
        public override ChordatesType ChordatesType => ChordatesType.Reptiles;
    }
}