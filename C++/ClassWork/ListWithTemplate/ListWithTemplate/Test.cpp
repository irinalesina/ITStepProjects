#include "List.h"
#include <iostream>
#include <conio.h>
#include <new>



using namespace std;
int main()
{
	List<int> list_int;
	for (int i = 0; i < 7; i++)
		list_int.PushFront(i);
	for (int i = 0; i < 7; i++)
		cout << list_int[i] << ' ';
		
	_getch();
	return 0;
}
