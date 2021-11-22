using Module2HW4.Models.Enums;

namespace Module2HW4.Models.Arthropods.Insects
{
    public class Mantis : Insects
    {
        public MantisType MantisType { get; set; }
        public override InsectsType InsectsType => InsectsType.Fleas;
    }
}
