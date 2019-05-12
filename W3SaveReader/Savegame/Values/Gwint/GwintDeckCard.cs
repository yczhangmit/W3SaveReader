using W3SaveReader.Savegame.Attributes;

namespace W3SaveReader.Savegame.Values.Gwint
{
    public class GwintDeckCard
    {
        [CName("cardIndex")]
        public int CardIndex { get; set; }
    }
}