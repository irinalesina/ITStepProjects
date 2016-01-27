#pragma once
#include <iostream>



class Fraction
{
public:
	int numerator;
	unsigned int denominator;



	//����� ��������
	void Reduce();
	void Input();
	void Output();
	


	//������� ��������
	Fraction operator-()const;
	Fraction operator+()const;



	//�������� ��������
	Fraction &operator+=(Fraction source); 
	Fraction operator+(Fraction source);

	Fraction &operator-=(Fraction source);
	Fraction operator-(Fraction source);

	Fraction &operator*=(Fraction source);
	Fraction operator*(Fraction source);

	Fraction &operator/=(Fraction source);
	Fraction operator/(Fraction source);
	
	bool operator==(Fraction source);
	bool operator!=(Fraction source);
	
	bool operator>=(Fraction source);
	bool operator>(Fraction source);
	
	bool operator<=(Fraction source);
	bool operator<(Fraction source);



	//ctor
	Fraction();
	Fraction(const Fraction &sourse);
	Fraction(int a);
	Fraction(double a);
	Fraction(int num, int denom);

	//dtor
	~Fraction();
};



//function
std::ostream &operator<<(std::ostream &s, const Fraction &a);



