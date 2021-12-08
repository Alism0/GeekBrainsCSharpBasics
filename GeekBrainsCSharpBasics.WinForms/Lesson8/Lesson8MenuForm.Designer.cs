
namespace GeekBrainsCSharpBasics.WinForms.Lesson8
{
    partial class Lesson8MenuForm
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
            this.RunExercise1Button = new System.Windows.Forms.Button();
            this.RunExercise2Button = new System.Windows.Forms.Button();
            this.RunExercise3Button = new System.Windows.Forms.Button();
            this.RunExercise4Button = new System.Windows.Forms.Button();
            this.RunExercise5Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RunExercise1Button
            // 
            this.RunExercise1Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RunExercise1Button.Location = new System.Drawing.Point(12, 12);
            this.RunExercise1Button.Name = "RunExercise1Button";
            this.RunExercise1Button.Size = new System.Drawing.Size(220, 45);
            this.RunExercise1Button.TabIndex = 2;
            this.RunExercise1Button.Text = "Задание 1";
            this.RunExercise1Button.UseVisualStyleBackColor = true;
            this.RunExercise1Button.Click += new System.EventHandler(this.RunExercise1Button_Click);
            // 
            // RunExercise2Button
            // 
            this.RunExercise2Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RunExercise2Button.Location = new System.Drawing.Point(12, 63);
            this.RunExercise2Button.Name = "RunExercise2Button";
            this.RunExercise2Button.Size = new System.Drawing.Size(220, 45);
            this.RunExercise2Button.TabIndex = 3;
            this.RunExercise2Button.Text = "Задание 2";
            this.RunExercise2Button.UseVisualStyleBackColor = true;
            this.RunExercise2Button.Click += new System.EventHandler(this.RunExercise2Button_Click);
            // 
            // RunExercise3Button
            // 
            this.RunExercise3Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RunExercise3Button.Location = new System.Drawing.Point(12, 114);
            this.RunExercise3Button.Name = "RunExercise3Button";
            this.RunExercise3Button.Size = new System.Drawing.Size(220, 45);
            this.RunExercise3Button.TabIndex = 4;
            this.RunExercise3Button.Text = "Задание 3";
            this.RunExercise3Button.UseVisualStyleBackColor = true;
            this.RunExercise3Button.Click += new System.EventHandler(this.RunExercise3Button_Click);
            // 
            // RunExercise4Button
            // 
            this.RunExercise4Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RunExercise4Button.Location = new System.Drawing.Point(12, 165);
            this.RunExercise4Button.Name = "RunExercise4Button";
            this.RunExercise4Button.Size = new System.Drawing.Size(220, 45);
            this.RunExercise4Button.TabIndex = 5;
            this.RunExercise4Button.Text = "Задание 4";
            this.RunExercise4Button.UseVisualStyleBackColor = true;
            this.RunExercise4Button.Click += new System.EventHandler(this.RunExercise4Button_Click);
            // 
            // RunExercise5Button
            // 
            this.RunExercise5Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RunExercise5Button.Location = new System.Drawing.Point(12, 216);
            this.RunExercise5Button.Name = "RunExercise5Button";
            this.RunExercise5Button.Size = new System.Drawing.Size(220, 45);
            this.RunExercise5Button.TabIndex = 6;
            this.RunExercise5Button.Text = "Задание 5";
            this.RunExercise5Button.UseVisualStyleBackColor = true;
            this.RunExercise5Button.Click += new System.EventHandler(this.RunExercise5Button_Click);
            // 
            // Lesson8MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 278);
            this.Controls.Add(this.RunExercise5Button);
            this.Controls.Add(this.RunExercise4Button);
            this.Controls.Add(this.RunExercise3Button);
            this.Controls.Add(this.RunExercise2Button);
            this.Controls.Add(this.RunExercise1Button);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(265, 325);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(265, 325);
            this.Name = "Lesson8MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Урок 8";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button RunExercise1Button;
        private System.Windows.Forms.Button RunExercise2Button;
        private System.Windows.Forms.Button RunExercise3Button;
        private System.Windows.Forms.Button RunExercise4Button;
        private System.Windows.Forms.Button RunExercise5Button;
    }
}