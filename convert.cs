using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Converter
{
    class convert
    {
        public static string hexa_decimal_value(string hexa_value)
        {

            hexa_value = Console.ReadLine();
            int int_value = Convert.ToInt32(hexa_value, 16);
            string octal = Convert.ToString(int_value, 8);
            string binary = Convert.ToString(int_value, 2);

            Console.WriteLine("hex_value = {0}", hexa_value);
            Console.WriteLine("Decimal_value = {0}", int_value);
            Console.WriteLine("Binary_value = {0}", binary);
            Console.WriteLine("Octa_value = {0}", octal);

            return hexa_value;
        }
        public static string binary_value(string binary)
        {
            binary = Console.ReadLine();
            int int_value = Convert.ToInt32(binary, 2);
            string octal = Convert.ToString(int_value, 8);
            string hexa_dec = Convert.ToString(int_value, 16);

            Console.WriteLine("Binary_value = {0}", binary);
            Console.WriteLine("Decimal_value = {0}", int_value);
            Console.WriteLine("Octa_value = {0}", octal);
            Console.WriteLine("hex_value = {0}", hexa_dec);

            return binary;
        }
        public static string octal_value(string octal)
        {
            octal = Console.ReadLine();
            int int_value = Convert.ToInt32(octal, 8);
            string binary = Convert.ToString(int_value, 2);
            string hexa_dec = Convert.ToString(int_value, 16);

            Console.WriteLine("Octa_value = {0}", octal);
            Console.WriteLine("Decimal_value = {0}", int_value);
            Console.WriteLine("Binary_value = {0}", binary);
            Console.WriteLine("hex_value = {0}", hexa_dec);


            return octal;
        }
        public static int decimal_value(int int_value)
        {

            int_value = int.Parse(Console.ReadLine());
            string octal = Convert.ToString(int_value, 8);
            string binary = Convert.ToString(int_value, 2);
            string hexa_value = Convert.ToString(int_value, 16);


            Console.WriteLine("hex_value = {0}", hexa_value);
            Console.WriteLine("Decimal_value = {0}", int_value);
            Console.WriteLine("Binary_value = {0}", binary);
            Console.WriteLine("Octa_value = {0}", octal);

            return int_value;
        }
    }
}
