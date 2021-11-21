using Module2HW4.Models;
using Module2HW4.Models.Enums;
using Module2HW4.Providers.Abstractions;
using Module2HW4.Models.Chordates.Mammals;
using Module2HW4.Models.Arthropods.Insects;
using Module2HW4.Models.Chordates.Reptiles;
using Module2HW4.Models.Arthropods.Arachnids;

namespace Module2HW4.Providers
{
    public class AnimalProvider : IAnimalProvider
    {
        public Animal[] GetAnimals()
        {
            var animals = new Animal[]
            {
                new Scorpion { Name = "Scorpi", Weight = 0.63, ScorpionType = ScorpionType.Imperial },
                new Spider { Name = "Piter", Weight = 0.33, SpiderType = SpiderType.Hirakantis },
                new Butterfly { Name = "Batafurii", Weight = 0.12, ButterflyType = ButterflyType.Glossata },
                new Mantis { Name = "Suicider", Weight = 1.3, MantisType = MantisType.Chaeteessidae },
                new Elephant { Name = "Dambo", Weight = 412.5, ElephantType = ElephantType.African },
                new Lion { Name = "Simba", Weight = 170.6, LionType = LionType.EastAfrican },
                new Gecko { Name = "Rango", Weight = 5.3, GeckoType = GeckoType.Hemiteconix },
                new Turtle { Name = "Rafaelo", Weight = 100, TurtleType = TurtleType.RedEared }
            };

            return animals;
        }
    }
}