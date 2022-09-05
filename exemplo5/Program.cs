namespace exemplo5
{
    internal class Program
    {

        class TempRecord
        {
            private float[] temps = new float[10] {56.2F,56.3F,25.2F,58.6F,
                                                78.4F,78.5F,13.4F,59.7F,85.5F,78.3F};

            public int Length
            {
                get { return temps.Length; }
            }
            

            public float this[int index]
            {
                get { return temps[index]; }
                set { temps[index] = value; }   
            }
        }

        static void Main(string[] args)
        {
            TempRecord tempRecord = new TempRecord();
            tempRecord[3] = 58.3F;
            tempRecord[5] = 60.1F;

            for (int i = 0; i < 10; i++)
            {
                System.Console.WriteLine("Element #{0} = {1}", i, tempRecord[i]);
            }
            System.Console.WriteLine("Press any key to exit.");
            System.Console.ReadLine(); 
        }
    }
}