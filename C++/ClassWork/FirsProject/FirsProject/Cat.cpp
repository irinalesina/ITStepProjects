#include <iostream>
#include "Cat.h"


using namespace std;

void Cat::Voice()
{
	cout << "Cat " << name <<  " said Meow :)" << endl;
}

Cat::Cat(string name_): //наследование Cat от Animal
Animal(name_) //вызываем конструктор Animal, передавая ему параметр name_
{
	cout << "Cat " << name << " has opened its eyes!" << endl;
}