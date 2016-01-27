#include "Tank.h"
#include <conio.h>




using namespace std;
int main()
{
	srand(time(NULL));

	Tank MC_1("MC_1");
	MC_1.ShowDetail();


	_getch();
	return 0;
}