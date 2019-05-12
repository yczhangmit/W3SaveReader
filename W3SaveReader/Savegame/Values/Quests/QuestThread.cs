using W3SaveReader.Savegame.Attributes;

namespace W3SaveReader.Savegame.Values.Quests
{
    [CSerializable("questThread")]
    public class QuestThread
    {
        public QuestThread()
        {
            
        }

        [CArray("numBlocksToActivate")]
        public QuestBlock[] QuestBlocksToActivate { get; set; }

        [CArray("numBlocks")]
        public QuestBlock[] QuestBlocks { get; set; }

        [CArray("numThreads", ElementName = "questThread")]
        public QuestThreadKeyValue[] QuestThreads { get; set; }
    }
}