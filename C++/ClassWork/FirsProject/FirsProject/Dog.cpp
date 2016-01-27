#include <iostream>
#include "Dog.h"


using namespace std;

void Dog::Voice()
{
	cout << "Dog " << name << " said Woof :)" << endl;
}

Dog::Dog(string name_):
Animal(name_)
{
	cout << "Dog " << name << " has opened its eyes!" << endl;
}