#include <iostream>
#include "Tree.h"
#include <conio.h>



using namespace std;
int main()
{
	Tree<int, int> example;
	for(int i = 0; i < 7; i++)
		example[i] = i * 10;

	example.Remove(3);

	for(int i = 0; i < 7; i++)
		cout << example[i] << endl;

	example[100];

	_getch();
	return 0;
}