using Tyuiu.ElyshevFI.Sprint1.Task0.V15.Lib;

namespace Tyuiu.ElyshevFI.Sprint1.Task0.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpresion()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(2, res);
        }
    }
}
