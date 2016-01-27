#pragma once
#include <vector>



//typedef double Func(double value);
typedef double Func(double value);

class AnalizeFunction
{
private:
	Func* func_name;
public:
	AnalizeFunction(Func* name) : func_name(name){}
	std::vector<double> MinFunc(double begin, double end);
	//double MaxFunc(double begin, double end);
	//~Function();
};

