﻿using System;
using System.Collections.Generic;
using Xbim.Common.Geometry;

namespace XbimGeometry.Interfaces
{
    /// <summary>
    /// Abstract class for all Xbim Geometry objects
    /// </summary>
    public interface IXbimGeometryObject : IDisposable
    {
        XbimGeometryObjectType GeometryType { get; }
        bool IsValid { get; }
        /// <summary>
        /// True if the geometry object is a collection
        /// </summary>
        bool IsSet { get; }
        XbimRect3D BoundingBox { get; }
        /// <summary>
        /// Returns a copy of the current object transformed by matrix3D, it is guranteed to return the same type as "this"
        /// </summary>
        /// <param name="matrix3D"></param>
        /// <returns></returns>
        IXbimGeometryObject Transform(XbimMatrix3D matrix3D);
        /// <summary>
        /// Returns a new version of the object transformed but does not perform a deepcopy, changes to this  will be reflected in the copy and vice versa
        /// </summary>
        /// <param name="matrix3D"></param>
        /// <returns></returns>
        IXbimGeometryObject TransformShallow(XbimMatrix3D matrix3D);

    }
}
