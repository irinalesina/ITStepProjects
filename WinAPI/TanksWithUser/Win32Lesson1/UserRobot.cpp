#include "stdafx.h"
#include "UserRobot.h"


//void makeDecision(){}

void UserRobot::Draw(HDC hdc) {

	//COLORREF qRobotColor = RGB(0, 200, 200);
	//HPEN hLinePen = CreatePen(PS_SOLID, 5, qUserColor);
	HPEN hPenOld = (HPEN)SelectObject(hdc, line::pen5);
	MoveToEx(hdc, x, y, nullptr);

	// drow robot
	// circle
	Ellipse(hdc, x - robot_radius, y - robot_radius, x + robot_radius, y + robot_radius);

	//COLORREF qDethColor = RGB(255, 140, 0);
	//hLinePen = CreatePen(PS_SOLID, 3, qDethColor);
	hPenOld = (HPEN)SelectObject(hdc, line::pen2);
	MoveToEx(hdc, x - 10, y - 15, nullptr);
	LineTo(hdc, x + 10, y - 15);

	//COLORREF qLifeColor = RGB(50, 205, 50);
	//hLinePen = CreatePen(PS_SOLID, 3, qLifeColor);
	hPenOld = (HPEN)SelectObject(hdc, line::pen3);
	MoveToEx(hdc, x - 10, y - 15, nullptr);
	int xxx = (robot_energy - energy) / 100 * 2;
	LineTo(hdc, (x + 10) - xxx, y - 15);

	//LineTo(hdc, x2, y2);
	// text
	TCHAR str[1000];
	wsprintf(str, TEXT("Robot id %d : energy - %d."), id, energy);
	TextOut(hdc, 10, arenaXSize + (line::indent += 20), str, wcslen(str));
}