using W3SaveReader.Savegame.Attributes;

namespace W3SaveReader.Savegame.Values
{
    [CSerializable("entry")]
    public class FactEntry
    {
        [CName("value")]
        public int Value { get; set; }
        [CName("time")]
        public double Time { get; set; }
        [CName("expiryTime")]
        public double ExpiryTime { get; set; }
    }
}