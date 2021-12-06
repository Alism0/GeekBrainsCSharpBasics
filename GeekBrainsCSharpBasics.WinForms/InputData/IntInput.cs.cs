using System;
using System.Windows.Forms;

namespace GeekBrainsCSharpBasics.WinForms
{
    public partial class IntInputForm : Form, IInputForm<int>
    {
        public int Value { get; set; }

        public IntInputForm()
        {
            InitializeComponent();
        }

        public event EventHandler OnEnterKeyPress;

        private void InputTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
                return;

            if (string.IsNullOrEmpty(InputTextBox.Text))
                return;

            Value = int.Parse(InputTextBox.Text);
            OnEnterKeyPress.Invoke(Value, null);
            Close();
        }
    }
}
