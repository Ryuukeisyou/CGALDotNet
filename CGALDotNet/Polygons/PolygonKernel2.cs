﻿using System;
using System.Collections.Generic;
using System.Text;

using CGALDotNet.Geometry;

namespace CGALDotNet.Polygons
{
    internal abstract class PolygonKernel2
    {
        internal PolygonKernel2()
        {

        }

        internal abstract string Name { get; }

        internal abstract IntPtr Create();

        internal abstract IntPtr CreateFromPoints(Point2d[] points, int startIndex, int count);

        internal abstract void Release(IntPtr ptr);

        internal abstract int Count(IntPtr ptr);

        internal abstract IntPtr Copy(IntPtr ptr);

        internal abstract void Clear(IntPtr ptr);

        internal abstract Point2d GetPoint(IntPtr ptr, int index);

        internal abstract void GetPoints(IntPtr ptr, Point2d[] points, int startIndex, int count);

        internal abstract void SetPoint(IntPtr ptr, int index, Point2d point);

        internal abstract void SetPoints(IntPtr ptr, Point2d[] points, int startIndex, int count);

        internal abstract void Reverse(IntPtr ptr);

        internal abstract bool IsSimple(IntPtr ptr);

        internal abstract bool IsConvex(IntPtr ptr);

        internal abstract CGAL_ORIENTATION Orientation(IntPtr ptr);

        internal abstract CGAL_ORIENTED_SIDE OrientedSide(IntPtr ptr, Point2d point);

        internal abstract double SignedArea(IntPtr ptr);
    }
}
