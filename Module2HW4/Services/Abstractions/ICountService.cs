using Module2HW4.Models;

namespace Module2HW4.Services.Abstractions
{
    public interface ICountService
    {
        public int CountDifferentTypes(Animal[] animals);
    }
}
