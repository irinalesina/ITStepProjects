// ���� WINDOWS.H �������� �����������, �������, � ��������� 
// ������� ������������ ��� ��������� ���������� ��� Windows. 
#include <windows.h>
#include <windowsx.h>
#include <tchar.h>
#include <map>
using namespace std;

//�������� ������� ���������
LRESULT CALLBACK WindowProc(HWND, UINT, WPARAM, LPARAM); // 

TCHAR szClassWindow[] = TEXT("��������� ����������"); /* ��� ������ ���� */

typedef LRESULT CALLBACK EventProc(HWND hWnd, UINT uMessage, WPARAM wParam, LPARAM lParam);


map<UINT, EventProc*> eventMap;


LRESULT CALLBACK MouseHanldler(HWND hWnd, UINT uMessage, WPARAM wParam, LPARAM lParam) {
	RECT winParams; // ��������� ��� ��������� ����
//	GetWindowRect(hWnd, &r);
//	
//	int top = r.top; // y
//	int left = r.left; // x
//	int width = r.right - r.left; // x
//	int height = r.bottom - r.top; // y
//	
//	POINT mouse ;
//	GetCursorPos(&mouse);
//
//	if (mouse.x + 20 >= r.left && mouse.x - 20 <= r.left) left += 20; // x left
//	if (mouse.x + 20 >= r.right && mouse.x - 20 <= r.right) left -= 20; // x right
//	if (r.top <= mouse.y && r.top + 20 >= mouse.y) top += 20; // y up
//	if (mouse.y + 20 >= r.bottom && mouse.y - 20 <= r.bottom) top -= 20; // y down
//
//
//	MoveWindow(hWnd, left, top, width, height, TRUE);
//
//	return 0;
	GetWindowRect(hWnd, &winParams);
	int winWidht = winParams.right - winParams.left, winHeight = winParams.bottom - winParams.top;
	int newTop = rand() % (1024 - winHeight), newLeft = rand() % (1280 - winWidht);
	MoveWindow(hWnd, newLeft, newTop, winWidht, winHeight, TRUE);
	return 0;

}

LRESULT CALLBACK OnExit(HWND hWnd, UINT uMessage, WPARAM wParam, LPARAM lParam){
	PostQuitMessage(0);	// ������� ��������� WM_QUIT
	return 0;
}





INT WINAPI _tWinMain(HINSTANCE hInst, HINSTANCE hPrevInst, LPTSTR lpszCmdLine, int nCmdShow)
{
	HWND hWnd;
	MSG Msg;
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
		TEXT("������  Windows ����������"),	// ��������� ����
		/* ���������, �����, ����������� ������ �������, ��������� ����,
		������ ������������ � ���������� ����  */
		WS_OVERLAPPEDWINDOW,	// ����� ����
		CW_USEDEFAULT,	// �-���������� ������ �������� ���� ����
		CW_USEDEFAULT,	// y-���������� ������ �������� ���� ����
		CW_USEDEFAULT,	// ������ ����
		CW_USEDEFAULT,	// ������ ����
		NULL,			// ���������� ������������� ����
		NULL,			// ���������� ���� ����
		hInst,		// ������������� ����������, ���������� ����
		NULL);		// ��������� �� ������� ������ ����������


	/* 4. ����������� ���� */

	ShowWindow(hWnd, nCmdShow);
	UpdateWindow(hWnd);	// ����������� ����

	SetTimer(hWnd, 1, 10, NULL);


	/* 4.5 ������������ ������� */

	eventMap[WM_MOUSEMOVE] = MouseHanldler;
	eventMap[WM_DESTROY] = OnExit;

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
// -���������� ���������-
LRESULT CALLBACK WindowProc(HWND hWnd, UINT uMessage, WPARAM wParam, LPARAM lParam)
{
	if (eventMap.find(uMessage) != eventMap.end())
	return (eventMap[uMessage])  (hWnd, uMessage, wParam, lParam);
	else
	return DefWindowProc(hWnd, uMessage, wParam, lParam);
	
}


