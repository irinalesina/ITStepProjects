#include <cstdio>
#include "Cat.h"
#include "Dog.h"
#include "Animal.h"


int main()
{
	Cat thomas("Thomas");

	Dog chappy("Chappy");

	Animal *animals[2];
	animals[0] = &thomas;
	animals[1] = &chappy;

	for (int i = 0; i < 2; i++)
	{
		animals[i]->Voice();
	}
	
	//Animal vugluskr;

	getc(stdin);
	return 0;
}