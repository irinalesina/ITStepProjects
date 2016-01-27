#include <stdio.h>
#include <stdlib.h>
#include <time.h>
#include "CalcRocketCount.h"
#include <conio.h>


int main()
{
	int i;
	srand(time(NULL));

	printf("%s", "Start!\n");
	for(i = 0; i < 10; i++)
	{
		CalcRocketCount();
	}
	printf("%s", "End!\n");

	_getch();
	return 1;
}