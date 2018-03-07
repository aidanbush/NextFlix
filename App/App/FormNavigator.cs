using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace App
{
    internal class FormNavigator
    {

        static Dictionary<string, Form> forms = new Dictionary<string, Form>();
        public static void ChangeForm(Form form, string formName)
        {

            if (forms.TryGetValue(formName, out Form existingForm))
            {
                form.Hide();
                existingForm.ShowDialog();
                return;
            }

            Debug.WriteLine("There is currently no form to switch to!, create one with State.AddForm(Form, name)");

        }


        public static void AddForm(Form form, string formName)
        {
            forms.Add(formName, form);
        }
    }
}