#pragma once
#include <time.h>
#include <cstdlib>



class Drum
{
private:
	int *drum;
	unsigned int count, current;
	int time;
public:
	Drum() : drum(nullptr), count(0), current(rand() % 30) {}
	~Drum();

	void CreateDrum(int amount);
	void ShowBeforeCurrent();
	void ShowCurrent();
	void ShowAfterCurrent();
	void SetTime(int time_);
	void AddCurrent();
	int GetTime() { return time; }

	void ShowContent();

	int GetValueCurrent() { return drum[current]; }
};

