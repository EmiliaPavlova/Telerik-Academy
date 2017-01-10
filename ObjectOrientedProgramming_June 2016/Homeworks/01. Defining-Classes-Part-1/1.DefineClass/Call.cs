namespace MobilePhoneDevice
{
    using System;

    public class Call
    {
        private DateTime dateTime;

        public Call()
        {
            this.dateTime = DateTime.Now;
        }

        public string Time => this.dateTime.ToString("HH:mm:ss");

        public string Date => this.dateTime.ToString("dd.MM.yyyy");

        public string DialedPhone { get; set; }

        public long Duration { get; set; }

        public override string ToString()
        {
            return $"Dialed: {this.DialedPhone}, date: {this.Date}, time: {this.Time}, duration: {this.Duration}";
        }
    }
}