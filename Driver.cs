using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using StringExtensions;

namespace EnumExample
{
    public class Driver
    {
        public static void Main(string[] args)
        {

            Season s = Season.Fall;
            Console.WriteLine(s); // print(s) // System.out.println(s);
            Console.WriteLine((int)s);
            Console.WriteLine(s.GetDisplayName());
            Console.WriteLine($"The season you chose was {s.GetDisplayName()}");            

            InsuranceType ins = InsuranceType.UmbrellaPolicy;
            Console.WriteLine(ins);
            Console.WriteLine((uint)ins);
            Console.WriteLine(ins.GetDisplayName());
            Console.WriteLine($"Insurance type chosen was {ins.GetDisplayName()}");

            Season s2 = GetSeason();
            Console.WriteLine($"You chose {s2}");
        }

        private static Season GetSeason()
        {
            Season retval = Season.Undefined;
            bool valid = false;
            while (!valid)
            {
                Console.WriteLine("Enter a valid season (Spring, Summer, Fall, Winter)");
                string resp = Console.ReadLine();
                
                if (resp != null && !String.IsNullOrEmpty(resp))
                {
                    resp = resp.ProperCase();
                    valid = Enum.TryParse<Season>(resp, out retval);
                }

            }

            return retval;
        }

        public enum HighSchoolYear
        {
            Freshman = 1,
            Sophomore,
            Junior,
            Senior
        }

        /// <summary>
        /// Example of overriding the default underlying representation from int to unsigned int.
        /// </summary>
        public enum Season : ushort
        {
            Spring,
            Summer,
            Fall,
            Winter,
            Undefined            
        }
        public enum HasHadCancer
        {
            yes,
            no,
            unspecified
        }

        /// <summary>
        /// Example of an enumeration with optional display name
        /// </summary>
        public enum InsuranceType
        {
            Renters,
            Homeowners,
            Automobile,
            [Display(Name ="Umbrella Policy")]
            UmbrellaPolicy,
            RecreationalVehicle
        }
    }
}