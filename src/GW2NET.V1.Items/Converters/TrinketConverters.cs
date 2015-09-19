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

    public sealed partial class TrinketConverter : IConverter<ItemDTO, Trinket>
	{
	    private readonly ITypeConverterFactory<ItemDTO, Trinket> converterFactory;

		private TrinketConverter(ITypeConverterFactory<ItemDTO, Trinket> converterFactory)
		{
		    if (converterFactory == null)
    		{
    		    throw new ArgumentNullException("converterFactory");
    		}

		    this.converterFactory = converterFactory;
		}

		 /// <inheritdoc />
        Trinket IConverter<ItemDTO, Trinket>.Convert(ItemDTO value, object state)
		{
		    if (value == null)
    		{
    		    throw new ArgumentNullException("value");
    		}

			string discriminator = value.Trinket == null ? null : value.Trinket.Type;
			var converter = this.converterFactory.Create(discriminator);
			var entity = converter.Convert(value, value);
			this.Merge(entity, value, state);
			return entity;
		}

		// Implement this method in a buddy class to set properties that are specific to 'Trinket' (if any)
    	partial void Merge(Trinket entity, ItemDTO dto, object state);

		/*
		// Use this template
		public partial class TrinketConverter
		{
		    partial void Merge(Trinket entity, ItemDTO dto, object state)
			{
			    throw new NotImplementedException();
			}
		}
		*/
	}

#region Accessory
    /// <summary>Converts objects of type <see cref="ItemDTO"/> to objects of type <see cref="Accessory"/>.</summary>
    public sealed partial class AccessoryConverter : IConverter<ItemDTO, Accessory>
    {
	    /// <inheritdoc />
        public Accessory Convert(ItemDTO value, object state)
        {    
    		var entity = new Accessory();
            this.Merge(entity, value, state);
    		return entity;
        }
    
    	// Implement this method in a buddy class to set properties that are specific to 'Accessory' (if any)
    	partial void Merge(Accessory entity, ItemDTO dto, object state);

		/*
		// Use this template
		public partial class AccessoryConverter
		{
		    partial void Merge(Accessory entity, ItemDTO dto, object state)
			{
			    throw new NotImplementedException();
			}
		}
		*/
    }
#endregion

#region Amulet
    /// <summary>Converts objects of type <see cref="ItemDTO"/> to objects of type <see cref="Amulet"/>.</summary>
    public sealed partial class AmuletConverter : IConverter<ItemDTO, Amulet>
    {
	    /// <inheritdoc />
        public Amulet Convert(ItemDTO value, object state)
        {    
    		var entity = new Amulet();
            this.Merge(entity, value, state);
    		return entity;
        }
    
    	// Implement this method in a buddy class to set properties that are specific to 'Amulet' (if any)
    	partial void Merge(Amulet entity, ItemDTO dto, object state);

		/*
		// Use this template
		public partial class AmuletConverter
		{
		    partial void Merge(Amulet entity, ItemDTO dto, object state)
			{
			    throw new NotImplementedException();
			}
		}
		*/
    }
#endregion

#region Ring
    /// <summary>Converts objects of type <see cref="ItemDTO"/> to objects of type <see cref="Ring"/>.</summary>
    public sealed partial class RingConverter : IConverter<ItemDTO, Ring>
    {
	    /// <inheritdoc />
        public Ring Convert(ItemDTO value, object state)
        {    
    		var entity = new Ring();
            this.Merge(entity, value, state);
    		return entity;
        }
    
    	// Implement this method in a buddy class to set properties that are specific to 'Ring' (if any)
    	partial void Merge(Ring entity, ItemDTO dto, object state);

		/*
		// Use this template
		public partial class RingConverter
		{
		    partial void Merge(Ring entity, ItemDTO dto, object state)
			{
			    throw new NotImplementedException();
			}
		}
		*/
    }
#endregion

#region UnknownTrinket
    /// <summary>Converts objects of type <see cref="ItemDTO"/> to objects of type <see cref="UnknownTrinket"/>.</summary>
    public sealed partial class UnknownTrinketConverter : IConverter<ItemDTO, UnknownTrinket>
    {
	    /// <inheritdoc />
        public UnknownTrinket Convert(ItemDTO value, object state)
        {    
    		var entity = new UnknownTrinket();
            this.Merge(entity, value, state);
    		return entity;
        }
    
    	// Implement this method in a buddy class to set properties that are specific to 'UnknownTrinket' (if any)
    	partial void Merge(UnknownTrinket entity, ItemDTO dto, object state);

		/*
		// Use this template
		public partial class UnknownTrinketConverter
		{
		    partial void Merge(UnknownTrinket entity, ItemDTO dto, object state)
			{
			    throw new NotImplementedException();
			}
		}
		*/
    }
#endregion

}
