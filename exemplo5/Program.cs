namespace exemplo5
{
    internal class Program
    {

        class TempRecord
        {
            private float[] temps = new float[10] {56.2f,56.3f,25.2f,58.6f,
                                                78.4f,78.5f,13.4f,59.7f,85.5f,78.3f};

            public float[] Temps { get { return temps; } } 
            

            public float this[int index]
            {
                get { return temps[index]; }
                set { temps[index] = value; }   
            }
        }

        static void Main(string[] args)
        {
            TempRecord tempRecord = new TempRecord();
            tempRecord[3] = 58.3f;
            tempRecord[5] = 60.1f;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Element #{0) = {1}", i, tempRecord[i]);
            }
            Console.WriteLine("Press any key to exit.");
            Console.ReadLine(); 
        }
    }
}