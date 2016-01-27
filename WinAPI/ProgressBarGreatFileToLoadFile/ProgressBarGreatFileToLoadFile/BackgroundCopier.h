#pragma once
#include <string>
#include <list>
#include <Windows.h>


class BackgroundCopier
{
public:
	struct QueueEntry 
	{
		std::wstring from, to; int progress;
		QueueEntry(std::wstring &src, std::wstring &dest) : from(src), to(dest), progress(0) {};
	};

private:
	std::list<QueueEntry> files_queue;
	HANDLE thread;
public:

	bool ScheduleCopy(std::wstring src, std::wstring dest);
	int GetCurrentOperatonProgress();


	BackgroundCopier();
	~BackgroundCopier();
};

