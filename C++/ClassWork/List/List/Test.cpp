#include "List.h"
#include <iostream>
#include <conio.h>


using namespace std;
int main()
{
	List a, b;
	for (int i = 0; i < 7; i++)
	{
		a.PushFront(i);
	}

	size_t size_of_list = a.GetSize();
	cout << "Size = " << size_of_list << endl;

	for (size_t i = 0; i < size_of_list; i++)
	{
		cout << a[i]->data << endl;
	}
	b = a;
	cout << "size b = " << b.GetSize() << endl;
	b.Delete(2);
	cout << "new size b = " << b.GetSize() << endl;
	for (size_t i = 0; i < b.GetSize(); i++)
	{
		cout << b[i]->data << endl;
	}

	_getch();
	return 0;
}


