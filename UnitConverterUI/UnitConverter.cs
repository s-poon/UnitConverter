using BaseUnitLibrary;
using static BaseUnitLibrary.Distance;
using static BaseUnitLibrary.Temperature;
using static BaseUnitLibrary.Time;

namespace UnitConverterUI {
    public partial class UnitConverter : Form {
        // Members
        private Temperature _temperature;
        private Time _time;
        private Distance _distance;

        //Constructor
        public UnitConverter() {
            InitializeComponent();
            InitializeComboBox();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void tabTemperature_Click(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            ValidateTemp();
            textBoxCelsius.Text = _temperature.Celsius.ToString("F2");
            textBoxFahrenheit.Text = _temperature.Fahrenhiet.ToString("F2");
            textBoxKelvin.Text = _temperature.Kelvin.ToString("F2");
        }

        private void InitializeComboBox() {
            comboBoxTemperatureUnit.DataSource = Enum.GetValues(typeof(TemperatureUnits));
            comboBoxTimeUnit.DataSource = Enum.GetValues(typeof(TimeUnits));
            comboBoxDistanceUnit.DataSource = Enum.GetValues(typeof(DistanceUnits));
        }
        private void ValidateTemp() {
            double input;
            string value = comboBoxTemperatureUnit.Text;
            TemperatureUnits unit;
            if(double.TryParse(textBoxTempInput.Text, out input) && Enum.TryParse(value, out unit)) {
                switch (unit) {
                    case TemperatureUnits.Celsius:
                        if (input < -273.15) {
                            MessageBox.Show(
                                "Temperature is below absolute zero",
                                "Invalid Temperature",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning
                            );
                        }
                        else {
                            _temperature = new(input, unit);
                        }
                        break;
                    case TemperatureUnits.Fahrenheit:
                        if (input < -459.67) {
                            MessageBox.Show(
                                "Temperature is below absolute zero",
                                "Invalid Temperature",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning
                            );
                        }
                        else { 
                            _temperature = new(input, unit);
                        }
                        break;
                    case TemperatureUnits.Kelvin:
                        if(input < 0) {
                            MessageBox.Show(
                                "Temperature is below absolute zero",
                                "Invalid Temperature",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning
                            );
                        }
                        else {
                            _temperature = new(input, unit);
                        }
                        break;
                }
            }
        }
        
        private void ValidateTime() {
            double input;
            string value = comboBoxTimeUnit.Text;
            TimeUnits unit;
            if(double.TryParse(textBoxTimeInput.Text, out input) && Enum.TryParse(value, out unit)) {
                if (input < 0) {
                    MessageBox.Show(
                        "Time cannot be negative",
                        "Invalid Time",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
                else {
                    _time = new(input, unit);
                }
            }
        }

        private void buttonConvertTime_Click(object sender, EventArgs e) {
            ValidateTime();
            textBoxNanoseconds.Text = _time.Nanoseconds.ToString("F2");
            textBoxMicro.Text = _time.Microseconds.ToString("F2");
            textBoxMilli.Text = _time.Milliseconds.ToString("F2");
            textBoxSeconds.Text = _time.Seconds.ToString("F2");
            textBoxMinutes.Text = _time.Minutes.ToString("F2");
            textBoxHours.Text = _time.Hours.ToString("F2");
            textBoxDays.Text = _time.Days.ToString("F2");
            textBoxYears.Text = _time.Years.ToString("F2");
        }

        private void ValidateDistance() {
            double input;
            double inputInch;
            string value = comboBoxDistanceUnit.Text;
            DistanceUnits unit;
            if (
                double.TryParse(textBoxDistanceInput.Text, out input) && 
                Enum.TryParse(value, out unit)
            ){
                if (input < 0) {
                    MessageBox.Show(
                        "Distance cannot be negative",
                        "Invalid Time",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
                else if(unit == DistanceUnits.Feet && double.TryParse(textBoxInchIn.Text, out inputInch)) {
                    inputInch += input * 12;
                    _distance = new(inputInch, DistanceUnits.Feet);
                }
                else {
                    _distance = new(input, unit);
                }
            }
        }

        private void buttonConvertDistance_Click(object sender, EventArgs e) {
            ValidateDistance();
            textBoxNanometer.Text = _distance.Nanometers.ToString("F2");
            textBoxMicrometer.Text = _distance.Micrometers.ToString("F2");
            textBoxMillimeter.Text = _distance.Millimeters.ToString("F2");
            textBoxCentimeter.Text = _distance.Centimeters.ToString("F2");
            textBoxMeter.Text = _distance.Meters.ToString("F2");
            textBoxKilometer.Text = _distance.Kilometers.ToString("F2");
            textBoxLightYear.Text = _distance.Lightyears.ToString("F2");
            textBoxMil.Text = _distance.Mils.ToString("F2");
            textBoxInch.Text = _distance.Inches.ToString("F2");
            textBoxFeet.Text = _distance.Feet.ToString("F2");
            textBoxYard.Text = _distance.Yards.ToString("F2");
            textBoxMile.Text = _distance.Miles.ToString("F2");
            textBoxNauticalMile.Text = _distance.NauticalMiles.ToString("F2");

            textBoxWholeFeet.Text = _distance.WholeFeet.ToString();
            textBoxFeetInch.Text = _distance.FootInch.ToString("F2");
        }

        private void comboBoxDistanceUnit_SelectedIndexChanged(object sender, EventArgs e) {
            if (comboBoxDistanceUnit.SelectedIndex == 9) {
                textBoxInchIn.Visible = true;
                labelInchIn.Visible = true;
                labelFeetIn.Visible = true;
            }
            else {
                textBoxInchIn.Visible = false;
                labelInchIn.Visible = false;
                labelFeetIn.Visible = false;

            }
        }
    }
}