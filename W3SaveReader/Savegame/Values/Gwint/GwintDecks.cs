using W3SaveReader.Savegame.Attributes;

namespace W3SaveReader.Savegame.Values.Gwint
{
    public class GwintDecks
    {
        [CName("DeckCount")]
        public uint DeckCount { get; set; }

        public GwintDeck[] Decks { get; set; }
    }
}