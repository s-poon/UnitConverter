using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static UnitLibrary.Time;

namespace UnitLibrary {
    public class Speed {
        // Members
        private Time _time;
        private Distance _distance;

        // Properties
        public double KPH { get => _distance.Kilometers / _time.Hours; }
        public double MPS { get => _distance.Meters / _time.Seconds; }
        public double MPH { get => _distance.Miles / _time.Hours; }
        public double Knot { get => _distance.NauticalMiles / _time.Hours; }

        // Constructor
        public Speed(double input, SpeedUnits unit) {
            switch (unit) {
                case SpeedUnits.Kilometer_per_hour:
                    _distance = new(input, Distance.DistanceUnits.Kilometers);
                    _time = new(1, TimeUnits.Hours);
                    break;
                case SpeedUnits.Meter_per_second:
                    _distance = new(input, Distance.DistanceUnits.Meters);
                    _time = new(1, TimeUnits.Seconds);
                    break;
                case SpeedUnits.Mile_per_hour:
                    _distance = new(input, Distance.DistanceUnits.Miles);
                    _time = new(1, TimeUnits.Hours);
                    break;
                case SpeedUnits.Knot:
                    _distance = new(input, Distance.DistanceUnits.NauticalMiles);
                    _time = new(1, TimeUnits.Hours);
                    break;
                default:
                    break;
            }
        }
        // Methods

        //Enum
        public enum SpeedUnits {
            Kilometer_per_hour,
            Meter_per_second,
            Mile_per_hour,
            Knot
        }
    }
}
