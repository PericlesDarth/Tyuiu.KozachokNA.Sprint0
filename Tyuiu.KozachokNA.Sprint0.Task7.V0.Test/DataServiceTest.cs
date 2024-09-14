using Tyuiu.KozachokNA.Sprint0.Task7.V0.Lib;

namespace Tyuiu.KozachokNA.Sprint0.Task7.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckAdditionArraysValid()
        {
            var nums1 = new int[] { 1, 1, 1, 1, 1 };
            var nums2 = new int[] { 1, 1, 1, 1, 1 };
            var nums3 = new int[] { 2, 2, 2, 2, 2 };
            int[] res = DataService.AdditionArrays(nums1, nums2);
            
            CollectionAssert.AreEqual(res, nums3);
        }
    }
}