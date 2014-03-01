﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MapType.cs" company="GW2.Net Coding Team">
//   This product is licensed under the GNU General Public License version 2 (GPLv2) as defined on the following page: http://www.gnu.org/licenses/gpl-2.0.html
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace GW2DotNET.V1.Core.WorldVersusWorldInformation.Details
{
    /// <summary>
    /// Enumerates all possible map types.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum MapType
    {
        /// <summary>The 'Red Home' map type.</summary>
        [EnumMember(Value = "RedHome")]
        RedHome = 1 << 0,

        /// <summary>The 'Green Home' map type.</summary>
        [EnumMember(Value = "GreenHome")]
        GreenHome = 1 << 1,

        /// <summary>The 'Blue Home' map type.</summary>
        [EnumMember(Value = "BlueHome")]
        BlueHome = 1 << 2,

        /// <summary>The 'Center' map type.</summary>
        [EnumMember(Value = "Center")]
        Center = 1 << 3
    }
}