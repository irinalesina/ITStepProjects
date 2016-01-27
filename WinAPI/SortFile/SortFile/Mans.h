#pragma once
#include "Man.h"
#include <vector>


//typedef bool Compare(Man &a, Man &b);

class Mans
{
public:
	static std::vector<Man> mans;
public:
	//void Add(Man man);
	void Sort(/*Compare *func*/);
};
