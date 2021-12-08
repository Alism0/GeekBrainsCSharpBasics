using System;
using System.Windows.Forms;

namespace GeekBrainsCSharpBasics.WinForms.Lesson7
{
    public partial class GamesMenu : Form
    {
        public GamesMenu() => InitializeComponent();

        private void RunDoublerButton_Click(object sender, EventArgs e) =>
            this.HideParentForm(this.RunChildForm<GamesMenu, Doubler>());

        private void RunNumberDetectiveButton_Click(object sender, EventArgs e) =>
            this.HideParentForm(this.RunChildForm<GamesMenu, NumberDetective>());
    }
}
