using System;
using System.Windows.Forms;

namespace Lecture_28_FinancialCrm
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmDashboard());
        }
    }
}
