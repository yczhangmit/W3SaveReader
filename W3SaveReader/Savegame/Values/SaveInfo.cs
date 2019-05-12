using W3SaveReader.Savegame.Attributes;

namespace W3SaveReader.Savegame.Values
{
    [CSerializable("saveInfo")]
    public class SaveInfo
    {
        [CName("magic_number")]
        public byte[] MagicNumber { get; set; }

        [CName("description")]
        public string Description { get; set; }

        [CName("runtimeGUIDCounter")]
        public ulong RuntimeGuidCounter { get; set; }

        [CArray]
        public SaveInfoItem[] Items { get; set; }
    }
}