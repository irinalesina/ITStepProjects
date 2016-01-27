#include "Drum.h"
#include "GamingMachine.h"
#include "Player.h"
#include "Game.h"
#include <iostream>
#include <conio.h>




using namespace std;
int main()
{
	srand(time(NULL));
	int cash;
	do
	{
		std::cout << "Enter your cash: ";
		cin >> cash;
		if (cash <= 0)
			std::cout << "You enter invalid cash!\n";
	} while(cash <= 0);
		
	Player gamer(1000);
	GamingMachine machine(100000);
	Game one(gamer, machine);
	int game;
	do
	{
		one.Play();
		int answer;
		if (gamer.GetCash() == 0)
		{
			std::cout <<  "Your cash = 0\n" << "Do you want to add your cash!\n"
				"1 - yes\n"
				"0 - no\n";
			cin >> answer;
			if (answer == 1)
			{
				unsigned int sum;
				std::cout << "Enter summ ";
				cin >> sum;
				gamer.AddCash(sum);
			}
			else
				break;
		}
		std::cout << "Do you wont to play again?\n"
			"1 - yes\n"
			"0 - no\n";
		cin >> game;
	} while (game);
	std::cout << "Thanks for the game!\nCome again!\n";
	_getch();
	return 0;
}

