#include <iostream>
#include <conio.h>
#include <string>
#include <vector>
#include <fstream>


std::vector<std::string> ParsCSVString(std::string &str);


using namespace std;
int main()
{
	ifstream file;
	file.open("test.txt");
	if (!file.is_open())
		cout << "Erro" << endl;

	string str;
	getline(file, str);
	vector<string> pars;
	pars = ParsCSVString(str);
	for (auto i = pars.begin(); i < pars.end(); i++)\
		cout << *i << endl;
	_getch();
	return 0;
}














std::vector<std::string> ParsCSVString(std::string &str)
{
	std::vector<std::string> result;
	auto size = str.size() - 1;
	auto position = str.find(';');
	while(position != size)
	{
		size = str.size() - 1;
		position = str.find(';');
		str = str.substr(position + 1, size - position);
		size = str.size() - 1;
		position = str.find(';');
		result.push_back(str.substr(0, position));
		if(position != size)
			str = str.substr(position + 1, size - position);
	} 
	return result;
}