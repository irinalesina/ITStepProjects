// ���� WINDOWS.H �������� �����������, �������, � ��������� 
// ������� ������������ ��� ��������� ���������� ��� Windows. 
#include <windows.h>
#include <tchar.h>
#include <map>
using namespace std;

//�������� ������� ���������
LRESULT CALLBACK WindowProc(HWND, UINT, WPARAM, LPARAM);

TCHAR szClassWindow[] = TEXT("��������� ����������"); /* ��� ������ ���� */

typedef LRESULT CALLBACK EventProc(HWND hWnd, UINT uMessage, WPARAM wParam, LPARAM lParam);


map<UINT, EventProc*> eventMap;

inline int sgn(int x) { return x<0 ? -1 : (x>0 ? 1 : 0); }
int vy = 0, vx = 0;
LRESULT CALLBACK OnTimer(HWND hWnd, UINT uMessage, WPARAM wParam, LPARAM lParam) {
	RECT r;
	GetWindowRect(hWnd, &r);
	int top = r.top;
	int left = r.left;
	int width = r.right - r.left;
	int height = r.bottom - r.top;
	int ax = (vx != 0) ? -(vx / 10 + sgn(vx)) : 0;
	int ay = (vy != 0) ? -(vy / 10 + sgn(vy)) : 0;
	vx += ax;	vy += ay;
	left += vx;	top += vy;
	MoveWindow(hWnd, left, top, width, height, TRUE);
	return 0;
}

LRESULT CALLBACK KeyboardHanldler(HWND hWnd, UINT uMessage, WPARAM wParam, LPARAM lParam) {
	if (wParam == VK_LEFT) vx = -20;
	if (wParam == VK_RIGHT) vx = 20;
	if (wParam == VK_UP) vy = -20;
	if (wParam == VK_DOWN) vy = 20;
	return 0;
}

LRESULT CALLBACK OnLeftMouseUpDown(HWND hWnd, UINT uMessage, WPARAM wParam, LPARAM lParam){
	static int x1, y1;
	if (uMessage == WM_LBUTTONDOWN) {
		x1 = LOWORD(lParam);
		y1 = HIWORD(lParam);
		return 0;
	}
	int x2, y2;
	x2 = LOWORD(lParam);
	y2 = HIWORD(lParam);
	vx = (x2 - x1) / 10;
	vy = (y2 - y1) / 10;

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

	eventMap[WM_KEYDOWN] = KeyboardHanldler;
	eventMap[WM_LBUTTONDOWN] = OnLeftMouseUpDown;
	eventMap[WM_LBUTTONUP] = OnLeftMouseUpDown;
	eventMap[WM_DESTROY] = OnExit;
	eventMap[WM_TIMER] = OnTimer;

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
	/*if (eventMap.find(uMessage) != eventMap.end())
	return (eventMap[uMessage])  (hWnd, uMessage, wParam, lParam);
	else
		return DefWindowProc(hWnd, uMessage, wParam, lParam);*/

	switch (uMessage)
	{
	case WM_LBUTTONDOWN:
	{
		MessageBox(0, TEXT("������ ����� ������ ����"),
			TEXT("WM_LBUTTONDOWN"), MB_OK | MB_ICONINFORMATION);
		break;
	}
	case WM_LBUTTONUP:
	{
		MessageBox(0, TEXT("�������� ����� ������ ����"),
			TEXT("WM_LBUTTONUP"), MB_OK | MB_ICONINFORMATION);
		break;
	}
	case WM_RBUTTONDOWN:
	{
		MessageBox(0, TEXT("������ ������ ������ ����"),
			TEXT("WM_RBUTTONDOWN"), MB_OK | MB_ICONINFORMATION);
		break;
	}
	case WM_MOUSEMOVE:
	{
		TCHAR str[50];
		wsprintf(str, TEXT("X=%d  Y=%d"), LOWORD(lParam), HIWORD(lParam)); // ������� ���������� ������� ����
		SetWindowText(hWnd, str);	// ������ ��������� � ��������� ����
		break;
	}
	case WM_CHAR:
	{
		TCHAR str[50];
		wsprintf(str, TEXT("������ ������� %c"), (TCHAR)wParam);	// ASCII-��� ������� �������
		MessageBox(0, str, TEXT("WM_CHAR"), MB_OK | MB_ICONINFORMATION);
		break;
	}
	default:
		return DefWindowProc(hWnd, uMessage, wParam, lParam);
	}

	return 0;

}


