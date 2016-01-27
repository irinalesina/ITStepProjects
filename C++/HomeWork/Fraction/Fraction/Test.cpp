#include "Fraction.h"
#include <iostream>
#include <conio.h>



using namespace std;
int main()
{
	Fraction a;
	a.Input();
	//a.Output();
	a += 2;
	cout << a;
	_getch();
	return 0;
}


