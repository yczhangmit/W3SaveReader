using W3SaveReader.Savegame.Attributes;

namespace W3SaveReader.Savegame.Values
{
    public class AdditionalContent
    {
        [CName("count")]
        public uint Count { get; set; }

        public string[] Items { get; set; }
    }
}