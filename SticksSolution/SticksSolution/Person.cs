namespace SticksSolution
{
    public class Person
    {
        public int SticksHolded { get; private set; }

        public int Id { get; private set; }

        public int NewSticksHolded { get; private set; }

        public bool IsAllocated { get; private set; }

        public Person(int id, int sticksHolded)
        {
            Id = id;
            SticksHolded = sticksHolded;
            NewSticksHolded = SticksHolded;
        }

        public void CalculateLoad(int sumOfAllCount)
        {
            NewSticksHolded = sumOfAllCount - SticksHolded;
            if (NewSticksHolded < 0)
            {
                IsAllocated = true;
                NewSticksHolded = SticksHolded;
            }
        }
    }
}