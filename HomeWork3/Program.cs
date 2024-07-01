namespace HomeWork3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1, num2;
            string operation;
            Console.WriteLine("Введите первое число ");
            num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число ");
            num2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите действие (+, -, *, /, %, ^) ");
            operation = Console.ReadLine();

            switch (operation)
            {
                case "+":
                    Console.WriteLine("Результат сложения");
                    Console.WriteLine(num1 + num2);
                    break;
                case "-":
                    Console.WriteLine("Результат вычитания");
                    Console.WriteLine(num1 - num2);
                    break;
                case "*":
                    Console.WriteLine("Результат умножения");
                    Console.WriteLine(num1 * num2);
                    break;
                case "/":
                    if (num2 == 0)
                    {
                        Console.WriteLine("На 0 делить нельзя");
                    }
                    else
                    {
                        Console.WriteLine("Результат деления");
                        Console.WriteLine(num1 / num2);
                    }
                    break;
                    case "%":
                    Console.WriteLine("Процент от числа");
                    Console.WriteLine((num1 / 100) * num2 );
                    break;

                case "^":
                    Console.WriteLine("Квадратный корень числа");
                    Console.WriteLine(Math.Sqrt(num1));
                    break;
                default:
                    Console.WriteLine("Ошибка");
                    break;
            }

            
            
            
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
    

