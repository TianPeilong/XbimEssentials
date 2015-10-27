// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
using System;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.PropertyResource;

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcExtendedProperties
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcExtendedProperties : IIfcPropertyAbstraction
	{
		IfcIdentifier? @Name { get; }
		IfcText? @Description { get; }
		IEnumerable<IIfcProperty> @Properties { get; }
		
	}
}

namespace Xbim.Ifc4.PropertyResource
{
	[ExpressType("IFCEXTENDEDPROPERTIES", 631)]
	// ReSharper disable once PartialTypeWithSinglePart
	public abstract partial class @IfcExtendedProperties : IfcPropertyAbstraction, IIfcExtendedProperties, IEqualityComparer<@IfcExtendedProperties>, IEquatable<@IfcExtendedProperties>
	{
		#region IIfcExtendedProperties explicit implementation
		IfcIdentifier? IIfcExtendedProperties.Name { get { return @Name; } }	
		IfcText? IIfcExtendedProperties.Description { get { return @Description; } }	
		IEnumerable<IIfcProperty> IIfcExtendedProperties.Properties { get { return @Properties; } }	
	
	 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcExtendedProperties(IModel model) : base(model) 		{ 
			Model = model; 
			_properties = new ItemSet<IfcProperty>( this, 0 );
		}

		#region Explicit attribute fields
		private IfcIdentifier? _name;
		private IfcText? _description;
		private ItemSet<IfcProperty> _properties;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcIdentifier? @Name 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _name;
				((IPersistEntity)this).Activate(false);
				return _name;
			} 
			set
			{
				SetValue( v =>  _name = v, _name, value,  "Name");
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcText? @Description 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _description;
				((IPersistEntity)this).Activate(false);
				return _description;
			} 
			set
			{
				SetValue( v =>  _description = v, _description, value,  "Description");
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 1, -1)]
		public ItemSet<IfcProperty> @Properties 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _properties;
				((IPersistEntity)this).Activate(false);
				return _properties;
			} 
		}	
		#endregion




		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_name = value.StringVal;
					return;
				case 1: 
					_description = value.StringVal;
					return;
				case 2: 
					if (_properties == null) _properties = new ItemSet<IfcProperty>( this );
					_properties.InternalAdd((IfcProperty)value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
			return "";
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcExtendedProperties other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcExtendedProperties
            var root = (@IfcExtendedProperties)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcExtendedProperties left, @IfcExtendedProperties right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcExtendedProperties left, @IfcExtendedProperties right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcExtendedProperties x, @IfcExtendedProperties y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcExtendedProperties obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}