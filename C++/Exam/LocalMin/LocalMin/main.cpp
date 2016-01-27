/*2
Дан массив из целых чисел
найти в массиве числа, vtymit соседних
решить задачу, не используя циклы*/


#include <iostream>
#include <vector>
#include "LocalMinMax.h"



using namespace std;
void main()
{
	vector<int> source { 1, 5, 3, 4, 2, 8 };
	
	cout << "Local min:" << endl;
	
	for (auto it : LocalMin(source))
		cout << it << ' ';

	cout << endl;

	getc(stdin);
}

