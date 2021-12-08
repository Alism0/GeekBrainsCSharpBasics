
namespace GeekBrainsCSharpBasics.WinForms.Lesson8
{
    partial class NotesLog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotesLog));
            this.LogNoteText = new System.Windows.Forms.TextBox();
            this.MenuToolStrip = new System.Windows.Forms.ToolStrip();
            this.FileToolStripButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.NewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FileToolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ControlPanel = new System.Windows.Forms.Panel();
            this.LogNoteDateTime = new System.Windows.Forms.Label();
            this.LogNoteNumber = new System.Windows.Forms.NumericUpDown();
            this.SaveButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.MenuToolStrip.SuspendLayout();
            this.ControlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogNoteNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // LogNoteText
            // 
            this.LogNoteText.Enabled = false;
            this.LogNoteText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.LogNoteText.Location = new System.Drawing.Point(0, 34);
            this.LogNoteText.Multiline = true;
            this.LogNoteText.Name = "LogNoteText";
            this.LogNoteText.Size = new System.Drawing.Size(602, 169);
            this.LogNoteText.TabIndex = 2;
            // 
            // MenuToolStrip
            // 
            this.MenuToolStrip.AutoSize = false;
            this.MenuToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripButton,
            this.HelpToolStripDropDownButton});
            this.MenuToolStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuToolStrip.Name = "MenuToolStrip";
            this.MenuToolStrip.Size = new System.Drawing.Size(582, 27);
            this.MenuToolStrip.TabIndex = 1;
            this.MenuToolStrip.Text = "MenuToolStrip";
            // 
            // FileToolStripButton
            // 
            this.FileToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.FileToolStripButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewToolStripMenuItem,
            this.OpenToolStripMenuItem,
            this.SaveToolStripMenuItem,
            this.SaveAsToolStripMenuItem,
            this.FileToolStripSeparator,
            this.ExitToolStripMenuItem});
            this.FileToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("FileToolStripButton.Image")));
            this.FileToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FileToolStripButton.Name = "FileToolStripButton";
            this.FileToolStripButton.Size = new System.Drawing.Size(59, 24);
            this.FileToolStripButton.Text = "Файл";
            // 
            // NewToolStripMenuItem
            // 
            this.NewToolStripMenuItem.Name = "NewToolStripMenuItem";
            this.NewToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.NewToolStripMenuItem.Text = "Новый";
            this.NewToolStripMenuItem.Click += new System.EventHandler(this.NewToolStripMenuItem_Click);
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.OpenToolStripMenuItem.Text = "Открыть";
            this.OpenToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Enabled = false;
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.SaveToolStripMenuItem.Text = "Сохранить";
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // SaveAsToolStripMenuItem
            // 
            this.SaveAsToolStripMenuItem.Enabled = false;
            this.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem";
            this.SaveAsToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.SaveAsToolStripMenuItem.Text = "Сохранить как";
            this.SaveAsToolStripMenuItem.Click += new System.EventHandler(this.SaveAsToolStripMenuItem_Click);
            // 
            // FileToolStripSeparator
            // 
            this.FileToolStripSeparator.Name = "FileToolStripSeparator";
            this.FileToolStripSeparator.Size = new System.Drawing.Size(189, 6);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.ExitToolStripMenuItem.Text = "Выход";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // HelpToolStripDropDownButton
            // 
            this.HelpToolStripDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.HelpToolStripDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutToolStripMenuItem});
            this.HelpToolStripDropDownButton.Image = ((System.Drawing.Image)(resources.GetObject("HelpToolStripDropDownButton.Image")));
            this.HelpToolStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HelpToolStripDropDownButton.Name = "HelpToolStripDropDownButton";
            this.HelpToolStripDropDownButton.Size = new System.Drawing.Size(83, 24);
            this.HelpToolStripDropDownButton.Text = "Помощь";
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.AboutToolStripMenuItem.Text = "О приложение";
            this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // ControlPanel
            // 
            this.ControlPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ControlPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ControlPanel.Controls.Add(this.LogNoteDateTime);
            this.ControlPanel.Controls.Add(this.LogNoteNumber);
            this.ControlPanel.Controls.Add(this.SaveButton);
            this.ControlPanel.Controls.Add(this.RemoveButton);
            this.ControlPanel.Controls.Add(this.AddButton);
            this.ControlPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ControlPanel.Enabled = false;
            this.ControlPanel.Location = new System.Drawing.Point(0, 134);
            this.ControlPanel.Name = "ControlPanel";
            this.ControlPanel.Size = new System.Drawing.Size(582, 69);
            this.ControlPanel.TabIndex = 3;
            // 
            // LogNoteDateTime
            // 
            this.LogNoteDateTime.AutoSize = true;
            this.LogNoteDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.LogNoteDateTime.Location = new System.Drawing.Point(451, 39);
            this.LogNoteDateTime.Name = "LogNoteDateTime";
            this.LogNoteDateTime.Size = new System.Drawing.Size(0, 18);
            this.LogNoteDateTime.TabIndex = 8;
            // 
            // LogNoteNumber
            // 
            this.LogNoteNumber.Location = new System.Drawing.Point(454, 12);
            this.LogNoteNumber.Name = "LogNoteNumber";
            this.LogNoteNumber.Size = new System.Drawing.Size(117, 24);
            this.LogNoteNumber.TabIndex = 7;
            this.LogNoteNumber.ValueChanged += new System.EventHandler(this.QuestionNumber_ValueChanged);
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveButton.Location = new System.Drawing.Point(304, 12);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(140, 45);
            this.SaveButton.TabIndex = 5;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RemoveButton.Location = new System.Drawing.Point(158, 12);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(140, 45);
            this.RemoveButton.TabIndex = 4;
            this.RemoveButton.Text = "Удалить";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddButton.Location = new System.Drawing.Point(12, 12);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(140, 45);
            this.AddButton.TabIndex = 3;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // NotesLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 203);
            this.Controls.Add(this.ControlPanel);
            this.Controls.Add(this.MenuToolStrip);
            this.Controls.Add(this.LogNoteText);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 250);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 250);
            this.Name = "NotesLog";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Журнал заметок";
            this.MenuToolStrip.ResumeLayout(false);
            this.MenuToolStrip.PerformLayout();
            this.ControlPanel.ResumeLayout(false);
            this.ControlPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogNoteNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LogNoteText;
        private System.Windows.Forms.ToolStrip MenuToolStrip;
        private System.Windows.Forms.ToolStripDropDownButton FileToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem NewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator FileToolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton HelpToolStripDropDownButton;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.Panel ControlPanel;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.NumericUpDown LogNoteNumber;
        private System.Windows.Forms.Label LogNoteDateTime;
    }
}