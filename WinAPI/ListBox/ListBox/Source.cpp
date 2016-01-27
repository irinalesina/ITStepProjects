#include <windows.h>
#include <tchar.h>
#include <list>
#include <string>
#include <sstream>
#include <map>
#include <utility>



HDC hdc;

using namespace std;

HWND list_box, basket, score, list_box_content;

LRESULT CALLBACK WindowProc(HWND, UINT, WPARAM, LPARAM);

TCHAR szClassWindow[] = TEXT("���������� ����������");

LRESULT CALLBACK OnExit(HWND hWnd, UINT uMessage, WPARAM wParam, LPARAM lParam){
	PostQuitMessage(0);
	return 0;
}


int element_count = 0;
HINSTANCE hInst;
//list<wstring> content{ L"���������", L"�������", L"������", L"�����������",
//L"����", L"����������", L"������", L"�������", L"������", L"������", L"����������",
//L"�����", L"���������", L"������", L"�����", L"�������", L"��������", L"�������",
//L"��������", L"����", L"���������", L"������", L"����������", L"��������", L"�������",
//L"���������", L"��������", L"���������", L"���������", L"�����", L"��������", L"����"};

map<wstring, list<wstring>> content;


void CreatContent();

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

	CreatContent();


	score = CreateWindow(TEXT("Static"), TEXT("Element count: 0"),
		WS_CHILD | WS_VISIBLE | WS_BORDER | SS_CENTER | WS_EX_CLIENTEDGE,
		100, 450, 400, 30, hWnd, NULL, hInst, NULL);

	list_box = CreateWindow(TEXT("listbox"), TEXT(""), LBS_STANDARD |WS_CHILD | WS_VISIBLE, 10, 10, 150, 200, hWnd, NULL, hInst, NULL);

	list_box_content = CreateWindow(TEXT("listbox"), TEXT(""), LBS_STANDARD | WS_CHILD | WS_VISIBLE, 10 * 3 + 150, 10, 150, 200, hWnd, NULL, hInst, NULL);

	for (auto it : content)
		SendMessage(list_box, LB_ADDSTRING, 0, (LPARAM)it.first.c_str());
	
	basket = CreateWindow(TEXT("listbox"), TEXT(""), LBS_NOTIFY | WS_VSCROLL | WS_BORDER | WS_CHILD | WS_VISIBLE, 2 * (10 * 3 + 150), 10, 150, 200, hWnd, NULL, hInst, NULL);
	


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
					   if (HWND(lParam) == list_box && HIWORD(wParam) == LBN_SELCHANGE)
					   {
						   wchar_t buf1[15];
						   int pos1 = SendMessage(list_box, LB_GETCURSEL, 0, 0);
						   SendMessage(list_box, LB_GETTEXT, pos1, LPARAM(buf1));

						   while (SendMessage(list_box_content, LB_GETCOUNT, 0, 0))
							   SendMessage(list_box_content, LB_DELETESTRING, 0, 0);
						   for (auto it : content[buf1])
							   SendMessage(list_box_content, LB_ADDSTRING, 0, LPARAM(it.c_str()));
					   }

					   if (HWND(lParam) == list_box_content && HIWORD(wParam) == LBN_SELCHANGE)
					   {
						   wchar_t buf[15];
						   int pos1 = SendMessage(list_box_content, LB_GETCURSEL, 0, 0);
						   SendMessage(list_box_content, LB_GETTEXT, pos1, LPARAM(buf));
						   SendMessage(basket, LB_ADDSTRING, 0, LPARAM(buf));
						   
						   wstringstream text;
						   text << L"Element count: " << ++element_count;
						   SetWindowText(score, text.str().c_str());
					   }

					   if (HWND(lParam) == basket && HIWORD(wParam) == LBN_SELCHANGE)
					   {
						   int pos2 = SendMessage(basket, LB_GETCURSEL, 0, 0);
						   SendMessage(basket, LB_DELETESTRING, pos2, 0);

						   wstringstream text;
						   text << L"Element count: " << --element_count;
						   SetWindowText(score, text.str().c_str());
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


void CreatContent()
{
	content[L"��������"] = { L"�����", L"�����", L"������", L"�������", L"�������", L"������" };
	content[L"������"] = { L"������", L"�����", L"�����������", L"�����������", L"����", L"�����" };
	content[L"���������"] = { L"������", L"�������", L"��������" };
	content[L"������"] = { L"������" };
}