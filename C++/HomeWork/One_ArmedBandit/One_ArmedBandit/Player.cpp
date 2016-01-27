#include "Player.h"
#include <iostream>



using namespace std;

unsigned int Player::MakeBet()
{
	unsigned int bet;
	do
	{
		cout << "Make your bet: ";
		cin >> bet;
		if (bet > cash)
			cout << "Your bet more than cash!\n";
	} while (bet > cash);
	cash -= bet;
	return bet;
}