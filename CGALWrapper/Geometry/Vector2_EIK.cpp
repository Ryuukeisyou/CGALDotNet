#include "Vector2_EIK.h"
#include <CGAL/Vector_2.h>
#include <CGAL/Cartesian_converter.h>

typedef EIK::FT FT;
typedef CGAL::Vector_2<EIK> Vector2;

void* Vector2_EIK_Create()
{
	return new Vector2();
}

void* Vector2_EIK_CreateFromVector(const Vector2d& point)
{
	auto p = point.ToCGAL<EIK>();
	return new Vector2(p.x(), p.y());
}

void Vector2_EIK_Release(void* ptr)
{
	auto obj = static_cast<Vector2*>(ptr);
	if (obj != nullptr)
	{
		delete obj;
		obj = nullptr;
	}
}

Vector2* CastToVector2(void* ptr)
{
	return static_cast<Vector2*>(ptr);
}

double Vector2_EIK_GetX(void* ptr)
{
	auto p = CastToVector2(ptr);
	return CGAL::to_double(p->x());
}

double Vector2_EIK_GetY(void* ptr)
{
	auto p = CastToVector2(ptr);
	return CGAL::to_double(p->y());
}

void Vector2_EIK_SetX(void* ptr, double x)
{
	auto p = CastToVector2(ptr);
	(*p) = Vector2(x, p->y());
}

void Vector2_EIK_SetY(void* ptr, double y)
{
	auto p = CastToVector2(ptr);
	(*p) = Vector2(p->x(), y);
}

double Vector2_EIK_SqrLength(void* ptr)
{
	auto p = CastToVector2(ptr);
	return CGAL::to_double(p->squared_length());
}

void* Vector2_EIK_Perpendicular(void* ptr, CGAL::Orientation orientation)
{
	auto p = CastToVector2(ptr);
	auto v = new Vector2();
	(*v) = p->perpendicular(orientation);
	return v;
}

void Vector2_EIK_Normalize(void* ptr)
{
	auto p = CastToVector2(ptr);
	auto sq_len = CGAL::to_double(p->squared_length());

	if (sq_len == 0) return;

	auto len = CGAL::sqrt(sq_len);

	(*p) = Vector2(p->x() / len, p->y() / len);
}

double Vector2_EIK_Magnitude(void* ptr)
{
	auto p = CastToVector2(ptr);
	auto sq_len = CGAL::to_double(p->squared_length());

	if (sq_len == 0) return 0;
	return CGAL::sqrt(sq_len);
}

void* Vector2_EIK_Copy(void* ptr)
{
	auto v = CastToVector2(ptr);
	auto v2 = new Vector2();

	(*v2) = *v;
	return v2;
}

void* Vector2_EIK_Convert(void* ptr)
{
	typedef CGAL::Cartesian_converter<EIK, EEK> Converter;
	Converter convert;

	auto p = CastToVector2(ptr);
	auto x = convert(p->x());
	auto y = convert(p->y());

	return new CGAL::Vector_2<EEK>(x, y);
}
