using System;
namespace ProbabilityApp
{
    class CombineCalculation : Calculation
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="T:ProbabilityApp.CombineCalculation"/> class.
        /// </summary>
        /// <param name="probabilities">The given probabilities to process in this calculation.</param>
        public CombineCalculation(float[] probabilities) : base (probabilities)
        {
            this.calcDescriptor = "combine calculation";
        }

        /// <summary>
        /// Performs the Combine calculation.
        /// P(A) * P(B)
        /// </summary>
        /// <returns></returns>
        protected override float DoCalculation()
        {
            float result = this.probabilities[0] * this.probabilities[1];
            for (int i = 2; i < this.probabilities.Length; i++)
            {
                result *= probabilities[i];
            }
            return result;
        }

    }
}
