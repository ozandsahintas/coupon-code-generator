using System.Configuration;
using static System.Net.Mime.MediaTypeNames;

namespace CouponCodeGenerator
{
    public class CodeGenerator
    {
        static readonly string dataSet = Configurator.CharacterSet;

        public static string[] GenerateCoupons(int pass, int gen)
        {
            // Not as unique as guid but would be a better option.
            // var rand = new Random(Guid.NewGuid().GetHashCode());
            var rnd = new Random(pass);

            // These are just codes yet, not coupons.
            return GenerateCodes(rnd, gen, 8);

        }

        public static void DisplayCoupons(int pass, int gen)
        {
            var rnd = new Random(pass);
            DisplayCodes(rnd, gen, 8);
        }

        static string[] GenerateCodes(Random r, int gen, int length = 8)
        {
            string[] coupons = new string[gen];

            for (int i = 0; i < gen; i++)
            {
                var coupon = "";
                for (int j = 0; j < length; j++)
                {
                    coupon += dataSet[r.Next(0, dataSet.Length)];
                }

                coupons[i] = coupon;
            }

            return coupons;
        }

        static void DisplayCodes(Random r, int gen, int length = 8)
        {

            for (int i = 0; i < gen; i++)
            {
                var coupon = "";
                for (int j = 0; j < length; j++)
                {
                    coupon += dataSet[r.Next(0, dataSet.Length)];
                }

                Console.WriteLine(coupon);
            }
        }
    }
}




