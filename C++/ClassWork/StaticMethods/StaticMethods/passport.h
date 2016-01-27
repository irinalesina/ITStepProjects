#pragma once



class passport
{
private:
	static int last;
public:
	int num;
	passport(): num(last++) {}
	static void SetLast(int l) { last - l; }
};

int passport::last = 1;






