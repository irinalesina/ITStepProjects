#include <iostream>
#include <Windows.h>
#include <tchar.h>
#include <fstream>
#include <string>
#include <sstream>
#include <locale>
#include <codecvt>
#include <vector>
#include "Man.h"
#include "Mans.h"



using namespace std;
void _tmain()
{
	wcout.imbue(locale(".866"));
	
	wchar_t cc = 0x41A;
	std::wcout << cc;

	// read data from file
	wifstream data;
	wofstream file;
	data.open("names.txt");
	data.imbue(locale(data.getloc(), new codecvt_utf16<wchar_t, 0x10ffff, consume_header>));
	file.imbue(locale(file.getloc(), new codecvt_utf16<wchar_t, 0x10ffff, consume_header>));

	wstring temp;
	vector<wstring> buffer;
	while (!(data.eof()))
	{
		//data >> temp;
		getline(data, temp);

		buffer.push_back(temp);
	}

	getline(data, temp);

	data.close();

	Mans my_mans;
	for (auto it : buffer)
	{
		wstring f_name, l_name;
		int i = it.find(' ');

		f_name = it.substr(0, i);
		i++;
		l_name = it.substr(i);
		my_mans.mans.push_back(Man(f_name, l_name));
	}
	my_mans.Sort();

	file.open("names_result.txt");

	for (auto it : my_mans.mans)
	{
		file << it.first_name << L" " << it.last_name << L"\n";
	}
	file.close();

	getc(stdin);
}