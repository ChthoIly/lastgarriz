﻿using System.Runtime.Serialization;

namespace Run.Models.Serializable
{
    [DataContract()]
    internal sealed class ConfigData
    {
        [DataMember(Name = "options")]
        internal ConfigOption Options { get; set; } = null;

        [DataMember(Name = "shortcuts")]
        internal ConfigShortcut[] Shortcuts { get; set; } = null;
    }
}
