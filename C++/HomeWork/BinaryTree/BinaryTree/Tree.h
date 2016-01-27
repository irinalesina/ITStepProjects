#pragma once
#include <new>
#include <exception>



template <class Tkey, class Tvalue>
class Tree
{
private:
	struct Node
	{
		Node() : m_left(nullptr), m_right(nullptr) {};
		Tkey m_key;
		Tvalue m_value;
		Node *m_left, *m_right;
	};
	Node *m_root;
	int m_element_count;

	void Clear(Node *current);
public:
	Tvalue &operator[](const Tkey key);
	Tree &Remove(Tkey key);

	Tree() : m_root(nullptr), m_element_count(0) {};
	~Tree()
	{
		Clear(m_root);
	}
};


template <class Tkey, class Tvalue>
Tvalue &Tree<Tkey, Tvalue>::operator[](const Tkey key)
{
	Node *temp = m_root;
	Node **pointer = &m_root;
	while(temp != nullptr)
	{
		if(key < temp->m_key)
		{
			pointer = &(temp->m_left);
			temp = temp->m_left;
		}
		else if(key > temp->m_key)
		{
			pointer = &(temp->m_right);
			temp = temp->m_right;
		}
		else
			return temp->m_value;
	}
	
	*pointer = new Node;
	(*pointer)->m_key = key;
	++m_element_count;
	return (*pointer)->m_value;
} 


template <class Tkey, class Tvalue>
Tree<Tkey, Tvalue> &Tree<Tkey, Tvalue>::Remove(Tkey key)
{
	Node *temp = m_root;
	Node **pointer = &m_root;


	while(temp != nullptr && key != temp->m_key)
	{
		if(key < temp->m_key)
		{
			pointer = &(temp->m_left);
			temp = temp->m_left;
		}
		else
		{
			pointer = &(temp->m_right);
			temp = temp->m_right;
		}
	}


	if(key == temp->m_key)
	{
		Node *temp_left = temp->m_left, *temp_right = temp->m_right;
		delete temp;
		--m_element_count;
		*pointer = temp_left;
		temp = temp_left;
		while(temp)
		{
			pointer = &(temp->m_right);
			temp = temp->m_right;
		}
		*pointer = temp_right;
	}

	return *this;
}

template <class Tkey, class Tvalue>
void Tree<Tkey, Tvalue>::Clear(Node *current)
{
	if(current)
	{
		Clear(current->m_left);
		Clear(current->m_right);
		delete current;
	}
}

