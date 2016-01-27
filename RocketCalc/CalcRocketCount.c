#include "CalcRocketCount.h"
#include <math.h>
#include <stdlib.h>
#include <stdio.h>


const double C2 = 0.95;

int CalcRocketCount()
{
	int n;
	// p1 >= 0.8
	double C1, p, p1;
	int random;
	random = rand() % 101;
	p = random / 100.0;
	random = rand() % 21 + 80;
	p1 = random / 100.0;
	C1 = 1 - p * p1;

	n = 1 + (log(C2) / log(C1));

	printf("\np1 = %f;\np = %f;\nn = %d;\n\n", p1, p, n);

	return n;
}