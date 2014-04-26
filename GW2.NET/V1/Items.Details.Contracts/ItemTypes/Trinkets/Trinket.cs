﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Trinket.cs" company="GW2.Net Coding Team">
//   This product is licensed under the GNU General Public License version 2 (GPLv2) as defined on the following page: http://www.gnu.org/licenses/gpl-2.0.html
// </copyright>
// <summary>
//   Represents a trinket.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace GW2DotNET.V1.Items.Details.Contracts.ItemTypes.Trinkets
{
    using System.Runtime.Serialization;

    using GW2DotNET.V1.Common.Converters;
    using GW2DotNET.V1.Items.Details.Contracts.ItemTypes.Common;

    using Newtonsoft.Json;

    /// <summary>Represents a trinket.</summary>
    [JsonConverter(typeof(DefaultJsonConverter))]
    public class Trinket : Item
    {
        /// <summary>Initializes a new instance of the <see cref="Trinket" /> class.</summary>
        public Trinket()
            : base(ItemType.Trinket)
        {
        }

        /// <summary>Gets or sets the item details.</summary>
        [DataMember(Name = "trinket", Order = 100)]
        [JsonConverter(typeof(TrinketDetailsConverter))]
        public override ItemDetails Details
        {
            get
            {
                return base.Details;
            }

            set
            {
                base.Details = value;
            }
        }
    }
}