using W3SaveReader.Savegame.Attributes;

namespace W3SaveReader.Savegame.Values
{
    public class W3EnvironmentManager
    {
        [CName("m_envId")]
        public int EnvId { get; set; }
    }
}