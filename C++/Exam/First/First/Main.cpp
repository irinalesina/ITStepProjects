/*
   1
�����, � ����������� �������� ���������� �������(double name(double);)
����:
�������(������� ���������)
������ ������:
���������� ��� ���� ��-��
*/



#include <iostream>
#include "AnalizeFunction.h"
#include <cmath>


double MyFunc(double value);

using namespace std;
void main()
{
	
	AnalizeFunction test_func(MyFunc);
	
	cout << "Min value of func:" << endl;

	for (auto it : test_func.MinFunc(-2, 2))
		cout << it << ' ';
	cout << endl;



	getc(stdin);
}

double MyFunc(double value)
{
	double res;
	res = pow(pow(value, 2) - 4, 2);
	return res;
}
