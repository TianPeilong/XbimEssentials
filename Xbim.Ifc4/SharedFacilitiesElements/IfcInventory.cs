// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Kernel;
using Xbim.Ifc4.UtilityResource;
using Xbim.Ifc4.MeasureResource;
using Xbim.Ifc4.ActorResource;
using Xbim.Ifc4.DateTimeResource;
using Xbim.Ifc4.CostResource;
using System;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.SharedFacilitiesElements;

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcInventory
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcInventory : IIfcGroup
	{
		IfcInventoryTypeEnum? @PredefinedType { get; }
		IfcActorSelect @Jurisdiction { get; }
		IEnumerable<IIfcPerson> @ResponsiblePersons { get; }
		IfcDate? @LastUpdateDate { get; }
		IIfcCostValue @CurrentValue { get; }
		IIfcCostValue @OriginalValue { get; }
		
	}
}

namespace Xbim.Ifc4.SharedFacilitiesElements
{
	[ExpressType("IFCINVENTORY", 712)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcInventory : IfcGroup, IInstantiableEntity, IIfcInventory, IEqualityComparer<@IfcInventory>, IEquatable<@IfcInventory>
	{
		#region IIfcInventory explicit implementation
		IfcInventoryTypeEnum? IIfcInventory.PredefinedType { get { return @PredefinedType; } }	
		IfcActorSelect IIfcInventory.Jurisdiction { get { return @Jurisdiction; } }	
		IEnumerable<IIfcPerson> IIfcInventory.ResponsiblePersons { get { return @ResponsiblePersons; } }	
		IfcDate? IIfcInventory.LastUpdateDate { get { return @LastUpdateDate; } }	
		IIfcCostValue IIfcInventory.CurrentValue { get { return @CurrentValue; } }	
		IIfcCostValue IIfcInventory.OriginalValue { get { return @OriginalValue; } }	
	
	 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcInventory(IModel model) : base(model) 		{ 
			Model = model; 
			_responsiblePersons = new OptionalItemSet<IfcPerson>( this, 0 );
		}

		#region Explicit attribute fields
		private IfcInventoryTypeEnum? _predefinedType;
		private IfcActorSelect _jurisdiction;
		private OptionalItemSet<IfcPerson> _responsiblePersons;
		private IfcDate? _lastUpdateDate;
		private IfcCostValue _currentValue;
		private IfcCostValue _originalValue;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1)]
		public IfcInventoryTypeEnum? @PredefinedType 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _predefinedType;
				((IPersistEntity)this).Activate(false);
				return _predefinedType;
			} 
			set
			{
				SetValue( v =>  _predefinedType = v, _predefinedType, value,  "PredefinedType");
			} 
		}	
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcActorSelect @Jurisdiction 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _jurisdiction;
				((IPersistEntity)this).Activate(false);
				return _jurisdiction;
			} 
			set
			{
				SetValue( v =>  _jurisdiction = v, _jurisdiction, value,  "Jurisdiction");
			} 
		}	
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.Set, EntityAttributeType.Class, 1, -1)]
		public OptionalItemSet<IfcPerson> @ResponsiblePersons 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _responsiblePersons;
				((IPersistEntity)this).Activate(false);
				return _responsiblePersons;
			} 
		}	
		[EntityAttribute(9, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcDate? @LastUpdateDate 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _lastUpdateDate;
				((IPersistEntity)this).Activate(false);
				return _lastUpdateDate;
			} 
			set
			{
				SetValue( v =>  _lastUpdateDate = v, _lastUpdateDate, value,  "LastUpdateDate");
			} 
		}	
		[EntityAttribute(10, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcCostValue @CurrentValue 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _currentValue;
				((IPersistEntity)this).Activate(false);
				return _currentValue;
			} 
			set
			{
				SetValue( v =>  _currentValue = v, _currentValue, value,  "CurrentValue");
			} 
		}	
		[EntityAttribute(11, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcCostValue @OriginalValue 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _originalValue;
				((IPersistEntity)this).Activate(false);
				return _originalValue;
			} 
			set
			{
				SetValue( v =>  _originalValue = v, _originalValue, value,  "OriginalValue");
			} 
		}	
		#endregion




		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
				case 1: 
				case 2: 
				case 3: 
				case 4: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 5: 
                    _predefinedType = (IfcInventoryTypeEnum) System.Enum.Parse(typeof (IfcInventoryTypeEnum), value.EnumVal, true);
					return;
				case 6: 
					_jurisdiction = (IfcActorSelect)(value.EntityVal);
					return;
				case 7: 
					if (_responsiblePersons == null) _responsiblePersons = new OptionalItemSet<IfcPerson>( this );
					_responsiblePersons.InternalAdd((IfcPerson)value.EntityVal);
					return;
				case 8: 
					_lastUpdateDate = value.StringVal;
					return;
				case 9: 
					_currentValue = (IfcCostValue)(value.EntityVal);
					return;
				case 10: 
					_originalValue = (IfcCostValue)(value.EntityVal);
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
        public bool Equals(@IfcInventory other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcInventory
            var root = (@IfcInventory)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcInventory left, @IfcInventory right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcInventory left, @IfcInventory right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcInventory x, @IfcInventory y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcInventory obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}