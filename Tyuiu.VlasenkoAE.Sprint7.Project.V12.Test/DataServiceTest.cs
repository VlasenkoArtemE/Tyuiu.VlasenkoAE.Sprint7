using System.IO;
using Tyuiu.VlasenkoAE.Sprint7.Project.V12.Lib;

namespace Tyuiu.VlasenkoAE.Sprint7.Project.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        DataService ds = new DataService();
        
        [TestMethod]
        public void ValidMaxPrice()
        {
            string testFile = "test_input.csv";

            string[] testData = {
                "1;2900;4300;6;14200",
                "2;3000;4700;8;31500",
                "3;3600;4200;6;6800",
                "4;3700;4600;8;16400",
            };

            File.WriteAllLines(testFile, testData);

            int result = ds.GetMaxPrice(testFile);
            int wait = 31500;

            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void ValidMinPrice()
        {
            string testFile = "test_input.csv";

            string[] testData = {
                "1;2900;4300;6;14200",
                "2;3000;4700;8;31500",
                "3;3600;4200;6;6800",
                "4;3700;4600;8;16400",
            };

            File.WriteAllLines(testFile, testData);

            int result = ds.GetMinPrice(testFile);
            int wait = 6800;

            Assert.AreEqual(wait, result);
        }
    }
}
