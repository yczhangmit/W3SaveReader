using W3SaveReader.Savegame.Attributes;

namespace W3SaveReader.Savegame.Values
{
    [CSerializable("facts")]
    public class Facts
    {
        [CArray]
        public Fact[] Items { get; set; }
    }
}