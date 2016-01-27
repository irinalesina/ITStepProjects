#include <iostream>
#include <numeric>
#include <vector>
#include <functional>
#include <algorithm>
#include <string>


// even numbers
bool Check(int x) { return (std::modulus<int>()(x, 2)); }


using namespace std;
/*
void main()
{
	vector<int> v{ -100, 1000, 123, 45, -2341, 2144 };
	int result = 0;
	int min_value = 1000;
	auto ch = Check;
	result = accumulate(v.begin(), v.end(), result, [min_value, ch](int x, int y)
	{ 
		if (ch(y))
			return x + y;
		return x;
	}
	);
	cout << result << endl;
	getc(stdin);
}
*/

void main()
{
	vector<int> v = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 15, 16, 17 };

	int amount_divided_3 = 0;
	int sum_simple = 0;

	// 1
	amount_divided_3 = count_if(v.begin(), v.end(), bind2nd(modulus<int>(), 3));
	amount_divided_3 = v.size() - amount_divided_3;
	cout << amount_divided_3 << endl;

	// 2
	vector<int> primes{2, 3, 5};
	sum_simple = accumulate(v.begin(), v.end(), sum_simple, [primes](int acc, int val)
	{
		auto it_begin = find(primes.begin(), primes.end(), val);
		if (it_begin == primes.end())
			it_begin = primes.begin();
		else
			it_begin++;
		if (count_if(it_begin, primes.end(), [val](int pr) {return !(val % pr); }))
			return acc;
		
		if (val != 1)
		{
			cout << val << endl;
			return (acc + val);
		}	
		return acc;
	});
	cout << "res = " << sum_simple << endl;

	// 3
	string result;
	result = accumulate(v.begin(), v.end(), result, [v](string res, int val)
	{
		auto temp = find(v.begin(), v.end(), val);
		temp++;
		res += to_string(val);
		if (temp != v.end())
			res += ';';
		return res;
	});
	cout << "{ " << result << " }" << endl;

	// 4
	struct Pair
	{
		vector<int> res;
		int pred;
		Pair() : pred(0){}
	};

	Pair numb_list;
	numb_list = accumulate(v.begin(), v.end(), numb_list, [v](Pair &acc, int val)
	{
		if (acc.pred == 0)
		{
			acc.pred = val;
			return acc;
		}
			
		if (val - acc.pred > 1 || val - acc.pred < 1)
		{
			acc.pred = val;
			acc.res.push_back(val);
			return acc;
		}
		acc.pred = val;
		return acc;
	});
	//output
	for (auto it : numb_list.res)
		cout << it << " ";
	cout << endl;

	getc(stdin);
}