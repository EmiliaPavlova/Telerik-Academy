namespace DefiningClasses
{
    public class Path3D
    {
        public Path3D(string sequenceOfPoints)
        {
            this.SequenceOfPoints = sequenceOfPoints;
        }

        public string SequenceOfPoints { get; set; }

        public override string ToString()
        {
            return SequenceOfPoints;
        }
    }
}