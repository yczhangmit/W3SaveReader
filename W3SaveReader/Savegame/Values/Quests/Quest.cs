using W3SaveReader.Savegame.Attributes;

namespace W3SaveReader.Savegame.Values.Quests
{
    [CSerializable("quest")]
    public class Quest
    {
        [CName("fileName")]
        public string FileName { get; set; }

        [CName("questThread")]
        public QuestThread QuestThread { get; set; }

    }
}