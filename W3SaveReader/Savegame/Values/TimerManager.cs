using W3SaveReader.Savegame.Attributes;
using W3SaveReader.Savegame.Values.Engine;

namespace W3SaveReader.Savegame.Values
{
    [CName("timerManager")]
    public class TimerManager
    {
        [CName("time")]
        public GameTime Time { get; set; }

        public object Unknown1 { get; set; }

        [CName("isPaused")]
        public bool IsPaused { get; set; }

        [CName("timeScalePriorityIndexGenerator")]
        public uint TimeScalePriorityIndexGenerator { get; set; }
         
    }
}