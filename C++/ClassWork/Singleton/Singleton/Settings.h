#pragma once
#include <string>

class Settings
{
private:
	Settings();
	static Settings *instance; // ����������� �������� ������ ���������� ������
	std::string name;
public:
	static Settings &getInstance();
	std::string &getName();

	void Settings::save();
};

