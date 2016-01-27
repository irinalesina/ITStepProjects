#pragma once

class List
{
private:
	static List *junk;

	// container
	struct Item
	{
		int data;
		Item *next;
	};

	Item *first;
	size_t size_list;

public:


	// getter method
	size_t GetSize()
	{
		return size_list;
	}

	List &Delete(int index);

	List &PushFront(int element);
	List &PopFront();

	List &PushEnd(int element);
	List &PopEnd();


	Item *operator[](size_t index);

	List &operator=(const List &data);

	// ctor
	// список инициализации конструктора
	List(): first(nullptr), size_list(0) {};
	List(const List &orig);

	// dtor
	~List();
};

