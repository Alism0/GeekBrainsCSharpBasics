using GeekBrainsCSharpBasics.WinForms.Lesson7;
using GeekBrainsCSharpBasics.WinForms.Lesson8;
using System;
using System.Windows.Forms;

namespace GeekBrainsCSharpBasics.WinForms
{
    public partial class Menu : Form
    {
        public Menu() => InitializeComponent();

        private void RunLesson7Button_Click(object sender, EventArgs e) =>
            this.HideParentForm(this.RunChildForm<Menu, GamesMenu>());

        private void RunLesson8ButtonButton_Click(object sender, EventArgs e) =>
            this.HideParentForm(this.RunChildForm<Menu, Lesson8MenuForm>());
    }
}
