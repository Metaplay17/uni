using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roaches
{
    internal static class RandomGenerator
    {
        private static Random random = new Random();

        public static int GetRandomNumber(int low, int high)
        {
            return random.Next(low, high);
        }
    }
}
