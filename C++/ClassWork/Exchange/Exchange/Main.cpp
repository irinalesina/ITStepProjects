#include "Stock.h"
#include "Buddy.h"
#include "Client.h"
#include "Player.h"
#include "CentralBank.h"

#include <iostream>
#include <conio.h>
#include <vector>
#include <fstream>

#include <ctime>



using namespace std;
int main()
{
	srand(time(NULL));
	Stock stock;
	vector<Buddy*> buddies{ new CentralBank(stock) };

	for (int i = 0; i < 10; i++) 
	{
		buddies.push_back(new Player(stock));
		buddies.push_back(new Client(stock));
	}
	
	// спекулятивные заявки
	stock.CreateBuyBet(1, 1e9);
	stock.CreateSellBet(1.8, 1e9);
	stock.CreateBuyBet(1.24, 1e7);
	stock.CreateSellBet(1.26, 1e7);
	stock.CreateBuyBet(1.239, 1e5);
	stock.CreateSellBet(1.261, 1e5);
	ofstream fs("result.csv");
	fs.imbue(locale("")); // чтобы интерпретировать в винде точки правильно (регионалные настройки по умолчанию)
	fs << "time;buy rate;sell rate\n";
	for (int time = 0; time < 10000; time++)
	{
		for (auto b : buddies) // (b->begin(); b != b->end(); b++)
			b->Act();
		fs << time << ";";
		fs << stock.GetBuyRate() << ";";
		fs << stock.GetSellRate() << "\n";
		//cout << time << ' ';
	}
	fs.close();
	cout << "end" << endl;
	_getch();
	return 0;
}
