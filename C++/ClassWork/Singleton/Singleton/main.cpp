#include "Settings.h"
#include <iostream>
#include <conio.h>

using namespace std;
int main()
{

	cout << "Hello " << Settings::getInstance().getName() << endl;
	_getch();
	Settings::getInstance().save();
	return 0;
}