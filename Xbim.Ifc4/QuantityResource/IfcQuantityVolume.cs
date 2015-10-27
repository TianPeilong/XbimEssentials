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
using Xbim.Ifc4.QuantityResource;

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcQuantityVolume
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcQuantityVolume : IIfcPhysicalSimpleQuantity
	{
		IfcVolumeMeasure @VolumeValue { get; }
		IfcLabel? @Formula { get; }
		
	}
}

namespace Xbim.Ifc4.QuantityResource
{
	[ExpressType("IFCQUANTITYVOLUME", 876)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcQuantityVolume : IfcPhysicalSimpleQuantity, IInstantiableEntity, IIfcQuantityVolume, IEqualityComparer<@IfcQuantityVolume>, IEquatable<@IfcQuantityVolume>
	{
		#region IIfcQuantityVolume explicit implementation
		IfcVolumeMeasure IIfcQuantityVolume.VolumeValue { get { return @VolumeValue; } }	
		IfcLabel? IIfcQuantityVolume.Formula { get { return @Formula; } }	
	
	 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcQuantityVolume(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcVolumeMeasure _volumeValue;
		private IfcLabel? _formula;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcVolumeMeasure @VolumeValue 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _volumeValue;
				((IPersistEntity)this).Activate(false);
				return _volumeValue;
			} 
			set
			{
				SetValue( v =>  _volumeValue = v, _volumeValue, value,  "VolumeValue");
			} 
		}	
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLabel? @Formula 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _formula;
				((IPersistEntity)this).Activate(false);
				return _formula;
			} 
			set
			{
				SetValue( v =>  _formula = v, _formula, value,  "Formula");
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
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 3: 
					_volumeValue = value.RealVal;
					return;
				case 4: 
					_formula = value.StringVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*WR21:                (SELF\IfcPhysicalSimpleQuantity.Unit.UnitType = IfcUnitEnum.VOLUMEUNIT);*/
		/*WR22:	WR22 : VolumeValue >= 0.;*/
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcQuantityVolume other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcQuantityVolume
            var root = (@IfcQuantityVolume)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcQuantityVolume left, @IfcQuantityVolume right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcQuantityVolume left, @IfcQuantityVolume right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcQuantityVolume x, @IfcQuantityVolume y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcQuantityVolume obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}