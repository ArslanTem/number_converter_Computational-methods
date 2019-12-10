using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Which Numberal system u want to input");
            Console.WriteLine("1)Decimal");
            Console.WriteLine("2)Binary");
            Console.WriteLine("3)Octal");
            Console.WriteLine("4)HexaDecimal");

            int choise = int.Parse(Console.ReadLine());
            switch (choise)
            {
                case 1:

                    Console.WriteLine("Enter Decimal value");
                    int decimal_value = 0;
                    convert.decimal_value(decimal_value);
                    break;

                case 2:

                    Console.WriteLine("Enter Binary value");
                    string binary_value = "";
                    convert.binary_value(binary_value);
                    break;

                case 3:

                    Console.WriteLine("Enter Octal value:");
                    string octal_value = "";
                    convert.octal_value(octal_value);
                    break;

                case 4:

                    Console.WriteLine("Enter Hexa-decimal value:");
                    string hexa_dec_value = "";
                    convert.hexa_decimal_value(hexa_dec_value);
                    break;


            }


        }

    }
}


