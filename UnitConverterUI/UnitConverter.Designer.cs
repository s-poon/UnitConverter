
using BaseUnitLibrary;

namespace UnitConverterUI {
    partial class UnitConverter {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabTemperature = new System.Windows.Forms.TabPage();
            this.textBoxKelvin = new System.Windows.Forms.TextBox();
            this.textBoxFahrenheit = new System.Windows.Forms.TextBox();
            this.textBoxCelsius = new System.Windows.Forms.TextBox();
            this.textBoxTempInput = new System.Windows.Forms.TextBox();
            this.comboBoxUnit = new System.Windows.Forms.ComboBox();
            this.buttonTempConvert = new System.Windows.Forms.Button();
            this.labelKelvin = new System.Windows.Forms.Label();
            this.labelFahrenheit = new System.Windows.Forms.Label();
            this.labelCelsius = new System.Windows.Forms.Label();
            this.labelTempValue = new System.Windows.Forms.Label();
            this.labelTempUnit = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl.SuspendLayout();
            this.tabTemperature.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabTemperature);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1496, 833);
            this.tabControl.TabIndex = 0;
            // 
            // tabTemperature
            // 
            this.tabTemperature.Controls.Add(this.textBoxKelvin);
            this.tabTemperature.Controls.Add(this.textBoxFahrenheit);
            this.tabTemperature.Controls.Add(this.textBoxCelsius);
            this.tabTemperature.Controls.Add(this.textBoxTempInput);
            this.tabTemperature.Controls.Add(this.comboBoxUnit);
            this.tabTemperature.Controls.Add(this.buttonTempConvert);
            this.tabTemperature.Controls.Add(this.labelKelvin);
            this.tabTemperature.Controls.Add(this.labelFahrenheit);
            this.tabTemperature.Controls.Add(this.labelCelsius);
            this.tabTemperature.Controls.Add(this.labelTempValue);
            this.tabTemperature.Controls.Add(this.labelTempUnit);
            this.tabTemperature.Location = new System.Drawing.Point(4, 29);
            this.tabTemperature.Name = "tabTemperature";
            this.tabTemperature.Padding = new System.Windows.Forms.Padding(3);
            this.tabTemperature.Size = new System.Drawing.Size(1488, 800);
            this.tabTemperature.TabIndex = 0;
            this.tabTemperature.Text = "Temperature";
            this.tabTemperature.UseVisualStyleBackColor = true;
            this.tabTemperature.Click += new System.EventHandler(this.tabTemperature_Click);
            // 
            // textBoxKelvin
            // 
            this.textBoxKelvin.Location = new System.Drawing.Point(639, 182);
            this.textBoxKelvin.Name = "textBoxKelvin";
            this.textBoxKelvin.Size = new System.Drawing.Size(125, 27);
            this.textBoxKelvin.TabIndex = 10;
            // 
            // textBoxFahrenheit
            // 
            this.textBoxFahrenheit.Location = new System.Drawing.Point(639, 108);
            this.textBoxFahrenheit.Name = "textBoxFahrenheit";
            this.textBoxFahrenheit.Size = new System.Drawing.Size(125, 27);
            this.textBoxFahrenheit.TabIndex = 9;
            // 
            // textBoxCelsius
            // 
            this.textBoxCelsius.Location = new System.Drawing.Point(639, 38);
            this.textBoxCelsius.Name = "textBoxCelsius";
            this.textBoxCelsius.Size = new System.Drawing.Size(125, 27);
            this.textBoxCelsius.TabIndex = 8;
            // 
            // textBoxTempInput
            // 
            this.textBoxTempInput.Location = new System.Drawing.Point(250, 39);
            this.textBoxTempInput.Name = "textBoxTempInput";
            this.textBoxTempInput.Size = new System.Drawing.Size(125, 27);
            this.textBoxTempInput.TabIndex = 7;
            this.textBoxTempInput.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // comboBoxUnit
            // 
            this.comboBoxUnit.FormattingEnabled = true;
            this.comboBoxUnit.Location = new System.Drawing.Point(19, 38);
            this.comboBoxUnit.Name = "comboBoxUnit";
            this.comboBoxUnit.Size = new System.Drawing.Size(151, 28);
            this.comboBoxUnit.TabIndex = 6;
            this.comboBoxUnit.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // buttonTempConvert
            // 
            this.buttonTempConvert.Location = new System.Drawing.Point(433, 37);
            this.buttonTempConvert.Name = "buttonTempConvert";
            this.buttonTempConvert.Size = new System.Drawing.Size(94, 29);
            this.buttonTempConvert.TabIndex = 5;
            this.buttonTempConvert.Text = "Convert";
            this.buttonTempConvert.UseVisualStyleBackColor = true;
            this.buttonTempConvert.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelKelvin
            // 
            this.labelKelvin.AutoSize = true;
            this.labelKelvin.Location = new System.Drawing.Point(639, 159);
            this.labelKelvin.Name = "labelKelvin";
            this.labelKelvin.Size = new System.Drawing.Size(49, 20);
            this.labelKelvin.TabIndex = 4;
            this.labelKelvin.Text = "Kelvin";
            // 
            // labelFahrenheit
            // 
            this.labelFahrenheit.AutoSize = true;
            this.labelFahrenheit.Location = new System.Drawing.Point(639, 85);
            this.labelFahrenheit.Name = "labelFahrenheit";
            this.labelFahrenheit.Size = new System.Drawing.Size(77, 20);
            this.labelFahrenheit.TabIndex = 3;
            this.labelFahrenheit.Text = "Fahrenheit";
            // 
            // labelCelsius
            // 
            this.labelCelsius.AutoSize = true;
            this.labelCelsius.Location = new System.Drawing.Point(639, 17);
            this.labelCelsius.Name = "labelCelsius";
            this.labelCelsius.Size = new System.Drawing.Size(54, 20);
            this.labelCelsius.TabIndex = 2;
            this.labelCelsius.Text = "Celsius";
            // 
            // labelTempValue
            // 
            this.labelTempValue.AutoSize = true;
            this.labelTempValue.Location = new System.Drawing.Point(250, 16);
            this.labelTempValue.Name = "labelTempValue";
            this.labelTempValue.Size = new System.Drawing.Size(45, 20);
            this.labelTempValue.TabIndex = 1;
            this.labelTempValue.Text = "Value";
            // 
            // labelTempUnit
            // 
            this.labelTempUnit.AutoSize = true;
            this.labelTempUnit.Location = new System.Drawing.Point(19, 16);
            this.labelTempUnit.Name = "labelTempUnit";
            this.labelTempUnit.Size = new System.Drawing.Size(36, 20);
            this.labelTempUnit.TabIndex = 0;
            this.labelTempUnit.Text = "Unit";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1488, 800);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // UnitConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1511, 1006);
            this.Controls.Add(this.tabControl);
            this.Name = "UnitConverter";
            this.Text = "Unit Converter";
            this.tabControl.ResumeLayout(false);
            this.tabTemperature.ResumeLayout(false);
            this.tabTemperature.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion


        private void InitializeComboBox() {
            this.comboBoxUnit.DataSource = Enum.GetValues(typeof(Unit));
        }

        private TabControl tabControl;
        private TabPage tabTemperature;
        private TabPage tabPage2;
        private TextBox textBoxKelvin;
        private TextBox textBoxFahrenheit;
        private TextBox textBoxCelsius;
        private TextBox textBoxTempInput;
        private ComboBox comboBoxUnit;
        private Button buttonTempConvert;
        private Label labelKelvin;
        private Label labelFahrenheit;
        private Label labelCelsius;
        private Label labelTempValue;
        private Label labelTempUnit;
    }
}