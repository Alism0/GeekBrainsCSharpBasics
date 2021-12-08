
namespace GeekBrainsCSharpBasics.WinForms
{
    partial class Menu
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
            this.RunLesson7Button = new System.Windows.Forms.Button();
            this.RunLesson8Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RunLesson7Button
            // 
            this.RunLesson7Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RunLesson7Button.Location = new System.Drawing.Point(12, 12);
            this.RunLesson7Button.Name = "RunLesson7Button";
            this.RunLesson7Button.Size = new System.Drawing.Size(220, 45);
            this.RunLesson7Button.TabIndex = 1;
            this.RunLesson7Button.Text = "Урок 7";
            this.RunLesson7Button.UseVisualStyleBackColor = true;
            this.RunLesson7Button.Click += new System.EventHandler(this.RunLesson7Button_Click);
            // 
            // RunLesson8Button
            // 
            this.RunLesson8Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RunLesson8Button.Location = new System.Drawing.Point(12, 63);
            this.RunLesson8Button.Name = "RunLesson8Button";
            this.RunLesson8Button.Size = new System.Drawing.Size(220, 45);
            this.RunLesson8Button.TabIndex = 2;
            this.RunLesson8Button.Text = "Урок 8";
            this.RunLesson8Button.UseVisualStyleBackColor = true;
            this.RunLesson8Button.Click += new System.EventHandler(this.RunLesson8ButtonButton_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 128);
            this.Controls.Add(this.RunLesson8Button);
            this.Controls.Add(this.RunLesson7Button);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(265, 175);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(265, 175);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button RunLesson7Button;
        private System.Windows.Forms.Button RunLesson8Button;
    }
}

