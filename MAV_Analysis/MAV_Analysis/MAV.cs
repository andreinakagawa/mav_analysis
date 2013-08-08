/*
 * -------------------------------------------------------
 * BRAZIL
 * FEDERAL UNIVERSITY OF UBERLÂNDIA
 * FACULTY OF ELECTRICAL ENGINEERING
 * BIOMEDICAL ENGINEERING LABORATORY 
 * 
 * MAV CLASS
 * CONTAINS THE DIFFERENT ALGORITHMS FOR ITS CALCULATION
 * Developed by: Andrei Nakagawa Silva
 * Contact: andrei.ufu@gmail.com
 * -------------------------------------------------------
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiolabProcessing
{
    public static class MAV
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
                    if (j >= window.Length - 1)
                    {
                        window[j] = Math.Abs(signal[i]);
                    }
                    else
                    {
                        window[j] = window[j + 1];
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

        public static double[] Algorithm2(double[] signal, int windowSize)
        {
            double[] window = new double[windowSize];
            double[] mav = new double[signal.Length];
            double sum = 0;

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

                    sum += window[j];
                }

                mav[i] = sum / window.Length;
                sum = 0;
            }

            return mav;
        }      
       

        public static double[] Algorithm3(double[] signal, int windowSize)
        {
            Queue<double> window = new Queue<double>();
            double[] mav = new double[signal.Length];
            double sum = 0;

            for (int i = 0; i < signal.Length; i++)
            {
                if (i >= windowSize)
                {                   
                    sum -= window.Dequeue();
                    sum += Math.Abs(signal[i]);
                    window.Enqueue(Math.Abs(signal[i]));
                    mav[i] = sum / window.Count;
                }
                else
                {
                    window.Enqueue(Math.Abs(signal[i]));
                    sum += window.ElementAt(i);
                    mav[i] = sum / windowSize;
                }               
            }

            return mav;
        }

        public static double[] Algorithm4(double[] signal, int windowSize)
        {
            double[] mav = new double[signal.Length];
            int first = 0;
            double sum = 0;

            for (int i = 0; i < signal.Length; i++)
            {
                if (i >= windowSize)
                {
                    sum -= Math.Abs(signal[first]);
                    sum += Math.Abs(signal[i]);
                    mav[i] = sum / windowSize;
                    first++;
                }
                else
                {
                    sum += Math.Abs(signal[i]);
                    mav[i] = sum / windowSize;                    
                }               
            }

            return mav;
        }

        public static double[] Algorithm5(double[] signal, int windowSize)
        {
            double[] mav = new double[signal.Length];
            int first = 0;
            double sum = 0, meanNew = 0, meanOld=0;

            for (int i = 0; i < signal.Length; i++)
            {
                if (i >= windowSize)
                {
                    meanOld = mav[i - 1];
                    //meanNew = meanOld + ((Math.Abs(signal[i]) - Math.Abs(signal[first])) / (double)windowSize);
                    mav[i] = meanOld + ((Math.Abs(signal[i]) - Math.Abs(signal[first])) / (double)windowSize);
                    first++;
                }
                else
                {
                    sum += Math.Abs(signal[i]);
                    mav[i] = sum / windowSize;                    
                }
            }

            return mav;
        }
    }
}
