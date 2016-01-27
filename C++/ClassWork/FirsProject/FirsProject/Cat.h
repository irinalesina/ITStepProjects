#pragma once //файл будет подключен только один раз
#include "Animal.h"
#include <string>


class Cat : public Animal //кот наследован от животного
{
public:
	Cat(string name_); //конструктор с параметром для кота
	void Voice();
};




