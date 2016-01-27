#include <string>
#include "../../FirsProject/FirsProject/Animal.h"

using namespace std;



class Mammal: Animal
{
public:
	Mammal(string name) : Animal(name) {}
	virtual void Voice() {}
};


class Lupus : public Mammal
{
public:
	int n_teeth;
	Lupus() : n_teeth(42), Mammal("Yo shy") {}
};


class Flyers
{
public:
	virtual void Fly() {}
};


class Bat : public Mammal, public Flyers
{
public:
	Bat(string name) : Mammal(name), Flyers() {}
};


class Bird : public Animal, public Flyers
{
public:
	Bird(string name) : Animal(name), Flyers() {}
};


class Helicopter : public Flyers
{
public:
	Helicopter() : Flyers() {}
};