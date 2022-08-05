
using static BaseUnitLibrary.Temperature;

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
            this.comboBoxTemperatureUnit = new System.Windows.Forms.ComboBox();
            this.buttonTempConvert = new System.Windows.Forms.Button();
            this.labelKelvin = new System.Windows.Forms.Label();
            this.labelFahrenheit = new System.Windows.Forms.Label();
            this.labelCelsius = new System.Windows.Forms.Label();
            this.labelTempValue = new System.Windows.Forms.Label();
            this.labelTempUnit = new System.Windows.Forms.Label();
            this.tabTime = new System.Windows.Forms.TabPage();
            this.labelTimeUnit = new System.Windows.Forms.Label();
            this.comboBoxTimeUnit = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBoxTimeInput = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelTimeValue = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabTemperature.SuspendLayout();
            this.tabTime.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabTemperature);
            this.tabControl.Controls.Add(this.tabTime);
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
            this.tabTemperature.Controls.Add(this.comboBoxTemperatureUnit);
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
            this.textBoxCelsius.Location = new System.Drawing.Point(639, 37);
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
            // comboBoxTemperatureUnit
            // 
            this.comboBoxTemperatureUnit.FormattingEnabled = true;
            this.comboBoxTemperatureUnit.Location = new System.Drawing.Point(20, 38);
            this.comboBoxTemperatureUnit.Name = "comboBoxTemperatureUnit";
            this.comboBoxTemperatureUnit.Size = new System.Drawing.Size(151, 28);
            this.comboBoxTemperatureUnit.TabIndex = 6;
            this.comboBoxTemperatureUnit.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // buttonTempConvert
            // 
            this.buttonTempConvert.Location = new System.Drawing.Point(441, 37);
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
            this.labelCelsius.Location = new System.Drawing.Point(639, 15);
            this.labelCelsius.Name = "labelCelsius";
            this.labelCelsius.Size = new System.Drawing.Size(54, 20);
            this.labelCelsius.TabIndex = 2;
            this.labelCelsius.Text = "Celsius";
            // 
            // labelTempValue
            // 
            this.labelTempValue.AutoSize = true;
            this.labelTempValue.Location = new System.Drawing.Point(250, 15);
            this.labelTempValue.Name = "labelTempValue";
            this.labelTempValue.Size = new System.Drawing.Size(45, 20);
            this.labelTempValue.TabIndex = 1;
            this.labelTempValue.Text = "Value";
            // 
            // labelTempUnit
            // 
            this.labelTempUnit.AutoSize = true;
            this.labelTempUnit.Location = new System.Drawing.Point(20, 15);
            this.labelTempUnit.Name = "labelTempUnit";
            this.labelTempUnit.Size = new System.Drawing.Size(36, 20);
            this.labelTempUnit.TabIndex = 0;
            this.labelTempUnit.Text = "Unit";
            // 
            // tabTime
            // 
            this.tabTime.Controls.Add(this.textBox8);
            this.tabTime.Controls.Add(this.textBox9);
            this.tabTime.Controls.Add(this.label8);
            this.tabTime.Controls.Add(this.label9);
            this.tabTime.Controls.Add(this.textBox5);
            this.tabTime.Controls.Add(this.textBox6);
            this.tabTime.Controls.Add(this.textBox7);
            this.tabTime.Controls.Add(this.label5);
            this.tabTime.Controls.Add(this.label6);
            this.tabTime.Controls.Add(this.label7);
            this.tabTime.Controls.Add(this.textBox1);
            this.tabTime.Controls.Add(this.textBox2);
            this.tabTime.Controls.Add(this.textBox3);
            this.tabTime.Controls.Add(this.textBoxTimeInput);
            this.tabTime.Controls.Add(this.button1);
            this.tabTime.Controls.Add(this.label1);
            this.tabTime.Controls.Add(this.label2);
            this.tabTime.Controls.Add(this.label3);
            this.tabTime.Controls.Add(this.labelTimeValue);
            this.tabTime.Controls.Add(this.comboBoxTimeUnit);
            this.tabTime.Controls.Add(this.labelTimeUnit);
            this.tabTime.Location = new System.Drawing.Point(4, 29);
            this.tabTime.Name = "tabTime";
            this.tabTime.Padding = new System.Windows.Forms.Padding(3);
            this.tabTime.Size = new System.Drawing.Size(1488, 800);
            this.tabTime.TabIndex = 1;
            this.tabTime.Text = "Time";
            this.tabTime.UseVisualStyleBackColor = true;
            // 
            // labelTimeUnit
            // 
            this.labelTimeUnit.AutoSize = true;
            this.labelTimeUnit.Location = new System.Drawing.Point(20, 15);
            this.labelTimeUnit.Name = "labelTimeUnit";
            this.labelTimeUnit.Size = new System.Drawing.Size(36, 20);
            this.labelTimeUnit.TabIndex = 0;
            this.labelTimeUnit.Text = "Unit";
            this.labelTimeUnit.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBoxTimeUnit
            // 
            this.comboBoxTimeUnit.FormattingEnabled = true;
            this.comboBoxTimeUnit.Location = new System.Drawing.Point(20, 38);
            this.comboBoxTimeUnit.Name = "comboBoxTimeUnit";
            this.comboBoxTimeUnit.Size = new System.Drawing.Size(151, 28);
            this.comboBoxTimeUnit.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(626, 182);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 27);
            this.textBox1.TabIndex = 19;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(626, 108);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(125, 27);
            this.textBox2.TabIndex = 18;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(626, 37);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(125, 27);
            this.textBox3.TabIndex = 17;
            // 
            // textBoxTimeInput
            // 
            this.textBoxTimeInput.Location = new System.Drawing.Point(237, 39);
            this.textBoxTimeInput.Name = "textBoxTimeInput";
            this.textBoxTimeInput.Size = new System.Drawing.Size(125, 27);
            this.textBoxTimeInput.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(428, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 15;
            this.button1.Text = "Convert";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(626, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Kelvin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(626, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Fahrenheit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(626, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Celsius";
            // 
            // labelTimeValue
            // 
            this.labelTimeValue.AutoSize = true;
            this.labelTimeValue.Location = new System.Drawing.Point(237, 15);
            this.labelTimeValue.Name = "labelTimeValue";
            this.labelTimeValue.Size = new System.Drawing.Size(45, 20);
            this.labelTimeValue.TabIndex = 11;
            this.labelTimeValue.Text = "Value";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(626, 399);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(125, 27);
            this.textBox5.TabIndex = 25;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(626, 325);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(125, 27);
            this.textBox6.TabIndex = 24;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(626, 254);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(125, 27);
            this.textBox7.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(626, 376);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Kelvin";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(626, 302);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 20);
            this.label6.TabIndex = 21;
            this.label6.Text = "Fahrenheit";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(626, 232);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "Celsius";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(626, 547);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(125, 27);
            this.textBox8.TabIndex = 29;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(626, 473);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(125, 27);
            this.textBox9.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(626, 524);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 20);
            this.label8.TabIndex = 27;
            this.label8.Text = "Kelvin";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(626, 450);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 20);
            this.label9.TabIndex = 26;
            this.label9.Text = "Fahrenheit";
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
            this.tabTime.ResumeLayout(false);
            this.tabTime.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl;
        private TabPage tabTemperature;
        private TabPage tabTime;
        private TextBox textBoxKelvin;
        private TextBox textBoxFahrenheit;
        private TextBox textBoxCelsius;
        private TextBox textBoxTempInput;
        private ComboBox comboBoxTemperatureUnit;
        private Button buttonTempConvert;
        private Label labelKelvin;
        private Label labelFahrenheit;
        private Label labelCelsius;
        private Label labelTempValue;
        private Label labelTempUnit;
        private Label labelTimeUnit;
        private TextBox textBox8;
        private TextBox textBox9;
        private Label label8;
        private Label label9;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBoxTimeInput;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label labelTimeValue;
        private ComboBox comboBoxTimeUnit;
    }
}