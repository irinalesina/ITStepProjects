#include <iostream>
#include <vector>
#include <list>
#include <iterator>
#include <sstream>



using namespace std;

template <class iter>
void BubbleSort(iter from, iter to);

template <class type>
string ToJSON(type source);


void main()
{
	list<int> my_list{ 5, 3, 7, 8, 1 };
	BubbleSort(my_list.begin(), my_list.end());
	for (auto it : my_list)
		cout << it << ' ';

	cout << endl;

	vector<int> my_vector{ 100, 2, 34, 39, 1, 0, 1000 };
	BubbleSort(my_vector.begin(), my_vector.end());
	for (auto it : my_vector)
		cout << it << ' ';

	cout << endl;

	cout << ToJSON(my_vector) << endl;

	getc(stdin);
}


template <class iter>
void BubbleSort(iter from, iter to)
{

	for (auto it = from; it != to; it++)
	for (auto equal = from; equal != to; equal++)
	{
		auto cur = equal;
		auto prev = cur;
		cur++;
		if (cur == to)
			break;
		if (*prev > *cur)
		{
			swap(*prev, *cur);
			/*auto temp = *prev;
			*prev = *cur;
			*cur = temp;*/
		}
	}
}


template <class type>
string ToJSON(type source)
{
	stringstream result;

	result << "[ ";

	for (auto it = source.begin(); it != source.end(); it++)
	{
		if (it != source.begin())
			result << ", ";
		result << *it;
	}
		
	result << " ]";

	string str(result.str());

	return str;
}