using GeekBrainsCSharpBasics.StudentsLibrary;
using System;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace GeekBrainsCSharpBasics.WinForms.Lesson8
{
    public partial class Lesson8MenuForm : Form
    {
        public Lesson8MenuForm() => InitializeComponent();

        private void RunExercise1Button_Click(object sender, EventArgs e)
        {
            PropertyInfo[] properties = typeof(DateTime).GetProperties();
            TextForm textForm = new TextForm(string.Join("\r\n", properties.Select(property => property.Name)));
            this.HideParentForm(textForm);
            textForm.Show(this);
        }

        private void RunExercise2Button_Click(object sender, EventArgs e) =>
            this.HideParentForm(this.RunChildForm<Lesson8MenuForm, Exercise2Form>());

        private void RunExercise3Button_Click(object sender, EventArgs e) =>
            this.HideParentForm(this.RunChildForm<Lesson8MenuForm, Questions>());

        private void RunExercise4Button_Click(object sender, EventArgs e) =>
            this.HideParentForm(this.RunChildForm<Lesson8MenuForm, NotesLog>());

        private void RunExercise5Button_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() != DialogResult.OK)
                return;

            FileConverter.Convert<Student>(openFileDialog.FileName, saveFileDialog.FileName);
        }
    }
}
