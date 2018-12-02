using System;
using System.IO;

namespace ProbabilityApp
{
    class Log
    {
        public static void LogCalculation(Calculation calculation)
        {
            using (StreamWriter writer = File.AppendText("log.txt"))
            {
                writer.WriteLine("Calculated " 
                                 + calculation.LogOutput() + " at " + DateTime.Now + Environment.NewLine);
            }
        }

        public static void LogError(Exception exception)
        {
            using (StreamWriter writer = File.AppendText("log.txt"))
            {
                writer.WriteLine(exception.ToString() + " at " + DateTime.Now + Environment.NewLine);
            }
        }

    }
}
