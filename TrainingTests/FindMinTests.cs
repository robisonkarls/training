using NUnit.Framework;
using Training;

namespace TrainingTests
{
    public class FindMinTests
    {
        [Test]
        public void  FindMin1()
        {
            var arr = new[] { 4, 5, 6, 7, 0, 1, 2 };

            var actual  = Solutions.FindMin(arr);
            
            Assert.AreEqual(0, actual);

        }
        
        [Test]
        public void  FindMin2()
        {
            var arr = new[] { 11, 13, 15, 17 };

            var actual  = Solutions.FindMin(arr);
            
            Assert.AreEqual(11, actual);

        }
        
        [Test]
        public void  FindMin3()
        {
            var arr = new[] { 3,4,0,1,2 };

            var actual  = Solutions.FindMin(arr);
            
            Assert.AreEqual(0, actual);
        }
        
        [Test]
        public void  FindMin4()
        {
            var arr = new[] { 1 };

            var actual  = Solutions.FindMin(arr);
            
            Assert.AreEqual(1, actual);
        }
        
        [Test]
        public void  FindMin5()
        {
            var arr = new[] { 1, 2 };

            var actual  = Solutions.FindMin(arr);
            
            Assert.AreEqual(1, actual);
        }
        
        [Test]
        public void  FindMin6()
        {
            var arr = new[] { 3,1,2 };

            var actual  = Solutions.FindMin(arr);
            
            Assert.AreEqual(1, actual);
        }
        
        [Test]
        public void  FindMin7()
        {
            var arr = new[] { 2,3,1 };

            var actual  = Solutions.FindMin(arr);
            
            Assert.AreEqual(1, actual);
        }
    }
}