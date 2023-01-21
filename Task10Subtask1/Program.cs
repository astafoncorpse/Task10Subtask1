using System;

namespace Task10Subtask1
{
    public interface ICalculator
    {
        void Sum(int a, int b);
    }

    public class MyCalc : ICalculator
    {
        public void Sum(int a, int b)
        {
            Console.WriteLine("Ответ: {0} ", a + b);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ICalculator mycalc;
            try
            {
                Console.WriteLine("Ввидите значение 1: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ввидите значение 2: ");
                int b = Convert.ToInt32(Console.ReadLine());

                mycalc = new MyCalc();
                mycalc.Sum(a, b);
            }
            catch (FormatException)
            {
                Console.WriteLine("Введенное значение не коректно!");
            }
            finally
            {
                Console.WriteLine("Калькулятор окончил работу");
            }
        }
    }
}
