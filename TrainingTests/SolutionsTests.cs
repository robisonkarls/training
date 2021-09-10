using NUnit.Framework;
using Training;

namespace TrainingTests
{
    public class SolutionsTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void JudgeSquareSum()
        {

            var actual = Solutions.JudgeSquareSum(1000);
            
            Assert.IsTrue(actual);
        }

        [Test]
        public void RectangleArea()
        {
            var rectangles = new[]
            {
                new[]{ 0, 0, 2, 2 }, 
                new[]{ 1, 0, 2, 3 },
                new[]{ 1, 0, 3, 1 }
            };
            
            var actual = Solutions.RectangleArea(rectangles);
            
            Assert.AreEqual(6, actual);
        }

        [Test]
        public void IsValidSerialization1()
        {
            const string preorder = "9,#,92,#,#";

            var actual = Solutions.IsValidSerialization(preorder);
            
            Assert.IsTrue(actual);
        }
        
        [Test]
        public void IsValidSerialization2()
        {
            const string preorder = "7,2,#,2,#,#,#,6,#";

            var actual = Solutions.IsValidSerialization(preorder);

            Assert.IsFalse(actual);
        }
        
        [Test]
        public void IsValidSerialization3()
        {
            const string preorder = "9,3,4,#,#,1,#,#,2,#,6,#,#";

            var actual = Solutions.IsValidSerialization(preorder);

            Assert.IsTrue(actual);
        }
        
        [Test]
        public void IsValidSerialization4()
        {
            const string preorder = "6,2,#,0,#,0,#,#,#,#,5,2,#";

            var actual = Solutions.IsValidSerialization(preorder);

            Assert.IsFalse(actual);
        }
        
        [Test]
        public void IsValidSerialization5()
        {
            const string preorder = "2,#,#,6,9,9,#,7,#,#,#";

            var actual = Solutions.IsValidSerialization(preorder);

            Assert.IsFalse(actual);
        }
    }
}