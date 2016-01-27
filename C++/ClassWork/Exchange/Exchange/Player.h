#pragma once
#include "Buddy.h"
#include "Stock.h"



class Player: public Buddy
{
public:
	Player(Stock &st) : Buddy(st) {}

	virtual void Act();
};

