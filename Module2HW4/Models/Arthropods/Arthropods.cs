using Module2HW4.Models.Enums;

namespace Module2HW4.Models.Arthropods
{
    public abstract class Arthropods : Animal
    {
        public abstract ArthropodsType ArthropodsType { get; }
        public override AnimalType AnimalType => AnimalType.Arthropods;
    }
}
