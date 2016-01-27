#pragma once
#include "Drum.h"



class GamingMachine
{
private:
	unsigned int cash;
	Drum drums[3];
	unsigned int rate;
	void ShowGame();
public:
	GamingMachine(unsigned int money);
	~GamingMachine() {}

	void GetRate(unsigned int sum)
	{
		rate = sum;
		cash += rate;
	}

	unsigned int Game();

	

};

