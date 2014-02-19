namespace CodeCompiler
{
    partial class Form1
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
            this.Input = new System.Windows.Forms.TextBox();
            this.CodeName = new System.Windows.Forms.ComboBox();
            this.EnteredCodes = new System.Windows.Forms.ListBox();
            this.Add = new System.Windows.Forms.Button();
            this.Compile = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.Brand = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Output = new System.Windows.Forms.TextBox();
            this.CodeType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Input
            // 
            this.Input.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Input.Location = new System.Drawing.Point(12, 40);
            this.Input.Multiline = true;
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(561, 121);
            this.Input.TabIndex = 0;
            // 
            // CodeName
            // 
            this.CodeName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CodeName.FormattingEnabled = true;
            this.CodeName.Location = new System.Drawing.Point(409, 12);
            this.CodeName.Name = "CodeName";
            this.CodeName.Size = new System.Drawing.Size(164, 21);
            this.CodeName.TabIndex = 1;
            // 
            // EnteredCodes
            // 
            this.EnteredCodes.FormattingEnabled = true;
            this.EnteredCodes.Location = new System.Drawing.Point(579, 40);
            this.EnteredCodes.Name = "EnteredCodes";
            this.EnteredCodes.Size = new System.Drawing.Size(165, 121);
            this.EnteredCodes.TabIndex = 2;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(579, 13);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(165, 23);
            this.Add.TabIndex = 3;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.button1_Click);
            // 
            // Compile
            // 
            this.Compile.Location = new System.Drawing.Point(13, 167);
            this.Compile.Name = "Compile";
            this.Compile.Size = new System.Drawing.Size(127, 23);
            this.Compile.TabIndex = 4;
            this.Compile.Text = "Compile";
            this.Compile.UseVisualStyleBackColor = true;
            this.Compile.Click += new System.EventHandler(this.button2_Click);
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(13, 196);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(127, 23);
            this.Reset.TabIndex = 5;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.button3_Click);
            // 
            // Brand
            // 
            this.Brand.Location = new System.Drawing.Point(51, 12);
            this.Brand.Name = "Brand";
            this.Brand.Size = new System.Drawing.Size(89, 20);
            this.Brand.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "brand";
            // 
            // Output
            // 
            this.Output.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Output.Location = new System.Drawing.Point(15, 225);
            this.Output.Multiline = true;
            this.Output.Name = "Output";
            this.Output.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Output.Size = new System.Drawing.Size(729, 282);
            this.Output.TabIndex = 10;
            // 
            // CodeType
            // 
            this.CodeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CodeType.FormattingEnabled = true;
            this.CodeType.Location = new System.Drawing.Point(282, 12);
            this.CodeType.Name = "CodeType";
            this.CodeType.Size = new System.Drawing.Size(121, 21);
            this.CodeType.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 519);
            this.Controls.Add(this.CodeType);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Brand);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.Compile);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.EnteredCodes);
            this.Controls.Add(this.CodeName);
            this.Controls.Add(this.Input);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Input;
        private System.Windows.Forms.ComboBox CodeName;
        private System.Windows.Forms.ListBox EnteredCodes;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Compile;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.TextBox Brand;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Output;
        private System.Windows.Forms.ComboBox CodeType;
    }
}

