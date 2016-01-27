#include "LocalMinMax.h"
#include <vector>
#include <algorithm>


using namespace std;
vector<int> LocalMin(vector<int> &source)
{
	vector<int> result;

	if (!source.size())
		return result;

	int prev = NAN;
	int pred_prev = NAN;
	int check = 1;

	auto it = for_each(source.begin(), source.end(), [&result, &pred_prev, &prev, &check](int cur)
	{
		bool res = false;
		// check begin
		if (check > 2)
		{
			if (prev < pred_prev && prev < cur)
			{
				result.push_back(prev);
				res = true;
			}
		}
		else
			check++;

		pred_prev = prev;
		prev = cur;

		return res;
	});

	return result;
}
