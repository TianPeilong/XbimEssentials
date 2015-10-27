// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.ProfileResource;
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
    /// Readonly interface for IfcExtrudedAreaSolidTapered
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcExtrudedAreaSolidTapered : IIfcExtrudedAreaSolid
	{
		IIfcProfileDef @EndSweptArea { get; }
		
	}
}

namespace Xbim.Ifc4.GeometricModelResource
{
	[ExpressType("IFCEXTRUDEDAREASOLIDTAPERED", 641)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcExtrudedAreaSolidTapered : IfcExtrudedAreaSolid, IInstantiableEntity, IIfcExtrudedAreaSolidTapered, IEqualityComparer<@IfcExtrudedAreaSolidTapered>, IEquatable<@IfcExtrudedAreaSolidTapered>
	{
		#region IIfcExtrudedAreaSolidTapered explicit implementation
		IIfcProfileDef IIfcExtrudedAreaSolidTapered.EndSweptArea { get { return @EndSweptArea; } }	
	
	 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcExtrudedAreaSolidTapered(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcProfileDef _endSweptArea;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(5, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcProfileDef @EndSweptArea 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _endSweptArea;
				((IPersistEntity)this).Activate(false);
				return _endSweptArea;
			} 
			set
			{
				SetValue( v =>  _endSweptArea = v, _endSweptArea, value,  "EndSweptArea");
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
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 4: 
					_endSweptArea = (IfcProfileDef)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*CorrectProfileAssignment:	CorrectProfileAssignment : IfcTaperedSweptAreaProfiles(SELF\IfcSweptAreaSolid.SweptArea, SELF.EndSweptArea);*/
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcExtrudedAreaSolidTapered other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcExtrudedAreaSolidTapered
            var root = (@IfcExtrudedAreaSolidTapered)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcExtrudedAreaSolidTapered left, @IfcExtrudedAreaSolidTapered right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcExtrudedAreaSolidTapered left, @IfcExtrudedAreaSolidTapered right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcExtrudedAreaSolidTapered x, @IfcExtrudedAreaSolidTapered y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcExtrudedAreaSolidTapered obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}