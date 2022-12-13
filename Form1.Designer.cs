namespace CS311_FinalProject_JWH
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rdoMeters = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdoGrams = new System.Windows.Forms.RadioButton();
            this.rdoCelsius = new System.Windows.Forms.RadioButton();
            this.rdoKilometers = new System.Windows.Forms.RadioButton();
            this.rdoKilograms = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rdoOunces = new System.Windows.Forms.RadioButton();
            this.rdoFeet = new System.Windows.Forms.RadioButton();
            this.rdoFahrenheit = new System.Windows.Forms.RadioButton();
            this.rdoMiles = new System.Windows.Forms.RadioButton();
            this.rdoPounds = new System.Windows.Forms.RadioButton();
            this.picArrow = new System.Windows.Forms.PictureBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lblOutput = new System.Windows.Forms.Label();
            this.btnSwap = new System.Windows.Forms.Button();
            this.btnConvert = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picArrow)).BeginInit();
            this.SuspendLayout();
            // 
            // rdoMeters
            // 
            this.rdoMeters.AutoSize = true;
            this.rdoMeters.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdoMeters.Location = new System.Drawing.Point(24, 15);
            this.rdoMeters.Name = "rdoMeters";
            this.rdoMeters.Size = new System.Drawing.Size(111, 34);
            this.rdoMeters.TabIndex = 0;
            this.rdoMeters.TabStop = true;
            this.rdoMeters.Text = "Meters";
            this.rdoMeters.UseVisualStyleBackColor = true;
            this.rdoMeters.CheckedChanged += new System.EventHandler(this.rdoMeters_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdoGrams);
            this.panel1.Controls.Add(this.rdoMeters);
            this.panel1.Controls.Add(this.rdoCelsius);
            this.panel1.Controls.Add(this.rdoKilometers);
            this.panel1.Controls.Add(this.rdoKilograms);
            this.panel1.Location = new System.Drawing.Point(115, 219);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(221, 202);
            this.panel1.TabIndex = 1;
            // 
            // rdoGrams
            // 
            this.rdoGrams.AutoSize = true;
            this.rdoGrams.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdoGrams.Location = new System.Drawing.Point(24, 155);
            this.rdoGrams.Name = "rdoGrams";
            this.rdoGrams.Size = new System.Drawing.Size(105, 34);
            this.rdoGrams.TabIndex = 4;
            this.rdoGrams.TabStop = true;
            this.rdoGrams.Text = "Grams";
            this.rdoGrams.UseVisualStyleBackColor = true;
            this.rdoGrams.CheckedChanged += new System.EventHandler(this.rdoGrams_CheckedChanged);
            // 
            // rdoCelsius
            // 
            this.rdoCelsius.AutoSize = true;
            this.rdoCelsius.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdoCelsius.Location = new System.Drawing.Point(24, 85);
            this.rdoCelsius.Name = "rdoCelsius";
            this.rdoCelsius.Size = new System.Drawing.Size(109, 34);
            this.rdoCelsius.TabIndex = 2;
            this.rdoCelsius.TabStop = true;
            this.rdoCelsius.Text = "Celsius";
            this.rdoCelsius.UseVisualStyleBackColor = true;
            this.rdoCelsius.CheckedChanged += new System.EventHandler(this.rdoCelsius_CheckedChanged);
            // 
            // rdoKilometers
            // 
            this.rdoKilometers.AutoSize = true;
            this.rdoKilometers.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdoKilometers.Location = new System.Drawing.Point(24, 50);
            this.rdoKilometers.Name = "rdoKilometers";
            this.rdoKilometers.Size = new System.Drawing.Size(149, 34);
            this.rdoKilometers.TabIndex = 1;
            this.rdoKilometers.TabStop = true;
            this.rdoKilometers.Text = "Kilometers";
            this.rdoKilometers.UseVisualStyleBackColor = true;
            this.rdoKilometers.CheckedChanged += new System.EventHandler(this.rdoKilometers_CheckedChanged);
            // 
            // rdoKilograms
            // 
            this.rdoKilograms.AutoSize = true;
            this.rdoKilograms.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdoKilograms.Location = new System.Drawing.Point(24, 120);
            this.rdoKilograms.Name = "rdoKilograms";
            this.rdoKilograms.Size = new System.Drawing.Size(142, 34);
            this.rdoKilograms.TabIndex = 3;
            this.rdoKilograms.TabStop = true;
            this.rdoKilograms.Text = "Kilograms";
            this.rdoKilograms.UseVisualStyleBackColor = true;
            this.rdoKilograms.CheckedChanged += new System.EventHandler(this.rdoKilograms_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rdoOunces);
            this.panel2.Controls.Add(this.rdoFeet);
            this.panel2.Controls.Add(this.rdoFahrenheit);
            this.panel2.Controls.Add(this.rdoMiles);
            this.panel2.Controls.Add(this.rdoPounds);
            this.panel2.Location = new System.Drawing.Point(639, 219);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(293, 202);
            this.panel2.TabIndex = 2;
            // 
            // rdoOunces
            // 
            this.rdoOunces.AutoSize = true;
            this.rdoOunces.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdoOunces.Location = new System.Drawing.Point(24, 155);
            this.rdoOunces.Name = "rdoOunces";
            this.rdoOunces.Size = new System.Drawing.Size(114, 34);
            this.rdoOunces.TabIndex = 4;
            this.rdoOunces.TabStop = true;
            this.rdoOunces.Text = "Ounces";
            this.rdoOunces.UseVisualStyleBackColor = true;
            this.rdoOunces.CheckedChanged += new System.EventHandler(this.rdoOunces_CheckedChanged);
            // 
            // rdoFeet
            // 
            this.rdoFeet.AutoSize = true;
            this.rdoFeet.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdoFeet.Location = new System.Drawing.Point(24, 15);
            this.rdoFeet.Name = "rdoFeet";
            this.rdoFeet.Size = new System.Drawing.Size(82, 34);
            this.rdoFeet.TabIndex = 0;
            this.rdoFeet.TabStop = true;
            this.rdoFeet.Text = "Feet";
            this.rdoFeet.UseVisualStyleBackColor = true;
            this.rdoFeet.CheckedChanged += new System.EventHandler(this.rdoFeet_CheckedChanged);
            // 
            // rdoFahrenheit
            // 
            this.rdoFahrenheit.AutoSize = true;
            this.rdoFahrenheit.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdoFahrenheit.Location = new System.Drawing.Point(24, 85);
            this.rdoFahrenheit.Name = "rdoFahrenheit";
            this.rdoFahrenheit.Size = new System.Drawing.Size(147, 34);
            this.rdoFahrenheit.TabIndex = 2;
            this.rdoFahrenheit.TabStop = true;
            this.rdoFahrenheit.Text = "Fahrenheit";
            this.rdoFahrenheit.UseVisualStyleBackColor = true;
            this.rdoFahrenheit.CheckedChanged += new System.EventHandler(this.rdoFahrenheit_CheckedChanged);
            // 
            // rdoMiles
            // 
            this.rdoMiles.AutoSize = true;
            this.rdoMiles.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdoMiles.Location = new System.Drawing.Point(24, 50);
            this.rdoMiles.Name = "rdoMiles";
            this.rdoMiles.Size = new System.Drawing.Size(93, 34);
            this.rdoMiles.TabIndex = 1;
            this.rdoMiles.TabStop = true;
            this.rdoMiles.Text = "Miles";
            this.rdoMiles.UseVisualStyleBackColor = true;
            this.rdoMiles.CheckedChanged += new System.EventHandler(this.rdoMiles_CheckedChanged);
            // 
            // rdoPounds
            // 
            this.rdoPounds.AutoSize = true;
            this.rdoPounds.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdoPounds.Location = new System.Drawing.Point(24, 120);
            this.rdoPounds.Name = "rdoPounds";
            this.rdoPounds.Size = new System.Drawing.Size(114, 34);
            this.rdoPounds.TabIndex = 3;
            this.rdoPounds.TabStop = true;
            this.rdoPounds.Text = "Pounds";
            this.rdoPounds.UseVisualStyleBackColor = true;
            this.rdoPounds.CheckedChanged += new System.EventHandler(this.rdoPounds_CheckedChanged);
            // 
            // picArrow
            // 
            this.picArrow.Image = global::CS311_FinalProject_JWH.Properties.Resources.rightarrow;
            this.picArrow.Location = new System.Drawing.Point(369, 234);
            this.picArrow.Name = "picArrow";
            this.picArrow.Size = new System.Drawing.Size(226, 186);
            this.picArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picArrow.TabIndex = 3;
            this.picArrow.TabStop = false;
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtInput.Location = new System.Drawing.Point(115, 81);
            this.txtInput.Name = "txtInput";
            this.txtInput.PlaceholderText = "Enter Unit Amount";
            this.txtInput.Size = new System.Drawing.Size(293, 45);
            this.txtInput.TabIndex = 4;
            this.txtInput.Tag = "";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOutput.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblOutput.Location = new System.Drawing.Point(641, 89);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(0, 48);
            this.lblOutput.TabIndex = 5;
            // 
            // btnSwap
            // 
            this.btnSwap.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSwap.Location = new System.Drawing.Point(412, 451);
            this.btnSwap.Name = "btnSwap";
            this.btnSwap.Size = new System.Drawing.Size(155, 50);
            this.btnSwap.TabIndex = 6;
            this.btnSwap.Text = "Swap";
            this.btnSwap.UseVisualStyleBackColor = true;
            this.btnSwap.Click += new System.EventHandler(this.btnSwap_Click);
            // 
            // btnConvert
            // 
            this.btnConvert.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConvert.Location = new System.Drawing.Point(744, 492);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(188, 100);
            this.btnConvert.TabIndex = 7;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1088, 703);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.btnSwap);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.picArrow);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Unit Converter";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picArrow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RadioButton rdoMeters;
        private Panel panel1;
        private RadioButton rdoKilometers;
        private RadioButton rdoGrams;
        private RadioButton rdoCelsius;
        private RadioButton rdoKilograms;
        private Panel panel2;
        private RadioButton rdoOunces;
        private RadioButton rdoFeet;
        private RadioButton rdoFahrenheit;
        private RadioButton rdoMiles;
        private RadioButton rdoPounds;
        private PictureBox picArrow;
        private TextBox txtInput;
        private Label lblOutput;
        private Button btnSwap;
        private Button btnConvert;
    }
}