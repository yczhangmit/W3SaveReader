﻿namespace W3SaveReader.Savegame.Variables
{
    public class SxapVariable : Variable
    {
        public int TypeCode1 { get; set; }
        public int TypeCode2 { get; set; }
        public int TypeCode3 { get; set; }

        public override string ToString()
        {
            return "SXAP " + base.ToString();
        }
    }
}
