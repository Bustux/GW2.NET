﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ErrorResponse.cs" company="GW2.Net Coding Team">
//   This product is licensed under the GNU General Public License version 2 (GPLv2) as defined on the following page: http://www.gnu.org/licenses/gpl-2.0.html
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using Newtonsoft.Json;

namespace GW2DotNET.V1.Core
{
    /// <summary>
    /// Represents the response that is returned when an error occurs.
    /// </summary>
    /// <remarks>
    /// See <a href="http://wiki.guildwars2.com/wiki/API:1"/> for more information.
    /// </remarks>
    public class ErrorResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorResponse"/> class.
        /// </summary>
        public ErrorResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorResponse"/> class using the specified values.
        /// </summary>
        /// <param name="error">The error number.</param>
        /// <param name="product">The product number.</param>
        /// <param name="module">The module number.</param>
        /// <param name="line">The line number.</param>
        /// <param name="text">The error message.</param>
        public ErrorResponse(int error, int product, int module, int line, string text)
        {
            this.Error = error;
            this.Product = product;
            this.Module = module;
            this.Line = line;
            this.Text = text;
        }

        /// <summary>
        /// Gets or sets a number that indicates the error kind.
        /// </summary>
        [JsonProperty("error")]
        public int Error { get; set; }

        /// <summary>
        /// Gets or sets the line number on which the error occurred.
        /// </summary>
        [JsonProperty("line")]
        public int Line { get; set; }

        /// <summary>
        /// Gets or sets a number that represents the module in which the error occurred.
        /// </summary>
        [JsonProperty("module")]
        public int Module { get; set; }

        /// <summary>
        /// Gets or sets a number that represents the product in which the error occurred.
        /// </summary>
        [JsonProperty("product")]
        public int Product { get; set; }

        /// <summary>
        /// Gets or sets the error message.
        /// </summary>
        [JsonProperty("text")]
        public string Text { get; set; }

        /// <summary>
        /// Gets the JSON representation of this instance.
        /// </summary>
        /// <returns>Returns a JSON <see cref="System.String"/>.</returns>
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }

        /// <summary>
        /// Gets the JSON representation of this instance.
        /// </summary>
        /// <param name="indent">A value that indicates whether to indent the output.</param>
        /// <returns>Returns a JSON <see cref="System.String"/>.</returns>
        public string ToString(bool indent)
        {
            return JsonConvert.SerializeObject(this, indent ? Formatting.Indented : Formatting.None);
        }
    }
}