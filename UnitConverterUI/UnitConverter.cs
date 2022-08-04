using BaseUnitLibrary;

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
            this.textBoxCelsius.Text = Double.ToString(_temp.Celsius);
        }

        private void ValidateTemp() {
            double input;
            
            Unit unit;
            if(double.TryParse(textBoxTempInput.Text, out input)  && Enum.TryParse<Unit>(comboBoxUnit.SelectedText, out unit)) {
                _temp = new(input, unit);
            }
        }

    }
}