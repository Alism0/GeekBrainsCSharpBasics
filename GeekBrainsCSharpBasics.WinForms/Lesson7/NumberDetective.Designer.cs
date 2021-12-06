
namespace GeekBrainsCSharpBasics.WinForms.Lesson7
{
    partial class NumberDetective
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
            this.EnterNumberButton = new System.Windows.Forms.Button();
            this.NewGameButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EnterNumberButton
            // 
            this.EnterNumberButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnterNumberButton.Location = new System.Drawing.Point(175, 12);
            this.EnterNumberButton.Name = "EnterNumberButton";
            this.EnterNumberButton.Size = new System.Drawing.Size(115, 45);
            this.EnterNumberButton.TabIndex = 1;
            this.EnterNumberButton.Text = "Ввод числа";
            this.EnterNumberButton.UseVisualStyleBackColor = true;
            this.EnterNumberButton.Click += new System.EventHandler(this.EnterNumberButton_Click);
            // 
            // NewGameButton
            // 
            this.NewGameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewGameButton.Location = new System.Drawing.Point(12, 12);
            this.NewGameButton.Name = "NewGameButton";
            this.NewGameButton.Size = new System.Drawing.Size(115, 45);
            this.NewGameButton.TabIndex = 2;
            this.NewGameButton.Text = "Новая игра";
            this.NewGameButton.UseVisualStyleBackColor = true;
            this.NewGameButton.Click += new System.EventHandler(this.NewGameButton_Click);
            // 
            // NumberDetective
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 73);
            this.Controls.Add(this.NewGameButton);
            this.Controls.Add(this.EnterNumberButton);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(320, 120);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(320, 120);
            this.Name = "NumberDetective";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Угадай число";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button EnterNumberButton;
        private System.Windows.Forms.Button NewGameButton;
    }
}