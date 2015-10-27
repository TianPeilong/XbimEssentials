// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
using Xbim.Ifc4.GeometryResource;
using System;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.ProfileResource;

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcArbitraryProfileDefWithVoids
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcArbitraryProfileDefWithVoids : IIfcArbitraryClosedProfileDef
	{
		IEnumerable<IIfcCurve> @InnerCurves { get; }
		
	}
}

namespace Xbim.Ifc4.ProfileResource
{
	[ExpressType("IFCARBITRARYPROFILEDEFWITHVOIDS", 416)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcArbitraryProfileDefWithVoids : IfcArbitraryClosedProfileDef, IInstantiableEntity, IIfcArbitraryProfileDefWithVoids, IEqualityComparer<@IfcArbitraryProfileDefWithVoids>, IEquatable<@IfcArbitraryProfileDefWithVoids>
	{
		#region IIfcArbitraryProfileDefWithVoids explicit implementation
		IEnumerable<IIfcCurve> IIfcArbitraryProfileDefWithVoids.InnerCurves { get { return @InnerCurves; } }	
	
	 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcArbitraryProfileDefWithVoids(IModel model) : base(model) 		{ 
			Model = model; 
			_innerCurves = new ItemSet<IfcCurve>( this, 0 );
		}

		#region Explicit attribute fields
		private ItemSet<IfcCurve> _innerCurves;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 1, -1)]
		public ItemSet<IfcCurve> @InnerCurves 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _innerCurves;
				((IPersistEntity)this).Activate(false);
				return _innerCurves;
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
					if (_innerCurves == null) _innerCurves = new ItemSet<IfcCurve>( this );
					_innerCurves.InternalAdd((IfcCurve)value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*WR1:	WR1 : SELF\IfcProfileDef.ProfileType = AREA;*/
		/*WR2:	WR2 : SIZEOF(QUERY(temp <* InnerCurves | temp.Dim <> 2)) = 0;*/
		/*WR3:	WR3 : SIZEOF(QUERY(temp <* InnerCurves | 'IFC4.IFCLINE' IN TYPEOF(temp))) = 0;*/
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcArbitraryProfileDefWithVoids other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcArbitraryProfileDefWithVoids
            var root = (@IfcArbitraryProfileDefWithVoids)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcArbitraryProfileDefWithVoids left, @IfcArbitraryProfileDefWithVoids right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcArbitraryProfileDefWithVoids left, @IfcArbitraryProfileDefWithVoids right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcArbitraryProfileDefWithVoids x, @IfcArbitraryProfileDefWithVoids y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcArbitraryProfileDefWithVoids obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}