using W3SaveReader.Savegame.Attributes;

namespace W3SaveReader.Savegame.Values.Journal
{
    public class JHuntingClues
    {
        [CName("Size")]
        public uint Size { get; set; }

        public JHuntingClue[] Clues { get; set; }
    }
}