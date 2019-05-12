using W3SaveReader.Savegame.Attributes;

namespace W3SaveReader.Savegame.Values.Journal
{
    public class JEntryAdvancedInfo
    {
        [CName("Size")]
        public uint Size { get; set; }

        [CName("JEntryAdvancedInfoGuid")]
        public JEntryAdvancedInfoGuid[] JEntryAdvancedInfoGuid { get; set; }
    }
}