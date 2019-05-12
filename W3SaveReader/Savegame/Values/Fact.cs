using W3SaveReader.Savegame.Attributes;

namespace W3SaveReader.Savegame.Values
{
    [CSerializable("fact")]
    public class Fact
    {
        [CName("id")]
        public string Id { get; set; }
        [CName("expiringCount")]
        public uint ExpiringCount { get; set; }
        [CArray("entryCount")]
        public FactEntry[] Entries { get; set; }
    }
}