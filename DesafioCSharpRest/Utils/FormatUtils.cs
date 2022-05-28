using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioCSharpRest.Utils
{
    internal class FormatUtils
    {
        public static String currencyFormat(Decimal value)
        {
            if (value != null)
                return value.ToString("C", CultureInfo.CurrentCulture);
            return "Vazio";
        }

        public static String toString(Object value, String defaultValue = "Vazio")
        {
            if (value != null)
            {
                return String.Format("{0}", value);
            }
            else
                return defaultValue;    
        }

        public static String toStringPriceField(Object value, String defaultValue = "Vazio")
        {
            //000.000.000 00 MZN
            if (value != null)
            {
                return String.Format("{0}", value).PadLeft(12);
            }
            else
                return defaultValue;    
        }
        public static String toStringVATField(Object value, String defaultValue = "Vazio")
        {
            //000.000.000 00 MZN
            if (value != null)
            {
                return String.Format("{0}", value).PadLeft(5);
            }
            else
                return defaultValue;
        }

        public static String stringToParseableDecimal(String value)
        {
           value = value
                .Replace(" MZN", "")
                .Trim()
                .Replace(".", "")
                .Trim()
                .Replace(",", "")
                .Trim()
                .Replace(" ", ",")
                .Trim();
            if (value.Length == 0) return "0";
            else return value;
        }

        public static String stringToParseableInteger(String value)
        {
            value = value
                 .Replace(" MZN", "")
                 .Trim()
                 .Replace(".", "")
                 .Trim()
                 .Replace(",", "")
                 .Trim()
                 .Replace(" ", ",")
                 .Trim();
            if (value.Length == 0) return "0";
            else return value;
        }
    }
}
