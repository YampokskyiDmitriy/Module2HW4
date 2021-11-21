using Module2HW4.Models;
using Module2HW4.Services.Abstractions;

namespace Module2HW4.Services
{
    public class CountService : ICountService
    {
        public int CountDifferentTypes(Animal[] animals)
        {
            var count = 0;
            var quantityOfTypes = new int[8];
            foreach (var animal in animals)
            {
                if (animal.GetType().Name == "Scorpion")
                {
                    quantityOfTypes[0]++;
                }
                else if (animal.GetType().Name == "Spider")
                {
                    quantityOfTypes[1]++;
                }
                else if (animal.GetType().Name == "Butterfly")
                {
                    quantityOfTypes[2]++;
                }
                else if (animal.GetType().Name == "Mantis")
                {
                    quantityOfTypes[3]++;
                }
                else if (animal.GetType().Name == "Elephant")
                {
                    quantityOfTypes[4]++;
                }
                else if (animal.GetType().Name == "Lion")
                {
                    quantityOfTypes[5]++;
                }
                else if (animal.GetType().Name == "Gecko")
                {
                    quantityOfTypes[6]++;
                }
                else if (animal.GetType().Name == "Turtle")
                {
                    quantityOfTypes[7]++;
                }
            }

            foreach (var quant in quantityOfTypes)
            {
                if (quant != 0)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
