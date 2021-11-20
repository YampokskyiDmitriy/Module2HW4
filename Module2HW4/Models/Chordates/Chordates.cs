using Module2HW4.Models.Enums;

namespace Module2HW4.Models.Chordates
{
    public abstract class Chordates : Animal
    {
        public abstract ChordatesType ChordatesType { get; }
        public override AnimalType AnimalType => AnimalType.Chordates;
    }
}
