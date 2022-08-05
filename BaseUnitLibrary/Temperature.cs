using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseUnitLibrary {
    public class Temperature {
        // Members
        private double _kelvin;

        // Properties
        public double Kelvin { get => _kelvin; }
        public double Celsius { get => KelvinToCelsius(_kelvin); }
        public double Fahrenhiet { get => KelvinToFahrenheit(_kelvin); }

        // Constructor
        public Temperature(double input, TemperatureUnits unit) {
            switch (unit) {
                case TemperatureUnits.Kelvin:
                    this._kelvin = input;
                    break;
                case TemperatureUnits.Celsius:
                    this._kelvin = CelsiusToKelvin(input);
                    break;
                case TemperatureUnits.Fahrenheit:
                    this._kelvin = FahrenheitToKelvin(input);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(unit));
            }
        }

        // Methods
        private double KelvinToCelsius(double kelvin) { return kelvin - 273.15; }
        private double KelvinToFahrenheit(double kelvin) { return 1.8 * (kelvin - 273.15) + 32; }
        private double CelsiusToKelvin(double celsius) { return celsius + 273.15; }
        private double FahrenheitToKelvin(double fahrenheit) { return (fahrenheit + 459.67) * 5 / 9; }

        // Enum
        public enum TemperatureUnits {
            Celsius,
            Kelvin,
            Fahrenheit
        }
    }
}
