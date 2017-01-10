namespace Generics.Attributes
{
    using System;

    [AttributeUsage(
        AttributeTargets.Struct |
        AttributeTargets.Interface |
        AttributeTargets.Method |
        AttributeTargets.Class |
        AttributeTargets.Enum)]
    public class CurrVersion : Attribute
    {
        public CurrVersion(int majorVersion, int minorVesion)
        {
            MajorVersion = majorVersion;
            MinorVesion = minorVesion;
        }

        public int MajorVersion { get; set; }
        public int MinorVesion { get; set; }

        public override string ToString()
        {
            return $"Version {this.MajorVersion}.{this.MinorVesion.ToString("X2")}";

        }
    }
}