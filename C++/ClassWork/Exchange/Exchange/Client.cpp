#include "Client.h"
#include <math.h>




void Client::Act()
{
	double amount, power;
	if ((stock.GetSellRate() / stock.GetBuyRate()) < 1.0001)
		power = 6,0;
	else
		power = 5.0;
	amount = pow(10, rand() * power / RAND_MAX);
	if (rand() % 2)
		stock.Buy(amount);
	else
		stock.Sell(amount);
}


