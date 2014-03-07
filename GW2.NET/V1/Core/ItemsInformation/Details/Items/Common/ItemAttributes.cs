﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ItemAttributes.cs" company="GW2.Net Coding Team">
//   This product is licensed under the GNU General Public License version 2 (GPLv2) as defined on the following page: http://www.gnu.org/licenses/gpl-2.0.html
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;

namespace GW2DotNET.V1.Core.ItemsInformation.Details.Items.Common
{
    /// <summary>
    /// Represents a collection of item attributes.
    /// </summary>
    public class ItemAttributes : JsonList<ItemAttribute>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemAttributes"/> class.
        /// </summary>
        public ItemAttributes()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ItemAttributes"/> class.
        /// </summary>
        /// <param name="capacity">The number of elements that the new list can initially store.</param>
        public ItemAttributes(int capacity)
            : base(capacity)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ItemAttributes"/> class.
        /// </summary>
        /// <param name="collection">The collection whose elements are copied to the new list.</param>
        public ItemAttributes(IEnumerable<ItemAttribute> collection)
            : base(collection)
        {
        }
    }
}