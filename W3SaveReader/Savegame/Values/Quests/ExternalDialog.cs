using System;
using W3SaveReader.Savegame.Attributes;

namespace W3SaveReader.Savegame.Values.Quests
{
    [CSerializable("ExternalDialog")]
    public class ExternalDialog
    {
        [CName("tag")]
        public string Tag { get; set; }
        [CArray("dialogsCount")]
        public Guid[] Dialogs { get; set; }
    }
}