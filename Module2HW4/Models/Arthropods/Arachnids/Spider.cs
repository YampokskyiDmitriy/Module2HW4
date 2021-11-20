using Module2HW4.Models.Enums;

namespace Module2HW4.Models.Arthropods.Arachnids
{
    public class Spider : Arachnids
    {
        public SpiderType SpiderType { get; }
        public override ArachnidsType ArachnidsType => ArachnidsType.Spiders;
    }
}
