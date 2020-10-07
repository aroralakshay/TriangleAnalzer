using NUnit.Framework;
using Triangle;

namespace NUnitTestTriangle1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void checkEquilateral()
        {
            string triangle = TriangleSolver.Analyze(12, 12, 12);
            Assert.AreEqual(triangle, "Equilateral triangle");
        }

        [Test]
        public void testScalene()
        {
            string triangle = TriangleSolver.Analyze(12, 13, 14);
            Assert.AreEqual(triangle, "Scalene triangle");
        }
        [Test]
        public void testIsoscelesForSide2AndSide3()
        {
            string triangle = TriangleSolver.Analyze(12, 14, 14);
            Assert.AreEqual(triangle, "Isosceles triangle");
        }

        [Test]
        public void testIsoscelesforSide1AndSide3()
        {
            string triangle = TriangleSolver.Analyze(14, 12, 14);
            Assert.AreEqual(triangle, "Isosceles triangle");
        }
        [Test]
        public void testIsoscelesforSide1AndSide2()
        {
            string triangle = TriangleSolver.Analyze(14, 14, 12);
            Assert.AreEqual(triangle, "Isosceles triangle");
        }

        [Test]
        public void checkPositiveNumber()
        {
            string triangle = TriangleSolver.Analyze(12, -1, 14);
            Assert.AreEqual(triangle, "All the sides of triangle must be entered as 1 or greater");
        }

        [Test]
        public void checkForZero()
        {
            string triangle = TriangleSolver.Analyze(0, 0, 0);
            Assert.AreEqual(triangle, "All the sides of triangle must be entered as 1 or greater");
        }  
    }
}