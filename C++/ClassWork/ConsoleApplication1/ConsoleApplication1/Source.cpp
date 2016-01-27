/*#include <iostream>
#include <string.h>
#include <time.h>
using namespace std;

class Queue
{
	// �������
	int * Wait;
	// ������������ ������ �������
	int MaxQueueLength;
	// ������� ������ �������
	int QueueLength;

public:
	// �����������
	Queue(int m);

	//����������
	~Queue();

	// ���������� ��������
	void Add(int c);

	// ���������� ��������
	int Extract();

	// ������� �������
	void Clear();

	// �������� ������������� ��������� � �������
	bool IsEmpty();

	// �������� �� ������������ �������
	bool IsFull();

	// ���������� ��������� � �������
	int GetCount();

	//������������ �������
	void Show();
};

void Queue::Show(){
	cout << "\n-------------------------------------\n";
	//������������ �������
	for (int i = 0; i<QueueLength; i++){
		cout << Wait[i] << " ";
	}
	cout << "\n-------------------------------------\n";
}

Queue::~Queue()
{
	//�������� �������
	delete[]Wait;
}

Queue::Queue(int m)
{
	//�������� ������
	MaxQueueLength = m;
	//������� �������
	Wait = new int[MaxQueueLength];
	// ���������� ������� �����
	QueueLength = 0;
}

void Queue::Clear()
{
	// ����������� "�������" ������� 
	QueueLength = 0;
}

bool Queue::IsEmpty()
{
	// ����?
	return QueueLength == 0;
}

bool Queue::IsFull()
{
	// �����?
	return QueueLength == MaxQueueLength;
}

int Queue::GetCount()
{
	// ���������� �������������� � ����� ���������
	return QueueLength;
}

void Queue::Add(int c)
{
	// ���� � ������� ���� ��������� �����, �� ����������� ����������
	// �������� � ��������� ����� �������
	if (!IsFull())
		Wait[QueueLength++] = c;
}

int Queue::Extract()
{
	// ���� � ������� ���� ��������, �� ���������� ���, 
	// ������� ����� ������ � �������� �������	
	if (!IsEmpty()){
		//��������� ������
		int temp = Wait[0];

		//�������� ��� ��������
		for (int i = 1; i<QueueLength; i++)
			Wait[i - 1] = Wait[i];

		//��������� ����������
		QueueLength--;

		//������� ������(�������)
		return temp;
	}

	else // ���� � ����� ��������� ���
		return -1;
}

void main()
{
	srand(time(0));

	//�������� �������
	Queue QU(25);

	//���������� ����� ���������
	for (int i = 0; i < 5; i++){
		QU.Add(rand() % 50);
	}
	//����� �������
	QU.Show();

	//���������� ��������
	QU.Extract();

	//����� �������
	QU.Show();
}*/
/*#include <iostream>
#include <string.h>
#include <time.h>
using namespace std;

class QueueRing
{
	// �������
	int * Wait;
	// ������������ ������ �������
	int MaxQueueLength;
	// ������� ������ �������
	int QueueLength;

public:
	// �����������
	QueueRing(int m);

	//����������
	~QueueRing();

	// ���������� ��������
	void Add(int c);

	// ���������� ��������
	bool Extract();

	// ������� �������
	void Clear();

	// �������� ������������� ��������� � �������
	bool IsEmpty();

	// �������� �� ������������ �������
	bool IsFull();

	// ���������� ��������� � �������
	int GetCount();

	//������������ �������
	void Show();
};

void QueueRing::Show(){
	cout << "\n-------------------------------------\n";
	//������������ �������
	for (int i = 0; i<QueueLength; i++){
		cout << Wait[i] << " ";
	}
	cout << "\n-------------------------------------\n";
}

QueueRing::~QueueRing()
{
	//�������� �������
	delete[]Wait;
}

QueueRing::QueueRing(int m)
{
	//�������� ������
	MaxQueueLength = m;
	//������� �������
	Wait = new int[MaxQueueLength];
	// ���������� ������� �����
	QueueLength = 0;
}

void QueueRing::Clear()
{
	// ����������� "�������" ������� 
	QueueLength = 0;
}

bool QueueRing::IsEmpty()
{
	// ����?
	return QueueLength == 0;
}

bool QueueRing::IsFull()
{
	// �����?
	return QueueLength == MaxQueueLength;
}

int QueueRing::GetCount()
{
	// ���������� �������������� � ����� ���������
	return QueueLength;
}

void QueueRing::Add(int c)
{
	// ���� � ������� ���� ��������� �����, �� ����������� ����������
	// �������� � ��������� ����� �������
	if (!IsFull())
		Wait[QueueLength++] = c;
}

bool QueueRing::Extract()
{
	// ���� � ������� ���� ��������, �� ���������� ���, 
	// ������� ����� ������ � �������� �������	
	if (!IsEmpty()){
		//��������� ������
		int temp = Wait[0];

		//�������� ��� ��������
		for (int i = 1; i<QueueLength; i++)
			Wait[i - 1] = Wait[i];

		//����������� ������ "����������� ������� � �����"
		Wait[QueueLength - 1] = temp;
		return 1;

	}
	else return 0;
}

void main()
{
	srand(time(0));

	//�������� �������
	QueueRing QUR(25);

	//���������� ����� ���������
	for (int i = 0; i<5; i++){
		QUR.Add(rand() % 50);
	}
	//����� �������
	QUR.Show();

	//���������� ��������
	QUR.Extract();

	//����� �������
	QUR.Show();
}
*/
#include <iostream>
#include <string.h>
#include <time.h>
using namespace std;

class QueuePriority
{
	// �������
	int * Wait;
	// ���������
	int * Pri;
	// ������������ ������ �������
	int MaxQueueLength;
	// ������� ������ �������
	int QueueLength;

public:
	// �����������
	QueuePriority(int m);

	//����������
	~QueuePriority();

	// ���������� ��������
	void Add(int c, int p);

	// ���������� ��������
	int Extract();

	// ������� �������
	void Clear();

	// �������� ������������� ��������� � �������
	bool IsEmpty();

	// �������� �� ������������ �������
	bool IsFull();

	// ���������� ��������� � �������
	int GetCount();

	//������������ �������
	void Show();
};

void QueuePriority::Show(){
	cout << "\n-------------------------------------\n";
	//������������ �������
	for (int i = 0; i<QueueLength; i++){
		cout << Wait[i] << " - " << Pri[i] << "\n\n";
	}
	cout << "\n-------------------------------------\n";
}

QueuePriority::~QueuePriority()
{
	//�������� �������
	delete[]Wait;
	delete[]Pri;
}

QueuePriority::QueuePriority(int m)
{
	//�������� ������
	MaxQueueLength = m;
	//������� �������
	Wait = new int[MaxQueueLength];
	Pri = new int[MaxQueueLength];
	// ���������� ������� �����
	QueueLength = 0;
}

void QueuePriority::Clear()
{
	// ����������� "�������" ������� 
	QueueLength = 0;
}

bool QueuePriority::IsEmpty()
{
	// ����?
	return QueueLength == 0;
}

bool QueuePriority::IsFull()
{
	// �����?
	return QueueLength == MaxQueueLength;
}

int QueuePriority::GetCount()
{
	// ���������� �������������� � ����� ���������
	return QueueLength;
}

void QueuePriority::Add(int c, int p)
{
	// ���� � ������� ���� ��������� �����, �� ����������� ����������
	// �������� � ��������� ����� �������
	if (!IsFull()){
		Wait[QueueLength] = c;
		Pri[QueueLength] = p;
		QueueLength++;
	}
}

int QueuePriority::Extract()
{
	// ���� � ������� ���� ��������, �� ���������� ���, 
	// � �������� ��������� ��������� � �������� �������	
	if (!IsEmpty()){


		//����� ������������ ������� - �������
		int max_pri = Pri[0];
		//� ������������ ������ = 0
		int pos_max_pri = 0;

		//���� ���������
		for (int i = 1; i<QueueLength; i++)
			//���� �������� ����� ������������ �������
		if (max_pri<Pri[i]){
			max_pri = Pri[i];
			pos_max_pri = i;
		}

		//����������� ������������ �������
		int temp1 = Wait[pos_max_pri];
		int temp2 = Pri[pos_max_pri];

		//�������� ��� ��������
		for (int i = pos_max_pri; i<QueueLength - 1; i++){
			Wait[i] = Wait[i + 1];
			Pri[i] = Pri[i + 1];
		}
		//��������� ����������
		QueueLength--;
		// ������� ������������ ��������	
		return temp1;

	}
	else return -1;
}

void main()
{
	srand(time(0));

	//�������� �������
	QueuePriority QUP(25);

	//���������� ����� ���������
	for (int i = 0; i<5; i++){

		// �������� �� 0 �� 99 (������������)
		// � ��������� �� 0 �� 11 (������������)
		QUP.Add(rand() % 100, rand() % 12);
	}
	//����� �������
	QUP.Show();

	//���������� ��������
	QUP.Extract();

	//����� �������
	QUP.Show();
}

