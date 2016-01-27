#include "String.h"
#include <iostream>


int main(){
	/*const String a('*', 7);
	String b = "Hello";
	String c; //вызовется конструктор копирования
	
	b.FirstNChar(2, c);
	c.PrintStr();
	b.EndNChar(3, c);
	c.PrintStr();
	

	b.Substr(3, 2, c);
	c.PrintStr();

	b.DeleteSpace(c);
	

	b.DeleteSpace();
	b.PrintStr();

	//b = a; //присваивание
	
	b.UpReg();
	b.PrintStr();
	
	//c = b.PlusNewStr(a);
	//c.PrintStr();

	
	b.Plus(" world!");

	a.PrintStr();

	if (b.Find("lo")){
		std::cout << "lo is found in Hello!" << std::endl;
	}


	b.PrintStr();
	*/

	String a("a"), b("b"), c("c"), d;
	d = a + b + c;
	
	std::cout << ' ';
	b.PrintStr();


	std::getc(stdin);
	return 0;
}