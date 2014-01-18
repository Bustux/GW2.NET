﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ObjectiveNamesResponse.cs" company="GW2.Net Coding Team">
//   This product is licensed under the GNU General Public License version 2 (GPLv2) as defined on the following page: http://www.gnu.org/licenses/gpl-2.0.html
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
using System;
using Newtonsoft.Json;

namespace GW2DotNET.V1.Core.WvW.ObjectiveNames
{
    /// <summary>
    /// Represents a response that is the result of an <see cref="ObjectiveNamesRequest"/>.
    /// </summary>
    /// <remarks>
    /// See <a href="http://wiki.guildwars2.com/wiki/API:1/wvw/objective_names"/> for more information.
    /// </remarks>
    public class ObjectiveNamesResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectiveNamesResponse"/> class.
        /// </summary>
        public ObjectiveNamesResponse()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the JSON representation of this instance.
        /// </summary>
        /// <returns>Returns a JSON <see cref="String"/>.</returns>
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}