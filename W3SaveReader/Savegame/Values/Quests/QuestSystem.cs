using W3SaveReader.Savegame.Attributes;

namespace W3SaveReader.Savegame.Values.Quests
{
    [CSerializable("questSystem")]
    public class QuestSystem
    {
        [CName("questExternalScenePlayers")]
        public QuestExternalScenePlayers QuestExternalScenePlayers { get; set; }

    }
}