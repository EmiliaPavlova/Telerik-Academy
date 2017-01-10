namespace MobilePhoneDevice
{
    using System;
    using System.Text;

    public class Display
    {
        private double size;
        private int numberOfColors;

        public Display(double size)
        {
            this.Size = size;
        }

        public Display(double size, int numberOfColors)
        {
            this.Size = size;
            this.NumberOfColors = numberOfColors;
        }

        public double Size
        {
            get { return this.size; }
            set
            {
                if (value < 0.0)
                {
                    throw new ArgumentNullException("Width cannot be < 0");
                }

                this.size = value;
            }
        }

        public int NumberOfColors
        {
            get { return this.numberOfColors; }
            set
            {
                if (value < 2)
                {
                    throw new ArgumentNullException("The number of collors should be >= 2");
                }

                this.numberOfColors = value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine($"\r\n -Size: {this.Size}");
            result.Append($" -Number of colors: {this.NumberOfColors}");

            return result.ToString();
        }
    }
}