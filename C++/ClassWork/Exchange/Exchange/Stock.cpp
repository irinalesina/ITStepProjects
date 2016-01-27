#include "Stock.h"



double Stock::GetSellRate()
{
	// если заявок нет
	if (S_sell_bets.size() == 0)
		return 2.0;
	return S_sell_bets.begin()->first;
}


double Stock::GetBuyRate()
{
	if (S_buy_bets.size() == 0)
		return 1.1;
	return S_buy_bets.rbegin()->first;
}


void Stock::CreateSellBet(const double rate, double amount)
{
	// если есть заявка на покупку у которой сумма 
	// больше текущей суммы на продажу
	while (rate <= GetBuyRate()) {
		// bet - итератор на самую выгодную сделку покупки
		auto bet = S_buy_bets.rbegin();
		//если в сууществующей заявке больше денег чем в новой
		if (amount < bet->second) {
			// частично осуществляем существующую заявку
			bet->second -= amount;
			// и не ставим новую
			return;
		}
		// если в сууществующей заявке денег не хватило
		// снимаем сущетвующую
		amount -= bet->second;
		S_buy_bets.erase(bet->first);
		if (amount == 0) {
			// если продавать больше нечего
			return;
		}
	}
	// если осталось, что продавать
	if (S_sell_bets.find(rate) == S_sell_bets.end())  {
		S_sell_bets[rate] = amount;
	}
	else {
		S_sell_bets[rate] += amount;
	}
}

void Stock::CreateBuyBet(const double rate, double amount)
{
	while (rate >= GetSellRate()) {
		auto bet = S_sell_bets.begin();
		if (amount < bet->second) {
			bet->second -= amount;
			return;
		}
		amount -= bet->second;
		S_sell_bets.erase(bet);
		if (!amount)
			return;
	}
	if (S_buy_bets.find(rate) == S_buy_bets.end())
		S_buy_bets[rate] = amount;
	else
		S_buy_bets[rate] += amount;
}


//потенциалный продавец
void Stock::Buy(double amount)
{
	while (amount > 0)
	{
		auto bet = S_sell_bets.begin();
		if (bet == S_sell_bets.end())
			return;
		if (amount < bet->second)
		{
			bet->second -= amount;
			return;
		}
		amount -= bet->second;
		S_sell_bets.erase(bet->first);
	}
}



//потенциальный покупатель
void Stock::Sell(double amount)
{
	while (amount > 0)
	{
		auto bet = S_buy_bets.rbegin();
		if (bet == S_buy_bets.rend())
			return;
		if (amount < bet->second)
		{
			bet->second -= amount;
			return;
		}
		amount -= bet->second;
		S_buy_bets.erase(bet->first);
	}
}
