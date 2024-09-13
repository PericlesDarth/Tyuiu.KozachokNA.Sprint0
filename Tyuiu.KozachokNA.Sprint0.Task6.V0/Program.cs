using Tyuiu.KozachokNA.Sprint0.Task6.V0.Lib;

namespace Tyuiu.KozachokNA.Sprint0.Task6.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine("Сумма элементов массива = " + DataService.AdditionArray(numbers));
            Console.WriteLine("Разность элементов массива = " + DataService.SubstractionArray(numbers));
            Console.WriteLine("Произведение элементов массива = " + DataService.MultiplicationArray(numbers));

            Console.ReadKey();
        }
    }
}
