#include "AnalizeFunction.h"
#include <stdexcept>
#include <vector>



//AnalizeFunction::AnalizeFunction(Func name)
//{
//}


std::vector<double> AnalizeFunction::MinFunc(double begin, double end)
{
	if (end <= begin)
		throw std::invalid_argument("Error in MinFunc: end <= begin!\n");
	
	double step = 1;
	double min = func_name(begin);

	std::vector<double> result;
	result.push_back(begin);

	// 


	for (double x = begin; x <= end; x += step)
	{
		double next = func_name(x);
		if (min > next)
		{
			result.clear();
			min = next;
			result.push_back(x);
		}
		else if (min == next)
			result.push_back(x);
		
	}
	return result;
}



//double AnalizeFunction::MaxFunc(double begin, double end)
//{
//	if (end <= begin)
//		throw std::invalid_argument("Error in MaxFunc: end <= begin!\n");
//	double step = (end - begin) / 100;
//
//}



