namespace exemplo03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um numero");
            var numero = Console.ReadLine();
            int num = int.Parse(numero);

            if (num >= 10 && num <= 100)
            {
                Console.WriteLine("O numero esta no intervalo");
            }
            else
            {
                Console.WriteLine("O numero não esta no intervalo");

            }
        }
    }
}