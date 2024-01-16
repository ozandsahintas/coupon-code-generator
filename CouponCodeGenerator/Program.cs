using System.Configuration;

namespace CouponCodeGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int generations = Configurator.Generations ?? 10;

            Console.WriteLine("Şifre:");
            int pass = Convert.ToInt32(Console.ReadLine());

            Console.ReadLine();
        }
    }
}
