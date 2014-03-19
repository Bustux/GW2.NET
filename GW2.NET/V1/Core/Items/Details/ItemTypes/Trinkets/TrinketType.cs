﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TrinketType.cs" company="GW2.Net Coding Team">
//   This product is licensed under the GNU General Public License version 2 (GPLv2) as defined on the following page: http://www.gnu.org/licenses/gpl-2.0.html
// </copyright>
// <summary>
//   Enumerates the possible trinket types.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace GW2DotNET.V1.Core.Items.Details.ItemTypes.Trinkets
{
    using System.Runtime.Serialization;

    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>Enumerates the possible trinket types.</summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TrinketType
    {
        /// <summary>The 'Unknown' trinket type.</summary>
        [EnumMember(Value = "Unknown")]
        Unknown = 0, 

        /// <summary>The 'Accessory' trinket type.</summary>
        [EnumMember(Value = "Accessory")]
        Accessory = 1 << 0, 

        /// <summary>The 'Amulet' trinket type.</summary>
        [EnumMember(Value = "Amulet")]
        Amulet = 1 << 2, 

        /// <summary>The 'Ring' trinket type.</summary>
        [EnumMember(Value = "Ring")]
        Ring = 1 << 3
    }
}