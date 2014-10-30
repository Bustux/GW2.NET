﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ConverterForCollectionPageResponse.cs" company="GW2.NET Coding Team">
//   This product is licensed under the GNU General Public License version 2 (GPLv2) as defined on the following page: http://www.gnu.org/licenses/gpl-2.0.html
// </copyright>
// <summary>
//   Converts objects of type <see cref="IResponse{T}" /> to objects of type <see cref="ICollectionPage{T}" />.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace GW2NET.V2.Common
{
    using System.Collections.Generic;
    using System.Linq;

    using GW2NET.Common;

    /// <summary>Converts objects of type <see cref="IResponse{T}"/> to objects of type <see cref="ICollectionPage{T}"/>.</summary>
    /// <typeparam name="TDataContract">The type of data contracts in the response content.</typeparam>
    /// <typeparam name="TValue">The type of the converted values.</typeparam>
    internal sealed class ConverterForCollectionPageResponse<TDataContract, TValue> : IConverter<IResponse<ICollection<TDataContract>>, ICollectionPage<TValue>>
    {
        /// <summary>Infrastructure. Holds a reference to a type converter.</summary>
        private readonly IConverter<TDataContract, TValue> converterForDataContract;

        /// <summary>Initializes a new instance of the <see cref="ConverterForCollectionPageResponse{TDataContract,TValue}"/> class.</summary>
        /// <param name="converterForDataContract">The converter for <typeparamref name="TDataContract"/>.</param>
        internal ConverterForCollectionPageResponse(IConverter<TDataContract, TValue> converterForDataContract)
        {
            this.converterForDataContract = converterForDataContract;
        }

        /// <inheritdoc />
        ICollectionPage<TValue> IConverter<IResponse<ICollection<TDataContract>>, ICollectionPage<TValue>>.Convert(IResponse<ICollection<TDataContract>> value)
        {
            var dataContracts = value.Content;
            if (dataContracts == null)
            {
                return new CollectionPage<TValue>(0);
            }

            var page = new CollectionPage<TValue>(dataContracts.Count) { PageSize = value.GetPageSize(), PageCount = value.GetPageTotal(), SubtotalCount = value.GetResultCount(), TotalCount = value.GetResultTotal() };

            page.AddRange(dataContracts.Select(this.converterForDataContract.Convert));

            foreach (var localizableItem in page.OfType<ILocalizable>())
            {
                localizableItem.Culture = value.Culture;
            }

            return page;
        }
    }
}