﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ImageSerializerFactory.cs" company="GW2.NET Coding Team">
//   This product is licensed under the GNU General Public License version 2 (GPLv2) as defined on the following page: http://www.gnu.org/licenses/gpl-2.0.html
// </copyright>
// <summary>
//   Provides factory methods for the image serialization engine.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace GW2DotNET.Common.Serializers
{
    using System;
    using System.Drawing;

    /// <summary>Provides factory methods for the image serialization engine.</summary>
    public class ImageSerializerFactory : ISerializerFactory
    {
        /// <summary>Gets a serializer for the specified type.</summary>
        /// <typeparam name="T">The serialization type.</typeparam>
        /// <returns>The <see cref="ISerializer{T}"/>.</returns>
        public ISerializer<T> GetSerializer<T>()
        {
            if (!typeof(Image).IsAssignableFrom(typeof(T)))
            {
                throw new NotSupportedException("The specified type is not supported by the image serializer.");
            }

            return (ISerializer<T>)new ImageSerializer();
        }
    }
}