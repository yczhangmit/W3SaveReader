using W3SaveReader.Savegame.Attributes;

namespace W3SaveReader.Savegame.Values
{
    [CName("idTagManager")]
    public class IdTagManager
    {
        [CName("tagIndex")]
        public ulong TagIndex { get; set; }
    }
}