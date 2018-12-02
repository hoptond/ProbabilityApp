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

    protected void CombineProbs(object sender, EventArgs a)
    {
        DoCalculation(typeof(CombineCalculation));
    }

    protected void EitherProbs(object sender, EventArgs a)
    {
        DoCalculation(typeof(EitherCalculation));
    }

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

    private void CreateCalculation(Func<float[], Calculation> del, float[] args)
    {
        Calculation cal = del(args);
    }
}
