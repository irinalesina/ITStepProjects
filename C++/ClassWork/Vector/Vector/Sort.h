#pragma once


template <class T>
void SortingBuble(T begin, T end)
{
	T  it, jt, before_end;
	before_end = end;
	before_end--;
	for (it = begin; it != end; it++)
	{
		for (jt = begin; jt != before_end; jt++)
		{
			T q = jt;
			q++;
			if (*jt > *q)
			{
				auto h = *jt;
				*jt = *q;
				*q = h;
			}
		}
	}
}

