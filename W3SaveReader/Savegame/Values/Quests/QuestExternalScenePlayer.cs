using W3SaveReader.Savegame.Attributes;

namespace W3SaveReader.Savegame.Values.Quests
{
    [CSerializable("CQuestExternalScenePlayer")]
    public class QuestExternalScenePlayer
    {
        public QuestExternalScenePlayer()
        {
            
        }

        [CArray("tagsCount")]
        public ExternalDialog[] ExternalDialogs { get; set; }

        [CArray("numQuests")]
        public Quest[] Quests { get; set; }
    }
}