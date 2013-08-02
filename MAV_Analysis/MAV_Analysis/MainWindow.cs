/*
 * -------------------------------------------------------
 * BRAZIL
 * FEDERAL UNIVERSITY OF UBERLÂNDIA
 * FACULTY OF ELECTRICAL ENGINEERING
 * BIOMEDICAL ENGINEERING LABORATORY 
 * 
 * ALGORITHM ANALYSIS APPLIED DO MEAN ABSOLUTE VALUE CALCULUS
 * Developed by: Andrei Nakagawa Silva
 * Contact: andrei.ufu@gmail.com
 * -------------------------------------------------------
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using BiolabProcessing;
using ZedGraph;

namespace MAV_Analysis
{
    public partial class MainWindow : Form
    {
        private List<double> _emgSignalList = new List<double>();
        private double[] mavArray;

        private delegate double[] mavFunc(double[] signal, int windowSize);

        private PointPairList emgPointPair = new PointPairList();
        private PointPairList mavPointPair = new PointPairList();

       

        public MainWindow()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            CreateChart(zgEMGSignal, "EMG Signal", "Num of Samples", "Amplitude (uV)");
            CreateChart(zgMAV, "Mean Absolute Value", "Num of Samples", "Amplitude (uV)");
            CreateCurve(zgEMGSignal, emgPointPair, "EMG", Color.Blue, SymbolType.None);
            CreateCurve(zgMAV, mavPointPair, "MAV", Color.Red, SymbolType.None);

            _emgSignalList = LoadEMGFile("coleta5.txt");

            Plot(_emgSignalList.ToArray(), ref zgEMGSignal, ref emgPointPair);
        }

        //Function to configure the ZedGraph chart
        private void CreateChart(ZedGraphControl zg, string title, string xTitle, string yTitle)
        {
            zg.GraphPane.Title.Text = title;
            zg.GraphPane.XAxis.Title.Text = xTitle;
            zg.GraphPane.YAxis.Title.Text = yTitle;
            zg.AxisChange();
            zg.Invalidate();
        }

        //Function to create a ZedGraph Curve
        private void CreateCurve(ZedGraphControl zg, PointPairList points, string name, Color curveColor, SymbolType symbol)
        {
            zg.GraphPane.AddCurve(name, points, curveColor, symbol);
        }

        //Functin to load the EMG signal from a specified text file
        private List<double> LoadEMGFile(string _fileName)
        {
            List<double> emgList = new List<double>();
            string line = string.Empty;
            StreamReader _fileReader = new StreamReader(_fileName);

            while ((line = _fileReader.ReadLine()) != null)
            {
                emgList.Add(Convert.ToDouble(line.Replace('.', ',')));
            }

            return emgList;
        }

        //Function to plot something on the ZedGraph chart
        private void Plot(double[] signalArray, ref ZedGraphControl _zg, ref PointPairList _pointList)
        {
            for (int i = 0; i < signalArray.Length; i++)
            {
                _pointList.Add(i, signalArray[i]);
            }
            _zg.AxisChange();
            _zg.Invalidate();
        }

        //Function to measure how long a function to takes to be executed
        private TimeSpan Measure(mavFunc _mavFunc, int numRepet, double[] signal, int windowSize, ref double[] mav)
        {
            Stopwatch _sw = new Stopwatch();
            _sw.Reset();
            _sw.Start();
            for (int i = 0; i < numRepet; i++)
                mav = _mavFunc(signal, windowSize);
            _sw.Stop();
            return _sw.Elapsed;
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            mavPointPair.Clear();
            TimeSpan measureTime = new TimeSpan();
            int numbRep = Convert.ToInt32(tbNumbRepet.Text);
            int windowSize = Convert.ToInt32(tbWindowSize.Text);

            double[] teste = new double[400];
            Array.Copy(_emgSignalList.ToArray(), teste, 400);

            if (rbAlg1.Checked)
                measureTime = Measure(MAV.Algorithm1, numbRep, teste, windowSize, ref mavArray);
            else if (rbAlg2.Checked)
                measureTime = Measure(MAV.Algorithm2, numbRep, teste, windowSize, ref mavArray);
            else if (rbAlg3.Checked)
                measureTime = Measure(MAV.Algorithm3, numbRep, teste, windowSize, ref mavArray);
            else if (rbAlg4.Checked)
                measureTime = Measure(MAV.Algorithm4, numbRep, teste, windowSize, ref mavArray);

            Plot(mavArray, ref zgMAV, ref mavPointPair);

            lbLog.Items.Add("Running finished");
            lbLog.Items.Add("Total time: " + measureTime.ToString());
            lbLog.Items.Add("---------------------------------------");
        }       
    }
}