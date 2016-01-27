#pragma once
#include "Buddy.h"
#include <queue>



class CentralBank : public Buddy
{
private:
	queue<double> course;
	const int days = 5;
	// 2%
	const int min_limit = 0.98;
	const int max_limit = 1.02;
public:
	virtual void Act();
	CentralBank(Stock &st) : Buddy(st) {}

};

