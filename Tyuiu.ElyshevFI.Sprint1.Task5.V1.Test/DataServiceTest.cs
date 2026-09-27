using Tyuiu.ElyshevFI.Sprint1.Task5.V1.Lib;

namespace Tyuiu.ElyshevFI.Sprint1.Task5.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            double x1 = 10;
            double y1 = 10;
            double x2 = 50;
            double y2 = 52;

            int wait = 58;

            int result = ds.DistanceBetweenDots(x1, y1, x2, y2);

            Assert.AreEqual(wait, result);
        }
    }
}
