using System.Collections;
using Module2HW4.Models;

namespace Module2HW4.Helpers
{
    public class AnimalComparer : IComparer
    {
        public int Compare(object first, object second)
        {
            var firstAnimal = first as Animal;
            var secondAnimal = second as Animal;
            if (firstAnimal == null || secondAnimal == null)
            {
                return 0;
            }

            if (firstAnimal.Weight > secondAnimal.Weight)
            {
                return 1;
            }
            else if (firstAnimal.Weight < secondAnimal.Weight)
            {
                return -1;
            }

            return 0;
        }
    }
}
