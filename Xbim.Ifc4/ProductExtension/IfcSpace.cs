// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.UtilityResource;
using Xbim.Ifc4.MeasureResource;
using Xbim.Ifc4.GeometricConstraintResource;
using Xbim.Ifc4.RepresentationResource;
using Xbim.Ifc4.SharedBldgElements;
using System;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.ProductExtension;

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcSpace
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcSpace : IIfcSpatialStructureElement, IfcSpaceBoundarySelect
	{
		IfcSpaceTypeEnum? @PredefinedType { get; }
		IfcLengthMeasure? @ElevationWithFlooring { get; }
		IEnumerable<IIfcRelCoversSpaces> @HasCoverings {  get; }
		IEnumerable<IIfcRelSpaceBoundary> @BoundedBy {  get; }
		
	}
}

namespace Xbim.Ifc4.ProductExtension
{
	[ExpressType("IFCSPACE", 993)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcSpace : IfcSpatialStructureElement, IInstantiableEntity, IIfcSpace, IEqualityComparer<@IfcSpace>, IEquatable<@IfcSpace>
	{
		#region IIfcSpace explicit implementation
		IfcSpaceTypeEnum? IIfcSpace.PredefinedType { get { return @PredefinedType; } }	
		IfcLengthMeasure? IIfcSpace.ElevationWithFlooring { get { return @ElevationWithFlooring; } }	
	
	 
		IEnumerable<IIfcRelCoversSpaces> IIfcSpace.HasCoverings {  get { return @HasCoverings; } }
		IEnumerable<IIfcRelSpaceBoundary> IIfcSpace.BoundedBy {  get { return @BoundedBy; } }
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcSpace(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcSpaceTypeEnum? _predefinedType;
		private IfcLengthMeasure? _elevationWithFlooring;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(10, EntityAttributeState.Optional, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1)]
		public IfcSpaceTypeEnum? @PredefinedType 
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
		[EntityAttribute(11, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLengthMeasure? @ElevationWithFlooring 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _elevationWithFlooring;
				((IPersistEntity)this).Activate(false);
				return _elevationWithFlooring;
			} 
			set
			{
				SetValue( v =>  _elevationWithFlooring = v, _elevationWithFlooring, value,  "ElevationWithFlooring");
			} 
		}	
		#endregion


		#region Inverse attributes
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, -1, -1)]
		public IEnumerable<IfcRelCoversSpaces> @HasCoverings 
		{ 
			get 
			{
				return Model.Instances.Where<IfcRelCoversSpaces>(e => (e.RelatingSpace as IfcSpace) == this);
			} 
		}
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, -1, -1)]
		public IEnumerable<IfcRelSpaceBoundary> @BoundedBy 
		{ 
			get 
			{
				return Model.Instances.Where<IfcRelSpaceBoundary>(e => (e.RelatingSpace as IfcSpace) == this);
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
				case 5: 
				case 6: 
				case 7: 
				case 8: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 9: 
                    _predefinedType = (IfcSpaceTypeEnum) System.Enum.Parse(typeof (IfcSpaceTypeEnum), value.EnumVal, true);
					return;
				case 10: 
					_elevationWithFlooring = value.RealVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*CorrectPredefinedType:                               ((PredefinedType = IfcSpaceTypeEnum.USERDEFINED) AND EXISTS (SELF\IfcObject.ObjectType));*/
		/*CorrectTypeAssigned:                                ('IFC4.IFCSPACETYPE' IN TYPEOF(SELF\IfcObject.IsTypedBy[1].RelatingType));*/
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcSpace other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcSpace
            var root = (@IfcSpace)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcSpace left, @IfcSpace right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcSpace left, @IfcSpace right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcSpace x, @IfcSpace y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcSpace obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}