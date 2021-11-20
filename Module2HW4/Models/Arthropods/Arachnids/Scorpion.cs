using Module2HW4.Models.Enums;

namespace Module2HW4.Models.Arthropods.Arachnids
{
    public class Scorpion : Arachnids
    {
        public ScorpionType ScorpionType { get; set; }
        public override ArachnidsType ArachnidsType => ArachnidsType.Tartarids;
    }
}
