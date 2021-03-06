#include "BackgroundCopier.h"
#include <windows.h>
#include <tchar.h>
#include <string>
#include <iostream>
#include <fstream>
#include <cstdlib>
#include <CommCtrl.h>

using namespace std;
// Global variables
std::wstring from, to;
// The main window class name.
static TCHAR szWindowClass[] = _T("CreateFiles");
HWND progress;
// The string that appears in the application's title bar.
static TCHAR szTitle[] = _T("����������� �����");

HINSTANCE hInst;
static HWND openfile, loadfile, go, edito, editl, hProgress;// ���������� ������
ifstream input;
ofstream output;
HWND hWnd;
// Forward declarations of functions included in this code module:
LRESULT CALLBACK WndProc(HWND, UINT, WPARAM, LPARAM);

int WINAPI WinMain(HINSTANCE hInstance,
	HINSTANCE hPrevInstance,
	LPSTR lpCmdLine,
	int nCmdShow)
{
	WNDCLASSEX wcex;
	InitCommonControls();
	wcex.cbSize = sizeof(WNDCLASSEX);
	wcex.style = CS_HREDRAW | CS_VREDRAW;
	wcex.lpfnWndProc = WndProc;
	wcex.cbClsExtra = 0;
	wcex.cbWndExtra = 0;
	wcex.hInstance = hInstance;
	wcex.hIcon = LoadIcon(hInstance, MAKEINTRESOURCE(IDI_APPLICATION));
	wcex.hCursor = LoadCursor(NULL, IDC_ARROW);
	wcex.hbrBackground = (HBRUSH)(COLOR_WINDOW + 1);
	wcex.lpszMenuName = NULL;
	wcex.lpszClassName = szWindowClass;
	wcex.hIconSm = LoadIcon(wcex.hInstance, MAKEINTRESOURCE(IDI_APPLICATION));

	if (!RegisterClassEx(&wcex))
	{
		MessageBox(NULL,
			_T("Call to RegisterClassEx failed!"),
			_T("Win32 Guided Tour"),
			NULL);

		return 1;
	}

	hInst = hInstance;

	hWnd = CreateWindow(szWindowClass, szTitle, WS_OVERLAPPEDWINDOW, CW_USEDEFAULT, CW_USEDEFAULT, 600, 500, NULL, NULL, hInstance, NULL);

	if (!hWnd)
	{
		MessageBox(NULL, _T("Call to CreateWindow failed!"), _T("Win32 Guided Tour"), NULL);
		return 1;
	}

	progress = CreateWindow(PROGRESS_CLASS, NULL, WS_CHILD | WS_VISIBLE, 100, 350, 400, 17, hWnd, NULL, hInst, NULL);

	// The parameters to ShowWindow explained:
	// hWnd: the value returned from CreateWindow
	// nCmdShow: the fourth parameter from WinMain
	ShowWindow(hWnd, nCmdShow);

	UpdateWindow(hWnd);

	// Main message loop:
	MSG msg;
	while (GetMessage(&msg, NULL, 0, 0))
	{
		TranslateMessage(&msg);
		DispatchMessage(&msg);
	}

	return (int)msg.wParam;
}

//��������� ����� ��� ������������ ����� � ����������� ������� Windows
int OpenDialog(HWND hWnd)
{
	OPENFILENAME ofn;
	TCHAR szFile[MAX_PATH];
	ZeroMemory(&ofn, sizeof(ofn));
	ofn.lStructSize = sizeof(ofn);
	ofn.lpstrFile = szFile;
	ofn.lpstrFile[0] = '\0';
	ofn.hwndOwner = hWnd;
	ofn.nMaxFile = sizeof(szFile);
	ofn.lpstrFilter = TEXT("txt Files (*.txt)\0*.txt\0All Files (*.*)\0*.*\0");
	ofn.nFilterIndex = 1;
	ofn.lpstrInitialDir = NULL;
	ofn.lpstrFileTitle = NULL;
	ofn.lpstrDefExt = L"txt";
	ofn.Flags = OFN_PATHMUSTEXIST | OFN_FILEMUSTEXIST;

	if (GetOpenFileName(&ofn))
	{
		SetWindowText(edito, ofn.lpstrFile);
		input.open(ofn.lpstrFile, ios_base::binary);
		from = ofn.lpstrFile;
	}
	return 0;
}



int SaveDialog(HWND hWnd)
{
	OPENFILENAME ofn;
	TCHAR szFile[MAX_PATH];
	ZeroMemory(&ofn, sizeof(ofn));
	ofn.lStructSize = sizeof(ofn);
	ofn.lpstrFile = szFile;
	ofn.lpstrFile[0] = '\0';
	ofn.hwndOwner = hWnd;
	ofn.nMaxFile = sizeof(szFile);
	ofn.lpstrFilter = TEXT("txt Files (*.txt)\0*.txt\0All Files (*.*)\0*.*\0");
	ofn.nFilterIndex = 1;
	ofn.lpstrInitialDir = NULL;
	ofn.lpstrFileTitle = NULL;
	ofn.lpstrDefExt = L"txt";
	ofn.Flags = OFN_PATHMUSTEXIST | OFN_FILEMUSTEXIST;

	if (GetOpenFileName(&ofn))
	{
		SetWindowText(editl, ofn.lpstrFile);
		output.open(ofn.lpstrFile, ios_base::binary);
		to = ofn.lpstrFile;
	}
	return 0;
}



int GoCopy(HWND hWnd)
{
	BackgroundCopier bg_copier;
	if (!input){ std::cerr << "File not found\n"; return -1; }

	
	bg_copier.ScheduleCopy(from, to);

	while (bg_copier.GetCurrentOperatonProgress() < 100)
		SendMessage(progress, PBM_SETPOS, (WPARAM)(bg_copier.GetCurrentOperatonProgress()), 0);
	//SendMessage(progress, PBM_SETPOS, (WPARAM)(bg_copier.GetCurrentOperatonProgress()), 0);
	/*while (getline(input, S))
	input.get(mas, 50);*/
	//std::copy((std::istreambuf_iterator<char>(input)), std::istreambuf_iterator<char>(), std::ostreambuf_iterator<char>(output));
	//input.close();
	//output.close();
	MessageBox(hWnd, L"���������", L"��������� �������", MB_OK);
	PostQuitMessage(0);
}



LRESULT CALLBACK WndProc(HWND hWnd, UINT message, WPARAM wParam, LPARAM lParam)
{
	PAINTSTRUCT ps;
	HDC hdc;

	switch (message)
	{
		// Parse the menu selections:
	case WM_CREATE:
	{

		edito = CreateWindow(L"edit", NULL, WS_CHILD | WS_VISIBLE | LBS_STANDARD, 20, 40, 560, 30, hWnd, (HMENU)101, ((LPCREATESTRUCT)lParam)->hInstance, NULL);
		openfile = CreateWindow(L"button", L"������� ����", WS_VISIBLE | WS_CHILD, 235, 75, 110, 40, hWnd, (HMENU)100, ((LPCREATESTRUCT)lParam)->hInstance, NULL);
		editl = CreateWindow(L"edit", NULL, WS_CHILD | WS_VISIBLE | LBS_STANDARD, 20, 140, 560, 30, hWnd, (HMENU)201, ((LPCREATESTRUCT)lParam)->hInstance, NULL);
		loadfile = CreateWindow(L"button", L"������� ����", WS_VISIBLE | WS_CHILD, 235, 175, 110, 40, hWnd, (HMENU)200, ((LPCREATESTRUCT)lParam)->hInstance, NULL);
		go = CreateWindow(L"button", L"������", WS_VISIBLE | WS_CHILD, 235, 250, 110, 40, hWnd, (HMENU)300, ((LPCREATESTRUCT)lParam)->hInstance, NULL);
		hProgress = CreateWindow(L"button", L"������", WS_VISIBLE | WS_CHILD, 235, 250, 110, 40, hWnd, (HMENU)300, ((LPCREATESTRUCT)lParam)->hInstance, NULL);
		hProgress = CreateWindowEx(0, L"PROGRESS_CLASS", NULL, WS_CHILD | WS_VISIBLE, 20, 20, 260, 17, hWnd, (HMENU)0, hInst, NULL);
		break;
	}
	case WM_COMMAND:
		switch (LOWORD(wParam))
		{
		case 100:
			OpenDialog(hWnd);
			break;
		case 200:
			SaveDialog(hWnd);
			break;
		case 300:
			GoCopy(hWnd);
			break;
		}
	case WM_PAINT:
		hdc = BeginPaint(hWnd, &ps);
		TextOut(hdc, 50, 25, TEXT("�������� ���� ������� ����� ����������"), _tcslen(TEXT("�������� ���� ������� ����� ����������")));
		TextOut(hdc, 50, 125, TEXT("�������� ���� ���� ����� ���������"), _tcslen(TEXT("�������� ���� ���� ����� ���������")));
		EndPaint(hWnd, &ps);
		break;
	case WM_DESTROY:
		PostQuitMessage(0);
		break;
	default:
		return DefWindowProc(hWnd, message, wParam, lParam);
		break;
	}

	return 0;
}