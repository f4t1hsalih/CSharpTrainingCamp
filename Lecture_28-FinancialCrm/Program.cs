using Lecture_28_FinancialCrm.Forms;
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
            FrmLogin mainForm = new FrmLogin();

            // Ana formu FormNavigator'a ayarla
            FormNavigator.SetMainForm(mainForm);

            Application.Run(mainForm);
        }
    }
}
