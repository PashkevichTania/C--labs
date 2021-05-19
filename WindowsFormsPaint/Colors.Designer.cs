namespace WindowsFormsPaint
{
    partial class ColorsForm
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
            this.picResultColor = new System.Windows.Forms.PictureBox();
            this.Scroll_Blue = new System.Windows.Forms.HScrollBar();
            this.Scroll_Green = new System.Windows.Forms.HScrollBar();
            this.Scroll_Red = new System.Windows.Forms.HScrollBar();
            this.numeric_Blue = new System.Windows.Forms.NumericUpDown();
            this.numeric_Green = new System.Windows.Forms.NumericUpDown();
            this.numeric_Red = new System.Windows.Forms.NumericUpDown();
            this.redLabel = new System.Windows.Forms.Label();
            this.greenLabel = new System.Windows.Forms.Label();
            this.blueLabel = new System.Windows.Forms.Label();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOtherColors = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picResultColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Blue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Red)).BeginInit();
            this.SuspendLayout();
            // 
            // picResultColor
            // 
            this.picResultColor.Location = new System.Drawing.Point(332, 21);
            this.picResultColor.Name = "picResultColor";
            this.picResultColor.Size = new System.Drawing.Size(77, 77);
            this.picResultColor.TabIndex = 0;
            this.picResultColor.TabStop = false;
            // 
            // Scroll_Blue
            // 
            this.Scroll_Blue.LargeChange = 1;
            this.Scroll_Blue.Location = new System.Drawing.Point(71, 76);
            this.Scroll_Blue.Maximum = 255;
            this.Scroll_Blue.Name = "Scroll_Blue";
            this.Scroll_Blue.Size = new System.Drawing.Size(194, 21);
            this.Scroll_Blue.TabIndex = 1;
            this.Scroll_Blue.ValueChanged += new System.EventHandler(this.ScrollColorValueChanged);
            // 
            // Scroll_Green
            // 
            this.Scroll_Green.LargeChange = 1;
            this.Scroll_Green.Location = new System.Drawing.Point(71, 48);
            this.Scroll_Green.Maximum = 255;
            this.Scroll_Green.Name = "Scroll_Green";
            this.Scroll_Green.Size = new System.Drawing.Size(194, 21);
            this.Scroll_Green.TabIndex = 2;
            this.Scroll_Green.ValueChanged += new System.EventHandler(this.ScrollColorValueChanged);
            // 
            // Scroll_Red
            // 
            this.Scroll_Red.LargeChange = 1;
            this.Scroll_Red.Location = new System.Drawing.Point(71, 16);
            this.Scroll_Red.Maximum = 255;
            this.Scroll_Red.Name = "Scroll_Red";
            this.Scroll_Red.Size = new System.Drawing.Size(194, 21);
            this.Scroll_Red.TabIndex = 3;
            this.Scroll_Red.ValueChanged += new System.EventHandler(this.ScrollColorValueChanged);
            // 
            // numeric_Blue
            // 
            this.numeric_Blue.Location = new System.Drawing.Point(282, 76);
            this.numeric_Blue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numeric_Blue.Name = "numeric_Blue";
            this.numeric_Blue.Size = new System.Drawing.Size(44, 22);
            this.numeric_Blue.TabIndex = 4;
            this.numeric_Blue.ValueChanged += new System.EventHandler(this.numericColorValueChanged);
            // 
            // numeric_Green
            // 
            this.numeric_Green.Location = new System.Drawing.Point(282, 48);
            this.numeric_Green.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numeric_Green.Name = "numeric_Green";
            this.numeric_Green.Size = new System.Drawing.Size(44, 22);
            this.numeric_Green.TabIndex = 5;
            this.numeric_Green.ValueChanged += new System.EventHandler(this.numericColorValueChanged);
            // 
            // numeric_Red
            // 
            this.numeric_Red.Location = new System.Drawing.Point(282, 20);
            this.numeric_Red.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numeric_Red.Name = "numeric_Red";
            this.numeric_Red.Size = new System.Drawing.Size(44, 22);
            this.numeric_Red.TabIndex = 6;
            this.numeric_Red.ValueChanged += new System.EventHandler(this.numericColorValueChanged);
            // 
            // redLabel
            // 
            this.redLabel.AutoSize = true;
            this.redLabel.Location = new System.Drawing.Point(5, 20);
            this.redLabel.Name = "redLabel";
            this.redLabel.Size = new System.Drawing.Size(34, 17);
            this.redLabel.TabIndex = 7;
            this.redLabel.Text = "Red";
            // 
            // greenLabel
            // 
            this.greenLabel.AutoSize = true;
            this.greenLabel.Location = new System.Drawing.Point(5, 48);
            this.greenLabel.Name = "greenLabel";
            this.greenLabel.Size = new System.Drawing.Size(48, 17);
            this.greenLabel.TabIndex = 8;
            this.greenLabel.Text = "Green";
            // 
            // blueLabel
            // 
            this.blueLabel.AutoSize = true;
            this.blueLabel.Location = new System.Drawing.Point(5, 76);
            this.blueLabel.Name = "blueLabel";
            this.blueLabel.Size = new System.Drawing.Size(36, 17);
            this.blueLabel.TabIndex = 9;
            this.blueLabel.Text = "Blue";
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(16, 123);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 10;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(107, 123);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 11;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOtherColors
            // 
            this.buttonOtherColors.Location = new System.Drawing.Point(282, 123);
            this.buttonOtherColors.Name = "buttonOtherColors";
            this.buttonOtherColors.Size = new System.Drawing.Size(127, 23);
            this.buttonOtherColors.TabIndex = 12;
            this.buttonOtherColors.Text = "Other Colors";
            this.buttonOtherColors.UseVisualStyleBackColor = true;
            this.buttonOtherColors.Click += new System.EventHandler(this.buttonOtherColors_Click);
            // 
            // ColorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 162);
            this.Controls.Add(this.buttonOtherColors);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.blueLabel);
            this.Controls.Add(this.greenLabel);
            this.Controls.Add(this.redLabel);
            this.Controls.Add(this.numeric_Red);
            this.Controls.Add(this.numeric_Green);
            this.Controls.Add(this.numeric_Blue);
            this.Controls.Add(this.Scroll_Red);
            this.Controls.Add(this.Scroll_Green);
            this.Controls.Add(this.Scroll_Blue);
            this.Controls.Add(this.picResultColor);
            this.Name = "ColorsForm";
            this.Text = "Colors";
            ((System.ComponentModel.ISupportInitialize)(this.picResultColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Blue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Green)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Red)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picResultColor;
        private System.Windows.Forms.HScrollBar Scroll_Blue;
        private System.Windows.Forms.HScrollBar Scroll_Green;
        private System.Windows.Forms.HScrollBar Scroll_Red;
        private System.Windows.Forms.NumericUpDown numeric_Blue;
        private System.Windows.Forms.NumericUpDown numeric_Green;
        private System.Windows.Forms.NumericUpDown numeric_Red;
        private System.Windows.Forms.Label redLabel;
        private System.Windows.Forms.Label greenLabel;
        private System.Windows.Forms.Label blueLabel;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOtherColors;
    }
}