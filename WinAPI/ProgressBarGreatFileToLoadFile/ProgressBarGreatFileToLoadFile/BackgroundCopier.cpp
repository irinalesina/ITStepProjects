#include "BackgroundCopier.h"
#include "Windows.h"
#include <process.h>
#include <fstream>

bool kill_thread;
const int buf_size = 0x10000; //4kb

DWORD WINAPI Thread(LPVOID lp)
{
	auto queue = (std::list<BackgroundCopier::QueueEntry>*)lp;

	while (!kill_thread)
	{
		SuspendThread(GetCurrentThread());

		while (queue->size())
		{
			std::ifstream file_from(queue->begin()->from, std::ifstream::ios_base::binary);
			std::ofstream file_to(queue->begin()->to, std::ofstream::ios_base::binary);


			// get file size
			file_from.seekg(0, file_from.end);
			int file_size = file_from.tellg();
			file_from.seekg(0, file_from.beg);

			// help variables
			char* buf = new char[buf_size];
			int total_read_bytes = 0;
			int current_read_bytes;
			double current_progress_translate_to_percent = 100.0 / file_size;

			while (total_read_bytes != file_size)
			{
				Sleep(250);
				file_from.read(buf, buf_size);

				current_read_bytes = file_from.gcount();
				total_read_bytes += current_read_bytes;

				file_to.write(buf, current_read_bytes);
				queue->begin()->progress = total_read_bytes * current_progress_translate_to_percent;
			}
			Sleep(1000);
			queue->pop_front();
			file_from.close();
			file_to.close();
			kill_thread = true;
		}
	}

	return 0;
}


BackgroundCopier::BackgroundCopier() : thread(NULL)
{
	kill_thread = false;
	thread = CreateThread(NULL, 0, Thread, (LPVOID)&files_queue, 0, NULL);
}


BackgroundCopier::~BackgroundCopier()
{
	kill_thread = true;
	ResumeThread(thread);

}

bool BackgroundCopier::ScheduleCopy(std::wstring src, std::wstring dest)
{
	files_queue.push_back(QueueEntry(src, dest));
	Sleep(1);
	ResumeThread(thread);
	return true;
}
int BackgroundCopier::GetCurrentOperatonProgress()
{
	if (files_queue.size())
		return files_queue.begin()->progress;
	return 0;
}

