﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ConverterForMapName.cs" company="GW2.NET Coding Team">
//   This product is licensed under the GNU General Public License version 2 (GPLv2) as defined on the following page: http://www.gnu.org/licenses/gpl-2.0.html
// </copyright>
// <summary>
//   Converts objects of type <see cref="MapNameDataContract" /> to objects of type <see cref="MapName" />.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace GW2NET.V1.Maps.Converters
{
    using System.Diagnostics.Contracts;

    using GW2NET.Common;
    using GW2NET.Maps;
    using GW2NET.V1.Maps.Json;

    /// <summary>Converts objects of type <see cref="MapNameDataContract"/> to objects of type <see cref="MapName"/>.</summary>
    internal sealed class ConverterForMapName : IConverter<MapNameDataContract, MapName>
    {
        /// <summary>Converts the given object of type <see cref="MapNameDataContract"/> to an object of type <see cref="MapName"/>.</summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value.</returns>
        public MapName Convert(MapNameDataContract value)
        {
            Contract.Assume(value != null);
            var mapName = new MapName
            {
                Name = value.Name
            };
            int id;
            if (int.TryParse(value.Id, out id))
            {
                mapName.MapId = id;
            }

            return mapName;
        }
    }
}