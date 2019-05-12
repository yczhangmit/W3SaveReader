using System.IO;
using W3SaveReader.Savegame.Variables;

namespace W3SaveReader.Savegame.VariableParsers
{
    public class OpVariableParser : VariableParserBase<OpVariable>
    {
        public override string MagicNumber
        {
            get { return "OP"; }
        }

        public override OpVariable ParseImpl(BinaryReader reader, ref int size)
        {
            ushort nameIndex = reader.ReadUInt16();
            ushort typeIndex = reader.ReadUInt16();
            size -= 2 * sizeof(short);
            
            // BUG: Can read invalid indices
            string name = nameIndex - 1 < Names.Length ? Names[nameIndex - 1] : "Unknown";
            string type = typeIndex - 1 < Names.Length ?  Names[typeIndex - 1] : "Unknown";

            var value = ReadValue(reader, type, ref size);

            return new OpVariable
            {
                Name = name,
                Type = type,
                Value = value
            };
        }
    }
}
