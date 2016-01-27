#include "CentralBank.h"
#include <cmath>


void CentralBank::Act()
{
	course.push(sqrt(stock.GetBuyRate() * stock.GetSellRate()));
	if (course.size() < days) {
		return;
	}
	// ������� ��� ���������� �������
	
	double volatility = course.back() / course.front(); // ratio new course to old

	// analyze
	if (volatility < min_limit)
		stock.CreateBuyBet(stock.GetBuyRate(), 1e6);
	else if (volatility > max_limit)
		stock.CreateSellBet(stock.GetSellRate(), 1e6);

	// ���� ������, ������� �������� �������
	course.pop();
}