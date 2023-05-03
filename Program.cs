
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System;
using Enum_ders.Models;
using System.ComponentModel.DataAnnotations;

namespace Enum_ders
{


    internal class Program
    {
        private static void Main(string[] args)
        {
            var properties = typeof(ShippingStatus).GetFields();
            foreach (var prop in properties)
            {
                var dd = prop.GetCustomAttribute(typeof(DisplayAttribute)) as DisplayAttribute;
                if (dd != null)
                {
                    Console.WriteLine(prop.Name + " --> " + dd.Name);
                }
            }

            //------------[Flags]-------------//


            Console.WriteLine(
                 "\n\nAll possible combinations of values without FlagsAttribute:");
            for (int val = 0; val <= 16; val++)
                Console.WriteLine("{0,3} - {1:G}", val, (SingleHue)val);



            Console.WriteLine(
                 "\nAll possible combinations of values with FlagsAttribute:");
            for (int val = 0; val <= 16; val++)
                Console.WriteLine("{0,3} - {1:G}", val, (MultiHue)val);


            Console.ReadLine();
        }
    }
}