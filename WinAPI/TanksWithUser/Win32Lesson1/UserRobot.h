#pragma once
#include "InterfaceRobort.h"




class UserRobot: public InterfaceRobort
{
public:
	void makeDecision(){}
	void Draw(HDC hdc);

	UserRobot(double init_x, double init_y)
		: InterfaceRobort(init_x, init_y) {};
	
};

