using Tyuiu.TsarevMA.Sprint1.Task5.V6.Lib;
namespace Tyuiu.TsarevMA.Sprint1.Task5.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int k = 15;
            int wait = 2;
            var res = ds.Calculate(k);
            Assert.AreEqual(wait, res);
        }
    }
}
