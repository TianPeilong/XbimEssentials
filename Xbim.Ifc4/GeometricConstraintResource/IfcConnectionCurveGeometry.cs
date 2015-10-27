// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.GeometricConstraintResource;

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcConnectionCurveGeometry
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcConnectionCurveGeometry : IIfcConnectionGeometry
	{
		IfcCurveOrEdgeCurve @CurveOnRelatingElement { get; }
		IfcCurveOrEdgeCurve @CurveOnRelatedElement { get; }
		
	}
}

namespace Xbim.Ifc4.GeometricConstraintResource
{
	[IndexedClass]
	[ExpressType("IFCCONNECTIONCURVEGEOMETRY", 510)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcConnectionCurveGeometry : IfcConnectionGeometry, IInstantiableEntity, IIfcConnectionCurveGeometry, IEqualityComparer<@IfcConnectionCurveGeometry>, IEquatable<@IfcConnectionCurveGeometry>
	{
		#region IIfcConnectionCurveGeometry explicit implementation
		IfcCurveOrEdgeCurve IIfcConnectionCurveGeometry.CurveOnRelatingElement { get { return @CurveOnRelatingElement; } }	
		IfcCurveOrEdgeCurve IIfcConnectionCurveGeometry.CurveOnRelatedElement { get { return @CurveOnRelatedElement; } }	
	
	 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcConnectionCurveGeometry(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcCurveOrEdgeCurve _curveOnRelatingElement;
		private IfcCurveOrEdgeCurve _curveOnRelatedElement;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcCurveOrEdgeCurve @CurveOnRelatingElement 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _curveOnRelatingElement;
				((IPersistEntity)this).Activate(false);
				return _curveOnRelatingElement;
			} 
			set
			{
				SetValue( v =>  _curveOnRelatingElement = v, _curveOnRelatingElement, value,  "CurveOnRelatingElement");
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcCurveOrEdgeCurve @CurveOnRelatedElement 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _curveOnRelatedElement;
				((IPersistEntity)this).Activate(false);
				return _curveOnRelatedElement;
			} 
			set
			{
				SetValue( v =>  _curveOnRelatedElement = v, _curveOnRelatedElement, value,  "CurveOnRelatedElement");
			} 
		}	
		#endregion




		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_curveOnRelatingElement = (IfcCurveOrEdgeCurve)(value.EntityVal);
					return;
				case 1: 
					_curveOnRelatedElement = (IfcCurveOrEdgeCurve)(value.EntityVal);
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
        public bool Equals(@IfcConnectionCurveGeometry other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcConnectionCurveGeometry
            var root = (@IfcConnectionCurveGeometry)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcConnectionCurveGeometry left, @IfcConnectionCurveGeometry right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcConnectionCurveGeometry left, @IfcConnectionCurveGeometry right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcConnectionCurveGeometry x, @IfcConnectionCurveGeometry y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcConnectionCurveGeometry obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}