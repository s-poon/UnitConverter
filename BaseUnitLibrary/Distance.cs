using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseUnitLibrary {
    public class Distance {
        // Members
        private double _meters;
        private double _inches;

        // Properties
        public double Nanometers { get => Prefix.ToNano(_meters); }
        public double Micrometers { get => Prefix.ToMicro(_meters); }
        public double Millimeters { get => Prefix.ToMilli(_meters); }
        public double Centimeters { get => Prefix.ToCenti(_meters); }
        public double Meters { get => _meters; }
        public double Kilometers { get => Prefix.ToKilo(_meters); }
        public double Lightyears { get => _meters / 9460730472580800; }
        public double Mils { get; }
        public double Inches { get => 1; }
        public double Feet { get => 1; }
        public int WholeFeet { get => 1; }
        public double Yards { get => 1; }
        public int WholeYards { get => 1; }
        public double Miles { get => 1; }
        public double NauticalMiles { get => 1; }


        //Constructor
        public Distance(double input, DistanceUnits unit) {
            switch (unit) {
                case DistanceUnits.Nanometers:
                    _meters = Prefix.NanoTo(input);
                    break;
                case DistanceUnits.Micrometers:
                    _meters = Prefix.MicroTo(input);
                    break;
                case DistanceUnits.Millimeters:
                    _meters = Prefix.MilliTo(input);
                    break;
                case DistanceUnits.Centimeters:
                    _meters = Prefix.CentiTo(input);
                    break;
                case DistanceUnits.Meters:
                    _meters = input;
                    break;
                case DistanceUnits.Kilometers:
                    _meters = Prefix.ToKilo(input);
                    break;
                case DistanceUnits.LightYear:
                    _meters = LightYearToMeters(input);
                    break;
                case DistanceUnits.Thou:
                    _meters = ThouToMeters(input);
                    _inches = input / 1000;
                    break;
                case DistanceUnits.Inches:
                    _meters = InchToMeters(input);
                    _inches = input;
                    break;
                case DistanceUnits.Feet:
                    _meters = FeetToMeters(input);
                    _inches = input * 12;
                    break;
                case DistanceUnits.Yard:
                    _meters = YardToMeters(input);
                    _inches = input * 36;
                    break;
                case DistanceUnits.Mile:
                    _meters = MileToMeters(input);
                    _inches = input * 63360;
                    break;
                case DistanceUnits.NauticalMile:
                    _meters = NauticalToMeters(input);
                    _inches = input * 72913.4 ;
                    break;
                default:
                    break;
            }
        }

        // Methods
        private double LightYearToMeters(double lightYear) { return lightYear * 9460730472580800; }
        private double ThouToMeters(double thou) { return thou / 39370.078740157; }
        private double InchToMeters(double inch) { return inch / 39.37; }
        private double FeetToMeters(double feet) { return feet / 3.281; }
        private double YardToMeters(double yard) { return  yard / 1.094; }
        private double MileToMeters(double mile) { return mile * 1609.34; }
        private double NauticalToMeters(double nautical) { return nautical * 1852; }
        private double MetersToInch(double meter) { return meter * 39.37; }

        // Enum
        public enum DistanceUnits {
            Nanometers,
            Micrometers,
            Millimeters,
            Centimeters,
            Meters,
            Kilometers,
            LightYear,
            Thou,
            Inches,
            Feet,
            Yard,
            Mile,
            NauticalMile
        }
    }
}
