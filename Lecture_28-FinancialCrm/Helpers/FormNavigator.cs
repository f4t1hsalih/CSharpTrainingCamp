using System.Windows.Forms;

namespace Lecture_28_FinancialCrm
{
    public static class FormNavigator
    {
        // Ana form referansını saklayan statik değişken
        private static Form mainForm;

        // Ana formu ayarlamak için kullanılacak metot
        public static void SetMainForm(Form form)
        {
            mainForm = form;
        }

        public static void Navigate(Form currentForm, Form targetForm, bool closeCurrent = true)
        {
            targetForm.Show();

            if (closeCurrent)
            {
                if (currentForm == mainForm)
                {
                    currentForm.Hide();
                }
                else
                {
                    currentForm.Close();
                }
            }
        }
    }
}
