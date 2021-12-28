using System;
using System.Windows.Forms;

namespace SolarTest
{
    class Programm 
    {
       [STAThread]
        static void Main(string[] args)
            {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}