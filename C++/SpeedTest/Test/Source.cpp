#define _CRT_SECURE_NO_WARNINGS
#include <iostream>
#include <list>
#include <vector>
#include <map>
#include <conio.h>
#include "../../ClassWork/AssociativeArray/AssociativeArray/Hash.h"
#include <chrono>
#include <fstream>
#include <algorithm> 

#include <Windows.h>
#include <process.h>


void InputData(int *source, int *arr, list<int> &t_list, map<int, int> &t_map, Hash<int, int> &t_hash, int N, ofstream &fs);

void SortData(int *arr, list<int> &t_list, int N, ofstream &sort);

void FindKey(map<int, int> &t_map, Hash<int, int> &t_hash, int N, ofstream &key);


std::chrono::milliseconds InputVector(int *source, int *destination, int N);
std::chrono::milliseconds InputList(int *source, list<int> &destination, int N);
std::chrono::milliseconds InputMap(int *source, map<int, int> &destination, int N);
std::chrono::milliseconds InputHash(int *source, Hash<int, int> &destination, int N);


std::chrono::milliseconds SortVector(int *source, int N);
std::chrono::milliseconds SortList(list<int> &source, int N);


std::chrono::milliseconds KeyMap(map<int, int> &source, int N);
std::chrono::milliseconds KeyHash(Hash<int, int> &source, int N);



const int min_size = 0x1000;
const int max_size = 0x40000;


/// thread

const int c_thread_count = 4;
const int c_iteration_count = 7;     //from min_size to max_size

enum ContainerType
{
    CT_vector = 1,
    CT_list,
    CT_map,
    CT_hash,
    CT_maximum
};

struct ThreadContext
{
    int container_type;
    long long **result;
    int *source;
};

unsigned int __stdcall ThreadFunction(void *arg)
{
    ThreadContext* tc = (ThreadContext*)arg;

    int index = 0;
    for (int N = min_size; N <= max_size; N *= 2, index++)
    {
        tc->result[index][0] = N;
        switch (tc->container_type)
        {
            case CT_vector:
            {
                cout << "vector: " << index << endl;
                int *arr = new int[N];
                tc->result[index][tc->container_type] = InputVector(tc->source, arr, N).count();
                break;
            }
            case CT_list:
            {
                cout << "list: " << index << endl;
                list<int> t_list;
                tc->result[index][tc->container_type] = InputList(tc->source, t_list, N).count();
                break;
            }
            case CT_map:
            {
                cout << "map: " << index << endl;
                map<int, int> t_map;
                tc->result[index][tc->container_type] = InputMap(tc->source, t_map, N).count();
                break;
            }
            case CT_hash:
            {
                cout << "hash: " << index << endl;
                Hash<int, int> t_hash(N);
                tc->result[index][tc->container_type] =  InputHash(tc->source, t_hash, N).count();
                break;
            }
        }
    }

    delete tc;
    return 0;
}

using namespace std;
int main()
{
	using namespace std::chrono;
	int *source = (int*)malloc(max_size * sizeof(int));
	for (int i = 0; i < max_size; i++)
	{
		source[i] = rand();
	}

    long long **input_result = new long long*[c_iteration_count]();
    for (int i = 0; i < c_iteration_count; i++)
        input_result[i] = new long long[CT_maximum]();

    HANDLE h_threads[c_thread_count] = {NULL};

    for (int i = 0; i < c_thread_count; i++)
    {

        ThreadContext* tc = new ThreadContext;
        tc->container_type = i + 1;
        tc->result = input_result;
        tc->source = source;

        h_threads[i] = (HANDLE)_beginthreadex(NULL, 0, ThreadFunction, tc, 0, 0);
        if (h_threads[i] == INVALID_HANDLE_VALUE)
        {
            cout << "Create thread failed" << endl;
        }
    }


    WaitForMultipleObjects(c_thread_count, h_threads, TRUE, INFINITE);



	ofstream fs("input.csv");
	fs << "N;vector;list;map;hash" << endl;

    for (int i = 0; i < c_iteration_count; i++)
        for (int j = 0; j < CT_maximum; j++)
        {
            fs << input_result[i][j];
            if (j != CT_maximum - 1)
                fs << ";";
            else 
                fs << "\n";
        }
    fs.close();


	//ofstream sort("sort.csv");
	//sort << "N;vector;list;" << endl;
    //
	//ofstream key("key.csv");
	//key << "N;map;hash" << endl;
    //
	//for (int N = min_size; N <= max_size; N *= 2) 
	//{
	//	//data
	//	int *arr = new int[N];
	//	list<int> t_list;
	//	map<int, int> t_map;
	//	Hash<int, int> t_hash(N);
    //
	//	cout << N << " ";
    //
	//	cout << "Input ";
	//	InputData(source, arr, &t_list, &t_map, &t_hash, N, fs);
    //
	//	//cout << "Sort ";
	//	//SortData(arr, t_list, N, sort);
    //
	//	//cout << "Key" << endl;
	//	//FindKey(t_map, t_hash, N, key);
    //
	//	delete[] arr;
	//}
    //
	//fs.close();
	//sort.close();
	//key.close();

	cout << "end" << endl;
	_getch();
	free(source);
    
    for (int i = 0; i < c_iteration_count; i++)
        delete[] input_result[i];
    delete[] input_result;

	return 0;
}



void InputData(int *source, int *arr, list<int> &t_list, map<int, int> &t_map, Hash<int, int> &t_hash, int N, ofstream &fs)
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
std::chrono::milliseconds InputList(int *source, list<int> &destination, int N)
{
	using namespace std::chrono;
	system_clock::time_point before = system_clock::now();

	for (int i = 0; i < N; i++)
	{
		destination.push_back(source[i]);
	}

	system_clock::time_point after = system_clock::now();

	milliseconds result = duration_cast<milliseconds> (after - before);

	return result;
}
std::chrono::milliseconds InputMap(int *source, map<int, int> &destination, int N)
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
std::chrono::milliseconds InputHash(int *source, Hash<int, int> &destination, int N)
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









