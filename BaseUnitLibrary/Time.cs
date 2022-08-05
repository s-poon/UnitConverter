using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseUnitLibrary {
    public class Time {
        // Members
        private double _seconds;

        // Properties
        public double NanoSeconds { get => SecondsToNano(_seconds); }
        public double MicroSeconds { get => SecondsToMicro(_seconds); }
        public double MilliSeconds { get => SecondsToMilli(_seconds); }
        public double Seconds { get => _seconds; }
        public double Minutes { get => SecondsToMinute(_seconds); }
        public double Hours { get => SecondsToHour(_seconds); }
        public double Days { get => SecondsToDay(_seconds); }
        public double Years { get => SecondsYear(_seconds); }

        // Constructor
        public Time(double input, TimeUnits unit) {
            switch (unit) {
                case TimeUnits.NanoSeconds:
                    _seconds = NanoToSeconds(input);
                    break;
                case TimeUnits.MicroSeconds:
                    _seconds = MicroToSeconds(input);
                    break;
                case TimeUnits.MilliSeconds:
                    _seconds = MilliToSeconds(input);
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
        private double NanoToSeconds(double nano) { return MicroToSeconds(nano / 1000); }
        private double MicroToSeconds(double micro) { return MilliToSeconds(micro / 1000); }
        private double MilliToSeconds(double milli) { return milli / 1000; }
        private double MinuteToSeconds(double minute) { return minute * 60; }
        private double HourToSeconds(double hour) { return MinuteToSeconds(hour * 60); }
        private double DayToSeconds(double day) { return HourToSeconds(day * 24); }
        private double YearToSeconds(double year) { return DayToSeconds(year * 365); }

        private double SecondsToNano(double seconds) { return SecondsToMicro(seconds * 1000); }
        private double SecondsToMicro(double seconds){ return SecondsToMilli(seconds) * 1000; }
        private double SecondsToMilli(double seconds){ return seconds * 1000; }
        private double SecondsToMinute(double seconds){ return seconds / 60; }
        private double SecondsToHour(double seconds){ return SecondsToMinute(seconds) / 60; }
        private double SecondsToDay(double seconds){ return SecondsToHour(seconds) / 24; }
        private double SecondsYear(double seconds){ return SecondsToDay(seconds) / 365; }






        // Enum
        public enum TimeUnits {
            NanoSeconds,
            MicroSeconds,
            MilliSeconds,
            Seconds,
            Minutes,
            Hours,
            Days,
            Years
        }
    }
}
