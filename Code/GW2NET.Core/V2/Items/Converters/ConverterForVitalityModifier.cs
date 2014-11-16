﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ConverterForVitalityModifier.cs" company="GW2.NET Coding Team">
//   This product is licensed under the GNU General Public License version 2 (GPLv2) as defined on the following page: http://www.gnu.org/licenses/gpl-2.0.html
// </copyright>
// <summary>
//   Converts objects of type <see cref="AttributeDataContract" /> to objects of type <see cref="VitalityModifier" />.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace GW2NET.V2.Items.Converters
{
    using System.Diagnostics.Contracts;

    using GW2NET.Common;
    using GW2NET.Items.Common;
    using GW2NET.V2.Items.Json;

    /// <summary>Converts objects of type <see cref="AttributeDataContract"/> to objects of type <see cref="VitalityModifier"/>.</summary>
    internal sealed class ConverterForVitalityModifier : IConverter<AttributeDataContract, VitalityModifier>
    {
        /// <summary>Converts the given object of type <see cref="AttributeDataContract"/> to an object of type <see cref="VitalityModifier"/>.</summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value.</returns>
        public VitalityModifier Convert(AttributeDataContract value)
        {
            Contract.Assume(value != null);
            return new VitalityModifier
            {
                Modifier = value.Modifier
            };
        }
    }
}