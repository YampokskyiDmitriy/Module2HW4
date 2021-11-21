using Module2HW4.Models;
using Module2HW4.Providers.Abstractions;
using Module2HW4.Services.Abstractions;

namespace Module2HW4.Services
{
    public class SafariService : ISafariService
    {
        private readonly IAnimalProvider _animalProvider;
        public SafariService(IAnimalProvider animalProvider)
        {
            _animalProvider = animalProvider;
        }

        private Animal[] Animals { get; set; }
        public void Clear()
        {
           Animals = new Animal[0];
        }

        public void Fill()
        {
            Animals = _animalProvider.GetAnimals();
        }

        public Animal FindByWeight()
        {
            throw new System.NotImplementedException();
        }

        public Animal[] GetAnimals()
        {
            return Animals;
        }

        public void SortByWeight()
        {
            throw new System.NotImplementedException();
        }
    }
}
