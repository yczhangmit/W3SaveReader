using W3SaveReader.Savegame.Attributes;

namespace W3SaveReader.Savegame.Values
{
    public class SGameplayFactRemoval
    {
        [CName("factName")]
        public string FactName { get; set; }

        [CName("value")]
        public int Value { get; set; }

        [CName("timerID")]
        public int TimerId { get; set; }
    }
}