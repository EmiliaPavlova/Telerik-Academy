namespace MobilePhoneDevice
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class GSM
    {
        private static GSM iPhone4S;

        private string model;
        private string manufacturer;
        private decimal? price;
        private string owner;
        private Battery batery;
        private Display display;
        private List<Call> callHistory; 

        static GSM()
        {
            iPhone4S = new GSM(
                "iPhone4S",
                "Apple",
                7600M,
                "Mr Guzar");
        }

        public GSM(string model, string manufacturer, decimal? price = null, string owner = null, Battery battery = null, Display display = null)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
            this.Battery = battery;
            this.Display = display;
            this.callHistory = new List<Call>();
        }

        public string Model
        {
            get { return this.model; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("GSM model cannot be missing");
                }

                this.model = value;
            }
        }

        public string Manufacturer
        {
            get { return this.manufacturer; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("GSM manufacturer cannot be missing");
                }

                this.manufacturer = value;
            }
        }

        public decimal? Price
        {
            get { return this.price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Price cannot be negative number");
                }

                this.price = value;
            }
        }

        public string Owner
        {
            get { return this.owner; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("GSM owner cannot be missing or white space");
                }

                this.owner = value;
            }
        }

        public Battery Battery { get; set; }

        public Display Display { get; set; }

        public List<Call> CallHistory
        {
            get
            {
                return new List<Call>(this.callHistory);
            }
            set
            {
                if (this.callHistory == null)
                {
                    this.callHistory = new List<Call>();
                }

                this.callHistory.Clear();
                this.callHistory = value;
            }
        }

        public static GSM IPhone4S => iPhone4S;

        public void AddCall(Call call)
        {
            this.callHistory.Add(call);
        }

        public void DeleteCall(Call call)
        {
            this.callHistory.Remove(call);
        }

        public void ClearHistory()
        {
            this.callHistory.Clear();
        }

        public decimal CalculateTotalPrice(decimal fixedPrice)
        {
            long totalDuration = this.CallHistory.Sum(call => (long) call.Duration);

            return fixedPrice * (decimal)(totalDuration / 60);
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine($"Model: {this.Model}");
            result.AppendLine($"Manufacturer: {this.Manufacturer}");
            result.AppendLine($"Price: {this.Price}");
            result.AppendLine($"Owner: {this.Owner}");
            result.AppendLine($"Battery: {this.Battery}");
            result.AppendLine($"Display: {this.Display}");

            return result.ToString();
        }
    }
}