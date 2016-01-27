#include "Fraction.h"



//общие операции
void Fraction::Reduce()
{
	int num, denom, help;
	num = abs(numerator);
	denom = denominator;
	while (num % denom != 0)
	{
		help = num % denom;
		num = denom;
		denom = help;
	}
	denominator /= denom;
	numerator /= denom;
}
void Fraction::Input()
{
	std::cout << "Enter numerator: ";
	std::cin >> numerator;
	do
	{
		std::cout << "Enter denominator: ";
		std::cin >> denominator;
		if(denominator <= 0)
			std::cout << "Denominator = " << denominator << ", it's wrong!" << std::endl;
	} while(denominator <= 0); //error handling
	Reduce();
}
void Fraction::Output()
{
	std::cout << '(' << numerator << '/' << denominator << ')'; 
}


//унарные операции
Fraction Fraction::operator-()const
{ 
	Fraction res(*this);
	res.numerator = -res.numerator;
	return res;
}
Fraction Fraction::operator+()const
{ 
	Fraction res(*this);
	return res;
}



//бинарные операции
Fraction &Fraction::operator+=(Fraction source)
{
	numerator = numerator * source.denominator + source.numerator * denominator;
	denominator *= source.denominator;
	Reduce();
	return *this;
}
Fraction Fraction::operator+(Fraction source)
{
	Fraction res(*this);
	return (res += source);
}

Fraction &Fraction::operator-=(Fraction source)
{
	numerator = numerator * source.denominator - source.numerator * denominator;
	denominator *= source.denominator;
	Reduce();
	return *this;
}
Fraction Fraction::operator-(Fraction source)
{
	Fraction res(*this);
	return (res -= source);
}

Fraction &Fraction::operator*=(Fraction source)
{
	numerator *= source.numerator;
	denominator *= source.denominator;
	Reduce();
	return *this;
}
Fraction Fraction::operator*(Fraction source)
{
	Fraction res(*this);
	return (res *= source);
}

Fraction &Fraction::operator/=(Fraction source)
{
	// division by zero checking
	if(source.numerator == 0)
	{
		std::cout << "Division by zero!" << std::endl;
		return *this;
	}
	// turn original fraction
	int help = source.numerator;
	source.numerator = source.denominator;
	// division by negative denominator
	if(help < 0)
	{
		help = - help;
		source.numerator = -source.numerator;
	}
	source.denominator = help;
	*this *= source;
	return *this;
}
Fraction Fraction::operator/(Fraction source)
{
	Fraction res(*this);
	return (res /= source);
}

bool Fraction::operator==(Fraction source)
{
	if(numerator - source.numerator == 0 && denominator - source.denominator == 0)
		return true;
	return false;
}
bool Fraction::operator!=(Fraction source)
{
	return *this == source ? false : true;
}

bool Fraction::operator>=(Fraction source)
{
	Fraction difference = *this - source;
	if(difference.numerator >= 0)
		return true;
	return false;
}
bool Fraction::operator>(Fraction source)
{
	Fraction difference = *this - source;
	if(difference.numerator > 0)
		return true;
	return false;
}
	
bool Fraction::operator<=(Fraction source)
{
	Fraction difference = *this - source;
	if(difference.numerator <= 0)
		return true;
	return false;
}
bool Fraction::operator<(Fraction source)
{
	Fraction difference = *this - source;
	if(difference.numerator < 0)
		return true;
	return false;
}



//ctor
Fraction::Fraction()
{
	numerator = 0;
	denominator = 1;
}
Fraction::Fraction(const Fraction &sourse)
{
	numerator = sourse.numerator;
	denominator = sourse.denominator;
}
Fraction::Fraction(int a)
{
	numerator = a;
	denominator = 1;
}
Fraction::Fraction(double a){
	int integer = 0, denom = 1;
	//выделяем целую часть
	integer = a; //приведение к int
	//определяем дробную часть в числитель
	a -= integer;
	while(a * denom < 1 && a != 0){
		denom *= 10;
	}
	numerator = integer * denom + a * denom;
	denominator = denom;
	Reduce();
}
Fraction::Fraction(int num, int denom){
	if(denom == 0)
		denom = 1; //обработка ошибки /0
	numerator = num;
	denominator = denom;
}



//dtor
Fraction::~Fraction()
{

}



//function
std::ostream &operator<<(std::ostream &s, const Fraction &a)
{
	s << '(' << a.numerator << '/' << a.denominator << ')';
	return s;
}




