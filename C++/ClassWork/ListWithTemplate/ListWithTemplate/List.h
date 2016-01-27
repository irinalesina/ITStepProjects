#pragma once
#include <new>


template <class T>
struct Node
{
	T data;
	Node *previous;
	Node *next;
};

template <class T>
class List
{
private:
	int m_element_count;
	Node<T> *m_begin, *m_end;

public:
	List() : m_element_count(0), m_begin(nullptr), m_end(nullptr){}
	List(const List &orig)
	{
		m_element_count = orig.m_element_count;
		Node<T> *temp = orig.m_begin;
		while (temp)
		{
			PushEnd(temp->data);
			temp = temp->next;
		}
	}
	~List()
	{
		while (m_element_count)
			PopFront();
	}


	int GetElementCount()
	{
		return m_element_count;
	}
	
	// standart
	List &PushFront(T element)
	{
		Node<T> *new_element = new Node<T>;
		new_element->data = element;

		// connect
		new_element->previous = nullptr;
		new_element->next = m_begin;
		if (m_begin != nullptr)
			m_begin->previous = new_element;

		m_begin = new_element;
		if (m_end == nullptr)
			m_end = new_element;
		++m_element_count;
		return *this;
	}

	List &PopFront()
	{
		if (m_element_count == 0)
			throw 0;
		Node<T> *temp = m_begin;
		m_begin = temp->next;
		delete temp;
		if (m_element_count == 1)
			m_end = nullptr;
		else
			m_begin->previous = nullptr;
		--m_element_count;
		return *this;
	}

	List &PushEnd(T element)
	{
		Node<T> *new_element = new Node<T>;
		new_element->data = element;
		new_element->next = nullptr;
		new_element->previous = m_end;
		m_end->next = new_element;
		m_end = new_element;
		if (m_element_count == 0)
			m_begin = new_element;
		++m_element_count;
		return *this;
	}

	List &PopEnd()
	{
		if (m_element_count == 0)
			throw 0;
		Node *temp = m_end;
		m_end->next = nullptr;
		if (m_element_count = 1)
		{
			m_begin = nullptr;
			m_end = nullptr;
		}
		else
			m_end = m_end->previous;
		delete temp;
		--m_element_count;
		return *this;
	}

	T &operator[](int index)
	{
		if (index >= m_element_count)
			throw 1;
		Node<T> *temp;
		if (index <= m_element_count / 2)
		{
			temp = m_end;
			for (int i = 0; i < index; i++)
				temp = temp->previous;
		}
		else
		{
			temp = m_begin;
			for (int i = m_element_count - 1; i > index; i--)
				temp = temp->next;
		}
		return temp->data;
	}

	List &operator=(const List &source)
	{
		while (m_element_count--)
			PopFront();
		m_element_count = source.m_element_count;
		Node<T> *temp = source.m_begin;
		for (int i = 0; i < m_element_count; i++, temp = temp->next)
		{
			PushEnd(temp->data);
		}
		return *this;
	}

	List &Delete(int index)
	{
		if (index >= m_element_count || index < 0)
			throw 1;
		if (index == 0)
			PopFront();
		else if (index == m_element_count - 1)
			PopEnd();
		else
		{
			Node<T> *temp = this->operator[](index);
			Node<T> *help_next = temp->next;
			(temp->next)->previous = temp->previous;
			(temp->previous)->next = help_next;
			delete temp;
		}
		return *this;
	}

	List &Reverse()
	{
		Node<T> *temp = this->m_end, *temp_previous;
		this->m_end = this->m_begin;
		this->m_begin = temp;
		for (int i = 0; i < m_element_count; i++, temp = temp->next)
		{
			temp_previous = temp->previous;
			temp->previous = temp->next;
			temp->next = temp_previous;
		}
		return *this;
	}




};

