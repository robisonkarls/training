using System.Linq;
using NUnit.Framework;
using Training;

namespace TrainingTests
{
    public class FindWheelsTests
    {
        [Test]
        public void Test1()
        {
            var input = new[] { 6, 3, 2 };
            var expected = new[] { 2, 0, 1 };

            var actual = Solutions.FindWheels(input).ToArray();
            
            Assert.AreEqual(expected, actual);
        }
        
        [Test]
        public void Test2()
        {
            var input = new[] { 8, 10, 14, 12 };
            
            var expected = new[] { 3, 3, 4, 4 };

            var actual = Solutions.FindWheels(input).ToArray();
            
            Assert.AreEqual(expected, actual);
        }
    }
}