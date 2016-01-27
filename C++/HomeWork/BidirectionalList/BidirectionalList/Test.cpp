#include "List.h"
#include <iostream>
#include <conio.h>
#include <new>



using namespace std;
int main()
{
	List a_int(sizeof(int));

	for (int i = 0; i < 7; i++)
		a_int.PushFront(&i);

	/*List::iterator p = a_int.find((void*)4);

	List::iterator q;

	for (; p != a_int.end(); ++p) {
		*p = (void*)8;
		cout << ((int)*p) << endl;
	}*/


	int size_a = a_int.GetElementCount();
	cout << "element count in a_int = " << size_a << endl;
	int b = 20;
	memcpy(a_int[6]->m_data, &b, sizeof(b));
	a_int.Reverse();
	for (int i = 0; i < size_a; i++)
		cout << *(int*)(a_int[i]->m_data) << ' ';

	_getch();
	return 0;
}