using Tyuiu.KozachokNA.Sprint0.Task7.V0.Lib;

namespace Tyuiu.KozachokNA.Sprint0.Task7.V0 
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #0 | Выполнил: Козачок Н. А. | РППб-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #0                                                               *");
            Console.WriteLine("* Тема:  Создания итогового решения по спринту                            *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #0                                                              *");
            Console.WriteLine("* Выполнил: Козачок Никита Андреевич | РППб-24-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать консольную программу на C#, которая суммирует значения двух    *");
            Console.WriteLine("* одинаковых массивов по длине                                            *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[] nums1 = { 1, 2, 3, 4, 5 };
            Console.WriteLine("Значения элементов массива №1");
            foreach (int i in nums1)
            {
                Console.Write(i + ", ");
            }

            Console.WriteLine();

            int[] nums2 = { 1, 2, 3, 4, 5 };
            Console.WriteLine("Значения элементов массива №2");
            foreach (int i in nums2)
            {
                Console.Write(i + ", ");
            }

            Console.WriteLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            if (nums1.Length == nums2.Length)
            {
                int[] res = DataService.AdditionArrays(nums1, nums2);
                Console.WriteLine("Почленная сумма элементов равна:");
                foreach (int i in res)
                {
                    Console.Write(i + ", ");
                }
            }
            else
            {
                Console.WriteLine("Ошибка! Исходные массивы имеют разное число элементов");
            }
            Console.ReadKey();
        }
    }
}