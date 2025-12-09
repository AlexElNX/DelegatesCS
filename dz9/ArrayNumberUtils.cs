namespace dz9
{
    internal class ArrayNumberUtils
    {
        public int[] Array {get; set;}
        public ArrayNumberUtils(uint size) 
        {
            if (size < 1) throw new ArgumentOutOfRangeException("Size cannot be less than 1");
            Array = new int[size];
            Random random = new Random();
            for (int i = 0; i < size; ++i)
            {
                Array[i] = random.Next(0, 100);
            }
        }

        public void Even()
        {
            foreach (int i in Array)
            {
                if (i % 2 == 0) Console.WriteLine(i);
            }
        }
        public void Odd()
        {
            foreach (int i in Array)
            {
                if (i % 2 != 0) Console.WriteLine(i);
            }
        }

        public void SimpleNumber()
        {
            foreach (int i in Array)
            {
                if(i > 1)
                {
                    bool isSimple = true;
                    for (int j = 2; j <= Math.Sqrt(i); ++j)
                    {
                        if (i % j == 0)
                        {
                            isSimple = false;
                            break;
                        }
                    }

                    if (isSimple)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }
        public void Print()
        {
            foreach (int i in Array) Console.WriteLine(i);
        }

    }
}
