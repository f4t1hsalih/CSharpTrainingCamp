using System;
using System.Windows.Forms;

namespace Lecture_28_FinancialCrm
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Ana formu başlat
            FrmDashboard mainForm = new FrmDashboard();

            // Ana formu FormNavigator'a ayarla
            FormNavigator.SetMainForm(mainForm);

            Application.Run(mainForm);
        }
    }
}
