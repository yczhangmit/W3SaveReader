using W3SaveReader.Savegame.Attributes;

namespace W3SaveReader.Savegame.Values.Journal
{
    public class JMonsterKnown
    {
        [CName("Size")]
        public uint Size { get; set; }
        
        [CName("JMonsterKnownGuid")]
        public JMonsterKnownGuid[] MonsterKnownGuid { get; set; }
    }
}