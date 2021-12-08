namespace GeekBrainsCSharpBasics.WinForms.Lesson7
{
    partial class GamesMenu
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
            this.RunDoublerButton = new System.Windows.Forms.Button();
            this.RunNumberDetectiveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RunDoublerButton
            // 
            this.RunDoublerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RunDoublerButton.Location = new System.Drawing.Point(12, 12);
            this.RunDoublerButton.Name = "RunDoublerButton";
            this.RunDoublerButton.Size = new System.Drawing.Size(220, 45);
            this.RunDoublerButton.TabIndex = 1;
            this.RunDoublerButton.Text = "Удвоитель";
            this.RunDoublerButton.UseVisualStyleBackColor = true;
            this.RunDoublerButton.Click += new System.EventHandler(this.RunDoublerButton_Click);
            // 
            // RunNumberDetectiveButton
            // 
            this.RunNumberDetectiveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RunNumberDetectiveButton.Location = new System.Drawing.Point(12, 63);
            this.RunNumberDetectiveButton.Name = "RunNumberDetectiveButton";
            this.RunNumberDetectiveButton.Size = new System.Drawing.Size(220, 45);
            this.RunNumberDetectiveButton.TabIndex = 2;
            this.RunNumberDetectiveButton.Text = "Угадай число";
            this.RunNumberDetectiveButton.UseVisualStyleBackColor = true;
            this.RunNumberDetectiveButton.Click += new System.EventHandler(this.RunNumberDetectiveButton_Click);
            // 
            // GamesMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 128);
            this.Controls.Add(this.RunNumberDetectiveButton);
            this.Controls.Add(this.RunDoublerButton);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(265, 175);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(265, 175);
            this.Name = "GamesMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Игры";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button RunDoublerButton;
        private System.Windows.Forms.Button RunNumberDetectiveButton;
    }
}

