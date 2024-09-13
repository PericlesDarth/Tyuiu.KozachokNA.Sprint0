namespace Tyuiu.KozachokNA.Sprint0.Task6.V0.Lib
{
    public class DataService
    {
        public static int AdditionArray(int[] numbers)
        {
            int res = 0;
            foreach (int number in numbers)
            {
                res += number;
            }
            return res;
        }
        public static int SubstractionArray(int[] numbers)
        {
            int res = 0;
            int index = 0;

            while (index < numbers.Length)
            {
                res -= numbers[index];
                index++;
            }
            return res;
        }
        public static int MultiplicationArray(int[] numbers)
        {
            int res = 1;
            int index = 0;
            do
            {
                res *= numbers[index];
                index++;
            } while (index < numbers.Length);
            return res;
        }
    }
}
