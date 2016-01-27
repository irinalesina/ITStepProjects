#include <Windows.h>
#include <tchar.h>
#include <conio.h>
#include <iostream>
#include <string>
#include <regex>

// _tmain - макрос, который преобразуется в зависимости от кодировки компиляторы в wmain / main
// _TCHAR -  макрос по аналогии с _tmain
int _tmain(int argc, _TCHAR *argv[])
{
	wchar_t *str = L"Привет"; // L - 
	wprintf(L"%s коллеги\n", str);

	std::wcout.imbue(std::locale(".866")); // for output russian letters

	//std::wcout << str << L" коллеги\n";


	wchar_t buf[50];
	wcscpy(buf, str);
	wcscat(buf, L" коллеги!\n");

	std::wcout << buf;



	std::wregex r(L"[уеэоаыёяию]");
	std::wstring s(buf);
	std::wsmatch m;
	
	int count = 0;
	while (std::regex_search(s, m, r))
	{
		count++;
		s = m.suffix().str();
	}

	std::wcout << count;

	_getch();
	return 0;
}








