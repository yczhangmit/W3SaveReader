using System;

namespace W3SaveReader.Savegame.Variables
{
    public class TypedVariable : Variable
    {
        public string Type { get; set; }
        public Type ClrType { get; set; }
        public VariableValue Value { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1} {2}", Type, base.ToString(), Value);
        }
    }
}