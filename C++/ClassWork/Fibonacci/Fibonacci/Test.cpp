#include <iostream>
#include "Fibonacci.h"
#include <conio.h>


using namespace std;
int main()
{
	Fibonacci a;
	for (int i = 0; i < 30; i++)
	{
		cout << a[i] << endl;
	}
	_getch();
	return 0;
}