
namespace GeekBrainsCSharpBasics.WinForms.Lesson8
{
    partial class Exercise2Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NumericUpDownElement = new System.Windows.Forms.NumericUpDown();
            this.TextBoxElement = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownElement)).BeginInit();
            this.SuspendLayout();
            // 
            // NumericUpDownElement
            // 
            this.NumericUpDownElement.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.NumericUpDownElement.Location = new System.Drawing.Point(13, 13);
            this.NumericUpDownElement.Name = "NumericUpDownElement";
            this.NumericUpDownElement.Size = new System.Drawing.Size(220, 24);
            this.NumericUpDownElement.TabIndex = 0;
            this.NumericUpDownElement.ValueChanged += new System.EventHandler(this.NumericUpDownElement_ValueChanged);
            // 
            // TextBoxElement
            // 
            this.TextBoxElement.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.TextBoxElement.Location = new System.Drawing.Point(12, 43);
            this.TextBoxElement.Name = "TextBoxElement";
            this.TextBoxElement.Size = new System.Drawing.Size(220, 24);
            this.TextBoxElement.TabIndex = 1;
            // 
            // Exercise2Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 78);
            this.Controls.Add(this.TextBoxElement);
            this.Controls.Add(this.NumericUpDownElement);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(265, 125);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(265, 125);
            this.Name = "Exercise2Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Задание 2";
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownElement)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown NumericUpDownElement;
        private System.Windows.Forms.TextBox TextBoxElement;
    }
}