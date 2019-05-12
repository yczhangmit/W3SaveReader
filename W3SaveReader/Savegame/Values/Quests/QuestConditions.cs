using W3SaveReader.Savegame.Attributes;

namespace W3SaveReader.Savegame.Values.Quests
{
    [CSerializable("conditions")]
    public class QuestConditions
    {
        public QuestConditions()
        {
            
        }

        [CArray("numConditions", ElementName = "p")]
        public QuestCondition[] Conditions { get; set; }
    }
}