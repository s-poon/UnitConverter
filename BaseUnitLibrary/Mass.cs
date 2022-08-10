using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static UnitLibrary.Prefix;

namespace UnitLibrary {
    public class Mass {
        // Members
        private double _kilograms;

        // Properties
        public double Milligram { get => ToMicro(_kilograms); }
        public double Gram { get => ToMilli(_kilograms); }
        public double Kilogram { get => _kilograms; }
        public double Tonne { get => ToKilo(_kilograms); }
        public double Ounce { get => KilogramsToOunce(_kilograms); }
        public double Pound { get => KilogramsToPound(_kilograms); }
        public double Stone { get => KilogramsToStone(_kilograms); }
        public double USTon { get => KilogramsToUSTon(_kilograms); }
        public double UKTon { get => KilogramsToUKTon(_kilograms); }

        // Constructor
        public Mass(double input, MassUnits unit) {
            switch (unit) {
                case MassUnits.Milligram:
                    _kilograms = MicroTo(input);
                    break;
                case MassUnits.Gram:
                    _kilograms = MilliTo(input);
                    break;
                case MassUnits.Kilogram:
                    _kilograms = input;
                    break;
                case MassUnits.Tonne:
                    _kilograms = KiloTo(input);
                    break;
                case MassUnits.Ounce:
                    _kilograms = OunceToKilograms(input);
                    break;
                case MassUnits.Pound:
                    _kilograms = PoundToKilograms(input);
                    break;
                case MassUnits.Stone:
                    _kilograms = StoneToKilograms(input);
                    break;
                case MassUnits.USTon:
                    _kilograms = USTonToKilograms(input);
                    break;
                case MassUnits.UKTon:
                    _kilograms = UKTonToKilograms(input);
                    break;
                default:
                    break;
            }
        }

        // Methods
        private double OunceToKilograms(double ounce) { return ounce / 356.274; }
        private double PoundToKilograms(double pound) { return pound / 2.205; }
        private double StoneToKilograms(double stone) { return stone * 6.35; }
        private double USTonToKilograms(double ton) { return ton * 907.185; }
        private double UKTonToKilograms(double ton) { return ton * 1016.05; }
        private double KilogramsToOunce(double kilogram) { return kilogram * 356.274; }
        private double KilogramsToPound(double kilogram) { return kilogram * 2.205; }
        private double KilogramsToStone(double kilogram) { return kilogram / 6.35; }
        private double KilogramsToUSTon(double kilogram) { return kilogram / 907.185; }
        private double KilogramsToUKTon(double kilogram) { return kilogram / 1016.05; }

        // Enum
        public enum MassUnits {
            Milligram,
            Gram,
            Kilogram,
            Tonne,
            Ounce,
            Pound,
            Stone,
            USTon,
            UKTon
        }
    }
}
