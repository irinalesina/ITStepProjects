#include "GamingMachine.h"
#include <iostream>
#include <windows.h>

GamingMachine::GamingMachine(unsigned int money)
{
	rate = 0;
	cash = money;
	for (int i = 0; i < 3; i++)
	{
		drums[i].CreateDrum(30);
		switch (i)
		{
		case 0:
		{
			drums[i].SetTime(3);
			break;
		}
		case 1:
		{
			drums[i].SetTime(5);
			break;
		}
		case 2:
		{
			drums[i].SetTime(9);
			break;
		}
		}
	}
}



unsigned int GamingMachine::Game()
{
	int result;
	ShowGame();
	if (drums[0].GetValueCurrent() == drums[1].GetValueCurrent() && 
		drums[0].GetValueCurrent() == drums[2].GetValueCurrent())
	{
		result = rate * 2;
		cash -= result;
		std::cout << "Congratulation, you win " << result << "$\n";
	}
	else
	{
		std::cout << "You are will lucky the next time!\n";
		result = 0;
	}
	return result;
}


void GamingMachine::ShowGame()
{
	int time = drums[2].GetTime();
	/*std::cout << time << std::endl;
	for (int i = 0; i < 3; i++)
	{
		drums[i].ShowContent();
	}*/
	
	// цикл по времени
	for (int k = 0; k <= time + 1; k++)
	{
		// цикл по выводу предыдущего текущего и следующего элементов
		for (int j = 0; j < 3; j++)
		{
			// перебор барабанов
			for (int i = 0; i < 3; i++)
			{
				std::cout << '|';
				switch (j)
				{
				case 0:
				{
					drums[i].ShowBeforeCurrent();
					break;
				}
				case 1:
				{
					drums[i].ShowCurrent();
					break;
				}
				case 2:
				{
					drums[i].ShowAfterCurrent();
					break;
				}
				}

			}
			std::cout << '|' << std::endl;
		}
		std::cout << std::endl;
		for (int p = 0; p < 3; p++)
		{
			if (k <= drums[p].GetTime())
				drums[p].AddCurrent();
		}
		Sleep(300);
		if (k != time + 1)
			system("cls");
	}
}