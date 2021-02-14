using System;

namespace OOP1Laba_divider
{
    class DivideIt
    {
        static void Main(string[] args)
        {
            int i, j;
            string temp;
            Console.WriteLine("Please, enter first integer number");
            try
            {
                i = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please, enter second integer number");
                temp = Console.ReadLine();
                if (Int32.TryParse(temp, out j))
                {
                    try
                    {
                        int k = i / j;
                        Console.WriteLine("The result of dividing first on second = {0}", k);
                    }
                    catch (Exception divide_on_zero)
                    {
                        if (j == 0)
                            Console.WriteLine("Exception of dividing on zero: {0}", divide_on_zero.StackTrace);
                    }
                }
                else
                {
                    Console.WriteLine("Entered string (second integer number) could not be converted to integer");
                    Console.WriteLine("Сannot calculate the result of division");
                }
            }
            catch (Exception wrong_format)
            {
                Console.WriteLine("Exception of wrong format of the number: {0}", wrong_format.StackTrace);
            }
        }
    }
}
