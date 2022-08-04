using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseUnitLibrary {
    public class Temperature {
        // Members
        private double _kelvin;
        private double _celsius;
        private double _fahrenhiet;

        // Properties
        public double Kelvin { get => _kelvin; }
        public double Celsius { get => _celsius; }
        public double Fahrenhiet { get => _fahrenhiet; }

        // Constructor
        public Temperature(double input, Unit unit) {
            switch (unit) {
                case Unit.Kelvin:
                    this._kelvin = input;
                    this._celsius = KelvinToCelsius(input);
                    this._fahrenhiet = KelvinToFahrenheit(input);
                    break;
                case Unit.Celsius:
                    this._kelvin = CelsiusToKelvin(input);
                    this._celsius = input;
                    this._fahrenhiet = CelsiusToKelvin(KelvinToFahrenheit(input));
                    break;
                case Unit.Fahrenheit:
                    this._kelvin = FahrenheitToKelvin(input);
                    this._celsius = FahrenheitToKelvin(KelvinToCelsius(input));
                    this._fahrenhiet = input;
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(unit));
            }
        }

        // Methods
        private double KelvinToCelsius(double kelvin) { return kelvin - 273.15; }
        private double KelvinToFahrenheit(double kelvin) { return 1.8 * (kelvin - 273) + 32; }
        private double CelsiusToKelvin(double celsius) { return celsius - 273.15; }
        private double FahrenheitToKelvin(double fahrenheit) { return 5 / 9 * (fahrenheit + 459.67);  }
        // Enum
        
    }
}
