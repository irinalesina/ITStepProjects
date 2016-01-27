#include "List.h"
#include <new>



// standart
List &List::PushFront(void *element)
{
	Node *new_element = new Node;
	new_element->m_data = new char[m_element_size];
	memcpy(new_element->m_data, element, m_element_size);

	// connect
	new_element->m_previous = nullptr;
	new_element->m_next = m_begin;
	if (m_begin != nullptr)
		m_begin->m_previous = new_element; 

	m_begin = new_element; 
	if (m_end == nullptr)
		m_end = new_element;
	++m_element_count;
	return *this;
}
List &List::PopFront()
{
	if (m_element_count == 0)
		throw 0;
	Node *temp = m_begin;
	m_begin = temp->m_next;
	delete temp->m_data;
	delete temp;
	if (m_element_count == 1)
		m_end = nullptr;
	else
		m_begin->m_previous = nullptr;
	--m_element_count;
	return *this;
}
List &List::PushEnd(void *element)
{
	Node *new_element = new Node;
	new_element->m_data = new char[m_element_size];
	memcpy(new_element->m_data, element, m_element_size);
	new_element->m_next = nullptr;
	new_element->m_previous = m_end;
	m_end->m_next = new_element;
	m_end = new_element;
	if (m_element_count == 0)
		m_begin = new_element;
	++m_element_count;
	return *this;
}
List &List::PopEnd()
{
	if (m_element_count == 0)
		throw 0;
	Node *temp = m_end;
	m_end->m_next = nullptr;
	if (m_element_count = 1)
	{
		m_begin = nullptr;
		m_end = nullptr;
	}
	else
		m_end = m_end->m_previous;
	delete temp->m_data;
	delete temp;
	--m_element_count;
	return *this;
}

List::Node *List::operator[](int index)
{
	if (index >= m_element_count)
		throw 1;
	Node *temp;
	if (index <= m_element_count / 2)
	{
		temp = m_end;
		for (int i = 0; i < index; i++)
			temp = temp->m_previous;
	}
	else
	{
		temp = m_begin;
		for (int i = m_element_count - 1; i > index; i--)
			temp = temp->m_next;
	}
	return temp;

}
List &List::operator=(const List &source)
{
	while (m_element_count--)
		PopFront();
	m_element_count = source.m_element_count;
	m_element_size = source.m_element_size;
	Node *temp = source.m_begin;
	for (int i = 0; i < m_element_count; i++, temp = temp->m_next)
	{
		PushEnd(temp->m_data);
	}
	return *this;
}

List &List::Delete(int index)
{
	if (index >= m_element_count || index < 0)
		throw 1;
	if (index == 0)
		PopFront();
	else if (index == m_element_count - 1)
		PopEnd();
	else
	{
		Node *temp = this->operator[](index);
		Node *help_next = temp->m_next;
		(temp->m_next)->m_previous = temp->m_previous;
		(temp->m_previous)->m_next = help_next;
		delete temp->m_data;
		delete temp;
	}
	return *this;
}
List &List::Reverse()
{
	Node *temp = this->m_end, *temp_previous;
	this->m_end = this->m_begin;
	this->m_begin = temp;
	for (int i = 0; i < m_element_count; i++, temp = temp->m_next)
	{
		temp_previous = temp->m_previous;
		temp->m_previous = temp->m_next;
		temp->m_next = temp_previous;
	}
	return *this;
}


// ctor
List::List(const List &orig)
{
	m_element_size = orig.m_element_size;
	m_element_count = orig.m_element_count;
	Node *temp = m_begin;
	for (int i = 0; i < m_element_count; i++, temp = temp->m_next)
	{
		PushEnd(temp->m_data);
	}
}

// dtor
List::~List()
{
	while (m_element_count)
		PopFront();
}


