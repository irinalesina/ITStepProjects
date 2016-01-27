#include <windows.h>
#include <tchar.h>
#include <list>
#include <string>
#include <sstream>
#include <map>
#include <utility>
#include <sstream>
#include <locale>
#include <codecvt>
#include <locale.h>
#include <fstream>
#include <vector>
#include <algorithm>
#include <random> 
#include <chrono>
#include <cmath>


using namespace std;


// globale variables
vector<HWND> buttons, butt_quest;
HDC hdc;
vector<wstring> answers, questions;
vector<wchar_t> letters;
int element_count = 0;
HINSTANCE hInst;
int button_width = 30, button_hight = 30;

HWND list_box, basket, score, list_box_content;


// functions
bool ReadData(string file_name, vector<wstring> &dest);
void CreatLettersFild(HWND hWnd);
void CreatQuestionsFild(HWND hWnd);


LRESULT CALLBACK WindowProc(HWND, UINT, WPARAM, LPARAM);

TCHAR szClassWindow[] = TEXT("Каракасное приложение");

LRESULT CALLBACK OnExit(HWND hWnd, UINT uMessage, WPARAM wParam, LPARAM lParam){
	PostQuitMessage(0);
	return 0;
}



INT WINAPI _tWinMain(HINSTANCE hinst, HINSTANCE hPrevInst, LPTSTR lpszCmdLine, int nCmdShow)
{
	hInst = hinst;
	HWND hWnd;
	MSG Msg;
	WNDCLASSEX wcl;

	/* 1.   */

	wcl.cbSize = sizeof (wcl);
	wcl.style = CS_HREDRAW | CS_VREDRAW | CS_DBLCLKS;
	wcl.lpfnWndProc = WindowProc;
	wcl.cbClsExtra = 0;
	wcl.cbWndExtra = 0;
	wcl.hInstance = hInst;
	wcl.hIcon = LoadIcon(NULL, IDI_APPLICATION);
	wcl.hCursor = LoadCursor(NULL, IDC_ARROW);
	wcl.hbrBackground = (HBRUSH)GetStockObject(WHITE_BRUSH);
	wcl.lpszMenuName = NULL;
	wcl.lpszClassName = szClassWindow;
	wcl.hIconSm = NULL;


	/*  2.  */

	if (!RegisterClassEx(&wcl))
		return 0;

	/*  3.   */


	hWnd = CreateWindowEx(
		0,
		szClassWindow,
		TEXT("Millioner"),
		WS_OVERLAPPEDWINDOW,
		CW_USEDEFAULT,
		CW_USEDEFAULT,
		1040,
		900,
		NULL,
		NULL,
		hInst,
		NULL);


	ReadData("questions.txt", questions);
	ReadData("answers.txt", answers);
	
	for (auto a: answers)
		for (auto l : a)
				letters.push_back(l);

	/*sort(letters.begin(), letters.end());
	auto it = unique(letters.begin(), letters.end());
	letters.erase(it, letters.end());*/


	unsigned seed = chrono::system_clock::now().time_since_epoch().count();
	shuffle(letters.begin(), letters.end(), default_random_engine(seed));

	CreatLettersFild(hWnd);
	CreatQuestionsFild(hWnd);

	/*score = CreateWindow(TEXT("Static"), TEXT("Score: 0"),
		WS_CHILD | WS_VISIBLE | WS_BORDER | SS_CENTER | WS_EX_CLIENTEDGE,
		100, 450, 400, 30, hWnd, NULL, hInst, NULL);*/

	//list_box = CreateWindow(TEXT("listbox"), TEXT(""), LBS_STANDARD | WS_CHILD | WS_VISIBLE, 10, 10, 150, 200, hWnd, NULL, hInst, NULL);

	//list_box_content = CreateWindow(TEXT("listbox"), TEXT(""), LBS_STANDARD | WS_CHILD | WS_VISIBLE, 10 * 3 + 150, 10, 150, 200, hWnd, NULL, hInst, NULL);

	/*for (auto it : content)
		SendMessage(list_box, LB_ADDSTRING, 0, (LPARAM)it.first.c_str());*/

	//basket = CreateWindow(TEXT("listbox"), TEXT(""), LBS_NOTIFY | WS_VSCROLL | WS_BORDER | WS_CHILD | WS_VISIBLE, 2 * (10 * 3 + 150), 10, 150, 200, hWnd, NULL, hInst, NULL);



	/* 4.  */

	ShowWindow(hWnd, nCmdShow);
	UpdateWindow(hWnd);


	/* 5.  */

	while (GetMessage(&Msg, NULL, 0, 0))
	{
		TranslateMessage(&Msg);
		DispatchMessage(&Msg);
	}
	return Msg.wParam;
}



int msgboxID;

LRESULT CALLBACK WindowProc(HWND hWnd, UINT uMessage, WPARAM wParam, LPARAM lParam)
{
	switch (uMessage)
	{
	case WM_COMMAND:
	{
					   if (HWND(lParam) == butt_quest[int(wParam)] && HIWORD(wParam) == LBN_SELCHANGE)
					   {
						   MessageBox(hWnd, questions[int(wParam)].c_str(), L"result", MB_OK);
					   }
					   //if (HWND(lParam) == list_box && HIWORD(wParam) == LBN_SELCHANGE)
					   //{
						  // wchar_t buf1[15];
						  // int pos1 = SendMessage(list_box, LB_GETCURSEL, 0, 0);
						  // SendMessage(list_box, LB_GETTEXT, pos1, LPARAM(buf1));

						  // while (SendMessage(list_box_content, LB_GETCOUNT, 0, 0))
							 //  SendMessage(list_box_content, LB_DELETESTRING, 0, 0);
						  // /*for (auto it : content[buf1])
							 //  SendMessage(list_box_content, LB_ADDSTRING, 0, LPARAM(it.c_str()));*/
					   //}

					   //if (HWND(lParam) == list_box_content && HIWORD(wParam) == LBN_SELCHANGE)
					   //{
						  // wchar_t buf[15];
						  // int pos1 = SendMessage(list_box_content, LB_GETCURSEL, 0, 0);
						  // SendMessage(list_box_content, LB_GETTEXT, pos1, LPARAM(buf));
						  // SendMessage(basket, LB_ADDSTRING, 0, LPARAM(buf));

						  // wstringstream text;
						  // text << L"Element count: " << ++element_count;
						  // SetWindowText(score, text.str().c_str());
					   //}

					   //if (HWND(lParam) == basket && HIWORD(wParam) == LBN_SELCHANGE)
					   //{
						  // int pos2 = SendMessage(basket, LB_GETCURSEL, 0, 0);
						  // SendMessage(basket, LB_DELETESTRING, pos2, 0);

						  // wstringstream text;
						  // text << L"Element count: " << --element_count;
						  // SetWindowText(score, text.str().c_str());
					   //}

	}
		break;
	case WM_DESTROY:
		//
		PostQuitMessage(0);
		break;
	default:
		return DefWindowProc(hWnd, uMessage, wParam, lParam);
	}

	return 0;
}


void CreatLettersFild(HWND hWnd)
{
	int index = 0, x_pos = 10, y_pos = 10;
	int count_x = 0, count_y = 0;
	for (auto it: letters)
	{
		wchar_t buf[2] {0};
		buf[0] = it;

		HWND button;

		button = CreateWindow(
			L"BUTTON",  // Predefined class; Unicode assumed 
			buf,      // Button text 
			WS_TABSTOP | WS_VISIBLE | WS_CHILD | BS_DEFPUSHBUTTON,  // Styles 
			x_pos + count_x * button_width,         // x position 
			y_pos + count_y * button_hight,         // y position 
			button_width,        // Button width
			button_hight,        // Button height
			hWnd,     // Parent window
			(HMENU)index++,       // button id (h - menu)
			hInst,
			NULL);

		count_x++;
		if (count_x == 30)
		{
			count_x = 0;
			count_y++;
		}
		
		buttons.push_back(button);
	}
}

void CreatQuestionsFild(HWND hWnd)
{
	int x_pos = 10, y_pos = 10 + button_hight * 6 + 10;
	int count_x = 0, count_y = 0;
	for (int i = 0; i < 20; i++)
	{
		wchar_t buf[2] = { '*' };
		HWND button;
		button = CreateWindow(
			L"BUTTON",  // Predefined class; Unicode assumed 
			buf,      // Button text 
			WS_TABSTOP | WS_VISIBLE | WS_CHILD | BS_DEFPUSHBUTTON,  // Styles 
			x_pos + count_x * (button_width + 20),         // x position 
			y_pos + count_y * (button_hight + 20),         // y position 
			button_width + 20,        // Button width
			button_hight + 20,        // Button height
			hWnd,     // Parent window
			(HMENU)i,       // button id (h - menu)
			hInst,
			NULL);

		count_x++;
		if (count_x == 5)
		{
			count_x = 0;
			count_y++;
		}

		butt_quest.push_back(button);
	}



	//int x_pos = 10, y_pos = 10 + button_hight * 6 + 10;
	//int  count_y = 0;
	//int quest_hight = 30;
	//for (auto it : questions)
	//{
	//	HWND button;

	//	/*CreateWindow(TEXT("Static"), it.c_str(),
	//		WS_CHILD | WS_VISIBLE | WS_BORDER | WS_EX_CLIENTEDGE,
	//		x_pos, y_pos + count_y * quest_hight, 600, quest_hight, hWnd, NULL, hInst, NULL);
	//	count_y++;*/
	//}
}

bool ReadData(string file_name, vector<wstring> &dest)
{
	wifstream file;

	file.open(file_name);
	if (!file.is_open())
		return false;
	file.imbue(locale(file.getloc(), new codecvt_utf8<wchar_t, 0x10ffff, consume_header>));
	wstring buf;

	while (!file.eof())
	{
		getline(file, buf);
		dest.push_back(buf);
	}

	file.close();
	return true;
}

