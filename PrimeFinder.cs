using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Dcoder
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int rangeMin = 0;
            int rangeMax = 100000;

            Enumerable.Range(rangeMin, rangeMax).ToList().ForEach(possiblePrime =>
            {
                int factors = 0;
                Enumerable.Range(1, possiblePrime / 2).ToList().ForEach(possibleFactor =>
                  {
                      if (factors > 1) return;
                      if (possiblePrime % possibleFactor != 0) return;
                      factors++;
                  });
                if (factors > 1) return;
                Console.WriteLine(possiblePrime);

            });
        }
    }
}
