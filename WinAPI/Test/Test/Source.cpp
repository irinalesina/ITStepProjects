 #include <windows.h>
#include <tchar.h>
#include <map>

#define ButtonWidth 100
#define ButtonHeigth 20

HDC hdc;
PAINTSTRUCT ps;


using namespace std;

//прототип оконной процедуры
LRESULT CALLBACK WindowProc(HWND, UINT, WPARAM, LPARAM);

TCHAR szClassWindow[] = TEXT("Каркасное приложение"); /* Имя класса окна */


// for event map
//typedef LRESULT CALLBACK EventProc(HWND hWnd, UINT uMessage, WPARAM wParam, LPARAM lParam);

void CreateContent(HWND hWnd, HINSTANCE hInst);

LRESULT CALLBACK OnExit(HWND hWnd, UINT uMessage, WPARAM wParam, LPARAM lParam){
	PostQuitMessage(0);	// посылка сообщения WM_QUIT
	return 0;
}

HWND hwndButton2, hwndButton3, hwndButtonDefault;
INT WINAPI _tWinMain(HINSTANCE hInst, HINSTANCE hPrevInst, LPTSTR lpszCmdLine, int nCmdShow)
{
	// дискриптор главного окна
	HWND hWnd;

	MSG Msg;

	// структура, которая содержит описание класса окна
	WNDCLASSEX wcl;

	/* 1. Определение класса окна  */

	wcl.cbSize = sizeof (wcl);	// размер структуры WNDCLASSEX 
	wcl.style = CS_HREDRAW | CS_VREDRAW | CS_DBLCLKS;	// окно сможет получать сообщения о двойном щелчке (DBLCLK)
	wcl.lpfnWndProc = WindowProc;	// адрес оконной процедуры
	wcl.cbClsExtra = 0;		// используется Windows 
	wcl.cbWndExtra = 0; 	// используется Windows 
	wcl.hInstance = hInst;	// дескриптор данного приложения
	wcl.hIcon = LoadIcon(NULL, IDI_APPLICATION);	// загрузка стандартной иконки
	wcl.hCursor = LoadCursor(NULL, IDC_ARROW);		// загрузка стандартного курсора
	wcl.hbrBackground = (HBRUSH)GetStockObject(WHITE_BRUSH);	//заполнение окна белым цветом			
	wcl.lpszMenuName = NULL;	// приложение не содержит меню
	wcl.lpszClassName = szClassWindow;	// имя класса окна
	wcl.hIconSm = NULL;	// отсутствие маленькой иконки для связи с классом окна


	/*  2. Регистрация класса окна  */

	if (!RegisterClassEx(&wcl))
		return 0;	// при неудачной регистрации - выход

	/*  3. Создание окна  */

	// создается окно и  переменной hWnd присваивается дескриптор окна
	hWnd = CreateWindowEx(
		0,		// расширенный стиль окна
		szClassWindow,	// имя класса окна
		TEXT("Викторина"),	// заголовок окна
		/* Заголовок, рамка, позволяющая менять размеры, системное меню,
		кнопки развёртывания и свёртывания окна  */
		WS_OVERLAPPEDWINDOW,	// стиль окна
		CW_USEDEFAULT,	// х-координата левого верхнего угла окна
		CW_USEDEFAULT,	// y-координата левого верхнего угла окна
		250,	// ширина окна
		300,	// высота окна
		NULL,			// дескриптор родительского окна
		NULL,			// дескриптор меню окна
		hInst,		// идентификатор приложения, создавшего окно
		NULL);		// указатель на область данных приложения


	CreateContent(hWnd, hInst);


	/* 4. Отображение окна */

	ShowWindow(hWnd, nCmdShow);
	UpdateWindow(hWnd);	// перерисовка окна

	/* 4.5 Регистрируем события */


	/* 5. Запуск цикла обработки сообщений  */

	// получение очередного сообщения из очереди сообщений
	while (GetMessage(&Msg, NULL, 0, 0))
	{
		TranslateMessage(&Msg);	// трансляция сообщения
		DispatchMessage(&Msg);	// диспетчеризация сообщений
	}
	return Msg.wParam;
}


// Оконная процедура вызывается операционной системой и получает в качестве 
// параметров сообщения из очереди сообщений данного приложения	

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
	case WM_DESTROY: // сообщение о завершении программы
		//
		PostQuitMessage(0); // посылка сообщения WM_QUIT
		break;
	default:
		// все сообщения, которые не обрабатываются в данной оконной функции 
		// направляются обратно Windows на обработку по умолчанию
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
