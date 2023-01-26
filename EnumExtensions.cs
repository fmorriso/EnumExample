using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EnumExample
{
    /// <summary>
    /// Note that extension methods must be inside a static class
    /// </summary>
    public static class EnumExtensions
    {
        /// <summary>
        /// Gets human-readable version of enum.
        /// </summary>
        /// <returns>effective DisplayAttribute.Name of given enum.</returns>
        public static string GetDisplayName<T>(this T enumValue) where T : struct, Enum
        {
            System.Type enumType = enumValue.GetType();
            return enumType
                .GetMember(enumValue.ToString())
                .Where(x => x.MemberType == MemberTypes.Field && ((FieldInfo)x).FieldType == enumType)
                .First()
                .GetCustomAttribute<DisplayAttribute>()?.Name ?? enumValue.ToString();
        }
    
    }
}
