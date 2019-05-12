using System;
using W3SaveReader.Savegame.Attributes;

namespace W3SaveReader.Savegame.Values.Journal
{
    public class JObjectiveCounter
    {
        [CName("guid")]
        public Guid Guid { get; set; }

        [CName("count")]
        public int Count { get; set; }
    }
}