using Tyuiu.ElyshevFI.Sprint1.Task3.V18.Lib;

namespace Tyuiu.ElyshevFI.Sprint1.Task3.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 3;
            double z = 1;
            double wait = 6;
            var res = ds.HowManySquares(x, y, z);
            Assert.AreEqual(wait, res);
        }
    }
}
