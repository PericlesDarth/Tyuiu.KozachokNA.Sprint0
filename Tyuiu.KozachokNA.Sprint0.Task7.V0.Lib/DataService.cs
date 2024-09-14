namespace Tyuiu.KozachokNA.Sprint0.Task7.V0.Lib
{
    public class DataService
    {
        public static int[] AdditionArrays(int[] nums1, int[] nums2)
        { 
            int[] resultArray = nums1;
            for (int i = 0; i < resultArray.Length; i++)
            {
                resultArray[i] += nums2[i];
            }
            return resultArray;
        }
    }
}
