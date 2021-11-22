using Module2HW4.Models.Enums;

namespace Module2HW4.Models.Arthropods.Insects
{
    public class Butterfly : Insects
    {
        public ButterflyType ButterflyType { get; set; }
        public override InsectsType InsectsType => InsectsType.Dragonflies;
    }
}
