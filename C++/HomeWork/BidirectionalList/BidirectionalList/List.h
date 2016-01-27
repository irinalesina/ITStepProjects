#pragma once
#include <iostream>
#include <exception>
#include <stdexcept>

using namespace std;

typedef void* INT;

class List
{
private:
	struct Node
	{
		void *m_data;
		Node *m_next;
		Node *m_previous;
	};
public:

	class iterator {
	private:
		Node* m_current;
	public:
		iterator(Node* arg) : m_current(arg) {};
		iterator() : m_current(nullptr) {};
		INT & operator*() {
			if (m_current == nullptr) {
				throw invalid_argument(
					"In List::iterator::operator*() : invalid iterator");
			}
			return m_current->m_data;
		}
		iterator& operator++() {
			if (m_current == nullptr) {
				throw invalid_argument(
					"In List::iterator::operator*() : invalid iterator");
			}
			m_current = m_current->m_next;
			return (*this);
		}

		bool operator==(const iterator &i) const{
			return m_current == i.m_current;
		}

		bool operator!=(const iterator &i) const{
			return m_current != i.m_current;
		}
	};  // m_end of List::iterator

	iterator begin() {
		return iterator(m_begin);
	}
	iterator end() {
		return iterator(nullptr);
	}

private:
	Node *m_begin;
	Node *m_end;
	int m_element_count;
	int m_element_size;

public:

	size_t GetElementCount()
	{
		return m_element_count;
	}

	int GetElementSize()
	{
		return m_element_size;
	}

	// standart
	List &PushFront(void *element);
	List &PopFront();

	List &PushEnd(void *element);
	List &PopEnd();

	Node *operator[](int index);
	List &operator=(const List &source);

	List &Delete(int index);
	List &Reverse();

	// ctor
	List(int size_of_element) : m_element_size(size_of_element), m_element_count(0), m_begin(nullptr), m_end(nullptr) {};
	List(const List &orig);

	iterator find(void* value) {
		Node* m_current;
		m_current = m_begin;
		while (m_current != nullptr) {
			if (m_current->m_data == value) {
				return iterator(m_current);
			}
			m_current = m_current->m_next;
		}
		return iterator(m_current);
	}

	// dtor
	~List();


};