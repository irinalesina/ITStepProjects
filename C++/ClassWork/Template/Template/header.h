
template <class T>
class Vector
{
private:
	T *m_elements;
	int m_size;
public:
	// ctor
	Vector() : m_elements(nullptr), m_size(0){}

	Vector(int size, T initial) : m_size(size)
	{
		m_elements = new T[size];
		for (int i = 0; i < size; i++)
			m_elements[i] = initial;
	}
	// dtor
	~Vector()
	{
		delete[] m_elements;
	}
		

	T &operator[](int index)
	{
		if (index < m_size && index >= 0)
			return m_elements[index];
		//throw 0;
	}

};

