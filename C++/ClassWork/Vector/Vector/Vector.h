#pragma once
#include <sstream>           // std::stringstream
#include <initializer_list>
#include <iostream>
#include <exception>
#include <cstdlib>
#include "Sort.h"



template <class T>
class Vector
{
private:
	// data
	T *vector;
	int element_count, memory_size;
public:

	class Iterator
	{
	private:
		T *current, *begin, *end;
		Vector *host;
	public:
		// ctor
		Iterator(T *arg, T *first, T *last, Vector *name) : current(arg), begin(first), 
				end(last), host(name) {};
		Iterator() : Iterator(nullptr, nullptr, nullptr, nullptr) {};

		//operations
		T &operator*()
		{
			if (current >= begin && current < end)
				return *current;
			throw std::invalid_argument("In Vector::Iterator::operator*() : invalid Iterator");
		}

		Iterator &operator++()  //prefix
		{
			if (current < end)
				++current;
			else
				current = end;
			return *this;
		}

		Iterator &operator--()
		{
			if (current > begin)
				--current;
			return *this;
		}

		Iterator &operator++(int) //postfix
		{
			if (current < end)
				++current;
			else
				current = end;
			return *this;
		}

		Iterator &operator--(int)
		{
			if (current > begin)
				--current;

			return *this;
		}

		// !=

		bool operator==(const Iterator &i) const{
			return current == i.current;
		}

		bool operator!=(const Iterator &i) const{
			return current != i.current;
		}


		friend class Vector;
	};


	
	void PushFront(T element);
	void PushEnd(T element);
	T PopFront();
	T PopEnd();	
	Vector(std::initializer_list<T> args);
	const T &operator[](int index)const;
	Iterator Find(T value);
	Iterator Begin() { return Iterator(vector, vector, vector + element_count, this); }
	Iterator End() { return Iterator(vector + element_count, vector, vector + element_count, this); }
	


	// ctor
	Vector() : vector(nullptr), memory_size(0), element_count(0){};

	// dtor
	~Vector()
	{
		free(vector);
	}

	template <class U>
	friend void x(std::ostream &s, Vector<U> &a);

	//friend std::ostream &operator<<(std::ostream &s, const Vector &a);
};



template <class T>
void Vector<T>::PushFront(T element)
{
	if (element_count == memory_size)
	{
		memory_size *= 2;
		vector = (T*)realloc(vector, memory_size * sizeof(T));
	}
	memmove(vector + 1, vector, element_count * sizeof(T));
	vector[0] = element;
	element_count++;
}


template <class T>
void Vector<T>::PushEnd(T element)
{
	if (element_count == memory_size)
	{
		memory_size *= 2;
		vector = (T*)realloc(vector, memory_size * sizeof(T));
	}
	vector[element_count++] = element;
}


template <class T>
T Vector<T>::PopFront()
{
	if (element_count * 2 == memory_size)
	{
		memory_size *= 3 / 4;
		vector = (T*)realloc(vector, memory_size * sizeof(T));
	}
	T result = vector[0];
	element_count--;
	memmove(vector, vector + 1, element_count * sizeof(T));
	return result;
}


template <class T>
T Vector<T>::PopEnd()
{
	if (element_count * 2 == memory_size)
	{
		memory_size *= 3 / 4;
		vector = (T*)realloc(vector, memory_size * sizeof(T));
	}
	T result = vector[--element_count];
	vector[element_count] = 0;
	return result;
}


template <class T>
Vector<T>::Vector(std::initializer_list<T> args)
{
	auto it = args.begin();
	element_count = args.size();
	memory_size = element_count * 2;
	vector = (T*)malloc(memory_size * sizeof(T));
	int i;
	for (it, i = 0; it != args.end(); it++, i++)
		vector[i] = *it;
}


template <class T>
const T &Vector<T>::operator[](int index)const
{
	if (element_count <= index)
		exit(1);
	return *(vector + index);
}


template <class T>
void x(std::ostream &s, Vector<T> &a)
//std::ostream &operator<<(std::ostream &s, const Vector<T> &a)

{
	s << '(';
	for (int i = 0; i < a.element_count; i++)
	{
		s << a.vector[i];
		if (i != a.element_count - 1)
			s << ", ";
	}
	s << ')';
	//return s;
}


template <class T>
typename Vector<T>::Iterator Find(T value)
{
	T *current = vector, *begin = vector, *end = vector + element_count;
	while (current != vector + element_count)
	{
		if (*current == value)
		{
			return Iterator(current, begin, end, this);
		}
		current++;
	}
	return Iterator(current, begin, end, this);
}


