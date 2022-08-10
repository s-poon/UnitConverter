using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitLibrary {
    public class Time {
        // Members
        private double _seconds;

        // Properties
        public double Nanoseconds { get => Prefix.ToNano(_seconds); }
        public double Microseconds { get => Prefix.ToMicro(_seconds); }
        public double Milliseconds { get => Prefix.ToMilli(_seconds); }
        public double Seconds { get => _seconds; }
        public double Minutes { get => SecondsToMinute(_seconds); }
        public double Hours { get => SecondsToHour(_seconds); }
        public double Days { get => SecondsToDay(_seconds); }
        public double Years { get => SecondsYear(_seconds); }

        // Constructor
        /// <summary>
        /// Constructor for Time class
        /// </summary>
        /// <param name="input">Value of unit to be converted</param>
        /// <param name="unit">Unit of value to be converted</param>
        public Time(double input, TimeUnits unit) {
            switch (unit) {
                case TimeUnits.Nanoseconds:
                    _seconds = Prefix.NanoTo(input);
                    break;
                case TimeUnits.Microseconds:
                    _seconds = Prefix.MicroTo(input);
                    break;
                case TimeUnits.Milliseconds:
                    _seconds = Prefix.MilliTo(input);
                    break;
                case TimeUnits.Seconds:
                    _seconds = input;
                    break;
                case TimeUnits.Minutes:
                    _seconds = MinuteToSeconds(input);
                    break;
                case TimeUnits.Hours:
                    _seconds = HourToSeconds(input);
                    break;
                case TimeUnits.Days:
                    _seconds = DayToSeconds(input);
                    break;
                case TimeUnits.Years:
                    _seconds = YearToSeconds(input);
                    break;

            }
        }

        // Methods
        private double MinuteToSeconds(double minute) { return minute * 60; }
        private double HourToSeconds(double hour) { return MinuteToSeconds(hour * 60); }
        private double DayToSeconds(double day) { return HourToSeconds(day * 24); }
        private double YearToSeconds(double year) { return DayToSeconds(year * 365); }
        private double SecondsToMinute(double seconds){ return seconds / 60; }
        private double SecondsToHour(double seconds){ return SecondsToMinute(seconds) / 60; }
        private double SecondsToDay(double seconds){ return SecondsToHour(seconds) / 24; }
        private double SecondsYear(double seconds){ return SecondsToDay(seconds) / 365; }

        // Enum
        public enum TimeUnits {
            Nanoseconds,
            Microseconds,
            Milliseconds,
            Seconds,
            Minutes,
            Hours,
            Days,
            Years
        }
    }
}
