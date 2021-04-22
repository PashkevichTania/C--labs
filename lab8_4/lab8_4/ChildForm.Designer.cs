namespace MdiApplication
{
    partial class ChildForm
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
            this.ChildTextBox = new System.Windows.Forms.RichTextBox();
            this.ChildWIndowMenu = new System.Windows.Forms.MenuStrip();
            this.FormatMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToggleMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChildWIndowMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // ChildTextBox
            // 
            this.ChildTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChildTextBox.Location = new System.Drawing.Point(0, 28);
            this.ChildTextBox.Name = "ChildTextBox";
            this.ChildTextBox.Size = new System.Drawing.Size(298, 173);
            this.ChildTextBox.TabIndex = 0;
            this.ChildTextBox.Text = "";
            // 
            // ChildWIndowMenu
            // 
            this.ChildWIndowMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ChildWIndowMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FormatMenuItem});
            this.ChildWIndowMenu.Location = new System.Drawing.Point(0, 0);
            this.ChildWIndowMenu.Name = "ChildWIndowMenu";
            this.ChildWIndowMenu.Size = new System.Drawing.Size(298, 28);
            this.ChildWIndowMenu.TabIndex = 1;
            this.ChildWIndowMenu.Text = "menuStrip1";
            // 
            // FormatMenuItem
            // 
            this.FormatMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToggleMenuItem});
            this.FormatMenuItem.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.FormatMenuItem.MergeIndex = 1;
            this.FormatMenuItem.Name = "FormatMenuItem";
            this.FormatMenuItem.Size = new System.Drawing.Size(70, 24);
            this.FormatMenuItem.Text = "Format";
            // 
            // ToggleMenuItem
            // 
            this.ToggleMenuItem.Name = "ToggleMenuItem";
            this.ToggleMenuItem.Size = new System.Drawing.Size(219, 26);
            this.ToggleMenuItem.Text = "Toggle Foreground";
            this.ToggleMenuItem.Click += new System.EventHandler(this.ToggleMenuItem_Click);
            // 
            // ChildForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 201);
            this.Controls.Add(this.ChildTextBox);
            this.Controls.Add(this.ChildWIndowMenu);
            this.MainMenuStrip = this.ChildWIndowMenu;
            this.Name = "ChildForm";
            this.Text = "Child Form";
            this.ChildWIndowMenu.ResumeLayout(false);
            this.ChildWIndowMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox ChildTextBox;
        private System.Windows.Forms.MenuStrip ChildWIndowMenu;
        private System.Windows.Forms.ToolStripMenuItem FormatMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToggleMenuItem;
    }
}