#include "Matrix.h"
#include <iostream>
#include <conio.h>
#include <vector>

using namespace std;
int main()
{
	vector<vector<double>> q{ { 0, 0, 0 }, { 1, 0, 0 }, { 1, 1, 0 }, { 0, 1, 0 } };
	auto r = Matrix<double>::RotateY(0.01);


	for (auto v : q)
	{
		auto rotated = r * v;
		for (auto coord : rotated)
			cout << ' ' << coord;

		cout << "\n-----\n";
	}
	_getch();
	return 0;
}

