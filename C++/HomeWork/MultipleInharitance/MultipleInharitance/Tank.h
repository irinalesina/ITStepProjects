#pragma once
#include <string>
#include <iostream>
#include <time.h>


class Detail
{
protected:
	int D_serial_number;
public:
	Detail() : D_serial_number(rand()){}
};


class Platform : public Detail
{
protected:
	std::string P_name;
public:
	Platform(std::string name) : P_name(name), Detail() {}
	void Action() { std::cout << "Go\n"; }
};


class Tower : public Detail
{
private:
	std::string T_name;
public:
	Tower(std::string name) : T_name(name), Detail() {}
	void Action() { std::cout << "Fire\n"; }
};


class Tank : public Platform, public Tower
{
private:
	std::string T_name;
public:
	Tank(std::string name) : T_name(name), Platform(name), Tower(name) {}
	void ShowDetail()
	{
		std::cout << Platform::D_serial_number << '\n'
			<< Tower::D_serial_number << '\n';
			//<< Tank::D_serial_number;

	}
};



