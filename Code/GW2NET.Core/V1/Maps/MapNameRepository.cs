﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MapNameRepository.cs" company="GW2.NET Coding Team">
//   This product is licensed under the GNU General Public License version 2 (GPLv2) as defined on the following page: http://www.gnu.org/licenses/gpl-2.0.html
// </copyright>
// <summary>
//   Represents a repository that retrieves data from the /v1/map_names.json interface.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace GW2NET.V1.Maps
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.Contracts;
    using System.Globalization;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;

    using GW2NET.Common;
    using GW2NET.Entities.Maps;
    using GW2NET.V1.Maps.Json;
    using GW2NET.V1.Maps.Json.Converters;

    /// <summary>Represents a repository that retrieves data from the /v1/map_names.json interface.</summary>
    public class MapNameRepository : IRepository<int, MapName>, ILocalizable
    {
        /// <summary>Infrastructure. Holds a reference to a type converter.</summary>
        private readonly IConverter<MapNameDataContract, MapName> converterForMapName;

        /// <summary>Infrastructure. Holds a reference to the service client.</summary>
        private readonly IServiceClient serviceClient;

        /// <summary>Initializes a new instance of the <see cref="MapNameRepository"/> class.</summary>
        /// <param name="serviceClient">The service client.</param>
        public MapNameRepository(IServiceClient serviceClient)
            : this(serviceClient, new ConverterForMapName())
        {
        }

        /// <summary>Initializes a new instance of the <see cref="MapNameRepository"/> class.</summary>
        /// <param name="serviceClient">The service client.</param>
        /// <param name="converterForMapName">The converter for <see cref="MapName"/>.</param>
        internal MapNameRepository(IServiceClient serviceClient, IConverter<MapNameDataContract, MapName> converterForMapName)
        {
            this.serviceClient = serviceClient;
            this.converterForMapName = converterForMapName;
        }

        /// <summary>Gets or sets the locale.</summary>
        public CultureInfo Culture { get; set; }

        /// <inheritdoc />
        ICollection<int> IDiscoverable<int>.Discover()
        {
            throw new NotSupportedException();
        }

        /// <inheritdoc />
        Task<ICollection<int>> IDiscoverable<int>.DiscoverAsync()
        {
            throw new NotSupportedException();
        }

        /// <inheritdoc />
        Task<ICollection<int>> IDiscoverable<int>.DiscoverAsync(CancellationToken cancellationToken)
        {
            throw new NotSupportedException();
        }

        /// <inheritdoc />
        MapName IRepository<int, MapName>.Find(int identifier)
        {
            throw new NotSupportedException();
        }

        /// <inheritdoc />
        IDictionaryRange<int, MapName> IRepository<int, MapName>.FindAll()
        {
            var request = new MapNameRequest { Culture = this.Culture };
            var response = this.serviceClient.Send<ICollection<MapNameDataContract>>(request);
            if (response.Content == null)
            {
                return new DictionaryRange<int, MapName>(0);
            }

            var values = response.Content.Select(this.converterForMapName.Convert).ToList();
            var mapNames = new DictionaryRange<int, MapName>(values.Count) { SubtotalCount = values.Count, TotalCount = values.Count };

            foreach (var mapName in values)
            {
                mapName.Culture = request.Culture;
                mapNames.Add(mapName.MapId, mapName);
            }

            return mapNames;
        }

        /// <inheritdoc />
        IDictionaryRange<int, MapName> IRepository<int, MapName>.FindAll(ICollection<int> identifiers)
        {
            throw new NotSupportedException();
        }

        /// <inheritdoc />
        Task<IDictionaryRange<int, MapName>> IRepository<int, MapName>.FindAllAsync()
        {
            return ((IRepository<int, MapName>)this).FindAllAsync(CancellationToken.None);
        }

        /// <inheritdoc />
        Task<IDictionaryRange<int, MapName>> IRepository<int, MapName>.FindAllAsync(CancellationToken cancellationToken)
        {
            var request = new MapNameRequest { Culture = this.Culture };
            return this.serviceClient.SendAsync<ICollection<MapNameDataContract>>(request, cancellationToken).ContinueWith<IDictionaryRange<int, MapName>>(task =>
            {
                var response = task.Result;
                if (response.Content == null)
                {
                    return new DictionaryRange<int, MapName>(0);
                }

                var values = response.Content.Select(this.converterForMapName.Convert).ToList();
                var mapNames = new DictionaryRange<int, MapName>(values.Count) { SubtotalCount = values.Count, TotalCount = values.Count };

                foreach (var mapName in values)
                {
                    mapName.Culture = request.Culture;
                    mapNames.Add(mapName.MapId, mapName);
                }

                return mapNames;
            }, cancellationToken);
        }

        /// <inheritdoc />
        Task<IDictionaryRange<int, MapName>> IRepository<int, MapName>.FindAllAsync(ICollection<int> identifiers)
        {
            throw new NotSupportedException();
        }

        /// <inheritdoc />
        Task<IDictionaryRange<int, MapName>> IRepository<int, MapName>.FindAllAsync(ICollection<int> identifiers, CancellationToken cancellationToken)
        {
            throw new NotSupportedException();
        }

        /// <inheritdoc />
        Task<MapName> IRepository<int, MapName>.FindAsync(int identifier)
        {
            throw new NotSupportedException();
        }

        /// <inheritdoc />
        Task<MapName> IRepository<int, MapName>.FindAsync(int identifier, CancellationToken cancellationToken)
        {
            throw new NotSupportedException();
        }

        /// <inheritdoc />
        ICollectionPage<MapName> IPaginator<MapName>.FindPage(int pageIndex)
        {
            throw new NotSupportedException();
        }

        /// <inheritdoc />
        ICollectionPage<MapName> IPaginator<MapName>.FindPage(int pageIndex, int pageSize)
        {
            throw new NotSupportedException();
        }

        /// <inheritdoc />
        Task<ICollectionPage<MapName>> IPaginator<MapName>.FindPageAsync(int pageIndex)
        {
            throw new NotSupportedException();
        }

        /// <inheritdoc />
        Task<ICollectionPage<MapName>> IPaginator<MapName>.FindPageAsync(int pageIndex, CancellationToken cancellationToken)
        {
            throw new NotSupportedException();
        }

        /// <inheritdoc />
        Task<ICollectionPage<MapName>> IPaginator<MapName>.FindPageAsync(int pageIndex, int pageSize)
        {
            throw new NotSupportedException();
        }

        /// <inheritdoc />
        Task<ICollectionPage<MapName>> IPaginator<MapName>.FindPageAsync(int pageIndex, int pageSize, CancellationToken cancellationToken)
        {
            throw new NotSupportedException();
        }

        /// <summary>The invariant method for this class.</summary>
        [ContractInvariantMethod]
        private void ObjectInvariant()
        {
            Contract.Invariant(this.serviceClient != null);
            Contract.Invariant(this.converterForMapName != null);
        }
    }
}