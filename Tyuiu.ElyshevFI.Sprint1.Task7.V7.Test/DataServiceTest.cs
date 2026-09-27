using Tyuiu.ElyshevFI.Sprint1.Task7.V7.Lib;

namespace Tyuiu.ElyshevFI.Sprint1.Task7.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 3;
            double y = 2;
            double wait = 44.165;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
