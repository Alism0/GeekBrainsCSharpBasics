using System;
using System.Windows.Forms;

namespace GeekBrainsCSharpBasics.WinForms
{
    public partial class TextForm : Form, IInputForm<string>
    {
        private string _value;

        public string Value
        {
            get => _value;
            set
            {
                InputTextBox.Text = value;
                _value = value;
            }
        }

        public TextForm(string value) : this()
        {
            Value = value;
        }

        public TextForm()
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

            Value = InputTextBox.Text;
            OnEnterKeyPress.Invoke(Value, null);
            Close();
        }
    }
}
