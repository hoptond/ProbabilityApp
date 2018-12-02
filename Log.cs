using System;
using System.IO;

namespace ProbabilityApp
{
    class Log
    {
        /// <summary>
        /// Logs the given calculation to the log file.
        /// </summary>
        /// <param name="calculation">The calculation to log.</param>
        public static void LogCalculation(Calculation calculation)
        {
            using (StreamWriter writer = File.AppendText("log.txt"))
            {
                writer.WriteLine("Calculated " 
                                 + calculation.LogOutput() + " at " + DateTime.Now + Environment.NewLine);
            }
        }

        /// <summary>
        /// Logs the given exception to the log file.
        /// </summary>
        /// <param name="exception">The exception to log.</param>
        public static void LogError(Exception exception)
        {
            using (StreamWriter writer = File.AppendText("log.txt"))
            {
                writer.WriteLine(exception.ToString() + " at " + DateTime.Now + Environment.NewLine);
            }
        }

    }
}
