using BaseUnitLibrary;

namespace UnitConverterUI {
    public partial class UnitConverter : Form {
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

        }

        private void ValidateTemp() {
            double input;
            Temperature temp;
            if(double.TryParse(textBoxTempInput.Text, out input)) {
                temp = new(input, Enum.Parse(Unit, comboBoxUnit.SelectedText));

            }
        }

    }
}