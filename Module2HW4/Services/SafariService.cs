using System;
using Module2HW4.Models;
using Module2HW4.Helpers;
using Module2HW4.Services.Abstractions;
using Module2HW4.Providers.Abstractions;

namespace Module2HW4.Services
{
    public class SafariService : ISafariService
    {
        private readonly IAnimalProvider _animalProvider;
        private readonly ICountService _countService;
        public SafariService(IAnimalProvider animalProvider, ICountService countService)
        {
            _animalProvider = animalProvider;
            _countService = countService;
        }

        private Animal[] Animals { get; set; }
        public void Clear()
        {
           Animals = new Animal[0];
        }

        public int CountDifferentTypes()
        {
            return _countService.CountDifferentTypes(Animals);
        }

        public void Fill()
        {
            Animals = _animalProvider.GetAnimals();
        }

        public Animal[] FindByWeight(double weight)
        {
            return Animals.FindByWeight(weight);
        }

        public Animal[] GetAnimals()
        {
            return Animals;
        }

        public void SortByWeight()
        {
            var comparer = new AnimalComparer();
            Array.Sort(Animals, comparer);
        }
    }
}
