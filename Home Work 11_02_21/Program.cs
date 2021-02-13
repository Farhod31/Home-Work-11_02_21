using System;

namespace Home_Work_11_02_21
{
    class Program
    {
        static void Main(string[] args)
        {
       
            
                Mathematic<double> operation = new Mathematic<double>();
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("First Number");
                    double number1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Second Number"); double number2 = double.Parse(Console.ReadLine());
                    Console.WriteLine(@"Choose comand: +, -,  *, /, Выход  !)))");


                    switch (Console.ReadLine())
                    {
                        case "+":
                            Console.Write(operation.DelSum(number1, number2));
                            break;
                        case "-":
                            Console.Write(operation.DelMin(number1, number2));
                            break;
                        case "*":
                            Console.Write(operation.DelMul(number1, number2));
                            break;
                        case "/":
                            Console.Write(operation.DelDivide(number1, number2));
                            break;
                        case "!)))": return;

                    }
                    Console.ReadLine();

                }
        }
    }
        class Mathematic<T>
        {
            public delegate T Operation(T number1, T number2);
            public Operation DelSum = Sum;
            public Operation DelMin = Sub;
            public Operation DelMul = Multiplier;
            public Operation DelDivide = Divide;
            public static T Sum(T number1, T number2)
            {
                return (dynamic)number1 + (dynamic)number2;
            }
            public static T Sub(T number1, T number2)
            {
                return (dynamic)number1 - (dynamic)number2;
            }
            public static T Multiplier(T number1, T number2)
            {
                return (dynamic)number1 * (dynamic)number2;
            }
            public static T Divide(T number1, T number2)
            {
                if ((dynamic)number2 == 0)
                {
                    Console.Write("Dont divide by zero\t");

                    return number2;

                }
                else
                {
                    return (dynamic)number1 / (dynamic)number2;

                }
            }
        }
}
