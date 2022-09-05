namespace ConsoleApp1
{
    internal class Program
    {
        public partial class CoOrds
        {
            private int x;
            private int y;

            public CoOrds(int x, int y)            {
                this.x = x;
                this.y = y;
            }

        }
        public partial class CoOrds
        {
            public void PrintCoOrds()
            {
                Console.WriteLine("CoOrds: {0},{1}", x, y);
            }
        }
        static void Main(string[] args)
        {
            CoOrds myCoOrds = new CoOrds(10, 5);
            myCoOrds.PrintCoOrds();
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}