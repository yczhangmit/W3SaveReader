using W3SaveReader.Savegame.Attributes;

namespace W3SaveReader.Savegame.Values.Gwint
{
    public class SelectedDeckIndex  
    {
        [CName("deckIndex")]
        [EnumName("eGwintFaction")]
        public W3Enum DeckIndex { get; set; }
    }
}