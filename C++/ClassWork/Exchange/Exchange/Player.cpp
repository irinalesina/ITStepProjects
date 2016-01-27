#include "Player.h"
#include <math.h>


void Player::Act()
{
	double rate, amount;
	if (rand() % 2) 
	{
		rate = stock.GetBuyRate() + ((double)rand() / RAND_MAX - 0.5) 
			* (stock.GetSellRate() - stock.GetBuyRate());
		amount = pow(10, rand() * 5.0 / RAND_MAX);
		stock.CreateBuyBet(rate, amount);
	}
	else
	{
		rate = stock.GetSellRate() + ((double)rand() / RAND_MAX - 0.5)
			* (stock.GetSellRate() - stock.GetBuyRate());
		amount = pow(10, rand() * 5.0 / RAND_MAX);
		stock.CreateSellBet(rate, amount);
	}
		
}