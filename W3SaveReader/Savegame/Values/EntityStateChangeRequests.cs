using W3SaveReader.Savegame.Attributes;

namespace W3SaveReader.Savegame.Values
{
    public class EntityStateChangeRequests
    {
        [CName("requestsCount")]
        public uint RequestsCount { get; set; }
    }
}