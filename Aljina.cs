    class Counter
    {
        public int Count = 0;

        public void Increase()
        {
            Count = Count + 1;
        }

        public void Decrease()
        {
            Count = Count - 1;
        }

        public void Reset()
        {
            Count = 0;
        }
    }

        class Task20
    {
        public static void Run()
        {
            Counter counter = new Counter();

            counter.Increase();
            counter.Increase();
            counter.Increase();
            Console.WriteLine("After 3 increases: " + counter.Count);

            counter.Decrease();
            Console.WriteLine("After 1 decrease: " + counter.Count);

            counter.Reset();
            Console.WriteLine("After reset: " + counter.Count);
        }
    }