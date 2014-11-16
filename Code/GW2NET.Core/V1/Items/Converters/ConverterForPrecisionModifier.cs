﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ConverterForPrecisionModifier.cs" company="GW2.NET Coding Team">
//   This product is licensed under the GNU General Public License version 2 (GPLv2) as defined on the following page: http://www.gnu.org/licenses/gpl-2.0.html
// </copyright>
// <summary>
//   Converts objects of type <see cref="AttributeDataContract" /> to objects of type <see cref="PrecisionModifier" />.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace GW2NET.V1.Items.Converters
{
    using System.Diagnostics.Contracts;

    using GW2NET.Common;
    using GW2NET.Items.Common;
    using GW2NET.V1.Items.Json;

    /// <summary>Converts objects of type <see cref="AttributeDataContract"/> to objects of type <see cref="PrecisionModifier"/>.</summary>
    internal sealed class ConverterForPrecisionModifier : IConverter<AttributeDataContract, PrecisionModifier>
    {
        /// <summary>Converts the given object of type <see cref="AttributeDataContract"/> to an object of type <see cref="PrecisionModifier"/>.</summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value.</returns>
        public PrecisionModifier Convert(AttributeDataContract value)
        {
            Contract.Assume(value != null);
            var attribute = new PrecisionModifier();
            int modifier;
            if (int.TryParse(value.Modifier, out modifier))
            {
                attribute.Modifier = modifier;
            }

            return attribute;
        }
    }
}