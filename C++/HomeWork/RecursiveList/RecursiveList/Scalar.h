#pragma once
#include "Value.h"



class Scalar : public Value
{
private:
	int data;
public:
	Scalar(int value) : data(value) {}
	~Scalar();

	// pointer to int
	operator int();
	void Print();
};

