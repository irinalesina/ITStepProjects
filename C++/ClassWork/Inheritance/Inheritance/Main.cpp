#include "Animals.h"
#include <iostream>
#include <conio.h>


using namespace std;
int main()
{
	Lupus yo;
	Bat man("man");
	Helicopter john;
	Flyers *fl[] = { &man, &john };

	_getch();
	return 0;
}