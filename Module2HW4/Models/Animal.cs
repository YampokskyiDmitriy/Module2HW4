using Module2HW4.Models.Enums;

namespace Module2HW4.Models
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public abstract AnimalType AnimalType { get; }
    }
}
