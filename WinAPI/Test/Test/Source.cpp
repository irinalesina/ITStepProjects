 #include <windows.h>
#include <tchar.h>
#include <map>

#define ButtonWidth 100
#define ButtonHeigth 20

HDC hdc;
PAINTSTRUCT ps;


using namespace std;

//�������� ������� ���������
LRESULT CALLBACK WindowProc(HWND, UINT, WPARAM, LPARAM);

TCHAR szClassWindow[] = TEXT("��������� ����������"); /* ��� ������ ���� */


// for event map
//typedef LRESULT CALLBACK EventProc(HWND hWnd, UINT uMessage, WPARAM wParam, LPARAM lParam);

void CreateContent(HWND hWnd, HINSTANCE hInst);

LRESULT CALLBACK OnExit(HWND hWnd, UINT uMessage, WPARAM wParam, LPARAM lParam){
	PostQuitMessage(0);	// ������� ��������� WM_QUIT
	return 0;
}

HWND hwndButton2, hwndButton3, hwndButtonDefault;
INT WINAPI _tWinMain(HINSTANCE hInst, HINSTANCE hPrevInst, LPTSTR lpszCmdLine, int nCmdShow)
{
	// ���������� �������� ����
	HWND hWnd;

	MSG Msg;

	// ���������, ������� �������� �������� ������ ����
	WNDCLASSEX wcl;

	/* 1. ����������� ������ ����  */

	wcl.cbSize = sizeof (wcl);	// ������ ��������� WNDCLASSEX 
	wcl.style = CS_HREDRAW | CS_VREDRAW | CS_DBLCLKS;	// ���� ������ �������� ��������� � ������� ������ (DBLCLK)
	wcl.lpfnWndProc = WindowProc;	// ����� ������� ���������
	wcl.cbClsExtra = 0;		// ������������ Windows 
	wcl.cbWndExtra = 0; 	// ������������ Windows 
	wcl.hInstance = hInst;	// ���������� ������� ����������
	wcl.hIcon = LoadIcon(NULL, IDI_APPLICATION);	// �������� ����������� ������
	wcl.hCursor = LoadCursor(NULL, IDC_ARROW);		// �������� ������������ �������
	wcl.hbrBackground = (HBRUSH)GetStockObject(WHITE_BRUSH);	//���������� ���� ����� ������			
	wcl.lpszMenuName = NULL;	// ���������� �� �������� ����
	wcl.lpszClassName = szClassWindow;	// ��� ������ ����
	wcl.hIconSm = NULL;	// ���������� ��������� ������ ��� ����� � ������� ����


	/*  2. ����������� ������ ����  */

	if (!RegisterClassEx(&wcl))
		return 0;	// ��� ��������� ����������� - �����

	/*  3. �������� ����  */

	// ��������� ���� �  ���������� hWnd ������������� ���������� ����
	hWnd = CreateWindowEx(
		0,		// ����������� ����� ����
		szClassWindow,	// ��� ������ ����
		TEXT("���������"),	// ��������� ����
		/* ���������, �����, ����������� ������ �������, ��������� ����,
		������ ������������ � ���������� ����  */
		WS_OVERLAPPEDWINDOW,	// ����� ����
		CW_USEDEFAULT,	// �-���������� ������ �������� ���� ����
		CW_USEDEFAULT,	// y-���������� ������ �������� ���� ����
		250,	// ������ ����
		300,	// ������ ����
		NULL,			// ���������� ������������� ����
		NULL,			// ���������� ���� ����
		hInst,		// ������������� ����������, ���������� ����
		NULL);		// ��������� �� ������� ������ ����������


	CreateContent(hWnd, hInst);


	/* 4. ����������� ���� */

	ShowWindow(hWnd, nCmdShow);
	UpdateWindow(hWnd);	// ����������� ����

	/* 4.5 ������������ ������� */


	/* 5. ������ ����� ��������� ���������  */

	// ��������� ���������� ��������� �� ������� ���������
	while (GetMessage(&Msg, NULL, 0, 0))
	{
		TranslateMessage(&Msg);	// ���������� ���������
		DispatchMessage(&Msg);	// ��������������� ���������
	}
	return Msg.wParam;
}


// ������� ��������� ���������� ������������ �������� � �������� � �������� 
// ���������� ��������� �� ������� ��������� ������� ����������	

LRESULT CALLBACK WindowProc(HWND hWnd, UINT uMessage, WPARAM wParam, LPARAM lParam)
{
	switch (uMessage)
	{
	case WM_COMMAND:
	{
		if ((HWND)lParam == hwndButtonDefault)
		   MessageBox(hWnd, TEXT("it's true"), TEXT("result"), MB_OK);
		else
		   MessageBox(hWnd, TEXT("it's false"), TEXT("result"), MB_OK);
		break;
	}
	case WM_PAINT:
	{
		hdc = BeginPaint(hWnd, &ps);
		TextOut(hdc, 10, 10, TEXT("How much 2 + 2?"), _tcslen(TEXT("How much 2 + 2?")));
		EndPaint(hWnd, &ps);
		break;
	}
	case WM_DESTROY: // ��������� � ���������� ���������
		//
		PostQuitMessage(0); // ������� ��������� WM_QUIT
		break;
	default:
		// ��� ���������, ������� �� �������������� � ������ ������� ������� 
		// ������������ ������� Windows �� ��������� �� ���������
		return DefWindowProc(hWnd, uMessage, wParam, lParam);
	}

	return 0;
}



void CreateContent(HWND hWnd, HINSTANCE hInst)
{
	/*LPRECT size;
	GetWindowRect(hWnd, size);*/

	// text
	/*CreateWindow(TEXT("Static"), TEXT("How much 2 + 2?"),
		WS_CHILD | WS_VISIBLE | WS_BORDER | SS_CENTER | WS_EX_STATICEDGE,
		10, 10, ButtonWidth * 2, ButtonHeigth, hWnd, NULL, hInst, NULL);*/
	

	// buttons
	hwndButton2 = CreateWindow(
		L"BUTTON",  // Predefined class; Unicode assumed 
		L"2",      // Button text 
		WS_TABSTOP | WS_VISIBLE | WS_CHILD | BS_DEFPUSHBUTTON,  // Styles 
		10,         // x position 
		50,         // y position 
		ButtonWidth,        // Button width
		ButtonHeigth,        // Button height
		hWnd,     // Parent window
		(HMENU)2,       // button id (h - menu)
		hInst,
		NULL);      // Pointer not needed.

	hwndButton3 = CreateWindow(
		L"BUTTON",  // Predefined class; Unicode assumed 
		L"3",      // Button text 
		WS_TABSTOP | WS_VISIBLE | WS_CHILD | BS_DEFPUSHBUTTON,  // Styles 
		10,         // x position 
		100,         // y position 
		ButtonWidth,        // Button width
		ButtonHeigth,        // Button height
		hWnd,     // Parent window
		(HMENU)3,       // button id (h - menu)
		hInst,
		NULL);      // Pointer not needed.


	hwndButtonDefault = CreateWindow(
		L"BUTTON",  // Predefined class; Unicode assumed 
		L"default",      // Button text 
		WS_TABSTOP | WS_VISIBLE | WS_CHILD | BS_DEFPUSHBUTTON,  // Styles 
		10,         // x position 
		150,         // y position 
		ButtonWidth,        // Button width
		ButtonHeigth,        // Button height
		hWnd,     // Parent window
		(HMENU)0,       // button id (h - menu)
		hInst,
		NULL);      // Pointer not needed.
}
