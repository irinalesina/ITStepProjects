#define _CRT_SECURE_NO_WARNINGS
#include <iostream>
#include <list>
#include <vector>
#include <map>
#include <conio.h>
#include "../../AssociativeArray/AssociativeArray/Hash.h"
#include <chrono>
#include <fstream>
#include <algorithm> 




void InputData(int *source, int *arr, list<int> *t_list, map<int, int> *t_map, Hash<int, int> *t_hash, int N, ofstream &fs);

void SortData(int *arr, list<int> &t_list, int N, ofstream &sort);

void FindKey(map<int, int> &t_map, Hash<int, int> &t_hash, int N, ofstream &key);


std::chrono::milliseconds InputVector(int *source, int *destination, int N);
std::chrono::milliseconds InputList(int *source, list<int> *destination, int N);
std::chrono::milliseconds InputMap(int *source, map<int, int> *destination, int N);
std::chrono::milliseconds InputHash(int *source, Hash<int, int> *destination, int N);


std::chrono::milliseconds SortVector(int *source, int N);
std::chrono::milliseconds SortList(list<int> &source, int N);


std::chrono::milliseconds KeyMap(map<int, int> &source, int N);
std::chrono::milliseconds KeyHash(Hash<int, int> &source, int N);



const int min_size = 0x10000;
const int max_size = 0x100000;


using namespace std;
int main()
{
	using namespace std::chrono;
	int *source = (int*)malloc(max_size * sizeof(int));
	for (int i = 0; i < max_size; i++)
	{
		source[i] = rand();
	}

	ofstream fs("input.csv");
	fs << "N;vector;list;map;hash" << endl;

	ofstream sort("sort.csv");
	sort << "N;vector;list;" << endl;

	ofstream key("key.csv");
	key << "N;map;hash" << endl;

	for (int N = min_size; N <= max_size; N *= 2) 
	{
		//data
		int *arr = new int[N];
		list<int> t_list;
		map<int, int> t_map;
		Hash<int, int> t_hash(N);

		cout << N << " ";

		cout << "Input ";
		InputData(source, arr, &t_list, &t_map, &t_hash, N, fs);

		cout << "Sort ";
		SortData(arr, t_list, N, sort);

		cout << "Key" << endl;
		FindKey(t_map, t_hash, N);

		delete[] arr;
	}

	fs.close();
	sort.close();
	key.close();

	cout << "end" << endl;
	_getch();
	free(source);
	return 0;
}



void InputData(int *source, int *arr, list<int> *t_list, map<int, int> *t_map, Hash<int, int> *t_hash, int N, ofstream &fs)
{
	fs<< N << ";";
	fs<< InputVector(source, arr, N).count() << ";";
	fs << InputList(source, t_list, N).count() << ";";
	fs << InputMap(source, t_map, N).count() << ";";
	fs << InputHash(source, t_hash, N).count() << std::endl;
}


void SortData(int *arr, list<int> &t_list, int N, ofstream &sort)
{
	sort << N << ";";
	sort << SortVector(arr, N).count() << ";";
	sort << SortList(t_list, N).count() << std::endl;
}


void FindKey(map<int, int> &t_map, Hash<int, int> &t_hash, int N, ofstream &key)
{
	key << N << ";";
	key << KeyMap(t_map, N).count() << ";";
	key << KeyHash(t_hash, N).count() << std::endl;
}



std::chrono::milliseconds InputVector(int *source, int *destination, int N)
{
	using namespace std::chrono;
	system_clock::time_point before = system_clock::now();
	
	for (int i = 0; i < N; i++)
	{
		destination[i] = source[i];
	}


	system_clock::time_point after = system_clock::now();

	milliseconds result = duration_cast<milliseconds> (after - before);

	return result;
}
std::chrono::milliseconds InputList(int *source, list<int> *destination, int N)
{
	using namespace std::chrono;
	system_clock::time_point before = system_clock::now();

	for (int i = 0; i < N; i++)
	{
		destination->push_back(source[i]);
	}

	system_clock::time_point after = system_clock::now();

	milliseconds result = duration_cast<milliseconds> (after - before);

	return result;
}
std::chrono::milliseconds InputMap(int *source, map<int, int> *destination, int N)
{
	using namespace std::chrono;
	system_clock::time_point before = system_clock::now();

	for (int i = 0; i < N; i++)
	{
		(*destination)[i] = source[i];
	}

	system_clock::time_point after = system_clock::now();

	milliseconds result = duration_cast<milliseconds> (after - before);

	return result;
}
std::chrono::milliseconds InputHash(int *source, Hash<int, int> *destination, int N)
{
	using namespace std::chrono;
	system_clock::time_point before = system_clock::now();

	for (int i = 0; i < N; i++)
	{
		(*destination)[i] = source[i];
	}

	system_clock::time_point after = system_clock::now();

	milliseconds result = duration_cast<milliseconds> (after - before);

	return result;
}



//bool Compare(int a, int b) { return a < b; }

std::chrono::milliseconds SortVector(int *source, int N)
{
	using namespace std::chrono;
	system_clock::time_point before = system_clock::now();
	
	std::sort(source, source + N);

	system_clock::time_point after = system_clock::now();

	milliseconds result = duration_cast<milliseconds> (after - before);

	return result;
}
std::chrono::milliseconds SortList(list<int> &source, int N)
{
	using namespace std::chrono;
	system_clock::time_point before = system_clock::now();
	
	source.sort();

	system_clock::time_point after = system_clock::now();

	milliseconds result = duration_cast<milliseconds> (after - before);

	return result;
}


std::chrono::milliseconds KeyMap(map<int, int> &source, int N)
{
	using namespace std::chrono;
	system_clock::time_point before = system_clock::now();
	
	for (int i = 0; i < N; i++)
	{
		source.find(i);
	}

	system_clock::time_point after = system_clock::now();

	milliseconds result = duration_cast<milliseconds> (after - before);

	return result;
}
std::chrono::milliseconds KeyHash(Hash<int, int> &source, int N)
{
	using namespace std::chrono;
	system_clock::time_point before = system_clock::now();
	
	for (int i = 0; i < N; i++)
	{
		source[i];
	}

	system_clock::time_point after = system_clock::now();

	milliseconds result = duration_cast<milliseconds> (after - before);

	return result;
}









