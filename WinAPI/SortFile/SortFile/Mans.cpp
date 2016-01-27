#include "Mans.h"
#include <list>
#include <algorithm>


std::vector<Man> Mans::mans;

void Mans::Sort()
{
	std::sort(mans.begin(), mans.end(), [](Man first, Man second)
	{
		if (first.first_name > second.first_name)
			return false;
		return true;
	}
	);
	return;
}