using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SticksSolution
{
    public class Allocator
    {
        public Allocator()
        {
           
        }
        
        public void Allocate(int countToBeAllocated, List<Person> collectors)
        {
            CalculateNewLoad(countToBeAllocated, collectors);

            if (collectors.Any(a => a.IsAllocated))
            {
                Allocate(countToBeAllocated, collectors.Where(a => !a.IsAllocated).ToList());
            }
        }

        private void CalculateNewLoad(int countToBeAllocated, List<Person> collectors)
        {
            int sum = collectors.Sum(a => a.SticksHolded) + countToBeAllocated;
            List<int> value = Utils.Split(sum, collectors.Count);

            int i = 0;
            foreach (Person collector in collectors)
            {
                collector.CalculateLoad(value[i++]);
            }
        }
    }
}
