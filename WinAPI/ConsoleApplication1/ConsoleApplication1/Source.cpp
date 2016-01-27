#include <stdio.h>
#include <stdlib.h>
#include <math.h>
template <typename T1, typename T2, typename T3>
double number_string(T1 a, T2 b , T3  c)
{
	double dis = 0, x=0;
	dis = b*b - 4 * a*c;
	if (dis < 0)
	{
		printf("korney net\n");
		return;
	}
	else
	{
		x = (-b + sqrt(dis)) / 2a;


		return x;
	}

}
template <typename T1, typename T2>
double number_string(T1 a, T2 b)
{
	
	return -b/a;


}


int main()
{
	double a, b, c;
	printf("enter a b c");
	scanf("%g %g %g", &a, &b, &c);
	printf("%g  \n", number_string(a, b, c));

	system("pause");
	return 0;



}
