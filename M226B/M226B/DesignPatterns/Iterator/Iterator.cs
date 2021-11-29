using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Iterator
{
    public class Iterator
    {
        public static IEnumerable<int> GetRandoms(int count)
        {
            Random random = new Random();

            for (int i = 0; i < count; i++)
                yield return random.Next(0, int.MaxValue);
        }
    }
}
