﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="QuagganContract.cs" company="GW2.NET Coding Team">
//   This product is licensed under the GNU General Public License version 2 (GPLv2) as defined on the following page: http://www.gnu.org/licenses/gpl-2.0.html
// </copyright>
// <summary>
//   Represents a Quaggan.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace GW2NET.V2.Quaggans.Json
{
    using System.Runtime.Serialization;

    /// <summary>Represents a Quaggan.</summary>
    [DataContract]
    internal sealed class QuagganContract
    {
        /// <summary>Gets or sets the Quaggan identifier.</summary>
        [DataMember(Name = "id", Order = 0)]
        public string Id { get; set; }

        /// <summary>Gets or sets the resource location.</summary>
        [DataMember(Name = "url", Order = 1)]
        public string Url { get; set; }
    }
}