#include "List.h"
#include <new>



List *List::junk;


List &List::Delete(int index)
{
	if (size_list == 0 || index >= size_list)
		return *junk;
	if(index == 0)
		PopFront();
	else if(index == size_list - 1)
		PopEnd();
	else
	{
		Item *previous = this->operator[](index - 1);
		Item *temp = this->operator[](index);
		previous->next = temp->next;
		delete temp;
		--size_list;
	}
	return *this;
}


List &List::PushFront(int element)
{
	Item *new_element = new Item;
	new_element->data = element;
	
	new_element->next = first;
	first = new_element;
	++size_list;
	return *this;
}

List &List::PopFront()
{
	if (first == nullptr)
		throw 1;
	Item *temp = first;
	first = first->next;
	delete temp;
	--size_list;
	return *this;
}


List &List::PushEnd(int element)
{
	Item *new_element = new Item;
	new_element->data = element;
	if (size_list)
		this->operator[](size_list-1)->next = new_element; //(*this)[size_list - 1]->next
	else
		first = new_element;
	new_element->next = nullptr;
	++size_list;
	return *this;
}

List &List::PopEnd()
{
	if (first == nullptr)
		throw 1;
	delete (*this)[size_list - 1];
	--size_list;
	return *this;
}




List::Item *List::operator[](size_t index)
{
	
	if (index >= size_list)
		throw 1;

	Item *temp = first;
	for (size_t i = 0; i < index; i++)
	{
		temp = temp->next;
	}
	return temp;
}

List &List::operator=(const List &data)
{
	while (size_list > 0)
	{
		PopFront();
	}
	//size_list = data.size_list;
	Item *temp = data.first;
	for (size_t i = 0; i < data.size_list; i++, temp = temp->next)
	{
		PushEnd(temp->data);
	}
	return *this;
}

List::List(const List &orig)
{
	size_list = orig.size_list;
	Item *temp = orig.first;
	for (size_t i = 0; i < orig.size_list; i++, temp = temp->next)
	{
		PushEnd(temp->data);
	}
}

List::~List()
{
	while (size_list > 0)
	{
		PopFront();
	}
}




