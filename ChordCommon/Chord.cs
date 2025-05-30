namespace ChordCommon
{
    public class Chord
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Notes { get; set; }

        public Chord(string name, string type, string notes)
        {
            Name = name.ToUpper();
            Type = type.ToUpper();
            Notes = notes.ToUpper();
        }


        public override string ToString()
        {
            return Name + " (" + Type + ")\n";
        }
    }
}
