using W3SaveReader.Savegame.Attributes;

namespace W3SaveReader.Savegame.Values.Quests
{
    [CSerializable("questCondition", Custom = true)]
    public class QuestCondition
    {
        [CName("nP")]
        public uint Np { get; set; }

        [CName("active")]
        public bool Active { get; set; }
    }
}