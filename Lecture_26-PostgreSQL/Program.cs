using System;
using System.Windows.Forms;

namespace Lecture_26_PostgreSQL
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmEmployee());
        }
    }
}
