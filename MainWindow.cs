using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Gtk;
using ProbabilityApp;

public partial class MainWindow : Gtk.Window
{
    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    /// <summary>
    /// The event delegate when the Combine button is pressed.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="a"></param>
    protected void CombineProbs(object sender, EventArgs a)
    {
        DoCalculation(typeof(CombineCalculation));
    }

    /// <summary>
    /// The method that is run when the Either button is pressed.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="a"></param>
    protected void EitherProbs(object sender, EventArgs a)
    {
        DoCalculation(typeof(EitherCalculation));
    }

    /// <summary>
    /// Creates a new calculation based on the given type. The calculation is then performed and logged to a given file.
    /// </summary>
    /// <param name="t">The type of calculation to create.</param>
    private void DoCalculation(Type t)
    {
        Calculation calculation = null;
        try
        {
            var args = GetInputProbabilities();
            switch (t.Name)
            {
                case "CombineCalculation":
                    calculation = new CombineCalculation(args);
                    break;
                case "EitherCalculation":
                    calculation = new EitherCalculation(args);
                    break;
            }
            outputView.Buffer.Text += calculation.MainOutput();
            Log.LogCalculation(calculation);
        }
        catch (Exception ex)
        {
            Log.LogError(ex);
        }
    }

    /// <summary>
    /// Gets the input probabilities from the two text entry boxes, parsing whatever is inside as a float.
    /// If the values are not floats or any of the values are outside the limit, an exception is thrown.
    /// </summary>
    /// <returns>An array containing the probabilities as floats.</returns>
    private float[] GetInputProbabilities()
    {
        var probs = new float[2];
        try
        {
            probs[0] = float.Parse(entry1.Text);
            probs[1] = float.Parse(entry2.Text);
            for (int i = 0; i < probs.Length; i++)
            {
                if (probs[i] < Calculation.LowerLimit || probs[i] > Calculation.UpperLimit)
                {
                    throw new Exception("One or more probabilities outside given range.");
                }
            }
        }
        catch (Exception e)
        {
            outputView.Buffer.Text += "Input was in an incorrect format. Please try again." + Environment.NewLine;
            throw e;
        }
        return probs;
    }
}
