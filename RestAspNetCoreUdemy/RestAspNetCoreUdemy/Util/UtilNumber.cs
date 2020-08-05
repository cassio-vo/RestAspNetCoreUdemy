using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestAspNetCoreUdemy.Util
{
    public class UtilNumber
    {
        public static decimal ConvertToDescimal(string number)
        {
            decimal decimalValue;
            if (Decimal.TryParse(number, out decimalValue))
                return decimalValue;
            return 0;
        }

        public static bool IsNumeric(string number)
        {
            double numberDouble;

            bool isNumber = Double.TryParse(
                number,
                System.Globalization.NumberStyles.Any,
                System.Globalization.NumberFormatInfo.InvariantInfo,
                out numberDouble);

            return isNumber;
        }
    }
}
