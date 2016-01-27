#include <iostream>
#include <conio.h>
#include "header.h"




using namespace std;
int main()
{
	/*Vector<int> arr(2);
	arr[0] = 1;
	arr[1] = 2;
	cout << arr[0] << arr[1] << endl;
	*/

	Vector<Vector<int>> vv(3, Vector<int>(3, 0));
	cout << vv[0][0];
	_getch();
	return 0;
}