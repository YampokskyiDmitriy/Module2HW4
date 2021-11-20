using Module2HW4.Models.Enums;

namespace Module2HW4.Models.Arthropods.Insects
{
    public abstract class Insects : Arthropods
    {
        public abstract InsectsType InsectsType { get; }
        public override ArthropodsType ArthropodsType => ArthropodsType.Insects;
    }
}
