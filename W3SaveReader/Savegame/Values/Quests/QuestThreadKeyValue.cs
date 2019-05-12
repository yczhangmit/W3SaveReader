using System;
using W3SaveReader.Savegame.Attributes;

namespace W3SaveReader.Savegame.Values.Quests
{
    [CSerializable("questThreadKeyValue", Custom = true)]
    public class QuestThreadKeyValue
    {
        public QuestThreadKeyValue()
        {

        }

        [CName("GUID")]
        public Guid Guid { get; set; }

        [CName("questThread")]
        public QuestThread Thread { get; set; }

    }
}