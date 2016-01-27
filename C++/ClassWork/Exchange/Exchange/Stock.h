#pragma once
#include <map>


using namespace std;
class Stock
{
private:
	map<double, double> S_sell_bets, S_buy_bets;
public:

	double GetSellRate();
	double GetBuyRate();

	void CreateSellBet(const double rate, double amount);
	void CreateBuyBet(const double rate, double amount);

	void Buy(double amount);
	void Sell(double amount);
};

