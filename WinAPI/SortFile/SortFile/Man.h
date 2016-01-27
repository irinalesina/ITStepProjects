#pragma once
#include <string>


class Man
{
public:
	std::wstring first_name;
	std::wstring last_name;
public:
	Man(std::wstring _first_name, std::wstring _last_name) :
		first_name(_first_name), last_name(_last_name) {}
	Man(){}
};

