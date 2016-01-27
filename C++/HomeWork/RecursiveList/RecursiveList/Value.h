#pragma once
#include <list>



class Value
{
public:
	virtual ~Value() {}
	virtual void Print() = 0;
};

