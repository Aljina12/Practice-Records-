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