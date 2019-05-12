using W3SaveReader.Savegame.Attributes;

namespace W3SaveReader.Savegame.Values
{
    [CName("worldState")]
    public class WorldState
    {
        [CName("entityStateChangeRequests")]
        public EntityStateChangeRequests EntityStateChangeRequests { get; set; }
    }
}