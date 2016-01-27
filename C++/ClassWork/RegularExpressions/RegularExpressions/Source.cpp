// regex_match example
#include <iostream>
#include <string>
#include <regex>



using namespace std;
int main()
{
	// 1
	/*
	string s("qwe12.7hgfd3gds5.7wer");
	std::smatch m;
	std::regex e("\\d+[.]\\d");

	cout << s << endl;

	while (std::regex_search(s, m, e)) {
		for (auto x : m) std::cout << x << " ";
		std::cout << std::endl;
		s = m.suffix().str();
	}
	*/

	// 2
	/*
	string s("192.168.1.1hy5yhyh6ythtrgfrtg");
	std::smatch m;
	std::regex e("\\d{1,3}[.]\\d{1,3}[.]\\d{1,3}[.]\\d{1,3}");  

	cout << s << endl;

	while (std::regex_search(s, m, e)) {
		for (auto x : m) std::cout << x << " ";
		std::cout << std::endl;
		s = m.suffix().str();
	}
	*/

	// 3
	
	string s("abb@x.com e-mail@x432.co.u2k united.states@a.b.c.d.e.f.org\n");
	std::smatch m;
	std::regex e("[a-zA-Z0-9_.-]+@(?:[a-zA-Z](?:[a-zA-Z0-9-])*[.]){1,6}[a-zA-Z]+\\s");

	cout << s << endl;

	while (std::regex_search(s, m, e)) {
		for (auto x : m) std::cout << x << " ";
		std::cout << std::endl;
		s = m.suffix().str();
	}
	

	// 4






	std::cout << std::endl;

	getc(stdin);
	return 0;
}