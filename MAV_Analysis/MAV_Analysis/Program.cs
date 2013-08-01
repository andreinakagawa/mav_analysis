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
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MAV_Analysis
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow());
        }
    }
}
