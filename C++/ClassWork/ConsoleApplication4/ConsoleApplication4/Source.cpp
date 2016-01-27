#include <iostream>
using namespace std;
class A{
public:
	int a;
	A()
	{
		a = 1;
	}
};
class B :public virtual A{
public:
	B()
	{
		a = 2;
	}
};
class C :public virtual A{
public:
	C()
	{
		a = 3;
	}
};
class D :public B, public A{
public:
	void show()
	{
		cout << a;
	}
};

int main()
{
	A a;
	B b;
	C c;
	D d;
	d.show();
}