using System;

namespace GeekBrainsCSharpBasics.WinForms
{
    public interface IInputForm<TInput>
    {
        TInput Value { get; set; }

        event EventHandler OnEnterKeyPress;
    }
}
