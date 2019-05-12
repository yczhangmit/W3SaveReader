using W3SaveReader.Savegame.Attributes;

namespace W3SaveReader.Savegame.Values.Gwint
{
    public class GwintDeck
    {
        [CName("DeckUnlocked")]
        public bool DeckUnlocked { get; set; }

        [CName("LeaderIndex")]
        public int LeaderIndex { get; set; }

        [CName("CardCount")]
        public uint CardCount { get; set; }

        public GwintDeckCard[] GwintDeckCards { get; set; }
    }
}