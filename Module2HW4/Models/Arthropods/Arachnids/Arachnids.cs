using Module2HW4.Models.Enums;

namespace Module2HW4.Models.Arthropods.Arachnids
{
    public abstract class Arachnids : Arthropods
    {
        public abstract ArachnidsType ArachnidsType { get; }
        public override ArthropodsType ArthropodsType => ArthropodsType.Arachnids;
    }
}