using System;
using W3SaveReader.Savegame.Attributes;

namespace W3SaveReader.Savegame.Values.Journal
{
    public class JTrackedQuest
    {
        [CName("guid")]
        public Guid Guid { get; set; }
    }
}