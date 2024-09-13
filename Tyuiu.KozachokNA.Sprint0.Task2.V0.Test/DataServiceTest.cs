using Tyuiu.KozachokNA.Sprint0.Task2.V0.Lib;

namespace Tyuiu.KozachokNA.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Никита";
            var res = DataService.GetMessage(name);
            
            Assert.AreEqual(res, "Привет, Никита");
        }
    }
}