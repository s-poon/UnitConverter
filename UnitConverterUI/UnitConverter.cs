using BaseUnitLibrary;
using static BaseUnitLibrary.Temperature;

namespace UnitConverterUI {
    public partial class UnitConverter : Form {
        // Members
        private Temperature _temp;

        //Constructor
        public UnitConverter() {
            InitializeComponent();
            InitializeComboBox();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void tabTemperature_Click(object sender, EventArgs e) {

        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            ValidateTemp();
            this.textBoxCelsius.Text = _temp.Celsius.ToString("F2");
            this.textBoxFahrenheit.Text = _temp.Fahrenhiet.ToString("F2");
            this.textBoxKelvin.Text = _temp.Kelvin.ToString("F2");
        }

        private void InitializeComboBox() {
            this.comboBoxTemperatureUnit.DataSource = Enum.GetValues(typeof(TemperatureUnits));
        }
        private void ValidateTemp() {
            double input;
            string value = this.comboBoxTemperatureUnit.Text;
            TemperatureUnits unit;
            if(double.TryParse(textBoxTempInput.Text, out input) && Enum.TryParse(value, out unit)) {
                _temp = new(input, unit);
            }
        }

        private void label1_Click(object sender, EventArgs e) {

        }
    }
}