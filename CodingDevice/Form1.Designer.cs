namespace CodingDevice
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.InputBox = new System.Windows.Forms.TextBox();
            this.CodeBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.EncodeButton = new System.Windows.Forms.Button();
            this.ReverseBox = new System.Windows.Forms.CheckBox();
            this.NumberOfChambersNumeric = new System.Windows.Forms.NumericUpDown();
            this.CodeBox2 = new System.Windows.Forms.TextBox();
            this.ReverseBox2 = new System.Windows.Forms.CheckBox();
            this.NumberOfRotationsBox = new System.Windows.Forms.NumericUpDown();
            this.NumberOfRotationsBox2 = new System.Windows.Forms.NumericUpDown();
            this.decodeButton = new System.Windows.Forms.Button();
            this.NumberOfRotationsBox3 = new System.Windows.Forms.NumericUpDown();
            this.ReverseBox3 = new System.Windows.Forms.CheckBox();
            this.CodeBox3 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfChambersNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfRotationsBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfRotationsBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfRotationsBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // InputBox
            // 
            this.InputBox.Location = new System.Drawing.Point(12, 12);
            this.InputBox.Multiline = true;
            this.InputBox.Name = "InputBox";
            this.InputBox.Size = new System.Drawing.Size(271, 85);
            this.InputBox.TabIndex = 0;
            this.InputBox.Text = "Input";
            // 
            // CodeBox
            // 
            this.CodeBox.Location = new System.Drawing.Point(12, 198);
            this.CodeBox.Name = "CodeBox";
            this.CodeBox.Size = new System.Drawing.Size(35, 20);
            this.CodeBox.TabIndex = 1;
            this.CodeBox.Text = "Code";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 103);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(271, 83);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Output";
            // 
            // EncodeButton
            // 
            this.EncodeButton.Location = new System.Drawing.Point(218, 198);
            this.EncodeButton.Name = "EncodeButton";
            this.EncodeButton.Size = new System.Drawing.Size(65, 27);
            this.EncodeButton.TabIndex = 3;
            this.EncodeButton.Text = "Encode";
            this.EncodeButton.UseVisualStyleBackColor = true;
            this.EncodeButton.Click += new System.EventHandler(this.EncodeButton_Click);
            // 
            // ReverseBox
            // 
            this.ReverseBox.AutoSize = true;
            this.ReverseBox.Location = new System.Drawing.Point(105, 201);
            this.ReverseBox.Name = "ReverseBox";
            this.ReverseBox.Size = new System.Drawing.Size(66, 17);
            this.ReverseBox.TabIndex = 9;
            this.ReverseBox.Text = "Reverse";
            this.ReverseBox.UseVisualStyleBackColor = true;
            // 
            // NumberOfChambersNumeric
            // 
            this.NumberOfChambersNumeric.Location = new System.Drawing.Point(177, 226);
            this.NumberOfChambersNumeric.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.NumberOfChambersNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumberOfChambersNumeric.Name = "NumberOfChambersNumeric";
            this.NumberOfChambersNumeric.Size = new System.Drawing.Size(35, 20);
            this.NumberOfChambersNumeric.TabIndex = 10;
            this.NumberOfChambersNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // CodeBox2
            // 
            this.CodeBox2.Location = new System.Drawing.Point(12, 224);
            this.CodeBox2.Name = "CodeBox2";
            this.CodeBox2.Size = new System.Drawing.Size(35, 20);
            this.CodeBox2.TabIndex = 11;
            this.CodeBox2.Text = "Code";
            // 
            // ReverseBox2
            // 
            this.ReverseBox2.AutoSize = true;
            this.ReverseBox2.Location = new System.Drawing.Point(105, 227);
            this.ReverseBox2.Name = "ReverseBox2";
            this.ReverseBox2.Size = new System.Drawing.Size(66, 17);
            this.ReverseBox2.TabIndex = 13;
            this.ReverseBox2.Text = "Reverse";
            this.ReverseBox2.UseVisualStyleBackColor = true;
            // 
            // NumberOfRotationsBox
            // 
            this.NumberOfRotationsBox.Location = new System.Drawing.Point(53, 198);
            this.NumberOfRotationsBox.Maximum = new decimal(new int[] {
            116,
            0,
            0,
            0});
            this.NumberOfRotationsBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumberOfRotationsBox.Name = "NumberOfRotationsBox";
            this.NumberOfRotationsBox.Size = new System.Drawing.Size(46, 20);
            this.NumberOfRotationsBox.TabIndex = 14;
            this.NumberOfRotationsBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NumberOfRotationsBox2
            // 
            this.NumberOfRotationsBox2.Location = new System.Drawing.Point(53, 223);
            this.NumberOfRotationsBox2.Maximum = new decimal(new int[] {
            116,
            0,
            0,
            0});
            this.NumberOfRotationsBox2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumberOfRotationsBox2.Name = "NumberOfRotationsBox2";
            this.NumberOfRotationsBox2.Size = new System.Drawing.Size(46, 20);
            this.NumberOfRotationsBox2.TabIndex = 15;
            this.NumberOfRotationsBox2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // decodeButton
            // 
            this.decodeButton.Location = new System.Drawing.Point(218, 244);
            this.decodeButton.Name = "decodeButton";
            this.decodeButton.Size = new System.Drawing.Size(65, 27);
            this.decodeButton.TabIndex = 18;
            this.decodeButton.Text = "Decode";
            this.decodeButton.UseVisualStyleBackColor = true;
            this.decodeButton.Click += new System.EventHandler(this.decodeButton_Click);
            // 
            // NumberOfRotationsBox3
            // 
            this.NumberOfRotationsBox3.Location = new System.Drawing.Point(53, 249);
            this.NumberOfRotationsBox3.Maximum = new decimal(new int[] {
            116,
            0,
            0,
            0});
            this.NumberOfRotationsBox3.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumberOfRotationsBox3.Name = "NumberOfRotationsBox3";
            this.NumberOfRotationsBox3.Size = new System.Drawing.Size(46, 20);
            this.NumberOfRotationsBox3.TabIndex = 21;
            this.NumberOfRotationsBox3.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ReverseBox3
            // 
            this.ReverseBox3.AutoSize = true;
            this.ReverseBox3.Location = new System.Drawing.Point(105, 253);
            this.ReverseBox3.Name = "ReverseBox3";
            this.ReverseBox3.Size = new System.Drawing.Size(66, 17);
            this.ReverseBox3.TabIndex = 20;
            this.ReverseBox3.Text = "Reverse";
            this.ReverseBox3.UseVisualStyleBackColor = true;
            // 
            // CodeBox3
            // 
            this.CodeBox3.Location = new System.Drawing.Point(12, 250);
            this.CodeBox3.Name = "CodeBox3";
            this.CodeBox3.Size = new System.Drawing.Size(35, 20);
            this.CodeBox3.TabIndex = 19;
            this.CodeBox3.Text = "Code";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 277);
            this.Controls.Add(this.InputBox);
            this.Controls.Add(this.NumberOfRotationsBox3);
            this.Controls.Add(this.CodeBox);
            this.Controls.Add(this.ReverseBox2);
            this.Controls.Add(this.ReverseBox3);
            this.Controls.Add(this.CodeBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.NumberOfRotationsBox);
            this.Controls.Add(this.CodeBox3);
            this.Controls.Add(this.NumberOfChambersNumeric);
            this.Controls.Add(this.EncodeButton);
            this.Controls.Add(this.NumberOfRotationsBox2);
            this.Controls.Add(this.decodeButton);
            this.Controls.Add(this.ReverseBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Coding Device by J.W.";
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfChambersNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfRotationsBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfRotationsBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfRotationsBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputBox;
        private System.Windows.Forms.TextBox CodeBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button EncodeButton;
        private System.Windows.Forms.CheckBox ReverseBox;
        private System.Windows.Forms.NumericUpDown NumberOfChambersNumeric;
        private System.Windows.Forms.TextBox CodeBox2;
        private System.Windows.Forms.CheckBox ReverseBox2;
        private System.Windows.Forms.NumericUpDown NumberOfRotationsBox;
        private System.Windows.Forms.NumericUpDown NumberOfRotationsBox2;
        private System.Windows.Forms.Button decodeButton;
        private System.Windows.Forms.NumericUpDown NumberOfRotationsBox3;
        private System.Windows.Forms.CheckBox ReverseBox3;
        private System.Windows.Forms.TextBox CodeBox3;
    }
}

