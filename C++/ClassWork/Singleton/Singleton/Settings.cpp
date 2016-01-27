#include "Settings.h"
#include <fstream>
#include <string>

Settings *Settings::instance = nullptr;

Settings::Settings()
{
	try
	{
		std::ifstream file;
		file.exceptions(std::ios::failbit);
		file.open("settings.txt");
	
		std::getline(file, name);
		file.close();
	}
	catch (std::exception e)
	{
		name = "user";
	}
}


Settings &Settings::getInstance()
{
	if (instance == nullptr)
		instance = new Settings;
	return (*instance);
}


std::string &Settings::getName()
{
	return name;
}


void Settings::save()
{
	std::ofstream file("settings.txt");
	file << name;
	file.close();
	delete Settings::instance;
}
