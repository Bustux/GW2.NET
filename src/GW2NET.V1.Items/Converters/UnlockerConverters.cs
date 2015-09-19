﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GW2NET.V1.Items.Converters
{
    using System;
    
    using GW2NET.Common;
    using GW2NET.Items;
    using GW2NET.V1.Items;
    using GW2NET.V1.Items.Json;

    public sealed partial class UnlockerConverter : IConverter<ItemDTO, Unlocker>
	{
	    private readonly ITypeConverterFactory<ItemDTO, Unlocker> converterFactory;

		public UnlockerConverter(ITypeConverterFactory<ItemDTO, Unlocker> converterFactory)
		{
		    if (converterFactory == null)
    		{
    		    throw new ArgumentNullException("converterFactory");
    		}

		    this.converterFactory = converterFactory;
		}

		 /// <inheritdoc />
        Unlocker IConverter<ItemDTO, Unlocker>.Convert(ItemDTO value, object state)
		{
		    if (value == null)
    		{
    		    throw new ArgumentNullException("value");
    		}

			string discriminator = value.Consumable == null ? null : value.Consumable.UnlockType;
			var converter = this.converterFactory.Create(discriminator);
			var entity = converter.Convert(value, value);
			this.Merge(entity, value, state);
			return entity;
		}

		// Implement this method in a buddy class to set properties that are specific to 'Unlocker' (if any)
    	partial void Merge(Unlocker entity, ItemDTO dto, object state);

		/*
		// Use this template
		public partial class UnlockerConverter
		{
		    partial void Merge(Unlocker entity, ItemDTO dto, object state)
			{
			    throw new NotImplementedException();
			}
		}
		*/
	}

#region BagSlotUnlocker
    /// <summary>Converts objects of type <see cref="ItemDTO"/> to objects of type <see cref="BagSlotUnlocker"/>.</summary>
    public sealed partial class BagSlotUnlockerConverter : IConverter<ItemDTO, BagSlotUnlocker>
    {
	    /// <inheritdoc />
        public BagSlotUnlocker Convert(ItemDTO value, object state)
        {    
    		var entity = new BagSlotUnlocker();
            this.Merge(entity, value, state);
    		return entity;
        }
    
    	// Implement this method in a buddy class to set properties that are specific to 'BagSlotUnlocker' (if any)
    	partial void Merge(BagSlotUnlocker entity, ItemDTO dto, object state);

		/*
		// Use this template
		public partial class BagSlotUnlockerConverter
		{
		    partial void Merge(BagSlotUnlocker entity, ItemDTO dto, object state)
			{
			    throw new NotImplementedException();
			}
		}
		*/
    }
#endregion

#region BankTabUnlocker
    /// <summary>Converts objects of type <see cref="ItemDTO"/> to objects of type <see cref="BankTabUnlocker"/>.</summary>
    public sealed partial class BankTabUnlockerConverter : IConverter<ItemDTO, BankTabUnlocker>
    {
	    /// <inheritdoc />
        public BankTabUnlocker Convert(ItemDTO value, object state)
        {    
    		var entity = new BankTabUnlocker();
            this.Merge(entity, value, state);
    		return entity;
        }
    
    	// Implement this method in a buddy class to set properties that are specific to 'BankTabUnlocker' (if any)
    	partial void Merge(BankTabUnlocker entity, ItemDTO dto, object state);

		/*
		// Use this template
		public partial class BankTabUnlockerConverter
		{
		    partial void Merge(BankTabUnlocker entity, ItemDTO dto, object state)
			{
			    throw new NotImplementedException();
			}
		}
		*/
    }
#endregion

#region CollectibleCapacityUnlocker
    /// <summary>Converts objects of type <see cref="ItemDTO"/> to objects of type <see cref="CollectibleCapacityUnlocker"/>.</summary>
    public sealed partial class CollectibleCapacityUnlockerConverter : IConverter<ItemDTO, CollectibleCapacityUnlocker>
    {
	    /// <inheritdoc />
        public CollectibleCapacityUnlocker Convert(ItemDTO value, object state)
        {    
    		var entity = new CollectibleCapacityUnlocker();
            this.Merge(entity, value, state);
    		return entity;
        }
    
    	// Implement this method in a buddy class to set properties that are specific to 'CollectibleCapacityUnlocker' (if any)
    	partial void Merge(CollectibleCapacityUnlocker entity, ItemDTO dto, object state);

		/*
		// Use this template
		public partial class CollectibleCapacityUnlockerConverter
		{
		    partial void Merge(CollectibleCapacityUnlocker entity, ItemDTO dto, object state)
			{
			    throw new NotImplementedException();
			}
		}
		*/
    }
#endregion

#region ContentUnlocker
    /// <summary>Converts objects of type <see cref="ItemDTO"/> to objects of type <see cref="ContentUnlocker"/>.</summary>
    public sealed partial class ContentUnlockerConverter : IConverter<ItemDTO, ContentUnlocker>
    {
	    /// <inheritdoc />
        public ContentUnlocker Convert(ItemDTO value, object state)
        {    
    		var entity = new ContentUnlocker();
            this.Merge(entity, value, state);
    		return entity;
        }
    
    	// Implement this method in a buddy class to set properties that are specific to 'ContentUnlocker' (if any)
    	partial void Merge(ContentUnlocker entity, ItemDTO dto, object state);

		/*
		// Use this template
		public partial class ContentUnlockerConverter
		{
		    partial void Merge(ContentUnlocker entity, ItemDTO dto, object state)
			{
			    throw new NotImplementedException();
			}
		}
		*/
    }
#endregion

#region CraftingRecipeUnlocker
    /// <summary>Converts objects of type <see cref="ItemDTO"/> to objects of type <see cref="CraftingRecipeUnlocker"/>.</summary>
    public sealed partial class CraftingRecipeUnlockerConverter : IConverter<ItemDTO, CraftingRecipeUnlocker>
    {
	    /// <inheritdoc />
        public CraftingRecipeUnlocker Convert(ItemDTO value, object state)
        {    
    		var entity = new CraftingRecipeUnlocker();
            this.Merge(entity, value, state);
    		return entity;
        }
    
    	// Implement this method in a buddy class to set properties that are specific to 'CraftingRecipeUnlocker' (if any)
    	partial void Merge(CraftingRecipeUnlocker entity, ItemDTO dto, object state);

		/*
		// Use this template
		public partial class CraftingRecipeUnlockerConverter
		{
		    partial void Merge(CraftingRecipeUnlocker entity, ItemDTO dto, object state)
			{
			    throw new NotImplementedException();
			}
		}
		*/
    }
#endregion

#region DyeUnlocker
    /// <summary>Converts objects of type <see cref="ItemDTO"/> to objects of type <see cref="DyeUnlocker"/>.</summary>
    public sealed partial class DyeUnlockerConverter : IConverter<ItemDTO, DyeUnlocker>
    {
	    /// <inheritdoc />
        public DyeUnlocker Convert(ItemDTO value, object state)
        {    
    		var entity = new DyeUnlocker();
            this.Merge(entity, value, state);
    		return entity;
        }
    
    	// Implement this method in a buddy class to set properties that are specific to 'DyeUnlocker' (if any)
    	partial void Merge(DyeUnlocker entity, ItemDTO dto, object state);

		/*
		// Use this template
		public partial class DyeUnlockerConverter
		{
		    partial void Merge(DyeUnlocker entity, ItemDTO dto, object state)
			{
			    throw new NotImplementedException();
			}
		}
		*/
    }
#endregion

#region UnknownUnlocker
    /// <summary>Converts objects of type <see cref="ItemDTO"/> to objects of type <see cref="UnknownUnlocker"/>.</summary>
    public sealed partial class UnknownUnlockerConverter : IConverter<ItemDTO, UnknownUnlocker>
    {
	    /// <inheritdoc />
        public UnknownUnlocker Convert(ItemDTO value, object state)
        {    
    		var entity = new UnknownUnlocker();
            this.Merge(entity, value, state);
    		return entity;
        }
    
    	// Implement this method in a buddy class to set properties that are specific to 'UnknownUnlocker' (if any)
    	partial void Merge(UnknownUnlocker entity, ItemDTO dto, object state);

		/*
		// Use this template
		public partial class UnknownUnlockerConverter
		{
		    partial void Merge(UnknownUnlocker entity, ItemDTO dto, object state)
			{
			    throw new NotImplementedException();
			}
		}
		*/
    }
#endregion

}
