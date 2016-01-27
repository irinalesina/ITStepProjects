#include <windows.h>
#include <tchar.h>
#include <map>
#include <list>
#include <string>
#include <fstream>
#include <locale>
#include <codecvt>
#include <locale.h>
#include <Windowsx.h>
#include <sstream>


int window_score_x = 400, window_score_y = 30;
std::string task("task.txt");


HDC hdc;
PAINTSTRUCT ps;


using namespace std;


LRESULT CALLBACK WindowProc(HWND, UINT, WPARAM, LPARAM);

TCHAR szClassWindow[] = TEXT("Каракасное приложение"); 


void CreateContent(HWND hWnd, HINSTANCE hInst);

LRESULT CALLBACK OnExit(HWND hWnd, UINT uMessage, WPARAM wParam, LPARAM lParam){
	PostQuitMessage(0);	
	return 0;
}


list<wstring> tasks;
int answer_numb;
int money = 0;
list<HWND> buttons;
HWND take_money, question, score, main_window;
HINSTANCE hInst;


bool GetTask();

INT WINAPI _tWinMain(HINSTANCE hinst, HINSTANCE hPrevInst, LPTSTR lpszCmdLine, int nCmdShow)
{
	hInst = hinst;
	//setlocale(LC_ALL, "rus");
	
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
		640,	
		600,	
		NULL,			
		NULL,			
		hInst,		
		NULL);		

	main_window = hWnd;

	score = CreateWindow(TEXT("Static"), TEXT("Money: 0"),
		WS_CHILD | WS_VISIBLE | WS_BORDER | SS_CENTER | WS_EX_CLIENTEDGE,
		100, 450, window_score_x, window_score_y, hWnd, NULL, hInst, NULL);

	take_money = CreateWindow(
		L"BUTTON",  // Predefined class; Unicode assumed 
		L"take money",      // Button text 
		WS_TABSTOP | WS_VISIBLE | WS_CHILD | BS_DEFPUSHBUTTON,  // Styles 
		200,         // x position 
		500,         // y position 
		200,        // Button width
		30,        // Button height
		hWnd,     // Parent window
		(HMENU)0,       // button id (h - menu)
		hInst,
		NULL);

	question = CreateWindow(TEXT("Static"), L"",
		WS_CHILD | WS_VISIBLE | WS_BORDER | SS_CENTER | WS_EX_CLIENTEDGE,
		100, 50, window_score_x, window_score_y, hWnd, NULL, hInst, NULL);

	GetTask();
	CreateContent(hWnd, hInst);


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
		 if ((HWND)lParam == take_money && money != 0)
		 {
		   wstringstream ss;
		   ss << L"Congratulations, you win " << money << L"$";
		   msgboxID = MessageBox(hWnd, ss.str().c_str(), L"result", MB_YESNO);
		   PostMessage(hWnd, WM_DESTROY, 0, 0);
		   break;
		 }
		 if ((int)wParam == answer_numb)
		 { 
		   money += 500;
		   wstringstream text;
		   text << L"Money: " << money << L"$";
		   SetWindowText(score, text.str().c_str());
		   for (auto it : buttons)
			   DestroyWindow(it);
		   buttons.clear();
		   if (tasks.size() > 0)
			   CreateContent(hWnd, hInst);
		   else
		   {
			   wstringstream ss;
			   ss << L"Congratulations, you win " << money << L"$";
			   MessageBox(hWnd, ss.str().c_str(), L"result", MB_OK);
			   PostMessage(hWnd, WM_DESTROY, 0, 0);
		   }
		 }
		 else
		 {
		   money = 0;
		   wstringstream ss;
		   ss << L"Game over! You lose!";
		   MessageBox(hWnd, ss.str().c_str(), L"result", MB_OK);
		   PostMessage(hWnd, WM_DESTROY, 0, 0);

		 }

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




void GetAnswerParam(wstring str, int &count, int &numb);

void CreateContent(HWND hWnd, HINSTANCE hInst)
{
	int answer_count;
	GetAnswerParam(tasks.front(), answer_count, answer_numb);
	tasks.pop_front();

	wstring current_question = tasks.front();
	tasks.pop_front();
	
	SetWindowText(question, current_question.c_str());

	int y_elements = 0;
	for (unsigned int i = 0; i < answer_count; i++)
	{	
		HWND button;
		button = CreateWindow(
			L"BUTTON",  // Predefined class; Unicode assumed 
			tasks.front().c_str(),      // Button text 
			WS_TABSTOP | WS_VISIBLE | WS_CHILD | BS_DEFPUSHBUTTON,  // Styles 
			150,         // x position 
			y_elements + 125,         // y position 
			300,        // Button width
			30,        // Button height
			hWnd,     // Parent window
			(HMENU)i,       // button id (h - menu)
			hInst,
			NULL);
		buttons.push_back(button);
		tasks.pop_front();
		y_elements += 50;
	}

}


bool GetTask()
{
	wifstream file;
	
	file.open(task);
	file.imbue(locale(file.getloc(), new codecvt_utf8<wchar_t, 0x10ffff, consume_header>));
	wstring buf;

	while (!file.eof())
	{
		getline(file, buf);
		tasks.push_back(buf);
	}

	file.close();
	return true;
}

void GetAnswerParam(wstring str, int &count, int &numb)
{
	size_t i = 0;
	while (str[i] != ' ')
		i++;
	count = stoi(str, &i);


	while (str[i] == ' ')
		i++;

	size_t byte = str.size() - i;
	numb = stoi(str.substr(i, byte), &byte);
}