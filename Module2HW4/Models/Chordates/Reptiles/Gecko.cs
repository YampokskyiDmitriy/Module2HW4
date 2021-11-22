using Module2HW4.Models.Enums;

namespace Module2HW4.Models.Chordates.Reptiles
{
    public class Gecko : Reptiles
    {
        public GeckoType GeckoType { get; set; }
        public override ReptilesType ReptilesType => ReptilesType.Beakheads;
    }
}
