using System;
using System.Windows.Forms;

namespace Lecture_22_Dapper
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmProduct());
        }
    }
}
