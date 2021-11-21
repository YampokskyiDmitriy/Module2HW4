using Module2HW4.Models;

namespace Module2HW4.Services.Abstractions
{
    public interface ISafariService
    {
        public void Fill();
        public Animal[] GetAnimals();
        public void SortByWeight();
        public void Clear();
        public Animal FindByWeight();
    }
}