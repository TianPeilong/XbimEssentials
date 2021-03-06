﻿#region XbimHeader

// The eXtensible Building Information Modelling (xBIM) Toolkit
// Solution:    XbimComplete
// Project:     Xbim.Ifc
// Filename:    IfcFurnishingElement.cs
// Published:   01, 2012
// Last Edited: 9:04 AM on 20 12 2011
// (See accompanying copyright.rtf)

#endregion

#region Directives

using System;
using Xbim.XbimExtensions;

#endregion

namespace Xbim.Ifc2x3.ProductExtension
{
    /// <summary>
    ///   Generalization of all furniture related objects. Furnishing objects are characterized as being 
    ///   pre-manufactured and assembled on-site, or 
    ///   manufactured on-site (built-in) 
    ///   Thus furnishing elements can either be movable, or not (as the built-ins).
    /// </summary>
    /// <remarks>
    ///   Definition from IAI: Generalization of all furniture related objects. Furnishing objects are characterized as being 
    ///   pre-manufactured and assembled on-site, or 
    ///   manufactured on-site (built-in) 
    ///   Thus furnishing elements can either be movable, or not (as the built-ins).
    ///   HISTORY New entity in IFC Release 2x.
    ///   Geometry Use Definitions:
    ///   The geometric representation of IfcFurnishingElement is given by the IfcProductDefinitionShape, allowing multiple geometric representation. 
    ///   Local Placement
    ///   The local placement for IfcFurnishingElement is defined in its supertype IfcProduct. It is defined by the IfcLocalPlacement, which defines the local coordinate system that is referenced by all geometric representations. 
    ///   The PlacementRelTo relationship of IfcLocalPlacement shall point (if given) to the local placement of the same IfcSpatialStructureElement , which is used in the ContainedInStructure inverse attribute, or to a spatial structure element at a higher level, referenced by that. 
    ///   If the relative placement is not used, the absolute placement is defined within the world coordinate system. 
    ///   SurfaceModel Representation
    ///   Any IfcFurnishingElement (so far no further constraints are defined at the level of its subtypes) may be represented as a single or multiple surface models, based on either shell or face based models. It is ensured by assigning the value 'SurfaceModel' to the RepresentationType attribute of IfcShapeRepresentation. In some cases it may be useful to also expose a simple representation as a bounding box representation of the same complex shape.
    ///   Brep Representation
    ///   Any IfcFurnishingElement (so far no further constraints are defined at the level of its subtypes) may be represented as a single or multiple Boundary Representation elements (which are restricted to faceted Brep with or without voids). The Brep representation allows for the representation of complex element shape. It is ensured by assigning the value 'Brep' to the RepresentationType attribute of IfcShapeRepresentation. In some cases it may be useful to also expose a simple representation as a bounding box representation of the same complex shape.
    ///   MappedRepresentation
    ///   The new mapped item, IfcMappedItem, should be used if appropriate as it allows for reusing the geometry definition of the equipment type at occurrences of the same equipement type. In this case the IfcShapeRepresentation.RepresentationType = MappedRepresentation is used.
    ///   EXPRESS specification:
    /// </remarks>
    [IfcPersistedEntityAttribute]
    public class IfcFurnishingElement : IfcElement
    {
    }
}