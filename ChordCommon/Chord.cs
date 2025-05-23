namespace ChordCommon
{
    public class Chord
    {
        public string Name { get; set; }
        public string Type { get; set; }

        public Chord(string name, string type)
        {
            Name = name.ToUpper();
            Type = type.ToUpper();
        }

        public override string ToString()
        {
            return Name + " (" + Type + ")\n";
        }
    }
}
