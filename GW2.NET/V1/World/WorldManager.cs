﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="WorldManager.cs" company="GW2.Net Coding Team">
//   This product is licensed under the GNU General Public License version 2 (GPLv2) as defined on the following page: http://www.gnu.org/licenses/gpl-2.0.html
// </copyright>
// <summary>
//   Defines the Language type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using GW2DotNET.V1.Infrastructure;
using GW2DotNET.V1.World.DataProvider;

namespace GW2DotNET.V1.World
{
    /// <summary>
    /// Contains methods and properties to get and modify the world content of the API.
    /// </summary>
    public class WorldManager
    {
        /// <summary>
        /// The world data class.
        /// </summary>
        private WorldData worldData;

        /// <summary>
        /// The map data class.
        /// </summary>
        private MapData mapData;

        /// <summary>
        /// The event data class.
        /// </summary>
        private EventData eventData;

        /// <summary>
        /// The chosen language
        /// </summary>
        private Language language;

        /// <summary>
        /// Initializes a new instance of the <see cref="WorldManager"/> class.
        /// </summary>
        public WorldManager()
        {
            this.language = Infrastructure.Language.En;
        }

        /// <summary>
        /// Gets the maps.
        /// </summary>
        public MapData Maps
        {
            get
            {
                if (this.mapData == null)
                {
                    this.mapData = new MapData(this.Language);
                }

                return this.mapData;
            }
        }

        /// <summary>
        /// Gets the worlds.
        /// </summary>
        public WorldData Worlds
        {
            get
            {
                if (this.worldData == null)
                {
                    this.worldData = new WorldData(this.Language);
                }

                return this.worldData;
            }
        }

        /// <summary>
        /// Gets the EventData object.
        /// </summary>
        public EventData Events
        {
            get
            {
                if (this.eventData == null)
                {
                    this.eventData = new EventData(this.Language, this);
                }

                return this.eventData;
            }
        }

        /// <summary>
        /// Gets or sets the language of the content.
        /// </summary>
        public Language Language
        {
            get
            {
                return this.language;
            }

            // ToDo: Clear cache if language changed.
            set
            {
                this.worldData = null;
                this.mapData = null;
                this.eventData = null;
            }
        }
    }
}
