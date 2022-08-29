namespace Exemplo4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero ");
            var numero1 = Console.ReadLine();
            Console.WriteLine("Digite outro numero");
            var numero2 = Console.ReadLine();

            int num1 = int.Parse(numero1);
            int num2 = int.Parse(numero2);
            
            if (num1 < num2)
            {
                for(int i = num1+1; i < num2;i++)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                Console.WriteLine("Invalido");
            }
        }
    }
}