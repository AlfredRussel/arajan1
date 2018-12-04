using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiply
{
    class Program
    {
        static void Main(string[] args)
        {
            int output;
            Program p = new Program();
            output = p.Multiply();
            Console.Write(output);
            Console.ReadLine();

            //Multiply(input, seperator);
        }

        public int Multiply()
        {
            string input, check;
            char seperator;
            Console.WriteLine("Enter the input data");
            input = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter data seperator");
            check = Convert.ToString(Console.ReadLine());
            //Console.WriteLine("Enter data seperator", seperator);
            //Console.Write("\ntest:\t" + input + seperator );
            seperator = Convert.ToChar(check);
            string[] values = input.Split(seperator);
            //for (int i = 0; i < values.Length; i++)
            //{
            //    values[i] = values[i].Trim();
            //}
            
            //Console.WriteLine("\n", values[j]);

                int prod = 1;
            if ((values.Length == 1) && (values[0] == ""))
            {
                prod = 0;
            }
            else {
                for (int k = 0; k < values.Length; k++)
                {
                    prod *= Convert.ToInt32(values[k]);
                }
            }
            return prod;
        }
    }
}
