﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Recipes.cs" company="GW2.Net Coding Team">
//   This product is licensed under the GNU General Public License version 2 (GPLv2) as defined on the following page: http://www.gnu.org/licenses/gpl-2.0.html
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;

namespace GW2DotNET.V1.Core.ItemsInformation.Catalogs
{
    /// <summary>
    /// Represents a collection of recipe IDs.
    /// </summary>
    public class Recipes : JsonList<int>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Recipes"/> class.
        /// </summary>
        public Recipes() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="Recipes"/> class.
        /// </summary>
        /// <param name="collection">The collection whose elements are copied to the new list.</param>
        public Recipes(IEnumerable<int> collection)
            : base(collection)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Recipes"/> class.
        /// </summary>
        /// <param name="capacity">The number of elements that the new list can initially store.</param>
        public Recipes(int capacity)
            : base(capacity)
        {
        }
    }
}