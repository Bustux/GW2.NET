﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GW2NET.Factories
{
    using System.Diagnostics.Contracts;
    using System.Globalization;
    using System.Runtime.CompilerServices;

    using GW2NET.Common;
    using GW2NET.Entities.Worlds;
    using GW2NET.V2.Worlds;

    public sealed class FactoryForV2Worlds : FactoryBase
    {
        /// <summary>Initializes a new instance of the <see cref="FactoryBase"/> class.</summary>
        /// <param name="serviceClient">The service client.</param>
        public FactoryForV2Worlds(IServiceClient serviceClient)
            : base(serviceClient)
        {
            Contract.Requires(serviceClient != null);
        }

        [IndexerName("Language")]
        public IRepository<int, World> this[string language]
        {
            get
            {
                Contract.Ensures(Contract.Result<IRepository<int, World>>() != null);
                return new WorldRepository(this.ServiceClient) { Culture = new CultureInfo(language) };
            }
        }

        public IRepository<int, World> Default
        {
            get
            {
                Contract.Ensures(Contract.Result<IRepository<int, World>>() != null);
                return new WorldRepository(this.ServiceClient);
            }
        }

        public IRepository<int, World> ForCurrentCulture
        {
            get
            {
                Contract.Ensures(Contract.Result<IRepository<int, World>>() != null);
                return this[CultureInfo.CurrentCulture.TwoLetterISOLanguageName];
            }
        }

        public IRepository<int, World> ForCurrentUICulture
        {
            get
            {
                Contract.Ensures(Contract.Result<IRepository<int, World>>() != null);
                return this[CultureInfo.CurrentUICulture.TwoLetterISOLanguageName];
            }
        }
    }
}
