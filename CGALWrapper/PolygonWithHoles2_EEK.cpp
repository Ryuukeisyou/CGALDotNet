#include "pch.h"
#include "Util.h"
#include "PolygonWithHoles2_EEK.h"
#include "PolygonWithHoles2.h"

#include <CGAL/Boolean_set_operations_2.h>

void* PolygonWithHoles2_EEK_Create()
{
	return Util_Create<CGAL::Polygon_with_holes_2<EEK>>();
}

void PolygonWithHoles2_EEK_Release(void* ptr)
{
	Util_Release<CGAL::Polygon_with_holes_2<EEK>>(ptr);
}

int PolygonWithHoles2_EEK_HoleCount(void* ptr)
{
	return PolygonWithHoles2_HoleCount<EEK>(ptr);
}

int PolygonWithHoles2_EEK_PointCount(void* ptr, int index)
{
	return PolygonWithHoles2_PointCount<EEK>(ptr, index);
}

void* PolygonWithHoles2_EEK_Copy(void* ptr)
{
	return PolygonWithHoles2_Copy<EEK>(ptr);
}

void PolygonWithHoles2_EEK_Clear(void* ptr)
{
	PolygonWithHoles2_Clear<EEK>(ptr);
}

void PolygonWithHoles2_EEK_ClearBoundary(void* ptr)
{
	PolygonWithHoles2_ClearBoundary<EEK>(ptr);
}

void* PolygonWithHoles2_EEK_CreateFromPolygon(void* ptr)
{
	return PolygonWithHoles2_CreateFromPolygon<EEK>(ptr);
}

void* PolygonWithHoles2_EEK_CreateFromPoints(Point2d* points, int startIndex, int count)
{
	return PolygonWithHoles2_CreateFromPoints<EEK>(points, startIndex, count);
}

Point2d PolygonWithHoles2_EEK_GetPoint(void* ptr, int polyIndex, int pointIndex)
{
	return PolygonWithHoles2_GetPoint<EEK>(ptr, polyIndex, pointIndex);
}

void PolygonWithHoles2_EEK_GetPoints(void* ptr, Point2d* points, int polyIndex, int startIndex, int count)
{
	PolygonWithHoles2_GetPoints<EEK>(ptr, points, polyIndex, startIndex, count);
}

void PolygonWithHoles2_EEK_SetPoint(void* ptr, int polyIndex, int pointIndex, Point2d point)
{
	PolygonWithHoles2_SetPoint<EEK>(ptr, polyIndex, pointIndex, point);
}

void PolygonWithHoles2_EEK_SetPoints(void* ptr, Point2d* points, int polyIndex, int startIndex, int count)
{
	PolygonWithHoles2_SetPoints<EEK>(ptr, points, polyIndex, startIndex, count);
}

void PolygonWithHoles2_EEK_AddHoleFromPolygon(void* pwhPtr, void* polygonPtr)
{
	PolygonWithHoles2_AddHoleFromPolygon<EEK>(pwhPtr, polygonPtr);
}

void PolygonWithHoles2_EEK_RemoveHole(void* ptr, int index)
{
	PolygonWithHoles2_RemoveHole<EEK>(ptr, index);
}

void* PolygonWithHoles2_EEK_CopyPolygon(void* ptr, int index)
{
	return PolygonWithHoles2_CopyPolygon<EEK>(ptr, index);
}

void PolygonWithHoles2_EEK_ReversePolygon(void* ptr, int index)
{
	PolygonWithHoles2_ReversePolygon<EEK>(ptr, index);
}

bool PolygonWithHoles2_EEK_IsUnbounded(void* ptr)
{
	return PolygonWithHoles2_IsUnbounded<EEK>(ptr);
}

bool PolygonWithHoles2_EEK_IsSimple(void* ptr, int index)
{
	return PolygonWithHoles2_IsSimple<EEK>(ptr, index);
}

bool PolygonWithHoles2_EEK_IsConvex(void* ptr, int index)
{
	return PolygonWithHoles2_IsConvex<EEK>(ptr, index);
}

CGAL::Orientation PolygonWithHoles2_EEK_Orientation(void* ptr, int index)
{
	return PolygonWithHoles2_Orientation<EEK>(ptr, index);
}

CGAL::Oriented_side PolygonWithHoles2_EEK_OrientedSide(void* ptr, int index, Point2d point)
{
	return PolygonWithHoles2_OrientedSide<EEK>(ptr, index, point);
}

double PolygonWithHoles2_EEK_SignedArea(void* ptr, int index)
{
	return PolygonWithHoles2_SignedArea<EEK>(ptr, index);
}

void PolygonWithHoles2_EEK_Translate(void* ptr, int index, Point2d translation)
{
	PolygonWithHoles2_Translate<EEK>(ptr, index, translation);
}

void PolygonWithHoles2_EEK_Rotate(void* ptr, int index, double rotation)
{
	PolygonWithHoles2_Rotate<EEK>(ptr, index, rotation);
}

void PolygonWithHoles2_EEK_Scale(void* ptr, int index, double scale)
{
	PolygonWithHoles2_Scale<EEK>(ptr, index, scale);
}

void PolygonWithHoles2_EEK_Transform(void* ptr, int index, Point2d translation, double rotation, double scale)
{
	PolygonWithHoles2_Transform<EEK>(ptr, index, translation, rotation, scale);
}


