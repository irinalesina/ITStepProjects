#pragma once
#include "Animal.h"
#include <string>

class Dog: public Animal
{
public:
	Dog(string name_);
	void Voice();
};
