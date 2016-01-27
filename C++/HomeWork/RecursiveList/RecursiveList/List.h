#pragma once
#include "Value.h"
#include <vector>


using namespace std;
class List : public Value
{
private:
	vector<Value*> data;
public:
	List(initializer_list<Value*> l = {}) : data(l) {}
	~List();

	Value &operator[](int position);
	void Print();
};

