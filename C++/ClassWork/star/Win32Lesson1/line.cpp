#include "line.h"
#include "stdafx.h"

HDC line::hdc;


void line::Draw()
{
	MoveToEx(hdc, x1, y1, nullptr);
	LineTo(hdc, x2, y2);
}