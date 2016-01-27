// MathFuncsDll.cpp : Defines the exported functions for the DLL application.

#include "MyDLL.h"
#include <stdexcept>

using namespace std;

int MultiplyByTen(int numb)
{
	int res = numb * 10;
	return res;
}
