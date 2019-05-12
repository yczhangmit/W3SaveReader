namespace W3SaveReader.Savegame.Variables
{
    public abstract class Variable
    {
        public string Name { get; set; }

        public int Size { get; set; }

        public int TokenSize { get; set; }

        public Variable()
        {
            Name = "None";
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
