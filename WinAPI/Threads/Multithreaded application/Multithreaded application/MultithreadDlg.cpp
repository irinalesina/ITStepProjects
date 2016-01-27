#include "MultithreadDlg.h"
#include <sstream>
#include <string>
#include <iostream>
#include <chrono>
#include <process.h>
#include <fstream>
#include <list>
#include <set>


const int range = 1000000;
const int capture = 50;

using namespace std;

CMultithreadDlg* CMultithreadDlg::ptr = NULL;


HWND hList;
int candidate = 0;
CRITICAL_SECTION CriticalSection;
std::chrono::milliseconds TimeThread;
list<int> simple_numbs_from_thread1, simple_numbs_from_thread2;
bool threads_run;


CMultithreadDlg::CMultithreadDlg(void)
{
	ptr = this;
}

CMultithreadDlg::~CMultithreadDlg(void)
{

}

void CMultithreadDlg::Cls_OnClose(HWND hwnd)
{
	EndDialog(hwnd, 0);
}


std::chrono::milliseconds FindTime()
{
	ofstream fs;
	fs.open("SimpleNumb.csv");
	using namespace std::chrono;
	system_clock::time_point before = system_clock::now();

	for (int c = 3; c < range; c += 2)
	{
		bool f = true;
		for (int d = 3; d * d <= c; d += 2)
		{
			if (c % d == 0)
			{
				f = false;
				break;
			}
		}
		if (f)
			fs << c << '\n';
	}


	system_clock::time_point after = system_clock::now();

	milliseconds result = duration_cast<milliseconds> (after - before);
	fs.close();
	return result;
}

DWORD WINAPI Thread(LPVOID lp)
{
	
	using namespace std::chrono;
	system_clock::time_point before = system_clock::now();
	if (int(lp) == 0) 
	{
		for (int c = 3; c < range; c += 4)
		{
			bool f = true;
			for (int d = 3; d * d <= c; d += 2)
			{
				if (c % d == 0)
				{
					f = false;
					break;
				}
			}
			if (f)
			{
				simple_numbs_from_thread1.push_back(c);
			}
				
		}
	}
	else if (int(lp) == 1)
	{
		for (int c = 5; c < range; c += 4)
		{
			bool f = true;
			for (int d = 3; d * d <= c; d += 2)
			{
				if (c % d == 0)
				{
					f = false;
					break;
				}
			}
			if (f)
			{
				simple_numbs_from_thread2.push_back(c);
			}
				
		}

		system_clock::time_point after = system_clock::now();
		TimeThread = duration_cast<milliseconds>(after - before);
		
	}
	else
	{
		ofstream fs;
		fs.open("SimpleNumbWithThreads.csv");
		set<int> for_write;


		while (threads_run)
		{
			while (simple_numbs_from_thread1.size() && simple_numbs_from_thread2.size())
			{
				for_write.insert(simple_numbs_from_thread1.front());
				for_write.insert(simple_numbs_from_thread2.front());
				simple_numbs_from_thread1.pop_front();
				simple_numbs_from_thread2.pop_front();
			}
		}

		while (simple_numbs_from_thread1.size() && simple_numbs_from_thread2.size())
		{
			for_write.insert(simple_numbs_from_thread1.front());
			for_write.insert(simple_numbs_from_thread2.front());
			simple_numbs_from_thread1.pop_front();
			simple_numbs_from_thread2.pop_front();
		}

		while (simple_numbs_from_thread1.size())
		{
			for_write.insert(simple_numbs_from_thread1.front());
			simple_numbs_from_thread1.pop_front();
		}

		while (simple_numbs_from_thread2.size())
		{
			for_write.insert(simple_numbs_from_thread2.front());
			simple_numbs_from_thread2.pop_front();
		}


		for (auto it: for_write)
			fs << it << '\n';






		/*while (threads_run)
		{
			while (simple_numbs_from_thread1.size() >= capture && simple_numbs_from_thread2.size() >= capture)
			{
				for (int i = 0; i <capture; i++)
				{
					for_write.insert(simple_numbs_from_thread1.front());
					for_write.insert(simple_numbs_from_thread2.front());
					simple_numbs_from_thread1.pop_front();
					simple_numbs_from_thread2.pop_front();
				}

				for (int i = 0; i < for_write.size() / 2; i++)
				{
					fs << *for_write.begin() << '\n';
					for_write.erase(for_write.begin());
				}
					
			}
		}

		while (simple_numbs_from_thread1.size() >= capture && simple_numbs_from_thread2.size() >= capture)
		{
			for (int i = 0; i < capture; i++)
			{
				for_write.insert(simple_numbs_from_thread1.front());
				for_write.insert(simple_numbs_from_thread2.front());
				simple_numbs_from_thread1.pop_front();
				simple_numbs_from_thread2.pop_front();
			}

			for (int i = 0; i < for_write.size() / 2; i++)
			{
				fs << *for_write.begin() << '\n';
				for_write.erase(for_write.begin());
			}
		}
		

		int s1 = simple_numbs_from_thread1.size();
		while (s1)
		{
			for_write.insert(simple_numbs_from_thread1.front());
			simple_numbs_from_thread1.pop_front();
			s1--;
		}

		int s2 = simple_numbs_from_thread2.size();
		while (s2)
		{
			for_write.insert(simple_numbs_from_thread2.front());
			simple_numbs_from_thread2.pop_front();
			s2--;
		}
			
		for (auto it : for_write)
			fs << it << '\n';*/

		fs.close();
	}
	
	return 0;
}


BOOL CMultithreadDlg::Cls_OnInitDialog(HWND hwnd, HWND hwndFocus, LPARAM lParam) 
{
	hList = GetDlgItem(hwnd, IDC_LIST1);
	SendMessage(hList, LB_ADDSTRING, 0, LPARAM(to_wstring(FindTime().count() * 1.0 / 1000).c_str()));
	
	//InitializeCriticalSection(&CriticalSection);
	threads_run = true;
	HANDLE handle1 = CreateThread(NULL, 0, Thread, (LPVOID)0, 0, NULL);
	HANDLE handle2 = CreateThread(NULL, 0, Thread, (LPVOID)1, 0, NULL);
	HANDLE handle3 = CreateThread(NULL, 0, Thread, (LPVOID)2, 0, NULL);
	WaitForSingleObject(handle1, INFINITE);
	WaitForSingleObject(handle2, INFINITE);
	
	threads_run = false;
	WaitForSingleObject(handle3, INFINITE);
	
	DeleteCriticalSection(&CriticalSection);
	SendMessage(hList, LB_ADDSTRING, 0, LPARAM(to_wstring(TimeThread.count() * 1.0 / 1000).c_str()));
	return TRUE;
}

BOOL CALLBACK CMultithreadDlg::DlgProc(HWND hwnd, UINT message, WPARAM wParam, LPARAM lParam)
{
	switch(message)
	{
		HANDLE_MSG(hwnd, WM_CLOSE, ptr->Cls_OnClose);
		HANDLE_MSG(hwnd, WM_INITDIALOG, ptr->Cls_OnInitDialog);
	}
	return FALSE;
}