using GeekBrainsCSharpBasics.WinForms.Lesson7;
using System;
using System.Windows.Forms;

namespace GeekBrainsCSharpBasics.WinForms
{
    public partial class Menu : Form
    {
        public Menu() => InitializeComponent();

        private void RubDoublerButton_Click(object sender, EventArgs e) =>
            RunForm<Doubler>(sender, e);

        private void RunNumberDetectiveButton_Click(object sender, EventArgs e) =>
            RunForm<NumberDetective>(sender, e);

        private void RunForm<TForm>(object sender, EventArgs e)
            where TForm : Form, new()
        {
            void onFormClosing(object _, FormClosingEventArgs args)
            {
                Visible = true;
            }

            Visible = false;
            TForm numberDetectiveForm = new TForm();
            numberDetectiveForm.Show(this);
            numberDetectiveForm.FormClosing += new FormClosingEventHandler(onFormClosing);
        }
    }
}
