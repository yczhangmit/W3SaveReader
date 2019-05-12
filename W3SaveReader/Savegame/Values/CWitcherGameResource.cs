using W3SaveReader.Savegame.Attributes;

namespace W3SaveReader.Savegame.Values
{
    [CSerializable("CWitcherGameResource")]
    public class CWitcherGameResource
    {
        [CName("path")]
        public string Path { get; set; }
    }
}
