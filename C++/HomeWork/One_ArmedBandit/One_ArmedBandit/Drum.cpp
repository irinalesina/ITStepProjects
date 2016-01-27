#include "Drum.h"
#include <algorithm>
#include <random>      
#include <chrono>
#include <iostream>
#include <cstdlib> 
#include <ctime> 



Drum::~Drum()
{
	if(count)
		delete [] drum;
}



void Drum::CreateDrum(int amount)
{
	count = amount;
	drum = new int[count];
	drum[0] = 1;
	int symbol = 1;
	for (int i = 1; i < count; i++)
	{
		// 10 %
		if(i > count / 10 && i <= count / 4)
			symbol = 0;
		// 25 %
		else if(i > count / 4 && i <= count * 4 / 10)
			symbol = 0;
		// 40 %
		else if(i > count * 4 / 10 && i <= count * 6 / 10)
			symbol = 0;
		// 60 %
		else if(i > count * 6 / 10 && i <= count * 8 / 10)
			symbol = 0;
		// 80 %
		else if(i > count * 8 / 10)
			symbol = 1;
		drum[i] = symbol;
	}

	std::random_shuffle(drum, drum + count - 1);
	//unsigned seed = std::chrono::system_clock::now().time_since_epoch().count();
	//shuffle(drum, drum + count - 1, std::default_random_engine(seed));
}


void Drum::ShowBeforeCurrent()
{
	if(current == 0)
		std::cout << drum[count - 1];
	else
		std::cout << drum[current - 1];
}

void Drum::ShowCurrent()
{
	std::cout << drum[current];
}

void Drum::ShowAfterCurrent()
{
	if(current == count - 1)
		std::cout << drum[0];
	else
		std::cout << drum[current + 1];
}




void Drum::SetTime(int time_)
{
	time = time_;
}


void Drum::AddCurrent()
{
	if(current == count - 1)
		current = 0;
	else
		current++;
}


void Drum::ShowContent()
{
	for (int i = 0; i < count; i++)
	{
		std::cout << drum[i] << ' ';
	}
	std::cout << std::endl;
}