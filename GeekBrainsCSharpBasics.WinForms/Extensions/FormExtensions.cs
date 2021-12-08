using System.Windows.Forms;

namespace GeekBrainsCSharpBasics.WinForms
{
    public static class FormExtensions
    {
        public static TChildForm RunChildForm<TParentForm, TChildForm>(this TParentForm parentForm)
            where TParentForm : Form
            where TChildForm : Form, new()
        {
            TChildForm childForm = new TChildForm();
            childForm.Show(parentForm);
            return childForm;
        }

        public static TParentForm HideParentForm<TParentForm, TChildForm>(this TParentForm parentForm, TChildForm childForm)
            where TParentForm : Form
            where TChildForm : Form
        {
            void onFormClosing(object _, FormClosingEventArgs args)
            {
                parentForm.Visible = true;
            }

            parentForm.Visible = false;
            childForm.FormClosing += new FormClosingEventHandler(onFormClosing);
            return parentForm;
        }
    }
}
