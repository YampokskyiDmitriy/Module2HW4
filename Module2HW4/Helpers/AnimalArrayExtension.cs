using System;
using Module2HW4.Models;

namespace Module2HW4.Helpers
{
    public static class AnimalArrayExtension
    {
        public static Animal[] FindByWeight(this Animal[] array, double weight)
        {
            var result = new Animal[0];
            foreach (var animal in array)
            {
                if (animal.Weight == weight)
                {
                    Array.Resize(ref result, result.Length + 1);
                    result[result.Length - 1] = animal;
                }
            }

            return result;
        }
    }
}