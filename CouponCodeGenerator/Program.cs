using System.Configuration;

namespace CouponCodeGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int generations = Configurator.Generations;

            Console.WriteLine("Şifre:");
            int pass = Convert.ToInt32(Console.ReadLine());

            var r = CodeGenerator.GenerateCoupons(pass, generations);
            CodeGenerator.DisplayCoupons(pass, generations);

            Console.ReadLine();
        }
    }
}
