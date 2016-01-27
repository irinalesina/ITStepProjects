#pragma once
#include <ctime>
#include <cstdlib>
#include <sstream>




class Player
{
private:
	unsigned int cash;
public:
	Player(unsigned int sum) : cash(sum) {}
	~Player() {}
	
	unsigned int MakeBet();
	void TakeProceeds(unsigned int sum)
	{
		cash += sum;
	}
	void AddCash(unsigned int sum) { cash += sum; }

	unsigned int GetCash() { return cash; } 
};


