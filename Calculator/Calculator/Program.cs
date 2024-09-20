using System;
using System.Linq;
using System.Text;
using System.Runtime.ExceptionServices;
using System.Xml.Linq;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

class Calculator
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        int start, cont;
        double first, second, equal;
        string function;

        Console.WriteLine("КАЛЬКУЛЯТОР by MakRan");
        Console.Write("Для того щоб почати калькулювати введіть 1, щоб вийти введіть 0: ");
        start = Convert.ToInt32(Console.ReadLine());

        if (start == 1)
        {
            Calculation();
        }
        else if (start == 0)
        {
            close();
        }

        void Pluss()
        {
            equal = first + second;
        }
        void Minus()
        {
            equal = first - second;
        }
        void Multiplication()
        {
            equal = first * second;
        }
        void Division()
        {
            equal = first / second;
        }

        
        void Calculation()
        {
            equal = 0;
            Console.Write("Введіть перше число : ");
            first = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введіть дію : ");
            function = Console.ReadLine();

            Console.Write("Введіть наступне число : ");
            second = Convert.ToInt32(Console.ReadLine());

            while (function != "=")
            {

                if (function == "+")
                {
                    Pluss();
                    first = equal;
                }
                else if (function == "-")
                {
                    Minus();
                    first = equal;
                }
                else if (function == "*")
                {
                    Multiplication();
                    first = equal;
                }
                else if (function == "/")
                {
                    Division();
                    first = equal;
                }

                Console.WriteLine(equal);
                Console.Write("Введіть наступну дію, або = : ");
                function = Console.ReadLine();

                if (function == "=")
                {
                    Console.WriteLine(equal);

                    Console.Write("Якщо ви хочете продовжити калькулювати введіть 1, щоб вийти введіть 0: ");
                    cont = Convert.ToInt32(Console.ReadLine());

                    if (cont == 1)
                    {
                        Calculation();
                    }
                    else if (cont == 0)
                    {
                        close();
                    }
                }

                Console.Write("Введіть наступне число : ");
                second = Convert.ToInt32(Console.ReadLine());
            }

            
            
        }

        void close()
        {
            Console.WriteLine("Ви завершили процес, до нових зустрічей");
            System.Environment.Exit(0);
        }
    }
}
