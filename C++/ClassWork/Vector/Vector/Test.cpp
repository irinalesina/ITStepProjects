#include "Vector.h"
#include <conio.h>
#include <iostream>
#include "Sort.h"



int main()
{
	Vector<int> a{ 2, 3, 4 };
	a.PushFront(10);
	x<int>(std::cout, a);
	SortingBuble<Vector<int>::Iterator>(a.Begin(), a.End());
	x<int>(std::cout, a);
	//std::cout << a[3] << a[2] << a[1] << a[0] << std::endl;
	_getch();
	return 0;
}

