﻿using System;

namespace W3SaveReader.Savegame.Attributes
{
    [AttributeUsage(AttributeTargets.Enum | AttributeTargets.Property)]
    public class EnumNameAttribute : Attribute
    {
        private string Name { get; set; }

        public EnumNameAttribute(string name)
        {
            Name = name;
        }
    }
}