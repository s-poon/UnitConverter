using UnitLibrary;
using static UnitLibrary.Distance;
using static UnitLibrary.Mass;
using static UnitLibrary.Speed;
using static UnitLibrary.Temperature;
using static UnitLibrary.Time;

namespace UnitConverterUI {
    public partial class UnitConverter : Form {
        // Members
        private Temperature _temperature;
        private Time _time;
        private Distance _distance;
        private Mass _mass;
        private Speed _speed;

        //Constructor
        public UnitConverter() {
            InitializeComponent();
            InitializeComboBox();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void tabTemperature_Click(object sender, EventArgs e) {

        }     

        private void InitializeComboBox() {
            comboBoxTemperatureUnit.DataSource = Enum.GetValues(typeof(TemperatureUnits));
            comboBoxTimeUnit.DataSource = Enum.GetValues(typeof(TimeUnits));
            comboBoxDistanceUnit.DataSource = Enum.GetValues(typeof(DistanceUnits));
            comboBoxMassUnit.DataSource = Enum.GetValues(typeof(MassUnits));
            comboBoxSpeedUnit.DataSource = Enum.GetValues(typeof(SpeedUnits));
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

        private bool ValidateMass() {
            double input;
            double inputOunce;
            string value = comboBoxMassUnit.Text;
            MassUnits unit;
            if (double.TryParse(textBoxMassInput.Text, out input) && Enum.TryParse(value, out unit)) {
                if(input < 0) {
                    MessageBox.Show(
                        "Distance cannot be negative",
                        "Invalid Time",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
                else if(unit == MassUnits.Pound && double.TryParse(textBoxOunceIn.Text, out inputOunce)) {
                    inputOunce += input * 16;
                    _mass = new(inputOunce, MassUnits.Ounce);
                    return true;
                }
                else {
                    _mass = new(input, unit);
                    return true;
                }
            }
            return false;
        }

        private bool ValidateDistance() {
            double input;
            double inputInch;
            string value = comboBoxDistanceUnit.Text;
            DistanceUnits unit;
            if (double.TryParse(textBoxDistanceInput.Text, out input) && Enum.TryParse(value, out unit)){
                if(unit == DistanceUnits.Feet && double.TryParse(textBoxInchIn.Text, out inputInch)) {
                    inputInch += input * 12;
                    _distance = new(inputInch, DistanceUnits.Inches);
                    return true;
                }
                else {
                    _distance = new(input, unit);
                    return true;
                }
            }
            return false;
        }

        private bool ValidateSpeed() {
            double input;
            string value = comboBoxSpeedUnit.Text;
            SpeedUnits unit;
            if (double.TryParse(textBoxSpeedInput.Text, out input) && Enum.TryParse(value, out unit)) {
                _speed = new(input, unit);
                return true;
            }
            return false;
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
        private void buttonConvertDistance_Click(object sender, EventArgs e) {
            if (ValidateDistance()) {
                textBoxNanometer.Text = _distance.Nanometers.ToString("F2");
                textBoxMicrometer.Text = _distance.Micrometers.ToString("F2");
                textBoxMillimeter.Text = _distance.Millimeters.ToString("F2");
                textBoxCentimeter.Text = _distance.Centimeters.ToString("F2");
                textBoxMeter.Text = _distance.Meters.ToString("F6");
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
        }
        private void buttonConvertMass_Click(object sender, EventArgs e) {
            if (ValidateMass()) {
                textBoxMilligram.Text = _mass.Milligram.ToString("F2");
                textBoxGram.Text = _mass.Gram.ToString("F2");
                textBoxKilogram.Text = _mass.Kilogram.ToString("F2");
                textBoxTonne.Text = _mass.Tonne.ToString("F2");
                textBoxOunce.Text = _mass.Ounce.ToString("F2");
                textBoxPound.Text = _mass.Pound.ToString("F2");
                textBoxStone.Text = _mass.Stone.ToString("F2");
                textBoxUSTon.Text = _mass.USTon.ToString("F2");
                textBoxUKTon.Text = _mass.UKTon.ToString("F2");
            }
        }

        private void buttonTempConvert_Click(object sender, EventArgs e) {
            ValidateTemp();
            textBoxCelsius.Text = _temperature.Celsius.ToString("F2");
            textBoxFahrenheit.Text = _temperature.Fahrenhiet.ToString("F2");
            textBoxKelvin.Text = _temperature.Kelvin.ToString("F2");
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

        

        private void comboBoxMassUnit_SelectedIndexChanged(object sender, EventArgs e) {
            if (comboBoxMassUnit.SelectedIndex == 5) {
                textBoxOunceIn.Visible = true;
                labelPoundIn.Visible = true;
                labelOunceIn.Visible = true;
            }
            else {
                textBoxOunceIn.Visible = false;
                labelPoundIn.Visible = false;
                labelOunceIn.Visible = false;
            }
        }

        private void buttonConvertSpeed_Click(object sender, EventArgs e) {
            if (ValidateSpeed()) {
                textBoxKPH.Text = _speed.KPH.ToString("F2");
                textBoxMPS.Text = _speed.MPS.ToString("F2");
                textBoxMPH.Text = _speed.MPH.ToString("F2");
                textBoxKnot.Text = _speed.Knot.ToString("F2");
            }

        }
    }
}