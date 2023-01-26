using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExtensions
{
    public static class StringExtensions
    {
        /// <summary>
        /// Convert a string to proper case with the first letter capitalized and the rest lower-case.
        /// </summary>
        /// <param name="resp"></param>
        /// <example>
        /// String proper = text.ProperCase();
        /// </example>
        /// <returns></returns>
        public static string ProperCase(this String? resp)
        {
            if (string.IsNullOrEmpty(resp))
            {
                return resp;
            }
            if (resp.Length == 1)
            {
                return resp.ToUpper();
            }
            resp = resp.Substring(0, 1).ToUpper() + resp.Substring(1);
            return resp;
        }
    }
}
