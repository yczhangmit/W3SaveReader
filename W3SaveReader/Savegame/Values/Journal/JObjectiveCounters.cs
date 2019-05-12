using W3SaveReader.Savegame.Attributes;

namespace W3SaveReader.Savegame.Values.Journal
{
    public class JObjectiveCounters
    {
        [CName("Size")]
        public uint Size { get; set; }

        public JObjectiveCounter[] Counters { get; set; }
    }
}