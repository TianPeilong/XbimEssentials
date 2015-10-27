// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.GeometryResource;
using Xbim.Ifc4.TopologyResource;
using System;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.GeometricModelResource;

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcShellBasedSurfaceModel
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcShellBasedSurfaceModel : IIfcGeometricRepresentationItem
	{
		IEnumerable<IfcShell> @SbsmBoundary { get; }
		
	}
}

namespace Xbim.Ifc4.GeometricModelResource
{
	[ExpressType("IFCSHELLBASEDSURFACEMODEL", 981)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcShellBasedSurfaceModel : IfcGeometricRepresentationItem, IInstantiableEntity, IIfcShellBasedSurfaceModel, IEqualityComparer<@IfcShellBasedSurfaceModel>, IEquatable<@IfcShellBasedSurfaceModel>
	{
		#region IIfcShellBasedSurfaceModel explicit implementation
		IEnumerable<IfcShell> IIfcShellBasedSurfaceModel.SbsmBoundary { get { return @SbsmBoundary; } }	
	
	 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcShellBasedSurfaceModel(IModel model) : base(model) 		{ 
			Model = model; 
			_sbsmBoundary = new ItemSet<IfcShell>( this, 0 );
		}

		#region Explicit attribute fields
		private ItemSet<IfcShell> _sbsmBoundary;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 1, -1)]
		public ItemSet<IfcShell> @SbsmBoundary 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _sbsmBoundary;
				((IPersistEntity)this).Activate(false);
				return _sbsmBoundary;
			} 
		}	
		#endregion




		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					if (_sbsmBoundary == null) _sbsmBoundary = new ItemSet<IfcShell>( this );
					_sbsmBoundary.InternalAdd((IfcShell)value.EntityVal);
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
        public bool Equals(@IfcShellBasedSurfaceModel other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcShellBasedSurfaceModel
            var root = (@IfcShellBasedSurfaceModel)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcShellBasedSurfaceModel left, @IfcShellBasedSurfaceModel right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcShellBasedSurfaceModel left, @IfcShellBasedSurfaceModel right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcShellBasedSurfaceModel x, @IfcShellBasedSurfaceModel y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcShellBasedSurfaceModel obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}