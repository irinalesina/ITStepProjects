#pragma once
#include <string>


using namespace std;

class Animal
{
protected:
	string name;
public:
	//конструктор
	Animal(string name_) {} //передача параметров конструктора
	//деструктор
	~Animal() {}
	virtual void Voice() {} /* метод помечаем как виртуальный( динамический - адрес метода задается не изначально
						  (не известен на этапе компиляции), а в процессе работы) */
};

