#include "Animal.h"
#include <iostream>

using namespace std;

Animal::Animal(string name_)
{
	name = name_;//присваивания преданного парамера конструктору полю name
	cout << "New animal " << name << " is created!\n";
}


Animal::~Animal()
{
	cout << "New animal is dead!\n";
}


void Animal::Voice()
{
	
}