using W3SaveReader.Savegame.Attributes;

namespace W3SaveReader.Savegame.Values
{
    [CName("SGameplayFact")]
    public class SGameplayFact
    {
        [CName("factName")]
        public string FactName { get; set; }

        [CName("value")]
        public int Value { get; set; }
    }
}