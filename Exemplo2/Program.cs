namespace Exemplo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Leia numero 1");
            var numeroStr1 = Console.ReadLine();
            Console.WriteLine("Leia numero 2");
            var numeroStr2 = Console.ReadLine();

            int numero1 = Convert.ToInt32(numeroStr1);
            int numero2 = Convert.ToInt32(numeroStr2);
            Console.WriteLine("A soma é " + (numero1 + numero2));
            Console.WriteLine("A divisão é " + (numero1 / numero2));
            Console.WriteLine("A multiplicaçao é " + (numero1 * numero2));
            Console.WriteLine("A subtração é " + (numero1 - numero2));

            if (numero1 > numero2)
            {
                Console.WriteLine("numero 1 é mairo que numero 2");
            }
            else
            {
                Console.WriteLine("numero 2 ´maior que numero 1");
            }
        }
    }
}