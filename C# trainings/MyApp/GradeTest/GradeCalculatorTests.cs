using MyApp;

namespace GradeTest
{
    public class GradeCalculatorTests
    {
        private GradeCalculator _calc { get; set; } = null!;
        [SetUp]
        public void Setup()
        {
            _calc = new GradeCalculator();
        }

        [TestCase(90)]
        [TestCase(91)]
        [TestCase(99)]
        [TestCase(100)]
        [TestCase(95)]
        public void GetGradeByPercentage_Test(int data)
        {
            // Assign
            var percentage = data;

            // Act
            var grade = _calc.GetGradeByPercentage(percentage);

            // Assert
            Assert.AreEqual("A", grade);
        }

        [TestCase(0)]
        [TestCase(80)]
        [TestCase(75)]
        [TestCase(35)]
        [TestCase(101)]
        public void GetGradeByPercentage_NegativeTest(int data)
        {
            // Assign
            var percentage = data;

            // Act
            var grade = _calc.GetGradeByPercentage(percentage);

            // Assert
            Assert.AreNotEqual("A", grade);
        }
    }
}