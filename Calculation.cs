using System;
namespace ProbabilityApp
{
    abstract class Calculation
    {
        protected float[] probabilities;
        public float Result { get; protected set; }

        protected string calcDescriptor;

        public static float LowerLimit = 0;
        public static float UpperLimit = 1;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:ProbabilityApp.Calculation"/> class.
        /// </summary>
        /// <param name="probabilities">The given probabilities to process in this calculation.</param>
        protected Calculation(float[] probabilities)
        {
            if(probabilities.Length < 2) {
                throw new Exception("Not enough probabilities given");
            }
            this.probabilities = probabilities;
            this.Result = DoCalculation();
        }

        /// <summary>
        /// Performs the calculation. The exact calculation will be determined by whichever class implements this abstraction.
        /// </summary>
        /// <returns>The result of the calculation.</returns>
        protected abstract float DoCalculation();

        /// <summary>
        /// Display the output of this given instance in the Main Window's text area.
        /// </summary>
        /// <returns>A formatted, human readable string.</returns>
        public string MainOutput()
        {
            return "Result of " + calcDescriptor +  " between " + ListProbabilities() + " was " + Result + Environment.NewLine;
        }

        /// <summary>
        /// Lists the probabilities in a human readable format, seperated by commas.
        /// </summary>
        /// <returns>The probabilities.</returns>
        private string ListProbabilities() 
        {
            if(probabilities.Length == 2) {
                return probabilities[0] + " and " + probabilities[1];
            }
            string output = "";
            for (int i = 0; i < probabilities.Length; i++)
            {
                if(i == probabilities.Length - 2) {
                    output += probabilities[i] + ", and ";
                }
                else if (i == probabilities.Length - 1) {
                    output += probabilities[i];
                }
                else{
                    output += probabilities[i] + ',';
                }
            }
            return output + Environment.NewLine;
        }

        /// <summary>
        /// Logs a shorthand version of the current calculation, its inputs and result. Intended to be use for the log file.
        /// </summary>
        /// <returns></returns>
        public string LogOutput()
        {
            return this.calcDescriptor + " | inputs: " + LogInputs() + " | result: " + Result;
        }

        /// <summary>
        /// Logs the inputs in a shorter, more concise format. Intended to be used for the log file.
        /// </summary>
        /// <returns></returns>
        protected string LogInputs()
        {
            var output = "";
            for (int i = 0; i < probabilities.Length; i++)
            {
                output += probabilities[i];
                if(i != probabilities.Length - 1) {
                    output += ", ";
                }
            }
            return output;
        }
    }
}
