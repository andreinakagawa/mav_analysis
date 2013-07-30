using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
using ZedGraph;

namespace BiolabProcessing
{
    public class MeanAbsoluteValue
    {
        public static double[] Algorithm1(double[] signal, int windowSize)
        {
            double[] window = new double[windowSize];
            double[] mav = new double[signal.Length];
            double sum = 0;
            double mean = 0;

            for (int i = 0; i < signal.Length; i++)
            {
                for (int j = 0; j < window.Length; j++)
                {
                    if (j < window.Length - 1)
                    {
                        window[j] = window[j + 1];
                    }
                    else
                    {
                        window[j] = Math.Abs(signal[i]);
                    }
                }

                for (int z = 0; z < window.Length; z++)
                {
                    sum += window[z];
                }

                mean = sum / window.Length;
                mav[i] = mean;
                sum = 0;
            }

            return mav;
        }
    }
}