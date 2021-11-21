using System;
using Module2HW4.Services.Abstractions;

namespace Module2HW4
{
    public class Starter
    {
        private ISafariService _safariService;
        public Starter(ISafariService safariService)
        {
            _safariService = safariService;
        }

        public void Run()
        {
            _safariService.Fill();
            _safariService.SortByWeight();
            var countOfTypes = _safariService.CountDifferentTypes();
            var searchResult = _safariService.FindByWeight(0.33);
            Console.WriteLine(countOfTypes);
        }
    }
}