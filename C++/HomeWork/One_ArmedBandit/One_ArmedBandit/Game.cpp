#include "Game.h"
#include <iostream>
#include <Windows.h>

using namespace std;

void Game::Play()
{
	unsigned int bet, winning;
	bet = current_player.MakeBet();
	current_machine.GetRate(bet);
	cout << "Your bet accepted!\n" << "Game started!\n";
	Sleep(1000);
	system("cls");
	winning = current_machine.Game();
	current_player.TakeProceeds(winning);
	cout << "Your cash " << current_player.GetCash() << "$\n";
}
