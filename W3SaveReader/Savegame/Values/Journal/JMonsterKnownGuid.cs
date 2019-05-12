using System;
using W3SaveReader.Savegame.Attributes;

namespace W3SaveReader.Savegame.Values.Journal
{
    public class JMonsterKnownGuid
    {
        [CName("guid")]
        public Guid Guid { get; set; }
    }
}