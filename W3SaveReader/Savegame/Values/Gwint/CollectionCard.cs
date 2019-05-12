using W3SaveReader.Savegame.Attributes;

namespace W3SaveReader.Savegame.Values.Gwint
{
    public class CollectionCard
    {
        [CName("cardIndex")]
        public uint CardIndex { get; set; }

        [CName("numCopies")]
        public uint NumCopies { get; set; }
    }
}