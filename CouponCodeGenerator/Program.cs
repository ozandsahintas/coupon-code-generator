using System.Configuration;

namespace CouponCodeGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int generations = Configurator.Generations;

            Console.WriteLine("Password:");
            int pass = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Select an operation.");
            Console.WriteLine("\n 1 - Generation \n 2 - Validation \n 0 - Exit ");
            var selection = Convert.ToInt32(Console.ReadLine());

            switch (selection)
            {
                case 0: Console.WriteLine(); break;
                case 1:
                    var r = CodeGenerator.GenerateCoupons(pass, generations);
                    CodeGenerator.DisplayCoupons(pass, generations);
                    break;
                case 2:
                    // pass: 555, code: T5YCRREE
                    Console.WriteLine("Code:");
                    string code = Console.ReadLine() ?? "";

                    var coupon = CodeValidator.ValidateCoupon(pass, code, generations);
                    Console.WriteLine(coupon);
                    break;
                default: Console.WriteLine("Wrong input."); break;
            }

            Console.ReadLine();
        }
    }
}
