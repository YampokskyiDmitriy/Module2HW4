using Module2HW4.Models;
using Module2HW4.Services.Abstractions;

namespace Module2HW4.Services
{
    public class CountService : ICountService
    {
        public int CountDifferentTypes(Animal[] animals)
        {
            var count = 0;
            for (var i = 0; i < animals.Length; i++)
            {
                var isDuplicate = false;
                for (var j = 0; j < i; j++)
                {
                    if (animals[i].GetType().Name == animals[j].GetType().Name)
                    {
                        isDuplicate = true;
                        break;
                    }
                }

                if (!isDuplicate)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
