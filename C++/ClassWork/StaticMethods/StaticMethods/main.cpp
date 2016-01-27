#include "passport.h"
#include <iostream>
#include <conio.h>


using namespace std;
int main()
{
	int *x = new int[7]();
	for (int i = 0; i < 7; i++)
		cout << x[i] << ' ';
	delete[] x;
	_getch();
	return 0;
}