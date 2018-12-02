using System;
using NUnit.Framework;

namespace ProbabilityApp
{
    public class CombineCalculationTest
    {
        [Test]
        public void TestConstructorSuccess()
        {
            var args = new float[] { 0.5f, 0.5f };
            var combineCalc = new CombineCalculation(args);
            Assert.IsNotNull(combineCalc);
        }

        [Test]
        public void TestConstructorFailure()
        {
            var args = new float[] { -0.5f };
            Assert.Throws<Exception>(delegate
            {
                var combineCalc = new CombineCalculation(args);
            });
        }

        [Test]
        public void TestDoCalculationSuccess()
        {
            var args = new float[] { 0.5f, 0.5f };
            var combineCalc = new CombineCalculation(args);
            Assert.AreEqual(combineCalc.Result, 0.25f);
        }

        [Test]
        public void TestDoCalculationFailure()
        {
            var args = new float[] { 0.23f, 0.78f };
            var combineCalc = new CombineCalculation(args);
            Assert.AreNotEqual(combineCalc.Result, 0.25f);
        }
    }
}
