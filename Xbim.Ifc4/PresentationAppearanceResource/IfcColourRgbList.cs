// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.PresentationDefinitionResource;
using Xbim.Ifc4.MeasureResource;
using System;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.PresentationAppearanceResource;

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcColourRgbList
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcColourRgbList : IIfcPresentationItem
	{
		IEnumerable<IEnumerable<IfcNormalisedRatioMeasure>> @ColourList { get; }
		
	}
}

namespace Xbim.Ifc4.PresentationAppearanceResource
{
	[ExpressType("IFCCOLOURRGBLIST", 491)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcColourRgbList : IfcPresentationItem, IInstantiableEntity, IIfcColourRgbList, IEqualityComparer<@IfcColourRgbList>, IEquatable<@IfcColourRgbList>
	{
		#region IIfcColourRgbList explicit implementation
		IEnumerable<IEnumerable<IfcNormalisedRatioMeasure>> IIfcColourRgbList.ColourList { get { return @ColourList; } }	
	
	 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcColourRgbList(IModel model) : base(model) 		{ 
			Model = model; 
			_colourList = new ItemSet<ItemSet<IfcNormalisedRatioMeasure>>( this, 0 );
		}

		#region Explicit attribute fields
		private ItemSet<ItemSet<IfcNormalisedRatioMeasure>> _colourList;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.List, EntityAttributeType.List, 1, -1)]
		public ItemSet<ItemSet<IfcNormalisedRatioMeasure>> @ColourList 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _colourList;
				((IPersistEntity)this).Activate(false);
				return _colourList;
			} 
		}	
		#endregion




		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_colourList
						.InternalGetAt(nestedIndex[0])
						.InternalAdd((IfcNormalisedRatioMeasure)(value.RealVal));
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
        public bool Equals(@IfcColourRgbList other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcColourRgbList
            var root = (@IfcColourRgbList)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcColourRgbList left, @IfcColourRgbList right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcColourRgbList left, @IfcColourRgbList right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcColourRgbList x, @IfcColourRgbList y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcColourRgbList obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}