using System;
namespace ProbabilityApp
{
    class EitherCalculation : Calculation
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="T:ProbabilityApp.EitherCalculation"/> class.
        /// </summary>
        /// <param name="probabilities">The given probabilities to process in this calculation.</param>
        public EitherCalculation(float[] probabilities) : base (probabilities)
        {
            this.calcDescriptor = "either calculation";
        }

        /// <summary>
        /// Performs the Either calculation.
        /// P(A)+P(B) - P(A)*P(B).
        /// </summary>
        /// <returns></returns>
        protected override float DoCalculation()
        {
            return (this.probabilities[0] + this.probabilities[1])
                - (this.probabilities[0] * this.probabilities[1]);
        }
    }
}
