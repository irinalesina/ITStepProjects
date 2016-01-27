#pragma once
#include "GamingMachine.h"
#include "Player.h"




class Game
{
public:
	Player &current_player;
	GamingMachine &current_machine;
	Game(Player &player, GamingMachine &machine) :
		current_player(player), current_machine(machine) {}

	void Play();

};

