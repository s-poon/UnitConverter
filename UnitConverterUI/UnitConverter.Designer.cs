
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
            this.textBoxMinutes = new System.Windows.Forms.TextBox();
            this.textBoxYears = new System.Windows.Forms.TextBox();
            this.labelMinutes = new System.Windows.Forms.Label();
            this.labelYears = new System.Windows.Forms.Label();
            this.textBoxDays = new System.Windows.Forms.TextBox();
            this.textBoxHours = new System.Windows.Forms.TextBox();
            this.textBoxSeconds = new System.Windows.Forms.TextBox();
            this.labelDays = new System.Windows.Forms.Label();
            this.labelHours = new System.Windows.Forms.Label();
            this.labelSeconds = new System.Windows.Forms.Label();
            this.textBoxMilli = new System.Windows.Forms.TextBox();
            this.textBoxMicro = new System.Windows.Forms.TextBox();
            this.textBoxNanoseconds = new System.Windows.Forms.TextBox();
            this.textBoxTimeInput = new System.Windows.Forms.TextBox();
            this.buttonConvertTime = new System.Windows.Forms.Button();
            this.labelMilliseconds = new System.Windows.Forms.Label();
            this.labelMicroseconds = new System.Windows.Forms.Label();
            this.labelNano = new System.Windows.Forms.Label();
            this.labelTimeValue = new System.Windows.Forms.Label();
            this.comboBoxTimeUnit = new System.Windows.Forms.ComboBox();
            this.labelTimeUnit = new System.Windows.Forms.Label();
            this.tabDistance = new System.Windows.Forms.TabPage();
            this.textBoxFeet = new System.Windows.Forms.TextBox();
            this.labelFeet = new System.Windows.Forms.Label();
            this.textBoxFeetInch = new System.Windows.Forms.TextBox();
            this.labelFeetInch = new System.Windows.Forms.Label();
            this.textBoxMile = new System.Windows.Forms.TextBox();
            this.labelMiles = new System.Windows.Forms.Label();
            this.textBoxNauticalMile = new System.Windows.Forms.TextBox();
            this.textBoxYard = new System.Windows.Forms.TextBox();
            this.labelNauticalMile = new System.Windows.Forms.Label();
            this.labelYard = new System.Windows.Forms.Label();
            this.textBoxWholeFeet = new System.Windows.Forms.TextBox();
            this.textBoxInch = new System.Windows.Forms.TextBox();
            this.textBoxMil = new System.Windows.Forms.TextBox();
            this.labelWholeFeet = new System.Windows.Forms.Label();
            this.labelInch = new System.Windows.Forms.Label();
            this.labelMil = new System.Windows.Forms.Label();
            this.labelInchIn = new System.Windows.Forms.Label();
            this.labelFeetIn = new System.Windows.Forms.Label();
            this.textBoxInchIn = new System.Windows.Forms.TextBox();
            this.textBoxMeter = new System.Windows.Forms.TextBox();
            this.labelMeter = new System.Windows.Forms.Label();
            this.textBoxLightYear = new System.Windows.Forms.TextBox();
            this.textBoxKilometer = new System.Windows.Forms.TextBox();
            this.textBoxCentimeter = new System.Windows.Forms.TextBox();
            this.labelLightYear = new System.Windows.Forms.Label();
            this.labelKilometer = new System.Windows.Forms.Label();
            this.labelCentimeter = new System.Windows.Forms.Label();
            this.textBoxMillimeter = new System.Windows.Forms.TextBox();
            this.textBoxMicrometer = new System.Windows.Forms.TextBox();
            this.textBoxNanometer = new System.Windows.Forms.TextBox();
            this.textBoxDistanceInput = new System.Windows.Forms.TextBox();
            this.buttonConvertDistance = new System.Windows.Forms.Button();
            this.labelMillisecond = new System.Windows.Forms.Label();
            this.labelMicrometer = new System.Windows.Forms.Label();
            this.labelNanometer = new System.Windows.Forms.Label();
            this.labelDistanceInput = new System.Windows.Forms.Label();
            this.comboBoxDistanceUnit = new System.Windows.Forms.ComboBox();
            this.labelDistanceUnit = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabTemperature.SuspendLayout();
            this.tabTime.SuspendLayout();
            this.tabDistance.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabTemperature);
            this.tabControl.Controls.Add(this.tabTime);
            this.tabControl.Controls.Add(this.tabDistance);
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
            this.tabTime.Controls.Add(this.textBoxMinutes);
            this.tabTime.Controls.Add(this.textBoxYears);
            this.tabTime.Controls.Add(this.labelMinutes);
            this.tabTime.Controls.Add(this.labelYears);
            this.tabTime.Controls.Add(this.textBoxDays);
            this.tabTime.Controls.Add(this.textBoxHours);
            this.tabTime.Controls.Add(this.textBoxSeconds);
            this.tabTime.Controls.Add(this.labelDays);
            this.tabTime.Controls.Add(this.labelHours);
            this.tabTime.Controls.Add(this.labelSeconds);
            this.tabTime.Controls.Add(this.textBoxMilli);
            this.tabTime.Controls.Add(this.textBoxMicro);
            this.tabTime.Controls.Add(this.textBoxNanoseconds);
            this.tabTime.Controls.Add(this.textBoxTimeInput);
            this.tabTime.Controls.Add(this.buttonConvertTime);
            this.tabTime.Controls.Add(this.labelMilliseconds);
            this.tabTime.Controls.Add(this.labelMicroseconds);
            this.tabTime.Controls.Add(this.labelNano);
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
            // textBoxMinutes
            // 
            this.textBoxMinutes.Location = new System.Drawing.Point(626, 331);
            this.textBoxMinutes.Name = "textBoxMinutes";
            this.textBoxMinutes.Size = new System.Drawing.Size(125, 27);
            this.textBoxMinutes.TabIndex = 29;
            // 
            // textBoxYears
            // 
            this.textBoxYears.Location = new System.Drawing.Point(626, 557);
            this.textBoxYears.Name = "textBoxYears";
            this.textBoxYears.Size = new System.Drawing.Size(125, 27);
            this.textBoxYears.TabIndex = 28;
            // 
            // labelMinutes
            // 
            this.labelMinutes.AutoSize = true;
            this.labelMinutes.Location = new System.Drawing.Point(626, 308);
            this.labelMinutes.Name = "labelMinutes";
            this.labelMinutes.Size = new System.Drawing.Size(61, 20);
            this.labelMinutes.TabIndex = 27;
            this.labelMinutes.Text = "Minutes";
            // 
            // labelYears
            // 
            this.labelYears.AutoSize = true;
            this.labelYears.Location = new System.Drawing.Point(626, 534);
            this.labelYears.Name = "labelYears";
            this.labelYears.Size = new System.Drawing.Size(43, 20);
            this.labelYears.TabIndex = 26;
            this.labelYears.Text = "Years";
            // 
            // textBoxDays
            // 
            this.textBoxDays.Location = new System.Drawing.Point(626, 483);
            this.textBoxDays.Name = "textBoxDays";
            this.textBoxDays.Size = new System.Drawing.Size(125, 27);
            this.textBoxDays.TabIndex = 25;
            // 
            // textBoxHours
            // 
            this.textBoxHours.Location = new System.Drawing.Point(626, 409);
            this.textBoxHours.Name = "textBoxHours";
            this.textBoxHours.Size = new System.Drawing.Size(125, 27);
            this.textBoxHours.TabIndex = 24;
            // 
            // textBoxSeconds
            // 
            this.textBoxSeconds.Location = new System.Drawing.Point(626, 254);
            this.textBoxSeconds.Name = "textBoxSeconds";
            this.textBoxSeconds.Size = new System.Drawing.Size(125, 27);
            this.textBoxSeconds.TabIndex = 23;
            // 
            // labelDays
            // 
            this.labelDays.AutoSize = true;
            this.labelDays.Location = new System.Drawing.Point(626, 460);
            this.labelDays.Name = "labelDays";
            this.labelDays.Size = new System.Drawing.Size(41, 20);
            this.labelDays.TabIndex = 22;
            this.labelDays.Text = "Days";
            // 
            // labelHours
            // 
            this.labelHours.AutoSize = true;
            this.labelHours.Location = new System.Drawing.Point(626, 386);
            this.labelHours.Name = "labelHours";
            this.labelHours.Size = new System.Drawing.Size(48, 20);
            this.labelHours.TabIndex = 21;
            this.labelHours.Text = "Hours";
            // 
            // labelSeconds
            // 
            this.labelSeconds.AutoSize = true;
            this.labelSeconds.Location = new System.Drawing.Point(626, 232);
            this.labelSeconds.Name = "labelSeconds";
            this.labelSeconds.Size = new System.Drawing.Size(64, 20);
            this.labelSeconds.TabIndex = 20;
            this.labelSeconds.Text = "Seconds";
            // 
            // textBoxMilli
            // 
            this.textBoxMilli.Location = new System.Drawing.Point(626, 182);
            this.textBoxMilli.Name = "textBoxMilli";
            this.textBoxMilli.Size = new System.Drawing.Size(125, 27);
            this.textBoxMilli.TabIndex = 19;
            // 
            // textBoxMicro
            // 
            this.textBoxMicro.Location = new System.Drawing.Point(626, 108);
            this.textBoxMicro.Name = "textBoxMicro";
            this.textBoxMicro.Size = new System.Drawing.Size(125, 27);
            this.textBoxMicro.TabIndex = 18;
            // 
            // textBoxNanoseconds
            // 
            this.textBoxNanoseconds.Location = new System.Drawing.Point(626, 37);
            this.textBoxNanoseconds.Name = "textBoxNanoseconds";
            this.textBoxNanoseconds.Size = new System.Drawing.Size(125, 27);
            this.textBoxNanoseconds.TabIndex = 17;
            // 
            // textBoxTimeInput
            // 
            this.textBoxTimeInput.Location = new System.Drawing.Point(237, 39);
            this.textBoxTimeInput.Name = "textBoxTimeInput";
            this.textBoxTimeInput.Size = new System.Drawing.Size(125, 27);
            this.textBoxTimeInput.TabIndex = 16;
            // 
            // buttonConvertTime
            // 
            this.buttonConvertTime.Location = new System.Drawing.Point(428, 37);
            this.buttonConvertTime.Name = "buttonConvertTime";
            this.buttonConvertTime.Size = new System.Drawing.Size(94, 29);
            this.buttonConvertTime.TabIndex = 15;
            this.buttonConvertTime.Text = "Convert";
            this.buttonConvertTime.UseVisualStyleBackColor = true;
            this.buttonConvertTime.Click += new System.EventHandler(this.buttonConvertTime_Click);
            // 
            // labelMilliseconds
            // 
            this.labelMilliseconds.AutoSize = true;
            this.labelMilliseconds.Location = new System.Drawing.Point(626, 159);
            this.labelMilliseconds.Name = "labelMilliseconds";
            this.labelMilliseconds.Size = new System.Drawing.Size(91, 20);
            this.labelMilliseconds.TabIndex = 14;
            this.labelMilliseconds.Text = "Milliseconds";
            // 
            // labelMicroseconds
            // 
            this.labelMicroseconds.AutoSize = true;
            this.labelMicroseconds.Location = new System.Drawing.Point(626, 85);
            this.labelMicroseconds.Name = "labelMicroseconds";
            this.labelMicroseconds.Size = new System.Drawing.Size(100, 20);
            this.labelMicroseconds.TabIndex = 13;
            this.labelMicroseconds.Text = "Microseconds";
            // 
            // labelNano
            // 
            this.labelNano.AutoSize = true;
            this.labelNano.Location = new System.Drawing.Point(626, 15);
            this.labelNano.Name = "labelNano";
            this.labelNano.Size = new System.Drawing.Size(98, 20);
            this.labelNano.TabIndex = 12;
            this.labelNano.Text = "Nanoseconds";
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
            // comboBoxTimeUnit
            // 
            this.comboBoxTimeUnit.FormattingEnabled = true;
            this.comboBoxTimeUnit.Location = new System.Drawing.Point(20, 38);
            this.comboBoxTimeUnit.Name = "comboBoxTimeUnit";
            this.comboBoxTimeUnit.Size = new System.Drawing.Size(151, 28);
            this.comboBoxTimeUnit.TabIndex = 7;
            // 
            // labelTimeUnit
            // 
            this.labelTimeUnit.AutoSize = true;
            this.labelTimeUnit.Location = new System.Drawing.Point(20, 15);
            this.labelTimeUnit.Name = "labelTimeUnit";
            this.labelTimeUnit.Size = new System.Drawing.Size(36, 20);
            this.labelTimeUnit.TabIndex = 0;
            this.labelTimeUnit.Text = "Unit";
            // 
            // tabDistance
            // 
            this.tabDistance.Controls.Add(this.textBoxFeet);
            this.tabDistance.Controls.Add(this.labelFeet);
            this.tabDistance.Controls.Add(this.textBoxFeetInch);
            this.tabDistance.Controls.Add(this.labelFeetInch);
            this.tabDistance.Controls.Add(this.textBoxMile);
            this.tabDistance.Controls.Add(this.labelMiles);
            this.tabDistance.Controls.Add(this.textBoxNauticalMile);
            this.tabDistance.Controls.Add(this.textBoxYard);
            this.tabDistance.Controls.Add(this.labelNauticalMile);
            this.tabDistance.Controls.Add(this.labelYard);
            this.tabDistance.Controls.Add(this.textBoxWholeFeet);
            this.tabDistance.Controls.Add(this.textBoxInch);
            this.tabDistance.Controls.Add(this.textBoxMil);
            this.tabDistance.Controls.Add(this.labelWholeFeet);
            this.tabDistance.Controls.Add(this.labelInch);
            this.tabDistance.Controls.Add(this.labelMil);
            this.tabDistance.Controls.Add(this.labelInchIn);
            this.tabDistance.Controls.Add(this.labelFeetIn);
            this.tabDistance.Controls.Add(this.textBoxInchIn);
            this.tabDistance.Controls.Add(this.textBoxMeter);
            this.tabDistance.Controls.Add(this.labelMeter);
            this.tabDistance.Controls.Add(this.textBoxLightYear);
            this.tabDistance.Controls.Add(this.textBoxKilometer);
            this.tabDistance.Controls.Add(this.textBoxCentimeter);
            this.tabDistance.Controls.Add(this.labelLightYear);
            this.tabDistance.Controls.Add(this.labelKilometer);
            this.tabDistance.Controls.Add(this.labelCentimeter);
            this.tabDistance.Controls.Add(this.textBoxMillimeter);
            this.tabDistance.Controls.Add(this.textBoxMicrometer);
            this.tabDistance.Controls.Add(this.textBoxNanometer);
            this.tabDistance.Controls.Add(this.textBoxDistanceInput);
            this.tabDistance.Controls.Add(this.buttonConvertDistance);
            this.tabDistance.Controls.Add(this.labelMillisecond);
            this.tabDistance.Controls.Add(this.labelMicrometer);
            this.tabDistance.Controls.Add(this.labelNanometer);
            this.tabDistance.Controls.Add(this.labelDistanceInput);
            this.tabDistance.Controls.Add(this.comboBoxDistanceUnit);
            this.tabDistance.Controls.Add(this.labelDistanceUnit);
            this.tabDistance.Location = new System.Drawing.Point(4, 29);
            this.tabDistance.Name = "tabDistance";
            this.tabDistance.Padding = new System.Windows.Forms.Padding(3);
            this.tabDistance.Size = new System.Drawing.Size(1488, 800);
            this.tabDistance.TabIndex = 2;
            this.tabDistance.Text = "Distance";
            this.tabDistance.UseVisualStyleBackColor = true;
            // 
            // textBoxFeet
            // 
            this.textBoxFeet.Location = new System.Drawing.Point(886, 256);
            this.textBoxFeet.Name = "textBoxFeet";
            this.textBoxFeet.Size = new System.Drawing.Size(125, 27);
            this.textBoxFeet.TabIndex = 69;
            // 
            // labelFeet
            // 
            this.labelFeet.AutoSize = true;
            this.labelFeet.Location = new System.Drawing.Point(886, 233);
            this.labelFeet.Name = "labelFeet";
            this.labelFeet.Size = new System.Drawing.Size(37, 20);
            this.labelFeet.TabIndex = 68;
            this.labelFeet.Text = "Feet";
            // 
            // textBoxFeetInch
            // 
            this.textBoxFeetInch.Location = new System.Drawing.Point(1017, 184);
            this.textBoxFeetInch.Name = "textBoxFeetInch";
            this.textBoxFeetInch.Size = new System.Drawing.Size(125, 27);
            this.textBoxFeetInch.TabIndex = 67;
            // 
            // labelFeetInch
            // 
            this.labelFeetInch.AutoSize = true;
            this.labelFeetInch.Location = new System.Drawing.Point(1017, 161);
            this.labelFeetInch.Name = "labelFeetInch";
            this.labelFeetInch.Size = new System.Drawing.Size(50, 20);
            this.labelFeetInch.TabIndex = 66;
            this.labelFeetInch.Text = "Inches";
            // 
            // textBoxMile
            // 
            this.textBoxMile.Location = new System.Drawing.Point(886, 407);
            this.textBoxMile.Name = "textBoxMile";
            this.textBoxMile.Size = new System.Drawing.Size(125, 27);
            this.textBoxMile.TabIndex = 65;
            // 
            // labelMiles
            // 
            this.labelMiles.AutoSize = true;
            this.labelMiles.Location = new System.Drawing.Point(886, 384);
            this.labelMiles.Name = "labelMiles";
            this.labelMiles.Size = new System.Drawing.Size(44, 20);
            this.labelMiles.TabIndex = 64;
            this.labelMiles.Text = "Miles";
            // 
            // textBoxNauticalMile
            // 
            this.textBoxNauticalMile.Location = new System.Drawing.Point(886, 485);
            this.textBoxNauticalMile.Name = "textBoxNauticalMile";
            this.textBoxNauticalMile.Size = new System.Drawing.Size(125, 27);
            this.textBoxNauticalMile.TabIndex = 63;
            // 
            // textBoxYard
            // 
            this.textBoxYard.Location = new System.Drawing.Point(886, 330);
            this.textBoxYard.Name = "textBoxYard";
            this.textBoxYard.Size = new System.Drawing.Size(125, 27);
            this.textBoxYard.TabIndex = 62;
            // 
            // labelNauticalMile
            // 
            this.labelNauticalMile.AutoSize = true;
            this.labelNauticalMile.Location = new System.Drawing.Point(886, 462);
            this.labelNauticalMile.Name = "labelNauticalMile";
            this.labelNauticalMile.Size = new System.Drawing.Size(103, 20);
            this.labelNauticalMile.TabIndex = 61;
            this.labelNauticalMile.Text = "Nautical Miles";
            // 
            // labelYard
            // 
            this.labelYard.AutoSize = true;
            this.labelYard.Location = new System.Drawing.Point(886, 308);
            this.labelYard.Name = "labelYard";
            this.labelYard.Size = new System.Drawing.Size(44, 20);
            this.labelYard.TabIndex = 60;
            this.labelYard.Text = "Yards";
            // 
            // textBoxWholeFeet
            // 
            this.textBoxWholeFeet.Location = new System.Drawing.Point(886, 184);
            this.textBoxWholeFeet.Name = "textBoxWholeFeet";
            this.textBoxWholeFeet.Size = new System.Drawing.Size(125, 27);
            this.textBoxWholeFeet.TabIndex = 59;
            // 
            // textBoxInch
            // 
            this.textBoxInch.Location = new System.Drawing.Point(886, 110);
            this.textBoxInch.Name = "textBoxInch";
            this.textBoxInch.Size = new System.Drawing.Size(125, 27);
            this.textBoxInch.TabIndex = 58;
            // 
            // textBoxMil
            // 
            this.textBoxMil.Location = new System.Drawing.Point(886, 39);
            this.textBoxMil.Name = "textBoxMil";
            this.textBoxMil.Size = new System.Drawing.Size(125, 27);
            this.textBoxMil.TabIndex = 57;
            // 
            // labelWholeFeet
            // 
            this.labelWholeFeet.AutoSize = true;
            this.labelWholeFeet.Location = new System.Drawing.Point(886, 161);
            this.labelWholeFeet.Name = "labelWholeFeet";
            this.labelWholeFeet.Size = new System.Drawing.Size(37, 20);
            this.labelWholeFeet.TabIndex = 56;
            this.labelWholeFeet.Text = "Feet";
            // 
            // labelInch
            // 
            this.labelInch.AutoSize = true;
            this.labelInch.Location = new System.Drawing.Point(886, 87);
            this.labelInch.Name = "labelInch";
            this.labelInch.Size = new System.Drawing.Size(50, 20);
            this.labelInch.TabIndex = 55;
            this.labelInch.Text = "Inches";
            // 
            // labelMil
            // 
            this.labelMil.AutoSize = true;
            this.labelMil.Location = new System.Drawing.Point(886, 17);
            this.labelMil.Name = "labelMil";
            this.labelMil.Size = new System.Drawing.Size(30, 20);
            this.labelMil.TabIndex = 54;
            this.labelMil.Text = "Mil";
            // 
            // labelInchIn
            // 
            this.labelInchIn.AutoSize = true;
            this.labelInchIn.Location = new System.Drawing.Point(339, 69);
            this.labelInchIn.Name = "labelInchIn";
            this.labelInchIn.Size = new System.Drawing.Size(50, 20);
            this.labelInchIn.TabIndex = 53;
            this.labelInchIn.Text = "Inches";
            // 
            // labelFeetIn
            // 
            this.labelFeetIn.AutoSize = true;
            this.labelFeetIn.Location = new System.Drawing.Point(208, 69);
            this.labelFeetIn.Name = "labelFeetIn";
            this.labelFeetIn.Size = new System.Drawing.Size(37, 20);
            this.labelFeetIn.TabIndex = 52;
            this.labelFeetIn.Text = "Feet";
            // 
            // textBoxInchIn
            // 
            this.textBoxInchIn.Location = new System.Drawing.Point(339, 39);
            this.textBoxInchIn.Name = "textBoxInchIn";
            this.textBoxInchIn.Size = new System.Drawing.Size(125, 27);
            this.textBoxInchIn.TabIndex = 51;
            // 
            // textBoxMeter
            // 
            this.textBoxMeter.Location = new System.Drawing.Point(656, 333);
            this.textBoxMeter.Name = "textBoxMeter";
            this.textBoxMeter.Size = new System.Drawing.Size(125, 27);
            this.textBoxMeter.TabIndex = 50;
            // 
            // labelMeter
            // 
            this.labelMeter.AutoSize = true;
            this.labelMeter.Location = new System.Drawing.Point(656, 310);
            this.labelMeter.Name = "labelMeter";
            this.labelMeter.Size = new System.Drawing.Size(54, 20);
            this.labelMeter.TabIndex = 48;
            this.labelMeter.Text = "Meters";
            // 
            // textBoxLightYear
            // 
            this.textBoxLightYear.Location = new System.Drawing.Point(656, 485);
            this.textBoxLightYear.Name = "textBoxLightYear";
            this.textBoxLightYear.Size = new System.Drawing.Size(125, 27);
            this.textBoxLightYear.TabIndex = 46;
            // 
            // textBoxKilometer
            // 
            this.textBoxKilometer.Location = new System.Drawing.Point(656, 411);
            this.textBoxKilometer.Name = "textBoxKilometer";
            this.textBoxKilometer.Size = new System.Drawing.Size(125, 27);
            this.textBoxKilometer.TabIndex = 45;
            // 
            // textBoxCentimeter
            // 
            this.textBoxCentimeter.Location = new System.Drawing.Point(656, 256);
            this.textBoxCentimeter.Name = "textBoxCentimeter";
            this.textBoxCentimeter.Size = new System.Drawing.Size(125, 27);
            this.textBoxCentimeter.TabIndex = 44;
            // 
            // labelLightYear
            // 
            this.labelLightYear.AutoSize = true;
            this.labelLightYear.Location = new System.Drawing.Point(656, 462);
            this.labelLightYear.Name = "labelLightYear";
            this.labelLightYear.Size = new System.Drawing.Size(80, 20);
            this.labelLightYear.TabIndex = 43;
            this.labelLightYear.Text = "Light Years";
            // 
            // labelKilometer
            // 
            this.labelKilometer.AutoSize = true;
            this.labelKilometer.Location = new System.Drawing.Point(656, 388);
            this.labelKilometer.Name = "labelKilometer";
            this.labelKilometer.Size = new System.Drawing.Size(80, 20);
            this.labelKilometer.TabIndex = 42;
            this.labelKilometer.Text = "Kilometers";
            // 
            // labelCentimeter
            // 
            this.labelCentimeter.AutoSize = true;
            this.labelCentimeter.Location = new System.Drawing.Point(656, 234);
            this.labelCentimeter.Name = "labelCentimeter";
            this.labelCentimeter.Size = new System.Drawing.Size(88, 20);
            this.labelCentimeter.TabIndex = 41;
            this.labelCentimeter.Text = "Centimeters";
            // 
            // textBoxMillimeter
            // 
            this.textBoxMillimeter.Location = new System.Drawing.Point(656, 184);
            this.textBoxMillimeter.Name = "textBoxMillimeter";
            this.textBoxMillimeter.Size = new System.Drawing.Size(125, 27);
            this.textBoxMillimeter.TabIndex = 40;
            // 
            // textBoxMicrometer
            // 
            this.textBoxMicrometer.Location = new System.Drawing.Point(656, 110);
            this.textBoxMicrometer.Name = "textBoxMicrometer";
            this.textBoxMicrometer.Size = new System.Drawing.Size(125, 27);
            this.textBoxMicrometer.TabIndex = 39;
            // 
            // textBoxNanometer
            // 
            this.textBoxNanometer.Location = new System.Drawing.Point(656, 39);
            this.textBoxNanometer.Name = "textBoxNanometer";
            this.textBoxNanometer.Size = new System.Drawing.Size(125, 27);
            this.textBoxNanometer.TabIndex = 38;
            // 
            // textBoxDistanceInput
            // 
            this.textBoxDistanceInput.Location = new System.Drawing.Point(208, 39);
            this.textBoxDistanceInput.Name = "textBoxDistanceInput";
            this.textBoxDistanceInput.Size = new System.Drawing.Size(125, 27);
            this.textBoxDistanceInput.TabIndex = 37;
            // 
            // buttonConvertDistance
            // 
            this.buttonConvertDistance.Location = new System.Drawing.Point(530, 36);
            this.buttonConvertDistance.Name = "buttonConvertDistance";
            this.buttonConvertDistance.Size = new System.Drawing.Size(94, 29);
            this.buttonConvertDistance.TabIndex = 36;
            this.buttonConvertDistance.Text = "Convert";
            this.buttonConvertDistance.UseVisualStyleBackColor = true;
            this.buttonConvertDistance.Click += new System.EventHandler(this.buttonConvertDistance_Click);
            // 
            // labelMillisecond
            // 
            this.labelMillisecond.AutoSize = true;
            this.labelMillisecond.Location = new System.Drawing.Point(656, 161);
            this.labelMillisecond.Name = "labelMillisecond";
            this.labelMillisecond.Size = new System.Drawing.Size(83, 20);
            this.labelMillisecond.TabIndex = 35;
            this.labelMillisecond.Text = "Millimeters";
            // 
            // labelMicrometer
            // 
            this.labelMicrometer.AutoSize = true;
            this.labelMicrometer.Location = new System.Drawing.Point(656, 87);
            this.labelMicrometer.Name = "labelMicrometer";
            this.labelMicrometer.Size = new System.Drawing.Size(92, 20);
            this.labelMicrometer.TabIndex = 34;
            this.labelMicrometer.Text = "Micrometers";
            // 
            // labelNanometer
            // 
            this.labelNanometer.AutoSize = true;
            this.labelNanometer.Location = new System.Drawing.Point(656, 17);
            this.labelNanometer.Name = "labelNanometer";
            this.labelNanometer.Size = new System.Drawing.Size(90, 20);
            this.labelNanometer.TabIndex = 33;
            this.labelNanometer.Text = "Nanometers";
            // 
            // labelDistanceInput
            // 
            this.labelDistanceInput.AutoSize = true;
            this.labelDistanceInput.Location = new System.Drawing.Point(208, 15);
            this.labelDistanceInput.Name = "labelDistanceInput";
            this.labelDistanceInput.Size = new System.Drawing.Size(45, 20);
            this.labelDistanceInput.TabIndex = 32;
            this.labelDistanceInput.Text = "Value";
            // 
            // comboBoxDistanceUnit
            // 
            this.comboBoxDistanceUnit.FormattingEnabled = true;
            this.comboBoxDistanceUnit.Location = new System.Drawing.Point(22, 38);
            this.comboBoxDistanceUnit.Name = "comboBoxDistanceUnit";
            this.comboBoxDistanceUnit.Size = new System.Drawing.Size(151, 28);
            this.comboBoxDistanceUnit.TabIndex = 31;
            this.comboBoxDistanceUnit.SelectedIndexChanged += new System.EventHandler(this.comboBoxDistanceUnit_SelectedIndexChanged);
            // 
            // labelDistanceUnit
            // 
            this.labelDistanceUnit.AutoSize = true;
            this.labelDistanceUnit.Location = new System.Drawing.Point(22, 15);
            this.labelDistanceUnit.Name = "labelDistanceUnit";
            this.labelDistanceUnit.Size = new System.Drawing.Size(36, 20);
            this.labelDistanceUnit.TabIndex = 30;
            this.labelDistanceUnit.Text = "Unit";
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
            this.tabDistance.ResumeLayout(false);
            this.tabDistance.PerformLayout();
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
        private TextBox textBoxMinutes;
        private TextBox textBoxYears;
        private Label labelMinutes;
        private Label labelYears;
        private TextBox textBoxDays;
        private TextBox textBoxHours;
        private TextBox textBoxSeconds;
        private Label labelDays;
        private Label labelHours;
        private Label labelSeconds;
        private TextBox textBoxMilli;
        private TextBox textBoxMicro;
        private TextBox textBoxNanoseconds;
        private TextBox textBoxTimeInput;
        private Button buttonConvertTime;
        private Label labelMilliseconds;
        private Label labelMicroseconds;
        private Label labelNano;
        private Label labelTimeValue;
        private ComboBox comboBoxTimeUnit;
        private TabPage tabDistance;
        private TextBox textBoxInchIn;
        private TextBox textBoxMeter;
        private Label labelMeter;
        private TextBox textBoxLightYear;
        private TextBox textBoxKilometer;
        private TextBox textBoxCentimeter;
        private Label labelLightYear;
        private Label labelKilometer;
        private Label labelCentimeter;
        private TextBox textBoxMillimeter;
        private TextBox textBoxMicrometer;
        private TextBox textBoxNanometer;
        private TextBox textBoxDistanceInput;
        private Button buttonConvertDistance;
        private Label labelMillisecond;
        private Label labelMicrometer;
        private Label labelNanometer;
        private Label labelDistanceInput;
        private ComboBox comboBoxDistanceUnit;
        private Label labelDistanceUnit;
        private Label labelInchIn;
        private Label labelFeetIn;
        private TextBox textBoxFeetInch;
        private Label labelFeetInch;
        private TextBox textBoxMile;
        private Label labelMiles;
        private TextBox textBoxNauticalMile;
        private TextBox textBoxYard;
        private Label labelNauticalMile;
        private Label labelYard;
        private TextBox textBoxWholeFeet;
        private TextBox textBoxInch;
        private TextBox textBoxMil;
        private Label labelWholeFeet;
        private Label labelInch;
        private Label labelMil;
        private TextBox textBoxFeet;
        private Label labelFeet;
    }
}