// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.GeometryResource;
using Xbim.Ifc4.MeasureResource;
using System;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.GeometricModelResource;

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcRightCircularCone
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcRightCircularCone : IIfcCsgPrimitive3D
	{
		IfcPositiveLengthMeasure @Height { get; }
		IfcPositiveLengthMeasure @BottomRadius { get; }
		
	}
}

namespace Xbim.Ifc4.GeometricModelResource
{
	[ExpressType("IFCRIGHTCIRCULARCONE", 961)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcRightCircularCone : IfcCsgPrimitive3D, IInstantiableEntity, IIfcRightCircularCone, IEqualityComparer<@IfcRightCircularCone>, IEquatable<@IfcRightCircularCone>
	{
		#region IIfcRightCircularCone explicit implementation
		IfcPositiveLengthMeasure IIfcRightCircularCone.Height { get { return @Height; } }	
		IfcPositiveLengthMeasure IIfcRightCircularCone.BottomRadius { get { return @BottomRadius; } }	
	
	 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcRightCircularCone(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcPositiveLengthMeasure _height;
		private IfcPositiveLengthMeasure _bottomRadius;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveLengthMeasure @Height 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _height;
				((IPersistEntity)this).Activate(false);
				return _height;
			} 
			set
			{
				SetValue( v =>  _height = v, _height, value,  "Height");
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveLengthMeasure @BottomRadius 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _bottomRadius;
				((IPersistEntity)this).Activate(false);
				return _bottomRadius;
			} 
			set
			{
				SetValue( v =>  _bottomRadius = v, _bottomRadius, value,  "BottomRadius");
			} 
		}	
		#endregion




		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 1: 
					_height = value.RealVal;
					return;
				case 2: 
					_bottomRadius = value.RealVal;
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
        public bool Equals(@IfcRightCircularCone other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcRightCircularCone
            var root = (@IfcRightCircularCone)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcRightCircularCone left, @IfcRightCircularCone right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcRightCircularCone left, @IfcRightCircularCone right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcRightCircularCone x, @IfcRightCircularCone y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcRightCircularCone obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}