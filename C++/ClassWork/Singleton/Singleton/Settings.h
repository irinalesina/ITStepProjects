#pragma once
#include <string>

class Settings
{
private:
	Settings();
	static Settings *instance; // гарантирует создание одного экземпл€ра класса
	std::string name;
public:
	static Settings &getInstance();
	std::string &getName();

	void Settings::save();
};

