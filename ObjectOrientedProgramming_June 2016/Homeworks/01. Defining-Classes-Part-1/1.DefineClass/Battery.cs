namespace MobilePhoneDevice
{
    using System;
    using System.Text;

    public class Battery
    {
        private string model;
        private double hoursIdle;
        private double hoursTalk;
        private BatteryType batteryType;

        public Battery()
        {
        }

        public Battery(string model)
        {
            this.Model = model;
        }

        public Battery(string model, BatteryType batteryType)
        {
            this.Model = model;
            this.BatteryType = batteryType;
        }

        public Battery(string model, double hoursIdle, double hoursTalk, BatteryType batteryType)
        {
            this.Model = model;
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
            this.BatteryType = batteryType;
        }

        public string Model
        {
            get { return this.model; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("The battery model cannot be empty!");
                }

                this.model = value;
            }
        }

        public double HoursIdle
        {
            get { return this.hoursIdle; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The battery hours idle cannot be < 0");
                }

                this.hoursIdle = value;
            }
        }

        public double HoursTalk
        {
            get { return this.hoursTalk; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The battery hours talk cannot be < 0");
                }

                this.hoursTalk = value;
            }
        }

        public BatteryType BatteryType
        {
            get { return this.batteryType; }
            set { this.batteryType = value; }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            if (this.Model == null)
            {
                result.Append("no battery");
            }
            else
            {
                result.AppendLine($"\r\n -Model: {this.Model}");
                result.AppendLine($" -Hours Idle: {this.HoursIdle}");
                result.AppendLine($" -Hours Talk: {this.HoursTalk}");
                result.Append($" -Battery Type: {this.BatteryType}");
            }

            return result.ToString();
        }
    }
}