using System;
using System.Windows.Forms;

namespace GeekBrainsCSharpBasics.WinForms.Lesson8
{
    public partial class Exercise2Form : Form
    {
        public Exercise2Form() =>
            InitializeComponent();

        private void NumericUpDownElement_ValueChanged(object sender, EventArgs e) =>
            TextBoxElement.Text = NumericUpDownElement.Value.ToString();
    }
}
