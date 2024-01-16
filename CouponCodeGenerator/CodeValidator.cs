using System.Configuration;
using static System.Net.Mime.MediaTypeNames;

namespace CouponCodeGenerator
{
    public class CodeValidator
    {
        static readonly string dataSet = Configurator.CharacterSet;


        public static string ValidateCoupon(int pass, string code, int gen)
        {
            Code? c = Validate(pass, code, gen);
            if (c == null)
            {
                return "Coupon does not exist.";
            }
            else
            {
                return "Coupon " + c._code + " found, index: " + c._index;
            }
        }

        static Code? Validate(int pass, string code, int gen)
        {
            var rnd = new Random(pass);
            return ValidateCodes(rnd, code, gen);
        }

        static Code? ValidateCodes(Random r, string code, int gen, int length = 8)
        {
            if (code.Length < length) { return null; }

            for (int i = 0; i < gen; i++)
            {
                string fullCode = "";
                for (int j = 0; j < length; j++)
                {
                    char c = dataSet[r.Next(0, dataSet.Length)];
                    fullCode += c;
                }

                if (string.Equals(code, fullCode))
                {
                    return new Code(code, i);
                }

            }
            return null;
        }

    }

    public class Code
    {
        public string _code;
        public int _index;

        public Code(string code, int index)
        {
            _code = code;
            _index = index;
        }
    }
}
