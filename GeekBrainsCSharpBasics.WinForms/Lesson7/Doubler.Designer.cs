
namespace GeekBrainsCSharpBasics.WinForms.Lesson7
{
    partial class Doubler
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
            this.NewGameButton = new System.Windows.Forms.Button();
            this.AdditionButton = new System.Windows.Forms.Button();
            this.MultiplicationButton = new System.Windows.Forms.Button();
            this.UserNumberLabel = new System.Windows.Forms.Label();
            this.MovesCountLabel = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.MenuToolStripDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.GameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CancelButton = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NewGameButton
            // 
            this.NewGameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewGameButton.Location = new System.Drawing.Point(245, 30);
            this.NewGameButton.Name = "NewGameButton";
            this.NewGameButton.Size = new System.Drawing.Size(115, 45);
            this.NewGameButton.TabIndex = 0;
            this.NewGameButton.Text = "Новая игра";
            this.NewGameButton.UseVisualStyleBackColor = true;
            this.NewGameButton.Click += new System.EventHandler(this.NewGameButton_Click);
            // 
            // AdditionButton
            // 
            this.AdditionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AdditionButton.Location = new System.Drawing.Point(245, 81);
            this.AdditionButton.Name = "AdditionButton";
            this.AdditionButton.Size = new System.Drawing.Size(115, 45);
            this.AdditionButton.TabIndex = 1;
            this.AdditionButton.Text = "+1";
            this.AdditionButton.UseVisualStyleBackColor = true;
            this.AdditionButton.Click += new System.EventHandler(this.AdditionButton_Click);
            // 
            // MultiplicationButton
            // 
            this.MultiplicationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MultiplicationButton.Location = new System.Drawing.Point(245, 132);
            this.MultiplicationButton.Name = "MultiplicationButton";
            this.MultiplicationButton.Size = new System.Drawing.Size(115, 45);
            this.MultiplicationButton.TabIndex = 2;
            this.MultiplicationButton.Text = "X2";
            this.MultiplicationButton.UseVisualStyleBackColor = true;
            this.MultiplicationButton.Click += new System.EventHandler(this.MultiplicationButton_Click);
            // 
            // UserNumberLabel
            // 
            this.UserNumberLabel.AutoSize = true;
            this.UserNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserNumberLabel.Location = new System.Drawing.Point(12, 43);
            this.UserNumberLabel.Name = "UserNumberLabel";
            this.UserNumberLabel.Size = new System.Drawing.Size(131, 18);
            this.UserNumberLabel.TabIndex = 4;
            this.UserNumberLabel.Text = "Текущее число:";
            // 
            // MovesCountLabel
            // 
            this.MovesCountLabel.AutoSize = true;
            this.MovesCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MovesCountLabel.Location = new System.Drawing.Point(12, 210);
            this.MovesCountLabel.Name = "MovesCountLabel";
            this.MovesCountLabel.Size = new System.Drawing.Size(153, 18);
            this.MovesCountLabel.TabIndex = 5;
            this.MovesCountLabel.Text = "Сделанных ходов:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuToolStripDropDownButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(372, 27);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // MenuToolStripDropDownButton
            // 
            this.MenuToolStripDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.MenuToolStripDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GameToolStripMenuItem});
            this.MenuToolStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MenuToolStripDropDownButton.Name = "MenuToolStripDropDownButton";
            this.MenuToolStripDropDownButton.Size = new System.Drawing.Size(65, 24);
            this.MenuToolStripDropDownButton.Text = "Меню";
            // 
            // GameToolStripMenuItem
            // 
            this.GameToolStripMenuItem.Name = "GameToolStripMenuItem";
            this.GameToolStripMenuItem.Size = new System.Drawing.Size(140, 26);
            this.GameToolStripMenuItem.Text = "Играть";
            this.GameToolStripMenuItem.Click += new System.EventHandler(this.GameToolStripMenuItem_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelButton.Location = new System.Drawing.Point(245, 183);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(115, 45);
            this.CancelButton.TabIndex = 8;
            this.CancelButton.Text = "Отменить";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // Doubler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 243);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.MovesCountLabel);
            this.Controls.Add(this.UserNumberLabel);
            this.Controls.Add(this.MultiplicationButton);
            this.Controls.Add(this.AdditionButton);
            this.Controls.Add(this.NewGameButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(390, 47);
            this.Name = "Doubler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doubler";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NewGameButton;
        private System.Windows.Forms.Button AdditionButton;
        private System.Windows.Forms.Button MultiplicationButton;
        private System.Windows.Forms.Label UserNumberLabel;
        private System.Windows.Forms.Label MovesCountLabel;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton MenuToolStripDropDownButton;
        private System.Windows.Forms.ToolStripMenuItem GameToolStripMenuItem;
        private new System.Windows.Forms.Button CancelButton;
    }
}