using System;
using W3SaveReader.Savegame.Attributes;

namespace W3SaveReader.Savegame.Values
{
    [CName("worldInfo")]
    public class WorldInfo
    {
        [CName("world")]
        public String World { get; set; }
    }
}